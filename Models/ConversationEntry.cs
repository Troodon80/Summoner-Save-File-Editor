using System;
using System.IO;

namespace SummonerSaveFileEditor.Models
{
    public class ConversationEntry
    {
        // Single hash value for conversation topic
        public uint TopicHash { get; set; }

        // Flag indicating if this topic has been seen
        public bool Seen { get; set; }

        public static ConversationEntry ReadFrom(BinaryReader reader)
        {
            if (reader.BaseStream.Position + 4 > reader.BaseStream.Length)
                throw new EndOfStreamException("Not enough data to read conversation entry");

            return new ConversationEntry
            {
                TopicHash = reader.ReadUInt32(),
                Seen = true // Default to seen since it's in the save file
            };
        }

        public void WriteTo(BinaryWriter writer)
        {
            writer.Write(TopicHash);
        }
    }
}