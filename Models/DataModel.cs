using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace SummonerSaveFileEditor.Models
{
    public class TimeDescriptionData
    {
        public float Time { get; set; }
        public string Description { get; set; }
        public string FormattedTime { get; set; }
    }

    public class ThumbnailData
    {
        public Image ThumbnailImage { get; set; }
    }

    public class InventoryData
    {
        public int Gold { get; set; }
        public int OriginalSize { get; set; }
        public List<InventoryItem> Items { get; set; } = new List<InventoryItem>();
        public List<ListViewItem> ListViewItems { get; set; } = new List<ListViewItem>();
    }

    public class CharacterData
    {
        public List<Character> MainCharacters { get; set; } = new List<Character>();
        public List<Creature> OtherCreatures { get; set; } = new List<Creature>();
        public List<ListViewItem> ListViewItems { get; set; } = new List<ListViewItem>();
        
        // Character-specific data
        public long JosephOffset { get; set; }
        public float JosephHealthDiff { get; set; }
        public short JosephApDiff { get; set; }
        
        public long FleceOffset { get; set; }
        public float FleceHealthDiff { get; set; }
        public short FleceApDiff { get; set; }
        
        public long RosalindOffset { get; set; }
        public float RosalindHealthDiff { get; set; }
        public short RosalindApDiff { get; set; }
        
        public long JekharOffset { get; set; }
        public float JekharHealthDiff { get; set; }
        public short JekharApDiff { get; set; }
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
