using System;
using System.Collections.Generic;

// I don't know if this should be hardcoded or not. I haven't looked too deeply into the table file to see
// if we can get this programmatically. For now, this will do. The game is over 20 years old, so I don't
// think we'll be seeing any more updates to it and it's not like the game has a thriving modding community.
// Doubt this will be changing, so it should be safe.

// TODO: find a way to do this by reading the TBL files. Not a priority.

namespace SummonerSaveFileEditor.Models
{
    public static class AreaScriptTable
    {
        public static readonly AreaScript[] Table = new AreaScript[]
        {
            new AreaScript("wolong",0x0C,0x9F,0x13),
            new AreaScript("wolong_m1",0x00,0x00,0x13),
            new AreaScript("catacombs",0x01,0x05,0x0A),
            new AreaScript("catacombs_m1",0x00,0x00,0x0A),
            new AreaScript("test",0x01,0x02,0x64),
            new AreaScript("masad",0x07,0x1C,0x03),
            new AreaScript("masad_v2",0x00,0x00,0x07),
            new AreaScript("masad_m1",0x00,0x00,0x04),
            new AreaScript("worldmap1",0x00,0x00,0x64),
            new AreaScript("lenele1b",0x7A,0x157,0x64),
            new AreaScript("lenele1b_v2",0x73,0x115,64),
            new AreaScript("lenele1b_v3",0x70,0x10F,0x64),
            new AreaScript("lenele1c",0x32,0xA6,0x64),
            new AreaScript("lenele1d",0x46,0xAD,0x64),
            new AreaScript("lenele1d_v2",0x4D,0xC8,0x64),
            new AreaScript("lenele1d_v3",0x4A,0xC2,0x64),
            new AreaScript("lenele1d_m1",0x00,0x00,0x0A),
            new AreaScript("lenele1e",0x23,0x46,0x64),
            new AreaScript("lenele1e_v2",0x18,0x30,0x64),
            new AreaScript("sewer",0x0E,0x38,0x06),
            new AreaScript("sewer_v2",0x00,0x00,0x0F),
            new AreaScript("sewer_v3",0x00,0x00,0x1E),
            new AreaScript("sewer_m1",0x00,0x00,0x08),
            new AreaScript("rand-hills01",0x00,0x00,0x64),
            new AreaScript("rand-hills01_v2",0x00,0x00,0x64),
            new AreaScript("rand-hills01_v3",0x01,0x03,0x64),
            new AreaScript("rand-hills01_v4",0x00,0x00,0x64),
            new AreaScript("IkaemosBottomInt",0x00,0x00,0x0D),
            new AreaScript("IkaemosBottomInt_m1",0x00,0x00,0x0D),
            new AreaScript("IkaemosTopInt",0x01,0x0B,0x0D),
            new AreaScript("IkaemosTopInt_m1",0x00,0x00,0x0D),
            new AreaScript("IkaemosExt",0x00,0x00,0x0C),
            new AreaScript("IkaemosExt_m1",0x00,0x00,0x0C),
            new AreaScript("khosanilab",0x00,0x00,0x0D),
            new AreaScript("khosanilab_m1",0x00,0x00,0x0D),
            new AreaScript("IonaEXT",0x3F,0x10D,0x64),
            new AreaScript("IonaEXT_m1",0x00,0x00,0x0D),
            new AreaScript("WolongCaverns",0x08,0x3D,0x14),
            new AreaScript("WolongCaverns_m1",0x00,0x00,0x14),
            new AreaScript("TempleInt",0x2C,0xB1,0x64),
            new AreaScript("TempleInt_v2",0x00,0x00,0x14),
            new AreaScript("TempleInt_m1",0x00,0x00,0x14),
            new AreaScript("Rand-Forest01",0x00,0x00,0x64),
            new AreaScript("Rand-Forest01_v2",0x00,0x00,0x64),
            new AreaScript("Rand-Forest01_v3",0x00,0x00,0x64),
            new AreaScript("Rand-Forest01_v4",0x00,0x00,64),
            new AreaScript("Rand-Forest01_v5",0x03,0x06,64),
            new AreaScript("Rand-Forest01_v6",0x07,0x31,64),
            new AreaScript("Rand-Forestnite1",0x00,0x00,64),
            new AreaScript("Rand-Forestnite1_v2",0x00,0x00,0x64),
            new AreaScript("Rand-Forestnite1_v3",0x00,0x00,0x64),
            new AreaScript("Rand-Forestnite1_v4",0x00,0x00,0x64),
            new AreaScript("Rand-Forestnite1_v5",0x00,0x00,0x64),
            new AreaScript("Rand-Forestnite1_v6",0x00,0x00,0x64),
            new AreaScript("Rand-Forestnite1_v7",0x00,0x00,0x64),
            new AreaScript("Liangshan",0x04,0x2A,0x15),
            new AreaScript("Liangshan_m1",0x00,0x00,0x15),
            new AreaScript("Rand-Desert",0x00,0x00,0x64),
            new AreaScript("Rand-Desert_v2",0x00,0x00,0x64),
            new AreaScript("Rand-Desert_v3",0x01,0x09,0x64),
            new AreaScript("IonaExt02",0x01,0x11,0x17),
            new AreaScript("IonaExt02_v2",0x01,0x0E,0x1E),
            new AreaScript("IonaExt02_m1",0x00,0x00,0x18),
            new AreaScript("KhosaniStrng",0x1E,0x5E,0x64),
            new AreaScript("KhosaniStrng_v2",0x20,0x6A,0x64),
            new AreaScript("KhosaniStrng_v3",0x15,0x3F,0x64),
            new AreaScript("KhosaniStrng_v4",0x22,0xE0,0x64),
            new AreaScript("KhosaniStrng_v5",0x1F,0xDD,0x64),
            new AreaScript("KhosaniStrng_v6",0x20,0xE2,0x64),
            new AreaScript("KhosaniStrng_m1",0x00,0x00,0x0D),
            new AreaScript("LPalaceInt",0x42,0xDB,0x64),
            new AreaScript("LPalaceInt_v2",0x2E,0xC1,0x64),
            new AreaScript("LPalaceInt_m1",0x00,0x00,0x0C),
            new AreaScript("tancredhouse",0x04,0x11,0x64),
            new AreaScript("tancredhouse_v3",0x09,0x23,0x64),
            new AreaScript("LPalaceInt02",0x00,0x00,0x19),
            new AreaScript("khosanilab2",0x00,0x00,0x1E),
            new AreaScript("khosanilab2_m1",0x00,0x00,0x18),
            new AreaScript("Wolong2",0x04,0x2C,0x15),
            new AreaScript("Wolong2_v2",0x25,0xAD,0x64),
            new AreaScript("eleh",0x15,0x65,0x10),
            new AreaScript("eleh_m1",0x00,0x00,0x10),
            new AreaScript("lenele2aa",0x03,0x21,0x64),
            new AreaScript("lenele2aa_m1",0x00,0x00,0x11),
            new AreaScript("lenele2ab",0x03,0x31,0x64),
            new AreaScript("lenele2ab_m1",0x00,0x00,0x11),
            new AreaScript("lenele3a",0x01,0x08,0x64),
            new AreaScript("lenele3a_m1",0x00,0x00,0x18),
            new AreaScript("Lenele3d",0x04,0x14,0x64),
            new AreaScript("lenele3d_m1",0x00,0x00,0x18),
            new AreaScript("jadetemple",0x0E,0x3F,0x16),
            new AreaScript("jadetemple_v2",0x00,0x00,0x32),
            new AreaScript("jadetemple_m1",0x00,0x00,0x16),
            new AreaScript("lenele1aa",0x6B,0x12F,0x64),
            new AreaScript("lenele1aa_v2",0x65,0x118,0x64),
            new AreaScript("lenele1aa_v3",0x68,0x11E,0x64),
            new AreaScript("lenele1ab",0x3A,0xA6,0x64),
            new AreaScript("lenele1ab_v2",0x32,0x96,0x64),
            new AreaScript("lenele1ab_v3",0x34,0x9A,0x64),
            new AreaScript("TempleInt2",0x03,0x0C,0x1E),
            new AreaScript("TempleInt2_m1",0x00,0x00,0x18),
            new AreaScript("IkaemosExt2",0x00,0x00,0x19),
            new AreaScript("IkaemosExt2_m1",0x00,0x00,0x18),
            new AreaScript("IkaemosBottomInt2",0x00,0x00,0x1E),
            new AreaScript("IkaemosBottomInt2_m1",0x00,0x00,0x18),
            new AreaScript("Rand-HillsNite01",0x00,0x00,0x64),
            new AreaScript("Rand-HillsNite01_v2",0x00,0x00,0x64),
            new AreaScript("Rand-HillsNite01_v3",0x00,0x00,0x64),
            new AreaScript("Rand-Iceland01",0x00,0x00,0x64),
            new AreaScript("Rand-Iceland01_v2",0x0B,0x16,0x64),
            new AreaScript("Rand-Iceland01_v3",0x00,0x00,0x64),
            new AreaScript("Rand-Iceland01_v4",0x00,0x00,0x64),
            new AreaScript("Rand-Grassland01",0x00,0x00,0x64),
            new AreaScript("Rand-grassland01_v2",0x00,0x00,0x64),
            new AreaScript("Rand-grassland01_v3",0x03,0x12,0x64),
            new AreaScript("Rand-grassland01_v4",0x04,0x08,0x64),
            new AreaScript("Rand-grassland01_v5",0x00,0x00,0x64),
            new AreaScript("Rand-Orenia01",0x00,0x00,0x64),
            new AreaScript("Rand-Orenia01_v2",0x00,0x00,0x64),
            new AreaScript("Rand-Orenia01_v3",0x01,0x0F,0x64),
            new AreaScript("Rand-OreniaNite01",0x00,0x00,0x64),
            new AreaScript("Rand-OreniaNite01_v2",0x00,0x00,0x64),
            new AreaScript("Rand-OreniaNite01_v3",0x01,0x07,0x64),
            new AreaScript("Rand-DesertNite01",0x00,0x00,0x64),
            new AreaScript("Rand-DesertNite01_v2",0x00,0x00,0x64),
            new AreaScript("Rand-DesertNite01_v3",0x05,0x0A,0x64),
            new AreaScript("Rand-GrasslandNite01",0x00,0x00,0x64),
            new AreaScript("Rand-GrasslandNite012",0x00,0x00,0x64),
            new AreaScript("Rand-GrasslandNite013",0x00,0x00,0x64),
            new AreaScript("Rand-IcelandNite01",0x00,0x00,0x64),
            new AreaScript("Rand-IcelandNite01_v2",0x00,0x00,0x64),
            new AreaScript("Rand-IcelandNite01_v3",0x00,0x00,0x64),
            new AreaScript("lenele2d",0x0B,0x21,0x64),
            new AreaScript("sewerboss",0x01,0x05,0x07),
            new AreaScript("sewerboss_m1",0x00,0x00,0x07)
        };
    }

    public class AreaScript
    {
        public string Name { get; }
        public int CharacterCount { get; }
        public int TopicCount { get; }
        public int LevelCap { get; }

        public AreaScript(string name, int characterCount, int topicCount, int levelCap)
        {
            Name = name;
            CharacterCount = characterCount;
            TopicCount = topicCount;
            LevelCap = levelCap;
        }
    }
    public class ConversationData
    {
        // Block metadata
        public AreaScript BlockInfo { get; set; }
        
        // Area visited flag/header
        public int HeaderValue { get; set; }
        
        // List of NPCs in this conversation block
        public List<ConversationNpc> Npcs { get; set; } = new List<ConversationNpc>();

        // Default constructor
        public ConversationData() { }
        
        // Constructor that parses raw data
        public ConversationData(AreaScript blockInfo, byte[] rawData, Dictionary<uint, string> characterNames = null)
        {
            BlockInfo = blockInfo;
            ParseFromBytes(rawData, characterNames);
        }

        // Parse the raw byte data into this conversation state
        public void ParseFromBytes(byte[] rawData, Dictionary<uint, string> characterNames = null)
        {
            if (rawData == null || rawData.Length == 0)
                return;

            try
            {
                using (var stream = new MemoryStream(rawData))
                using (var reader = new BinaryReader(stream))
                {
                    // Read header flag value
                    HeaderValue = reader.ReadInt32();

                    // Pre-allocate arrays for better performance
                    var characterHashes = new uint[BlockInfo.CharacterCount];
                    var topicCounts = new int[BlockInfo.CharacterCount];
                    var allTopics = new List<ConversationTopic>(BlockInfo.TopicCount);

                    // Read all character hashes in one batch
                    for (int i = 0; i < BlockInfo.CharacterCount && stream.Position < stream.Length - 3; i++)
                    {
                        characterHashes[i] = reader.ReadUInt32();
                    }

                    // Read all topic counts in one batch
                    for (int i = 0; i < BlockInfo.CharacterCount && stream.Position < stream.Length - 3; i++)
                    {
                        topicCounts[i] = reader.ReadInt32();
                    }

                    // Read all topic references in one batch
                    for (int i = 0; i < BlockInfo.TopicCount && stream.Position < stream.Length - 3; i++)
                    {
                        try
                        {
                            int topicHash = reader.ReadInt32();
                            allTopics.Add(new ConversationTopic
                            {
                                Hash = topicHash,
                                HasSeen = true  // If it's in the save file, it's been seen
                            });
                        }
                        catch (EndOfStreamException)
                        {
                            break;
                        }
                    }

                    // Build NPCs with pre-allocated capacity for better efficiency
                    Npcs = new List<ConversationNpc>(characterHashes.Length);
                    int topicIndex = 0;

                    for (int i = 0; i < characterHashes.Length && i < topicCounts.Length; i++)
                    {
                        var npc = new ConversationNpc
                        {
                            Hash = characterHashes[i],
                            // Look up name once using Dictionary (fast lookup)
                            Name = characterNames != null && characterNames.TryGetValue(characterHashes[i], out string name)
                                ? name
                                : $"NPC {characterHashes[i]:X8}",
                            Topics = new List<ConversationTopic>(topicCounts[i])
                        };

                        // Add this NPC's topics efficiently
                        int count = topicCounts[i];
                        for (int j = 0; j < count && topicIndex < allTopics.Count; j++)
                        {
                            npc.Topics.Add(allTopics[topicIndex++]);
                        }

                        Npcs.Add(npc);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error parsing conversation data: {ex.Message}");
                // On error, ensure we have at least an empty state
                Npcs = new List<ConversationNpc>();
                HeaderValue = 1; // Default to "area visited"
            }
        }

        // Convert back to bytes for saving
        public byte[] ToBytes()
        {
            using (var stream = new MemoryStream())
            using (var writer = new BinaryWriter(stream))
            {
                // Write header value
                writer.Write(HeaderValue);

                // Get flattened data
                var characterHashes = Npcs.Select(n => n.Hash).ToArray();
                var topicCounts = Npcs.Select(n => n.Topics.Count).ToArray();
                var allTopics = Npcs.SelectMany(n => n.Topics).ToList();

                // Write character hashes
                for (int i = 0; i < BlockInfo.CharacterCount; i++)
                {
                    writer.Write(i < characterHashes.Length ? characterHashes[i] : 0);
                }

                // Write topic counts
                for (int i = 0; i < BlockInfo.CharacterCount; i++)
                {
                    writer.Write(i < topicCounts.Length ? topicCounts[i] : 0);
                }

                // Write topic hashes
                for (int i = 0; i < BlockInfo.TopicCount; i++)
                {
                    writer.Write(i < allTopics.Count ? allTopics[i].Hash : 0);
                }

                // Add padding if needed
                int entryCount = BlockInfo.CharacterCount;
                int referenceCount = BlockInfo.TopicCount;
                int entryCountAligned = ((entryCount + 7) & ~7);
                int referenceCountAligned = ((referenceCount * 4 + 7) & ~7);
                int paddingBytes = (entryCountAligned - entryCount) +
                                  (referenceCountAligned - referenceCount * 4);

                for (int i = 0; i < paddingBytes; i++)
                {
                    writer.Write((byte)0);
                }

                return stream.ToArray();
            }
        }

        // Find NPC by hash
        public ConversationNpc FindNpc(uint hash)
        {
            return Npcs.FirstOrDefault(n => n.Hash == hash);
        }

        // Resolve NPC names from character name table
        public void ResolveNpcNames(Dictionary<uint, string> nameTable)
        {
            foreach (var npc in Npcs)
            {
                if (nameTable != null && nameTable.TryGetValue(npc.Hash, out string characterName))
                {
                    npc.Name = characterName;
                }
            }
        }
    }

    // Simple NPC class that holds a list of conversation topics
    public class ConversationNpc
    {
        // NPC identifier hash
        public uint Hash { get; set; }

        // NPC name (if it can be resolved)
        public string Name { get; set; }

        // Topics available for this NPC
        public List<ConversationTopic> Topics { get; set; } = new List<ConversationTopic>();
    }

    // Simple topic class with just a hash identifier
    public class ConversationTopic
    {
        // Topic identifier hash
        public int Hash { get; set; }

        // Topic name (if it can be resolved)
        public string Name { get; set; } = "Unknown Topic";

        // Topic name (if it can be resolved)
        public bool HasSeen { get; set; }
    }
}
