using System;

namespace SummonerSaveFileEditor.Models
{
    public class Creature
    {
        public CreatureHeader Header { get; set; }
        public CreatureBlock CreatureBlock { get; set; }

        public Creature()
        {
            Header = new CreatureHeader();
            CreatureBlock = new CreatureBlock();
        }

        public Creature(CreatureHeader header, CreatureBlock block)
        {
            Header = header;
            CreatureBlock = block;
        }
    }
}