using SummonerSaveFileEditor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace SummonerSaveFileEditor.Services
{
    public static class LevelItemsParser
    {
        /// <summary>
        /// Parses the level_items.tbl file content to extract level items
        /// </summary>
        /// <param name="tblData">Raw byte data of the TBL file</param>
        /// <returns>List of LevelItem objects</returns>
        public static List<LevelItem> ParseLevelItems(byte[] tblData)
        {
            var levelItems = new List<LevelItem>();
            string currentLevelName = string.Empty;
            
            using (var stream = new MemoryStream(tblData))
            using (var reader = new StreamReader(stream, Encoding.ASCII))
            {
                string line;
                bool inLevelItemsSection = false;
                LevelItem currentItem = null;
                
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();
                    
                    // Skip empty lines and comments
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("//"))
                        continue;
                        
                    // Check for level items header
                    if (line.StartsWith("#Level Items"))
                    {
                        inLevelItemsSection = true;
                        continue;
                    }
                    
                    if (!inLevelItemsSection)
                        continue;
                        
                    // Check for level header
                    if (line.StartsWith("#Level:"))
                    {
                        var match = Regex.Match(line, "#Level:\\s*\"([^\"]+)\"");
                        if (match.Success)
                        {
                            currentLevelName = match.Groups[1].Value;
                        }
                        continue;
                    }
                    
                    // Start of a new item
                    if (line.StartsWith("$Name:"))
                    {
                        // If we had a previous item, add it to the list
                        if (currentItem != null)
                        {
                            levelItems.Add(currentItem);
                        }
                        
                        // Create new item
                        currentItem = new LevelItem { LevelName = currentLevelName };
                        
                        // Extract item name
                        var match = Regex.Match(line, "\\$Name:\\s*\"([^\"]+)\"");
                        if (match.Success)
                        {
                            currentItem.Name = match.Groups[1].Value;
                        }
                    }
                    else if (currentItem != null) // Process properties of current item
                    {
                        if (line.StartsWith("$Script:"))
                        {
                            var match = Regex.Match(line, "\\$Script:\\s*\"([^\"]+)\"");
                            if (match.Success)
                                currentItem.Script = match.Groups[1].Value;
                        }
                        else if (line.StartsWith("$Item:"))
                        {
                            var match = Regex.Match(line, "\\$Item:\\s*\"([^\"]+)\"");
                            if (match.Success)
                                currentItem.Item = match.Groups[1].Value;
                        }
                        else if (line.StartsWith("$Navpoint:"))
                        {
                            var match = Regex.Match(line, "\\$Navpoint:\\s*\"([^\"]+)\"");
                            if (match.Success)
                                currentItem.Navpoint = match.Groups[1].Value;
                        }
                        else if (line.StartsWith("+Count:"))
                        {
                            var match = Regex.Match(line, "\\+Count:\\s*(\\d+)");
                            if (match.Success && int.TryParse(match.Groups[1].Value, out int count))
                                currentItem.Count = count;
                        }
                        else if (line.StartsWith("+Event:"))
                        {
                            var match = Regex.Match(line, "\\+Event:\\s*\"([^\"]+)\"\\s*\"([^\"]*)\"");
                            if (match.Success)
                            {
                                string eventType = match.Groups[1].Value;
                                // In the assembly, it seems the event ID is calculated from the event name
                                currentItem.EventId = eventType.GetHashCode();  // Simplified, but adequate
                                currentItem.EventData = match.Groups[2].Value;
                            }
                        }
                    }
                }
                
                // Add the last item if it exists
                if (currentItem != null)
                {
                    levelItems.Add(currentItem);
                }
            }
            
            return levelItems;
        }
        
        /// <summary>
        /// Helper method to load level items from a file
        /// </summary>
        public static List<LevelItem> LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"Level items file not found: {filePath}");
                
            byte[] data = File.ReadAllBytes(filePath);
            return ParseLevelItems(data);
        }
    }
}