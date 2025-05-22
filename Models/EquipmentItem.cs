using System;

namespace SummonerSaveFileEditor.Models
{
    public class EquipmentItem
    {
        private int index;
        private string name;
        private string category;
        private bool doubleslot;
        private Usability usability;

        public int Index
        {
            get { return index; }
            set { index = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public bool DoubleSlot
        {
            get { return doubleslot; }
            set { doubleslot = value; }
        }

        public void SetUsability(string str)
        {
            int indexOf = 0;
            usability = Usability.None;

            if (str == "")
            {
                usability = Usability.Joseph | Usability.Flece | Usability.Rosalind | Usability.Jekhar;
                return;
            }

            indexOf = str.IndexOf("Joseph");
            if (indexOf != -1)
                usability |= Usability.Joseph;
            indexOf = str.IndexOf("Flece");
            if (indexOf != -1)
                usability |= Usability.Flece;
            indexOf = str.IndexOf("Rosalind");
            if (indexOf != -1)
                usability |= Usability.Rosalind;
            indexOf = str.IndexOf("Jekhar");
            if (indexOf != -1)
                usability |= Usability.Jekhar;
        }

        public Usability GetUsability()
        {
            return usability;
        }

        public EquipmentItem() { }

        public void Init(int index)
        {
            this.index = index;
        }

        public override string ToString()
        {
            return name;
        }
    }
}
