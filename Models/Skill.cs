using System;

namespace SummonerSaveFileEditor.Models
{
    public class Skill
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Skill(string name, byte value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString() => $"{Name} (Lv {Value})";
    }
}
