using SummonerSaveFileEditor.Models;
using SummonerSaveFileEditor.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;

namespace SummonerSaveFileEditor.Services
{
    public static class ConversationDataService
    {
        public static void LoadConversationDataOnDemand(SaveGameViewModel viewModel, List<DialogueFile> dialogueFiles)
        {
            if (viewModel.ConversationDataLoaded || viewModel.RawConversationData == null)
                return;
            
            try
            {
                var rawMetadata = new Dictionary<AreaScript, byte[]>();
                var processedData = new Dictionary<string, ConversationData>();
                
                // Build character name map once for efficiency
                var dialogueCharacterNames = BuildCharacterNameMap(dialogueFiles);
                
                using (var memoryStream = new MemoryStream(viewModel.RawConversationData))
                using (var reader = new BinaryReader(memoryStream))
                {
                    foreach (var metadata in AreaScriptTable.Table)
                    {
                        if (metadata.Name.EndsWith("_m1"))
                            continue;
                            
                        // Calculate aligned sizes for proper padding
                        int entryCount = metadata.CharacterCount;
                        int referenceCount = metadata.TopicCount;
                        int entryCountAligned = ((entryCount + 7) & ~7);
                        int referenceCountAligned = ((referenceCount * 4 + 7) & ~7);
                        
                        // Calculate the total block size
                        int baseSize = 4 + (entryCount * 4) + (entryCount * 4) + (referenceCount * 4) +
                                      entryCountAligned + referenceCountAligned;
                        
                        // Read the raw data block
                        byte[] blockData = reader.ReadBytes(baseSize);
                        rawMetadata[metadata] = blockData;
                        
                        // Only process if there's actual content
                        if (entryCount > 0 && referenceCount > 0)
                        {
                            try
                            {
                                // Parse the raw data using a constructor that handles parsing
                                var conversationData = new ConversationData(metadata, blockData, dialogueCharacterNames);
                                processedData[metadata.Name] = conversationData;
                            }
                            catch (Exception ex)
                            {
                                // Create minimal fallback data on error
                                var conversationData = new ConversationData
                                {
                                    BlockInfo = metadata,
                                    HeaderValue = 0
                                };
                                processedData[metadata.Name] = conversationData;
                                
                                System.Diagnostics.Debug.WriteLine($"Error processing conversation block {metadata.Name}: {ex.Message}");
                            }
                        }
                    }
                }
                
                // Store results
                viewModel.ConversationMetadata = rawMetadata;
                viewModel.ConversationData = processedData;
                viewModel.ConversationDataLoaded = true;
                
                // Clean up the raw data since we no longer need it
                //viewModel.RawConversationData = null;
                // Store this for now since we're not actively doing anything with the conversation data; write it back as-is
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine($"Error processing conversation data: {ex.Message}");
            }
        }
        
        private static Dictionary<uint, string> BuildCharacterNameMap(List<DialogueFile> dialogueFiles)
        {
            var result = new Dictionary<uint, string>();
            
            if (dialogueFiles == null)
                return result;
                
            foreach (var file in dialogueFiles)
            {
                foreach (var character in file.Characters)
                {
                    uint hash = SummonerHash.ComputeHash(character.Name);
                    if (!result.ContainsKey(hash))
                    {
                        result[hash] = character.Name;
                    }
                }
            }
            
            return result;
        }
        
        public static void UpdateDialogueConversationState(
            List<DialogueFile> dialogueFiles, 
            Dictionary<string, ConversationData> processedData)
        {
            if (dialogueFiles == null || processedData == null)
                return;
                
            foreach (var dialogue in dialogueFiles)
            {
                // Extract block name (without .tbl extension and _dlg suffix)
                string blockName = dialogue.DisplayName;
                                    
                // Find conversation data for this dialogue file
                if (processedData.TryGetValue(blockName, out var conversationData))
                {
                    foreach (var character in dialogue.Characters)
                    {
                        uint characterHash = SummonerHash.ComputeHash(character.Name);
                        var npc = conversationData.FindNpc(characterHash);
                        
                        if (npc != null)
                        {
                            foreach (var topic in character.Topics)
                            {
                                foreach (var npcTopic in npc.Topics)
                                {
                                    if (npcTopic.Hash == topic.TopicHash)
                                    {
                                        // Set topic state from save file data
                                        topic.HasSeen = npcTopic.HasSeen;
                                        break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}