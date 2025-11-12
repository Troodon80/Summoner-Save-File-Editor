using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace SummonerSaveFileEditor.Models
{
    public class InventoryData
    {
        public List<InventoryItem> Items { get; set; } = new List<InventoryItem>();
    }

    public class CharacterData
    {
        public List<Character> MainCharacters { get; set; } = new List<Character>();
        public List<Creature> OtherCreatures { get; set; } = new List<Creature>();
    }

    public class CameraBlock
    {
        public int Unknown { get; set; }
        public float FieldOfView { get; set; }
        public float Pitch { get; set; }
        public float Yaw { get; set; }
        public float Zoom { get; set; }
        public float PositionX { get; set; }
        public float PositionY { get; set; }
        public float PositionZ { get; set; }
        public int CameraMode { get; set; }
    }

}
