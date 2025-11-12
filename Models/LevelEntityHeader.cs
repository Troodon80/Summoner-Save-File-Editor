using System.IO;

namespace SummonerSaveFileEditor.Models
{
    public class LevelEntityHeader
    {
        public string LentSignature { get; set; } // Signature for level entity header
        public uint FirstEntityOffset { get; set; }    // Relative offset to first entity
        public uint EndRegionOffset { get; set; }      // Relative offset to end of entity region
        public uint StatusBitfield { get; set; }     // Likely bitfield, mask, or constant
        public string SummonName { get; set; }         // Name of the currently active summon
        public uint EntityCount { get; set; }          // Number of entities
    }
}