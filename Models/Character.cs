using System;
using System.IO;

namespace SummonerSaveFileEditor.Models
{
    public class Character
    {
        public CreatureHeader Header { get; set; }
        public CharacterBlock CharacterBlock { get; set; }

        public Character()
        {
            Header = new CreatureHeader();
            CharacterBlock = new CharacterBlock();
        }

        public Character(CreatureHeader header, CharacterBlock block)
        {
            Header = header;
            CharacterBlock = block;
        }
    }
}