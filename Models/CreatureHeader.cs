using System;
using System.IO;

namespace SummonerSaveFileEditor.Models
{
    public struct CreatureHeader
    {
        public uint creatureId;
        public int creatureType;

        public CreatureHeader(BinaryReader reader) 
        { 
            creatureId = reader.ReadUInt32(); 
            creatureType = reader.ReadInt32(); 
        }
        
        public void Write(BinaryWriter writer) 
        { 
            writer.Write(creatureId); 
            writer.Write(creatureType); 
        }
    }
}
