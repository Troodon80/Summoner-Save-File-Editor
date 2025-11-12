using System;
using System.Collections.Generic;

namespace SummonerSaveFileEditor.Models
{
    public class Entity
    {
        public CreatureHeader Header { get; set; }
        public EntityBlock EntityBlock { get; set; }

        public Entity()
        {
            Header = new CreatureHeader();
            EntityBlock = new EntityBlock();
        }

        public Entity(CreatureHeader header, EntityBlock block)
        {
            Header = header;
            EntityBlock = block;
        }
        
        // Helper method to determine if this is a player character
        public bool IsPlayerCharacter => Header.creatureType == 7;
    }
}