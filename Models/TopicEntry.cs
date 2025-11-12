using System;
using System.Windows.Forms;

namespace SummonerSaveFileEditor.Models
{
    public class TopicEntry
    {
        public uint TopicId { get; set; }
        public int TopicHash { get; set; }
        public string Name { get; set; }

        public override string ToString()
        {
            return $"Topic {TopicId}: {Name}";
        }

        public ListViewItem ToListViewItem()
        {
            var item = new ListViewItem(Name)
            {
                Tag = this
            };
            return item;
        }
    }
}