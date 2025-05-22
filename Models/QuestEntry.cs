using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SummonerSaveFileEditor.Models
{
    internal class QuestEntry
    {
        public int QuestId { get; set; }
        public int State { get; set; }
        public int Flags { get; set; }
        public int Counter { get; set; }
        public string Label { get; set; }


    }
}
