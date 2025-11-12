using System;
using System.IO;

namespace SummonerSaveFileEditor.Models
{
    public struct EquippedItems
    {
        public int iAmulet;
        public int iRing1;
        public int iRing2;
        public int iGauntlets;
        public int iBoots;
        public int iWeapon;
        public int iShield;
        public int iTorso;
        public int iLeggings;

        public EquippedItems(BinaryReader reader)
        {
            iAmulet = reader.ReadInt32();
            iRing1 = reader.ReadInt32();
            iRing2 = reader.ReadInt32();
            iGauntlets = reader.ReadInt32();
            iBoots = reader.ReadInt32();
            iWeapon = reader.ReadInt32();
            iShield = reader.ReadInt32();
            iTorso = reader.ReadInt32();
            iLeggings = reader.ReadInt32();
        }

        public void Write(BinaryWriter writer)
        {
            writer.Write(iAmulet);
            writer.Write(iRing1);
            writer.Write(iRing2);
            writer.Write(iGauntlets);
            writer.Write(iBoots);
            writer.Write(iWeapon);
            writer.Write(iShield);
            writer.Write(iTorso);
            writer.Write(iLeggings);
        }
    }
}
