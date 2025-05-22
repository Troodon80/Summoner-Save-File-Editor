using System;
using System.Windows.Forms;

namespace SummonerSaveFileEditor.Models
{
    public class InventoryItem
    {
        private int hash;
        private int quantity;
        private int type;
        private int charge;
        private int maxcharge;
        private string name;
        private string category;
        private bool identified;

        public int Type
        {
            get { return type; }
            set { type = value; }
        }
        
        public string Category
        {
            get { return category; }
            set { category = value; }
        }

        public int Charge
        {
            get { return charge; }
            set { charge = value; }
        }

        public int MaxCharge
        {
            get { return maxcharge; }
            set { maxcharge = value; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public int Hash
        {
            get { return hash; }
            set { hash = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public bool IdentifiedBit
        {
            get { return identified; }
            set { identified = value; }
        }

        public InventoryItem()
        {
            charge = 0;
            quantity = 1;
        }

        public void Init(string name, int hash, int quantity, int charge)
        {
            this.name = name;
            this.hash = hash;
            this.quantity = quantity;
            this.charge = charge;
        }

        public override string ToString()
        {
            return name;
        }

        public ListViewItem GetInventoryListViewItem()
        {
            //string identified = this.identified ? "Identified" : "Unidentified";
            string[] strLvItem = { name, quantity.ToString(), charge.ToString()/*, identified*/ };
            ListViewItem listViewItem = new(strLvItem);
            return listViewItem;
        }
        public ListViewItem GetGameItemsListViewItem()
        {
            string identified = !this.identified ? "Identified" : "Unidentified";
            string[] strLvItem = { name, identified };
            ListViewItem listViewItem = new(strLvItem);
            return listViewItem;
        }
    }
}
