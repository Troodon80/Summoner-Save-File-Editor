using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SummonerSaveFileEditor.Models;
using SummonerSaveFileEditor.Properties;

namespace SummonerSaveFileEditor.Services
{
    public static class ResourceLoader
    {
        public static async Task<(List<InventoryItem> inventoryItems, List<EquipmentItem> equipmentItems, Dictionary<uint, string> characterNames)>
            LoadResourcesAsync()
        {
            var inventoryList = new List<InventoryItem>();
            var equipmentList = new List<EquipmentItem>();
            var characterNameDict = new Dictionary<uint, string>();

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

            // Parse character names
            string characters = Resource.characterNames.Replace("\r\n", "\n");
            string[] charLines = characters.Split('\n');
            foreach (var name in charLines)
            {
                if (string.IsNullOrWhiteSpace(name)) continue;
                uint id = SummonerHash.ComputeHash(name.Trim());
                characterNameDict[id] = name.Trim();
            }
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
            return (inventoryList, equipmentList, characterNameDict);
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

        public static async Task<Dictionary<string, List<TblEntry>>> LoadTblFilesFromVppAsync(string vppPath, string fileName = "")
        {
            try
            {
                return await VppExtractor.ExtractTblFilesAsync(vppPath, fileName);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading VPP file: {ex.Message}", "VPP Loading Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new Dictionary<string, List<TblEntry>>();
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
    }
}
