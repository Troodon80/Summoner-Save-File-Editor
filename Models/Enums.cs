using System;

namespace SummonerSaveFileEditor.Models
{
    [Flags]
    public enum Usability
    {
        None = 0,
        Joseph = 1,
        Flece = 2,
        Rosalind = 4,
        Jekhar = 8,
    }

    public enum EquipmentSlot
    {
        Amulet,
        Ring1,
        Ring2,
        Gauntlets,
        Boots,
        Weapon,
        Shield,
        Torso,
        Leggings
    }
}
