using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SummonerSaveFileEditor.Models;
using SummonerSaveFileEditor.Properties;

namespace SummonerSaveFileEditor.Services
{
    public static class ItemLoader
    {

        public static List<InventoryItem> LoadInventoryItems(string path)
        {
            var items = new List<InventoryItem>();
            var lines = File.ReadAllLines(path).Skip(1); // assuming header

            string itemsResource = Resource.items;
            itemsResource = itemsResource.Replace("\r\n", "\n");
            string[] array = itemsResource.Split('\n');

            foreach (var line in lines)
            {
                var parts = line.Split('\t');
                if (parts.Length >= 2 && int.TryParse(parts[0], out int hash))
                {
                    items.Add(new InventoryItem
                    {
                        Hash = hash,
                        Name = parts[1]
                    });
                }
            }

            return items;
        }
    }
}
