using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using SummonerSaveFileEditor.Models;

namespace SummonerSaveFileEditor.ViewModels
{
    public class CharacterViewModel : INotifyPropertyChanged
    {
        private Character _character;
        private ObservableCollection<Skill> _skills;

        public Character ToCharacter() => _character;

        public CharacterViewModel(Character character)
        {
            _character = character;

            // Set up the skills collection and wire change notifications
            _skills = new ObservableCollection<Skill>(character.CharacterBlock.SkillList ?? new());
            _skills.CollectionChanged += Skills_CollectionChanged;

            // Subscribe to property changes from the CharacterBlock
            _character.CharacterBlock.PropertyChanged += CharacterBlock_PropertyChanged;

            // Setup skill value change handlers
            foreach (var skill in _skills)
            {
                if (skill is INotifyPropertyChanged notifySkill)
                {
                    notifySkill.PropertyChanged += Skill_PropertyChanged;
                }
            }
        }

        private void Skills_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            // Handle items added to the collection
            if (e.NewItems != null)
            {
                foreach (var item in e.NewItems)
                {
                    if (item is INotifyPropertyChanged notifySkill)
                    {
                        notifySkill.PropertyChanged += Skill_PropertyChanged;
                    }
                }
            }

            // Handle items removed from the collection
            if (e.OldItems != null)
            {
                foreach (var item in e.OldItems)
                {
                    if (item is INotifyPropertyChanged notifySkill)
                    {
                        notifySkill.PropertyChanged -= Skill_PropertyChanged;
                    }
                }
            }

            // Update the CharacterBlock's SkillList
            _character.CharacterBlock.SkillList = new List<Skill>(_skills);
        }

        private void Skill_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Skill.Value) && sender is Skill)
            {
                // When a skill value changes, update the byte values
                _character.CharacterBlock.UpdateSkillBytes();
            }
        }

        private void CharacterBlock_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            // Propagate property changes from the CharacterBlock
            switch (e.PropertyName)
            {
                case nameof(CharacterBlock.wCharacterLevel):
                    OnPropertyChanged(nameof(Level));
                    break;
                case nameof(CharacterBlock.dwCharacterExp):
                    OnPropertyChanged(nameof(Experience));
                    break;
                case nameof(CharacterBlock.wSkillPoints):
                    OnPropertyChanged(nameof(SkillPoints));
                    break;
                case nameof(CharacterBlock.fCurrentHP):
                    OnPropertyChanged(nameof(CurrentHP));
                    break;
                case nameof(CharacterBlock.fBaseHP):
                    OnPropertyChanged(nameof(BaseHP));
                    break;
                case nameof(CharacterBlock.wCurrentAP):
                    OnPropertyChanged(nameof(CurrentAP));
                    break;
                case nameof(CharacterBlock.wBaseAP):
                    OnPropertyChanged(nameof(BaseAP));
                    break;
                case nameof(CharacterBlock.chCharacterSpeed):
                    OnPropertyChanged(nameof(Speed));
                    break;
                    // You can add more cases for other properties as needed
            }
        }

        public uint Hash => _character.Header.creatureId;

        public short Level
        {
            get => _character.CharacterBlock.wCharacterLevel;
            set
            {
                if (_character.CharacterBlock.wCharacterLevel != value)
                {
                    _character.CharacterBlock.wCharacterLevel = value;
                    OnPropertyChanged();
                }
            }
        }

        public int Experience
        {
            get => _character.CharacterBlock.dwCharacterExp;
            set
            {
                if (_character.CharacterBlock.dwCharacterExp != value)
                {
                    _character.CharacterBlock.dwCharacterExp = value;
                    OnPropertyChanged();
                }
            }
        }

        public int SkillPoints
        {
            get => _character.CharacterBlock.wSkillPoints;
            set
            {
                if (_character.CharacterBlock.wSkillPoints != value)
                {
                    _character.CharacterBlock.wSkillPoints = value;
                    OnPropertyChanged();
                }
            }
        }

        public float CurrentHP
        {
            get => _character.CharacterBlock.fCurrentHP;
            set
            {
                if (_character.CharacterBlock.fCurrentHP != value)
                {
                    _character.CharacterBlock.fCurrentHP = value;
                    OnPropertyChanged();
                }
            }
        }

        public float BaseHP
        {
            get => _character.CharacterBlock.fBaseHP;
            set
            {
                if (_character.CharacterBlock.fBaseHP != value)
                {
                    _character.CharacterBlock.fBaseHP = value;
                    OnPropertyChanged();
                }
            }
        }

        public short CurrentAP
        {
            get => _character.CharacterBlock.wCurrentAP;
            set
            {
                if (_character.CharacterBlock.wCurrentAP != value)
                {
                    _character.CharacterBlock.wCurrentAP = value;
                    OnPropertyChanged();
                }
            }
        }

        public short BaseAP
        {
            get => _character.CharacterBlock.wBaseAP;
            set
            {
                if (_character.CharacterBlock.wBaseAP != value)
                {
                    _character.CharacterBlock.wBaseAP = value;
                    OnPropertyChanged();
                }
            }
        }

        public byte Speed
        {
            get => _character.CharacterBlock.chCharacterSpeed;
            set
            {
                if (_character.CharacterBlock.chCharacterSpeed != value)
                {
                    _character.CharacterBlock.chCharacterSpeed = value;
                    OnPropertyChanged();
                }
            }
        }

        public int AmuletId
        {
            get => _character.CharacterBlock.equippedItems.iAmulet;
            set
            {
                if (_character.CharacterBlock.equippedItems.iAmulet != value)
                {
                    var items = _character.CharacterBlock.equippedItems;
                    items.iAmulet = value;
                    _character.CharacterBlock.equippedItems = items;
                    OnPropertyChanged();
                }
            }
        }

        public int Ring1Id
        {
            get => _character.CharacterBlock.equippedItems.iRing1;
            set
            {
                if (_character.CharacterBlock.equippedItems.iRing1 != value)
                {
                    var items = _character.CharacterBlock.equippedItems;
                    items.iRing1 = value;
                    _character.CharacterBlock.equippedItems = items;
                    OnPropertyChanged();
                }
            }
        }

        public int Ring2Id
        {
            get => _character.CharacterBlock.equippedItems.iRing2;
            set
            {
                if (_character.CharacterBlock.equippedItems.iRing2 != value)
                {
                    var items = _character.CharacterBlock.equippedItems;
                    items.iRing2 = value;
                    _character.CharacterBlock.equippedItems = items;
                    OnPropertyChanged();
                }
            }
        }

        public int GauntletsId
        {
            get => _character.CharacterBlock.equippedItems.iGauntlets;
            set
            {
                if (_character.CharacterBlock.equippedItems.iGauntlets != value)
                {
                    var items = _character.CharacterBlock.equippedItems;
                    items.iGauntlets = value;
                    _character.CharacterBlock.equippedItems = items;
                    OnPropertyChanged();
                }
            }
        }

        public int BootsId
        {
            get => _character.CharacterBlock.equippedItems.iBoots;
            set
            {
                if (_character.CharacterBlock.equippedItems.iBoots != value)
                {
                    var items = _character.CharacterBlock.equippedItems;
                    items.iBoots = value;
                    _character.CharacterBlock.equippedItems = items;
                    OnPropertyChanged();
                }
            }
        }

        public int WeaponId
        {
            get => _character.CharacterBlock.equippedItems.iWeapon;
            set
            {
                if (_character.CharacterBlock.equippedItems.iWeapon != value)
                {
                    var items = _character.CharacterBlock.equippedItems;
                    items.iWeapon = value;
                    _character.CharacterBlock.equippedItems = items;
                    OnPropertyChanged();
                }
            }
        }

        public int ShieldId
        {
            get => _character.CharacterBlock.equippedItems.iShield;
            set
            {
                if (_character.CharacterBlock.equippedItems.iShield != value)
                {
                    var items = _character.CharacterBlock.equippedItems;
                    items.iShield = value;
                    _character.CharacterBlock.equippedItems = items;
                    OnPropertyChanged();
                }
            }
        }

        public int TorsoId
        {
            get => _character.CharacterBlock.equippedItems.iTorso;
            set
            {
                if (_character.CharacterBlock.equippedItems.iTorso != value)
                {
                    var items = _character.CharacterBlock.equippedItems;
                    items.iTorso = value;
                    _character.CharacterBlock.equippedItems = items;
                    OnPropertyChanged();
                }
            }
        }

        public int LeggingsId
        {
            get => _character.CharacterBlock.equippedItems.iLeggings;
            set
            {
                if (_character.CharacterBlock.equippedItems.iLeggings != value)
                {
                    var items = _character.CharacterBlock.equippedItems;
                    items.iLeggings = value;
                    _character.CharacterBlock.equippedItems = items;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<Skill> Skills
        {
            get => _skills;
            set
            {
                if (_skills != value)
                {
                    if (_skills != null)
                    {
                        _skills.CollectionChanged -= Skills_CollectionChanged;
                    }

                    _skills = value;

                    if (_skills != null)
                    {
                        _skills.CollectionChanged += Skills_CollectionChanged;
                    }

                    OnPropertyChanged();
                }
            }
        }

        public Character Model => _character;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null) =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void NotifySkillChanged()
        {
            // This method can be simplified now since we have automatic two-way binding
            // But we'll keep it for compatibility with existing code
            _character.CharacterBlock.UpdateSkillBytes();
            OnPropertyChanged(nameof(Skills));
        }
    }
}