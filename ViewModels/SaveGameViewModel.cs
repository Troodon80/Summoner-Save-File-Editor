
using SummonerSaveFileEditor.Data;
using SummonerSaveFileEditor.Models;
using System.Collections.ObjectModel;

namespace SummonerSaveFileEditor.ViewModels
{
    public class SaveGameViewModel
    {
        public int SaveFileVersion { get; set; }
        public string AreaMain { get; set; } = "";
        public string AreaSub { get; set; } = "";
        public float GameTimeSeconds { get; set; }
        public string Description { get; set; } = "";
        public ImageThumbnail ImageThumbnail { get; set; }
        public byte[] PostThumbnailData { get; set; }
        public ObservableCollection<InventoryItemViewModel> Inventory { get; set; } = new();
        public Dictionary<AreaBlock, byte[]> AreaBlockData { get; set; } = new Dictionary<AreaBlock, byte[]>();
        public ObservableCollection<Creature> Creatures { get; set; } = new();
        public LevelEntityHeader LevelEntityHeader { get; set; }
        public CharacterViewModel Joseph { get; set; }
        public CharacterViewModel Flece { get; set; }
        public CharacterViewModel Rosalind { get; set; }
        public CharacterViewModel Jekhar { get; set; }
        public byte[] PostCreatureData { get; set; }
        public CameraViewModel Camera { get; set; }
        public List<Container> Containers { get; set; } = new List<Container>();

        public byte[] RemainingData { get; set; }
        //public byte[] ContSectionData { get; set; }
        public int Gold { get; set; }

        public void LoadFromModel(InventoryData inventoryData, CharacterData characterData, CameraBlock camera = null)
        {
            Inventory.Clear();
            foreach (var item in inventoryData.Items)
                Inventory.Add(new InventoryItemViewModel(item));

            foreach (var c in characterData.MainCharacters)
            {
                switch (c.Header.creatureId)
                {
                    case Constants.JOSEPH:
                        Joseph = new CharacterViewModel(c);
                        break;
                    case Constants.FLECE:
                        Flece = new CharacterViewModel(c);
                        break;
                    case Constants.ROSALIND:
                        Rosalind = new CharacterViewModel(c);
                        break;
                    case Constants.JEKHAR:
                        Jekhar = new CharacterViewModel(c);
                        break;
                }
            }

            Creatures.Clear();
            foreach (var c in characterData.OtherCreatures)
                Creatures.Add(c);

            if (camera != null)
                Camera = new CameraViewModel(camera);
        }
    }
}
