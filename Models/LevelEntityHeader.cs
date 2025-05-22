using System.IO;

namespace SummonerSaveFileEditor.Models
{
    public class LevelEntityHeader
    {
        public string LentSignature { get; set; } // Signature for level entity header
        public uint FirstEntityOffset { get; set; }    // Relative offset to first entity
        public uint EndRegionOffset { get; set; }      // Relative offset to end of entity region
        public uint PossibleBitfield { get; set; }     // Likely bitfield, mask, or constant
        public uint PossibleSaveId { get; set; }       // Possibly a global save ID/hash
        public uint PossibleMaxEntitySpan { get; set; } // Maybe max entity span
        public uint PossibleCodeRef1 { get; set; }     // Code address or data reference
        public uint PossibleCodeRef2 { get; set; }     // Code address or data reference
        public uint PossibleDataTable { get; set; }    // Likely data table or pointer
        public uint PossibleFuncAddr1 { get; set; }    // Function address
        public uint PossibleFuncAddr2 { get; set; }    // Function address
        public uint PossibleFuncAddr3 { get; set; }    // Function address
        public uint EntityCount { get; set; }          // Number of entities
    }
}