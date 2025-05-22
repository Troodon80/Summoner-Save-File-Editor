
using System.ComponentModel;
using SummonerSaveFileEditor.Models;

namespace SummonerSaveFileEditor.ViewModels
{
    public class InventoryItemViewModel : INotifyPropertyChanged
    {
        private readonly InventoryItem _item;

        public InventoryItemViewModel(InventoryItem item) => _item = item;

        public string Name => _item.Name;
        public int Hash => _item.Hash;
        public int Quantity
        {
            get => _item.Quantity;
            set
            {
                if (_item.Quantity != value)
                {
                    _item.Quantity = value;
                    OnPropertyChanged(nameof(Quantity));
                }
            }
        }

        public int Charge
        {
            get => _item.Charge;
            set
            {
                if (_item.Charge != value)
                {
                    _item.Charge = value;
                    OnPropertyChanged(nameof(Charge));
                }
            }
        }

        public bool IdentifiedBit
        {
            get => _item.IdentifiedBit;
            set
            {
                if (_item.IdentifiedBit != value)
                {
                    _item.IdentifiedBit = value;
                    OnPropertyChanged(nameof(IdentifiedBit));
                }
            }
        }

        public InventoryItem Model => _item;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public ListViewItem GetGameItemListViewItem()
        {
            return new ListViewItem(new[]
            {
                Name,
                !IdentifiedBit ? "Identified" : "Unidentified"
            })
            { Tag = this };
        }

        public ListViewItem GetInventoryListViewItem()
        {
            return new ListViewItem(new[]
            {
                Name,
                Quantity.ToString(),
                Charge.ToString()
            })
            { Tag = this };
        }
    }
}
