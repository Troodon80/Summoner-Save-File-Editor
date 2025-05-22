using System;

namespace SummonerSaveFileEditor.Models
{
    public class VppEntry
    {
        public string FileName { get; set; } = string.Empty;
        public int FileSize { get; set; }
        public int FileOffset { get; set; }
    }
}