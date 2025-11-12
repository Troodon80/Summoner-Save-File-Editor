using SummonerSaveFileEditor.Models;
using SummonerSaveFileEditor.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SummonerSaveFileEditor.Services
{
    public static class ResourceLoader
    {
        public static async Task<(List<InventoryItem> inventoryItems, List<EquipmentItem> equipmentItems,
            Dictionary<uint, string> characterNames, List<QuestEntry> questsNames, List<LevelItem> levelItems,
            List<DialogueFile> dialogueFiles)>
            LoadResourcesAsync()
        {
            var inventoryList = new List<InventoryItem>();
            var equipmentList = new List<EquipmentItem>();
            var characterNameDict = new Dictionary<uint, string>();
            var knownQuests = new List<QuestEntry>();
            var levelItems = new List<LevelItem>();
            var dialogueFiles = new List<DialogueFile>();

            // Parse item lines
            string items = Resource.items.Replace("\r\n", "\n");
            string[] lines = items.Split('\n');

            foreach (string line in lines)
            {
                if (string.IsNullOrWhiteSpace(line)) continue;

                try
                {
                    string[] parts = line.Split('\t');
                    var equipItem = new EquipmentItem
                    {
                        Index = int.Parse(parts[0]),
                        Name = parts[1],
                        Category = parts[3],
                        DoubleSlot = bool.Parse(parts[5])
                    };
                    equipItem.SetUsability(parts[6]);

                    var invItem = new InventoryItem
                    {
                        Name = parts[1],
                        Hash = SummonerHash.ComputeHashSigned(parts[1]),
                        Type = int.Parse(parts[2]),
                        Category = parts[3],
                        MaxCharge = int.Parse(parts[4])
                    };

                    equipmentList.Add(equipItem);
                    inventoryList.Add(invItem);
                }
                catch (Exception ex)
                {
                    throw new FormatException($"Error parsing item line:\n{line}", ex);
                }
            }

            // Load dialogue files - do this early to allow other processes to use this data
            try
            {
                dialogueFiles = await LoadAllDialogueFilesAsync();
            }
            catch (Exception ex)
            {
                // Log but continue - not critical
                System.Diagnostics.Debug.WriteLine($"Error loading dialogue files: {ex.Message}");
            }

            // Parse character names
            try
            {
                var vppNames = await LoadNameDictionaryFromVppAsync();
                foreach (var kvp in vppNames)
                {
                    // Add only if not already present
                    if (!characterNameDict.ContainsKey(kvp.Key))
                    {
                        characterNameDict[kvp.Key] = kvp.Value;
                    }
                }
            }
            catch (Exception ex)
            {
                // Log but continue - not critical
                System.Diagnostics.Debug.WriteLine($"Error loading names from VPP: {ex.Message}");
            }

            try
            {
                knownQuests = await LoadQuestNamesFromVppAsync();
            }
            catch (Exception ex)
            {
                // Log but continue - not critical
                System.Diagnostics.Debug.WriteLine($"Error loading quest names: {ex.Message}");
            }

            try
            {
                levelItems = await LoadLevelItemsAsync();
            }
            catch (Exception ex)
            {
                // Log but continue - not critical
                System.Diagnostics.Debug.WriteLine($"Error loading level items: {ex.Message}");
            }

            return (inventoryList, equipmentList, characterNameDict, knownQuests, levelItems, dialogueFiles);
        }

        public static async Task<Dictionary<uint, string>> LoadNameDictionaryFromVppAsync()
        {
            var nameDict = new Dictionary<uint, string>();
            string gamePath = GetGameInstallationPath();
            if (string.IsNullOrEmpty(gamePath))
                return nameDict;

            string vppPath = Path.Combine(gamePath, "tables.vpp");
            if (!File.Exists(vppPath))
                return nameDict;

            try
            {
                // Load VPP file entries
                var entries = await VppExtractor.LoadVppAsync(vppPath);
                int namesFound = 0;

                // Filter to only process script tables
                var scriptEntries = entries.Where(entry =>
                    entry.FileName.EndsWith("_script.tbl", StringComparison.OrdinalIgnoreCase) ||
                    entry.FileName.EndsWith("_cscript.tbl", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                using (var stream = new FileStream(vppPath, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(stream))
                {
                    foreach (var entry in scriptEntries)
                    {
                        reader.BaseStream.Seek(entry.FileOffset, SeekOrigin.Begin);
                        byte[] data = reader.ReadBytes(entry.FileSize);

                        var parsedEntries = TblParser.ParseTbl(data);

                        foreach (var tblEntry in parsedEntries)
                        {
                            // Looking for $Name entries with valid values
                            if (tblEntry.Key.Equals("$Name", StringComparison.OrdinalIgnoreCase) &&
                                !string.IsNullOrEmpty(tblEntry.Value) &&
                                !tblEntry.Value.StartsWith("$", StringComparison.OrdinalIgnoreCase))
                            {
                                // Compute hash and add to dictionary if not already present
                                uint hash = SummonerHash.ComputeHash(tblEntry.Value);
                                if (!nameDict.ContainsKey(hash))
                                {
                                    nameDict[hash] = tblEntry.Value;
                                    namesFound++;
                                }
                            }
                        }
                    }
                }

                System.Diagnostics.Debug.WriteLine($"Found {namesFound} names in {scriptEntries.Count} VPP script files");
                return nameDict;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error extracting names from VPP file: {ex.Message}");
                return nameDict;
            }
        }

        public static async Task<List<QuestEntry>> LoadQuestNamesFromVppAsync()
        {
            var questNames = new List<QuestEntry>();
            string gamePath = GetGameInstallationPath();
            if (string.IsNullOrEmpty(gamePath))
                return questNames;

            string vppPath = Path.Combine(gamePath, "tables.vpp");
            if (!File.Exists(vppPath))
                return questNames;

            try
            {
                // Extract quest_names.tbl as raw bytes
                var fileData = await VppExtractor.ExtractFileDataAsync(vppPath, "quest_names.tbl");
                //var fileData = await ExtractFileFromVppAsync("quest_names.tbl");
                if (fileData == null)
                    return questNames;

                string content = Encoding.UTF8.GetString(fileData);

                using (var reader = new StringReader(content))
                {
                    string? line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        line = line.Trim();

                        // Stop reading if we encounter end markers
                        if (line.Equals("#End", StringComparison.OrdinalIgnoreCase) ||
                            line.Equals("// -- end file --", StringComparison.OrdinalIgnoreCase))
                            break;

                        // Skip comments, blank lines, and section headers
                        if (string.IsNullOrEmpty(line) || line.StartsWith("//") || line.StartsWith("#"))
                            continue;

                        // Try to parse: <index>,    "<quest name>"
                        int commaIndex = line.IndexOf(',');
                        if (commaIndex > 0)
                        {
                            string indexPart = line.Substring(0, commaIndex).Trim();
                            string namePart = line.Substring(commaIndex + 1).Trim();

                            // Remove surrounding quotes from name
                            if (namePart.StartsWith("\"") && namePart.EndsWith("\""))
                                namePart = namePart.Substring(1, namePart.Length - 2);

                            if (int.TryParse(indexPart, out int questId) && !string.IsNullOrWhiteSpace(namePart))
                            {
                                questNames.Add(new QuestEntry
                                {
                                    QuestId = questId,
                                    Name = namePart,
                                    Visible = false // or set as needed
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading quest names: {ex.Message}");
            }

            return questNames;
        }

        public static async Task<List<DialogueFile>> LoadAllDialogueFilesAsync()
        {
            var dialogueFiles = new List<DialogueFile>();
            string gamePath = GetGameInstallationPath();
            if (string.IsNullOrEmpty(gamePath))
                return dialogueFiles;

            string vppPath = Path.Combine(gamePath, "tables.vpp");
            if (!File.Exists(vppPath))
                return dialogueFiles;

            try
            {
                // Get all dialogue files
                var entries = await VppExtractor.LoadVppAsync(vppPath);

                var dlgFiles = entries
                    .Where(entry => entry.FileName.EndsWith("_dlg.tbl", StringComparison.OrdinalIgnoreCase))
                    .ToList();

                System.Diagnostics.Debug.WriteLine($"Found {dlgFiles.Count} dialogue files to parse");

                using (var stream = new FileStream(vppPath, FileMode.Open, FileAccess.Read))
                using (var reader = new BinaryReader(stream))
                {
                    foreach (var dlgFile in dlgFiles)
                    {
                        reader.BaseStream.Seek(dlgFile.FileOffset, SeekOrigin.Begin);
                        byte[] data = reader.ReadBytes(dlgFile.FileSize);

                        try
                        {
                            var dialogueFile = DialogueFile.Parse(dlgFile.FileName, data);
                            dialogueFiles.Add(dialogueFile);
                        }
                        catch (Exception ex)
                        {
                            System.Diagnostics.Debug.WriteLine($"Error parsing dialogue file {dlgFile.FileName}: {ex.Message}");
                        }
                    }
                }

                return dialogueFiles;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading dialogue files: {ex.Message}");
                return dialogueFiles;
            }
        }

        public static string GetGameInstallationPath()
        {
            // First check if we have a saved path
            string savedPath = SettingsManager.GetGamePath();
            if (!string.IsNullOrEmpty(savedPath) && Directory.Exists(savedPath))
            {
                return savedPath;
            }

            // If not, check common locations. Only checking Steam location, and I am not spending all day on it.
            string[] possiblePaths = {
                @"C:\Program Files (x86)\Steam\steamapps\common\Summoner",
                @"D:\Steam\steamapps\common\Summoner",
                @"C:\SteamLibrary\steamapps\common\Summoner",
                @"D:\SteamLibrary\steamapps\common\Summoner",
            };

            foreach (var path in possiblePaths)
            {
                if (Directory.Exists(path))
                {
                    // Save the found path for next time
                    SettingsManager.SaveGamePath(path);
                    return path;
                }
            }

            // If not found in common locations, let user browse
            using (var dialog = new FolderBrowserDialog())
            {
                dialog.Description = "Please select your Summoner installation folder";
                dialog.UseDescriptionForTitle = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Save the selected path
                    SettingsManager.SaveGamePath(dialog.SelectedPath);
                    return dialog.SelectedPath;
                }
            }

            return null;
        }

        public static async Task<byte[]> ExtractFileFromVppAsync(string fileName)
        {
            string gamePath = GetGameInstallationPath();
            if (string.IsNullOrEmpty(gamePath))
                return null;

            string vppPath = Path.Combine(gamePath, "tables.vpp");
            if (!File.Exists(vppPath))
                return null;

            return await VppExtractor.ExtractFileDataAsync(vppPath, fileName);
        }

        /// <summary>
        /// Loads the level items from the level_items.tbl file
        /// </summary>
        /// <returns>A list of level items</returns>
        public static async Task<List<LevelItem>> LoadLevelItemsAsync()
        {
            try
            {
                // First try to load from the VPP archive
                byte[] fileData = await ExtractFileFromVppAsync("level_items.tbl");

                // If not found in VPP, try to load from the game directory directly
                if (fileData == null)
                {
                    string gamePath = GetGameInstallationPath();
                    if (string.IsNullOrEmpty(gamePath))
                        return new List<LevelItem>();

                    string filePath = Path.Combine(gamePath, "level_items.tbl");
                    if (File.Exists(filePath))
                    {
                        fileData = await File.ReadAllBytesAsync(filePath);
                    }
                    else
                    {
                        System.Diagnostics.Debug.WriteLine("Level items file not found");
                        return new List<LevelItem>();
                    }
                }

                return LevelItemsParser.ParseLevelItems(fileData);
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error loading level items: {ex.Message}");
                throw;
            }
        }

        /// <summary>
        /// Loads level items file directly from a specified path
        /// </summary>
        /// <param name="filePath">Path to the level_items.tbl file</param>
        /// <returns>A list of level items</returns>
        public static async Task<List<LevelItem>> LoadLevelItemsFromFileAsync(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Level items file not found: {filePath}");

            byte[] fileData = await File.ReadAllBytesAsync(filePath);
            return LevelItemsParser.ParseLevelItems(fileData);
        }
    }
}
