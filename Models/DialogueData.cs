using SummonerSaveFileEditor.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SummonerSaveFileEditor.Models
{
    public class DialogueFile
    {
        public string FileName { get; set; }
        public string DisplayName { get; set; }
        public List<DialogueCharacter> Characters { get; set; } = new List<DialogueCharacter>();

        public override string ToString() => DisplayName ?? FileName;

        public static DialogueFile Parse(string fileName, byte[] data)
        {
            string displayName = fileName;
            ReadOnlySpan<char> span = displayName.AsSpan();
            if (span.EndsWith(".tbl".AsSpan(), StringComparison.OrdinalIgnoreCase))
                span = span.Slice(0, span.Length - 4);
            if (span.EndsWith("_dlg".AsSpan(), StringComparison.OrdinalIgnoreCase))
                span = span.Slice(0, span.Length - 4);
            displayName = span.ToString();

            var dialogueFile = new DialogueFile
            {
                FileName = Path.GetFileName(fileName),
                DisplayName = displayName
            };

            string content = Encoding.UTF8.GetString(data);
            DialogueCharacter currentCharacter = null;
            DialogueTopic currentTopic = null;

            using (var reader = new StringReader(content))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.Trim();
                    
                    // Skip empty lines and comments
                    if (string.IsNullOrWhiteSpace(line) || line.StartsWith("//"))
                        continue;

                    // Character definition
                    if (line.StartsWith("$Character:"))
                    {
                        string characterName = ExtractQuotedText(line.Substring("$Character:".Length));
                        currentCharacter = new DialogueCharacter { Name = characterName };
                        dialogueFile.Characters.Add(currentCharacter);
                        currentTopic = null;
                    }
                    // Topic definition
                    else if (line.StartsWith("+Topic:") && currentCharacter != null)
                    {
                        string topicText = ExtractQuotedText(line.Substring("+Topic:".Length));
                        
                        // Handle "#N" variants by storing both the original and base names
                        string baseTopicText = topicText;
                        int hashIndex = topicText.IndexOf('#');
                        if (hashIndex > 0)
                            baseTopicText = topicText.Substring(0, hashIndex);
                        
                        currentTopic = new DialogueTopic 
                        { 
                            FullText = topicText,
                            BaseText = baseTopicText,
                            TopicHash = SummonerHash.ComputeHashSigned(topicText)
                        };
                        
                        currentCharacter.Topics.Add(currentTopic);
                    }
                    // NPC response text
                    else if (line.StartsWith("+NPCText:") && currentTopic != null)
                    {
                        string responseText = ExtractQuotedText(line.Substring("+NPCText:".Length));
                        currentTopic.ResponseText = responseText;
                    }
                    // Action flags like event triggers, conditions, etc.
                    else if (line.StartsWith("+") && currentTopic != null)
                    {
                        if (!line.StartsWith("+Add Topic:")) // Don't include follow-up topics in actions
                            currentTopic.Actions.Add(line.Trim());
                    }
                    // Initial topics for a character
                    else if (line.StartsWith("$Initial Topics:") && currentCharacter != null)
                    {
                        string initialTopicsText = line.Substring("$Initial Topics:".Length).Trim();
                        string[] initialTopics = initialTopicsText.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        
                        foreach (string topic in initialTopics)
                        {
                            string cleanTopic = ExtractQuotedText(topic);
                            if (!string.IsNullOrEmpty(cleanTopic))
                                currentCharacter.InitialTopics.Add(cleanTopic);
                        }
                    }
                }
            }

            return dialogueFile;
        }

        private static string ExtractQuotedText(string input)
        {
            input = input.Trim();
            
            // Extract text from {"text"} format
            int openBraceIndex = input.IndexOf('{');
            int closeBraceIndex = input.LastIndexOf('}');
            
            if (openBraceIndex >= 0 && closeBraceIndex > openBraceIndex)
            {
                return input.Substring(openBraceIndex + 1, closeBraceIndex - openBraceIndex - 1);
            }
            
            // Extract text from "text" format
            int firstQuoteIndex = input.IndexOf('"');
            int lastQuoteIndex = input.LastIndexOf('"');
            
            if (firstQuoteIndex >= 0 && lastQuoteIndex > firstQuoteIndex)
            {
                return input.Substring(firstQuoteIndex + 1, lastQuoteIndex - firstQuoteIndex - 1);
            }
            
            return input;
        }
    }

    public class DialogueCharacter
    {
        public string Name { get; set; }
        public List<DialogueTopic> Topics { get; set; } = new List<DialogueTopic>();
        public List<string> InitialTopics { get; set; } = new List<string>();
        public List<string> Flags { get; set; } = new List<string>();
        
        public override string ToString() => Name;
    }

    public class DialogueTopic
    {
        public string FullText { get; set; }
        public string BaseText { get; set; }
        public int TopicHash { get; set; }
        public string ResponseText { get; set; }
        public List<string> Actions { get; set; } = new List<string>();
        public bool HasSeen { get; set; } = false; // Will be set when comparing to save data
        
        public override string ToString() => FullText;
    }
}