using SummonerSaveFileEditor.Services;
using System;

namespace SummonerSaveFileEditor.Models
{
    public class LevelItem
    {
        // Core properties from the file
        private string _name = string.Empty;

        // Core properties from the file
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
                // Recalculate hash when name changes
                Hash = !string.IsNullOrEmpty(value) ? SummonerHash.ComputeHash(value) : 0;
            }
        }

        public uint Hash { get; private set; }
        public string Script { get; set; } = string.Empty;
        public string Item { get; set; } = string.Empty; 
        public string Navpoint { get; set; } = string.Empty;
        public int Count { get; set; } = 1; // Default to 1 if not specified
        public int EventId { get; set; } = -1; // -1 means no event
        public string EventData { get; set; } = string.Empty;
        
        // Additional context
        public string LevelName { get; set; } = string.Empty;

        // Track if this item exists in the world (can be picked up)
        // If false, it means the player has already picked it up or triggered it.
        public bool Exists { get; set; } = true;
        public override string ToString()
        {
            return $"{Name} ({Item}) - {LevelName}";
        }
    }
}