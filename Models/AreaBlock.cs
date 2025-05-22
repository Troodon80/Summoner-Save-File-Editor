using System;
using System.Collections.Generic;

// I don't know if this should be hardcoded or not. I haven't looked too deeply into the table file to see
// if we can get this programmatically. For now, this will do. The game is over 20 years old, so I don't
// think we'll be seeing any more updates to it and it's not like the game has a thriving modding community.
// Doubt this will be changing, so it should be safe.

namespace SummonerSaveFileEditor.Data
{
    public static class AreaBlockTable
    {
        public static readonly AreaBlock[] Table = new AreaBlock[]
        {
            new AreaBlock("wolong",0x0C,0x9F,0x13),
            new AreaBlock("wolong_m1",0x00,0x00,0x13),
            new AreaBlock("catacombs",0x01,0x05,0x0A),
            new AreaBlock("catacombs_m1",0x00,0x00,0x0A),
            new AreaBlock("test",0x01,0x02,0x64),
            new AreaBlock("masad",0x07,0x1C,0x03),
            new AreaBlock("masad_v2",0x00,0x00,0x07),
            new AreaBlock("masad_m1",0x00,0x00,0x04),
            new AreaBlock("worldmap1",0x00,0x00,0x64),
            new AreaBlock("lenele1b",0x7A,0x157,0x64),
            new AreaBlock("lenele1b_v2",0x73,0x115,64),
            new AreaBlock("lenele1b_v3",0x70,0x10F,0x64),
            new AreaBlock("lenele1c",0x32,0xA6,0x64),
            new AreaBlock("lenele1d",0x46,0xAD,0x64),
            new AreaBlock("lenele1d_v2",0x4D,0xC8,0x64),
            new AreaBlock("lenele1d_v3",0x4A,0xC2,0x64),
            new AreaBlock("lenele1d_m1",0x00,0x00,0x0A),
            new AreaBlock("lenele1e",0x23,0x46,0x64),
            new AreaBlock("lenele1e_v2",0x18,0x30,0x64),
            new AreaBlock("sewer",0x0E,0x38,0x06),
            new AreaBlock("sewer_v2",0x00,0x00,0x0F),
            new AreaBlock("sewer_v3",0x00,0x00,0x1E),
            new AreaBlock("sewer_m1",0x00,0x00,0x08),
            new AreaBlock("rand-hills01",0x00,0x00,0x64),
            new AreaBlock("rand-hills01_v2",0x00,0x00,0x64),
            new AreaBlock("rand-hills01_v3",0x01,0x03,0x64),
            new AreaBlock("rand-hills01_v4",0x00,0x00,0x64),
            new AreaBlock("IkaemosBottomInt",0x00,0x00,0x0D),
            new AreaBlock("IkaemosBottomInt_m1",0x00,0x00,0x0D),
            new AreaBlock("IkaemosTopInt",0x01,0x0B,0x0D),
            new AreaBlock("IkaemosTopInt_m1",0x00,0x00,0x0D),
            new AreaBlock("IkaemosExt",0x00,0x00,0x0C),
            new AreaBlock("IkaemosExt_m1",0x00,0x00,0x0C),
            new AreaBlock("khosanilab",0x00,0x00,0x0D),
            new AreaBlock("khosanilab_m1",0x00,0x00,0x0D),
            new AreaBlock("IonaEXT",0x3F,0x10D,0x64),
            new AreaBlock("IonaEXT_m1",0x00,0x00,0x0D),
            new AreaBlock("WolongCaverns",0x08,0x3D,0x14),
            new AreaBlock("WolongCaverns_m1",0x00,0x00,0x14),
            new AreaBlock("TempleInt",0x2C,0xB1,0x64),
            new AreaBlock("TempleInt_v2",0x00,0x00,0x14),
            new AreaBlock("TempleInt_m1",0x00,0x00,0x14),
            new AreaBlock("Rand-Forest01",0x00,0x00,0x64),
            new AreaBlock("Rand-Forest01_v2",0x00,0x00,0x64),
            new AreaBlock("Rand-Forest01_v3",0x00,0x00,0x64),
            new AreaBlock("Rand-Forest01_v4",0x00,0x00,64),
            new AreaBlock("Rand-Forest01_v5",0x03,0x06,64),
            new AreaBlock("Rand-Forest01_v6",0x07,0x31,64),
            new AreaBlock("Rand-Forestnite1",0x00,0x00,64),
            new AreaBlock("Rand-Forestnite1_v2",0x00,0x00,0x64),
            new AreaBlock("Rand-Forestnite1_v3",0x00,0x00,0x64),
            new AreaBlock("Rand-Forestnite1_v4",0x00,0x00,0x64),
            new AreaBlock("Rand-Forestnite1_v5",0x00,0x00,0x64),
            new AreaBlock("Rand-Forestnite1_v6",0x00,0x00,0x64),
            new AreaBlock("Rand-Forestnite1_v7",0x00,0x00,0x64),
            new AreaBlock("Liangshan",0x04,0x2A,0x15),
            new AreaBlock("Liangshan_m1",0x00,0x00,0x15),
            new AreaBlock("Rand-Desert",0x00,0x00,0x64),
            new AreaBlock("Rand-Desert_v2",0x00,0x00,0x64),
            new AreaBlock("Rand-Desert_v3",0x01,0x09,0x64),
            new AreaBlock("IonaExt02",0x01,0x11,0x17),
            new AreaBlock("IonaExt02_v2",0x01,0x0E,0x1E),
            new AreaBlock("IonaExt02_m1",0x00,0x00,0x18),
            new AreaBlock("KhosaniStrng",0x1E,0x5E,0x64),
            new AreaBlock("KhosaniStrng_v2",0x20,0x6A,0x64),
            new AreaBlock("KhosaniStrng_v3",0x15,0x3F,0x64),
            new AreaBlock("KhosaniStrng_v4",0x22,0xE0,0x64),
            new AreaBlock("KhosaniStrng_v5",0x1F,0xDD,0x64),
            new AreaBlock("KhosaniStrng_v6",0x20,0xE2,0x64),
            new AreaBlock("KhosaniStrng_m1",0x00,0x00,0x0D),
            new AreaBlock("LPalaceInt",0x42,0xDB,0x64),
            new AreaBlock("LPalaceInt_v2",0x2E,0xC1,0x64),
            new AreaBlock("LPalaceInt_m1",0x00,0x00,0x0C),
            new AreaBlock("tancredhouse",0x04,0x11,0x64),
            new AreaBlock("tancredhouse_v3",0x09,0x23,0x64),
            new AreaBlock("LPalaceInt02",0x00,0x00,0x19),
            new AreaBlock("khosanilab2",0x00,0x00,0x1E),
            new AreaBlock("khosanilab2_m1",0x00,0x00,0x18),
            new AreaBlock("Wolong2",0x04,0x2C,0x15),
            new AreaBlock("Wolong2_v2",0x25,0xAD,0x64),
            new AreaBlock("eleh",0x15,0x65,0x10),
            new AreaBlock("eleh_m1",0x00,0x00,0x10),
            new AreaBlock("lenele2aa",0x03,0x21,0x64),
            new AreaBlock("lenele2aa_m1",0x00,0x00,0x11),
            new AreaBlock("lenele2ab",0x03,0x31,0x64),
            new AreaBlock("lenele2ab_m1",0x00,0x00,0x11),
            new AreaBlock("lenele3a",0x01,0x08,0x64),
            new AreaBlock("lenele3a_m1",0x00,0x00,0x18),
            new AreaBlock("Lenele3d",0x04,0x14,0x64),
            new AreaBlock("lenele3d_m1",0x00,0x00,0x18),
            new AreaBlock("jadetemple",0x0E,0x3F,0x16),
            new AreaBlock("jadetemple_v2",0x00,0x00,0x32),
            new AreaBlock("jadetemple_m1",0x00,0x00,0x16),
            new AreaBlock("lenele1aa",0x6B,0x12F,0x64),
            new AreaBlock("lenele1aa_v2",0x65,0x118,0x64),
            new AreaBlock("lenele1aa_v3",0x68,0x11E,0x64),
            new AreaBlock("lenele1ab",0x3A,0xA6,0x64),
            new AreaBlock("lenele1ab_v2",0x32,0x96,0x64),
            new AreaBlock("lenele1ab_v3",0x34,0x9A,0x64),
            new AreaBlock("TempleInt2",0x03,0x0C,0x1E),
            new AreaBlock("TempleInt2_m1",0x00,0x00,0x18),
            new AreaBlock("IkaemosExt2",0x00,0x00,0x19),
            new AreaBlock("IkaemosExt2_m1",0x00,0x00,0x18),
            new AreaBlock("IkaemosBottomInt2",0x00,0x00,0x1E),
            new AreaBlock("IkaemosBottomInt2_m1",0x00,0x00,0x18),
            new AreaBlock("Rand-HillsNite01",0x00,0x00,0x64),
            new AreaBlock("Rand-HillsNite01_v2",0x00,0x00,0x64),
            new AreaBlock("Rand-HillsNite01_v3",0x00,0x00,0x64),
            new AreaBlock("Rand-Iceland01",0x00,0x00,0x64),
            new AreaBlock("Rand-Iceland01_v2",0x0B,0x16,0x64),
            new AreaBlock("Rand-Iceland01_v3",0x00,0x00,0x64),
            new AreaBlock("Rand-Iceland01_v4",0x00,0x00,0x64),
            new AreaBlock("Rand-Grassland01",0x00,0x00,0x64),
            new AreaBlock("Rand-grassland01_v2",0x00,0x00,0x64),
            new AreaBlock("Rand-grassland01_v3",0x03,0x12,0x64),
            new AreaBlock("Rand-grassland01_v4",0x04,0x08,0x64),
            new AreaBlock("Rand-grassland01_v5",0x00,0x00,0x64),
            new AreaBlock("Rand-Orenia01",0x00,0x00,0x64),
            new AreaBlock("Rand-Orenia01_v2",0x00,0x00,0x64),
            new AreaBlock("Rand-Orenia01_v3",0x01,0x0F,0x64),
            new AreaBlock("Rand-OreniaNite01",0x00,0x00,0x64),
            new AreaBlock("Rand-OreniaNite01_v2",0x00,0x00,0x64),
            new AreaBlock("Rand-OreniaNite01_v3",0x01,0x07,0x64),
            new AreaBlock("Rand-DesertNite01",0x00,0x00,0x64),
            new AreaBlock("Rand-DesertNite01_v2",0x00,0x00,0x64),
            new AreaBlock("Rand-DesertNite01_v3",0x05,0x0A,0x64),
            new AreaBlock("Rand-GrasslandNite01",0x00,0x00,0x64),
            new AreaBlock("Rand-GrasslandNite012",0x00,0x00,0x64),
            new AreaBlock("Rand-GrasslandNite013",0x00,0x00,0x64),
            new AreaBlock("Rand-IcelandNite01",0x00,0x00,0x64),
            new AreaBlock("Rand-IcelandNite01_v2",0x00,0x00,0x64),
            new AreaBlock("Rand-IcelandNite01_v3",0x00,0x00,0x64),
            new AreaBlock("lenele2d",0x0B,0x21,0x64),
            new AreaBlock("sewerboss",0x01,0x05,0x07),
            new AreaBlock("sewerboss_m1",0x00,0x00,0x07)
        };
    }

    public class AreaBlock
    {
        public string Name { get; }
        public int EntryCount { get; }
        public int ReferenceCount { get; }
        public int BlockType { get; }

        public AreaBlock(string name, int entryCount, int referenceCount, int blockType)
        {
            Name = name;
            EntryCount = entryCount;
            ReferenceCount = referenceCount;
            BlockType = blockType;
        }
    }
}