using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace SummonerSaveFileEditor.Models
{
    public struct IntTriple
    {
        public int A;
        public int B;
        public int C;
    }

    public class CharacterBlock : INotifyPropertyChanged
    {
        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Private backing fields
        private float _fPosX;
        private float _fPosZ;
        private float _fPosY;
        private float _fRotation;
        private IntTriple[] _triplets;
        private int _spareInt;
        private EquippedItems _equippedItems;
        private int[] _iUnmappedBlock;
        private uint _iNumEntries;

        // Skill backing fields
        private byte _chSkills_HandToHand;
        private byte _chUnknownCharacterSkill_1;
        private byte _chCharacterSpeed;
        private byte _chSkills_Sword;
        private byte _chSkills_Axe;
        private byte _chSkills_Blunt;
        private byte _chSkills_Staff;
        private byte _chSkills_Bow;
        private byte _chSkills_HeavyArms;
        private byte _chSkills_Parry;
        private byte _chSkills_CounterAttack;
        private byte _chSkills_Dodge;
        private byte _chSkills_CriticalHit;
        private byte _chSkills_DoubleAttack;
        private byte _chSkills_Push;
        private byte _chSkills_Kick;
        private byte _chSkills_Trip;
        private byte _chSkills_AimedAttack;
        private byte _chSkills_Backstab;
        private byte _chSkills_Assess;
        private byte _chSkills_Appraise;
        private byte _chSkills_Picklock;
        private byte _chSkills_Sneak;
        private byte _chSkills_Hide;
        private byte[] _chUnknownCharacterSkill_2;
        private byte _chSkills_Summon;
        private byte _chSkills_Heal;
        private byte _chSkills_Dark;
        private byte _chSkills_Energy;
        private byte _chSkills_Holy;
        private byte _chSkills_Fire;
        private byte _chSkills_Ice;
        private byte _chUnknownCharacterSkill_3;
        private byte _chSkills_MagicResist;

        // Character stats backing fields
        private short _wCharacterLevel;
        private int _dwCharacterExp;
        private float _fCurrentHP;
        private float _fBaseHP;
        private short _wCurrentAP;
        private short _wBaseAP;
        private int _unsure;
        private int _ai;
        private byte[] _chUnmappedCharacterItem;
        private int _wSkillPoints;

        // Properties with change notification
        public float fPosX
        {
            get => _fPosX;
            set { if (_fPosX != value) { _fPosX = value; OnPropertyChanged(); } }
        }

        public float fPosZ
        {
            get => _fPosZ;
            set { if (_fPosZ != value) { _fPosZ = value; OnPropertyChanged(); } }
        }

        public float fPosY
        {
            get => _fPosY;
            set { if (_fPosY != value) { _fPosY = value; OnPropertyChanged(); } }
        }

        public float fRotation
        {
            get => _fRotation;
            set { if (_fRotation != value) { _fRotation = value; OnPropertyChanged(); } }
        }

        public IntTriple[] Triplets
        {
            get => _triplets;
            set { if (_triplets != value) { _triplets = value; OnPropertyChanged(); } }
        }

        public int spareInt
        {
            get => _spareInt;
            set { if (_spareInt != value) { _spareInt = value; OnPropertyChanged(); } }
        }

        public EquippedItems equippedItems
        {
            get => _equippedItems;
            set { if (_equippedItems.Equals(value) == false) { _equippedItems = value; OnPropertyChanged(); } }
        }

        public int[] iUnmappedBlock
        {
            get => _iUnmappedBlock;
            set { if (_iUnmappedBlock != value) { _iUnmappedBlock = value; OnPropertyChanged(); } }
        }

        public uint iNumEntries
        {
            get => _iNumEntries;
            set { if (_iNumEntries != value) { _iNumEntries = value; OnPropertyChanged(); } }
        }

        // Skill properties with automatic SkillList updates
        public byte chSkills_HandToHand
        {
            get => _chSkills_HandToHand;
            set
            {
                if (_chSkills_HandToHand != value)
                {
                    _chSkills_HandToHand = value;
                    UpdateSkillInList(0, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chUnknownCharacterSkill_1
        {
            get => _chUnknownCharacterSkill_1;
            set { if (_chUnknownCharacterSkill_1 != value) { _chUnknownCharacterSkill_1 = value; OnPropertyChanged(); } }
        }

        public byte chCharacterSpeed
        {
            get => _chCharacterSpeed;
            set { if (_chCharacterSpeed != value) { _chCharacterSpeed = value; OnPropertyChanged(); } }
        }

        public byte chSkills_Sword
        {
            get => _chSkills_Sword;
            set
            {
                if (_chSkills_Sword != value)
                {
                    _chSkills_Sword = value;
                    UpdateSkillInList(1, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Axe
        {
            get => _chSkills_Axe;
            set
            {
                if (_chSkills_Axe != value)
                {
                    _chSkills_Axe = value;
                    UpdateSkillInList(2, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Blunt
        {
            get => _chSkills_Blunt;
            set
            {
                if (_chSkills_Blunt != value)
                {
                    _chSkills_Blunt = value;
                    UpdateSkillInList(3, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Staff
        {
            get => _chSkills_Staff;
            set
            {
                if (_chSkills_Staff != value)
                {
                    _chSkills_Staff = value;
                    UpdateSkillInList(4, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Bow
        {
            get => _chSkills_Bow;
            set
            {
                if (_chSkills_Bow != value)
                {
                    _chSkills_Bow = value;
                    UpdateSkillInList(5, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_HeavyArms
        {
            get => _chSkills_HeavyArms;
            set
            {
                if (_chSkills_HeavyArms != value)
                {
                    _chSkills_HeavyArms = value;
                    UpdateSkillInList(6, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Parry
        {
            get => _chSkills_Parry;
            set
            {
                if (_chSkills_Parry != value)
                {
                    _chSkills_Parry = value;
                    UpdateSkillInList(7, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_CounterAttack
        {
            get => _chSkills_CounterAttack;
            set
            {
                if (_chSkills_CounterAttack != value)
                {
                    _chSkills_CounterAttack = value;
                    UpdateSkillInList(8, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Dodge
        {
            get => _chSkills_Dodge;
            set
            {
                if (_chSkills_Dodge != value)
                {
                    _chSkills_Dodge = value;
                    UpdateSkillInList(9, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_CriticalHit
        {
            get => _chSkills_CriticalHit;
            set
            {
                if (_chSkills_CriticalHit != value)
                {
                    _chSkills_CriticalHit = value;
                    UpdateSkillInList(10, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_DoubleAttack
        {
            get => _chSkills_DoubleAttack;
            set
            {
                if (_chSkills_DoubleAttack != value)
                {
                    _chSkills_DoubleAttack = value;
                    UpdateSkillInList(11, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Push
        {
            get => _chSkills_Push;
            set
            {
                if (_chSkills_Push != value)
                {
                    _chSkills_Push = value;
                    UpdateSkillInList(12, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Kick
        {
            get => _chSkills_Kick;
            set
            {
                if (_chSkills_Kick != value)
                {
                    _chSkills_Kick = value;
                    UpdateSkillInList(13, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Trip
        {
            get => _chSkills_Trip;
            set
            {
                if (_chSkills_Trip != value)
                {
                    _chSkills_Trip = value;
                    UpdateSkillInList(14, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_AimedAttack
        {
            get => _chSkills_AimedAttack;
            set
            {
                if (_chSkills_AimedAttack != value)
                {
                    _chSkills_AimedAttack = value;
                    UpdateSkillInList(15, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Backstab
        {
            get => _chSkills_Backstab;
            set
            {
                if (_chSkills_Backstab != value)
                {
                    _chSkills_Backstab = value;
                    UpdateSkillInList(16, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Assess
        {
            get => _chSkills_Assess;
            set
            {
                if (_chSkills_Assess != value)
                {
                    _chSkills_Assess = value;
                    UpdateSkillInList(17, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Appraise
        {
            get => _chSkills_Appraise;
            set
            {
                if (_chSkills_Appraise != value)
                {
                    _chSkills_Appraise = value;
                    UpdateSkillInList(18, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Picklock
        {
            get => _chSkills_Picklock;
            set
            {
                if (_chSkills_Picklock != value)
                {
                    _chSkills_Picklock = value;
                    UpdateSkillInList(19, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Sneak
        {
            get => _chSkills_Sneak;
            set
            {
                if (_chSkills_Sneak != value)
                {
                    _chSkills_Sneak = value;
                    UpdateSkillInList(20, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Hide
        {
            get => _chSkills_Hide;
            set
            {
                if (_chSkills_Hide != value)
                {
                    _chSkills_Hide = value;
                    UpdateSkillInList(21, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte[] chUnknownCharacterSkill_2
        {
            get => _chUnknownCharacterSkill_2;
            set { if (_chUnknownCharacterSkill_2 != value) { _chUnknownCharacterSkill_2 = value; OnPropertyChanged(); } }
        }

        public byte chSkills_Summon
        {
            get => _chSkills_Summon;
            set
            {
                if (_chSkills_Summon != value)
                {
                    _chSkills_Summon = value;
                    UpdateSkillInList(22, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Heal
        {
            get => _chSkills_Heal;
            set
            {
                if (_chSkills_Heal != value)
                {
                    _chSkills_Heal = value;
                    UpdateSkillInList(23, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Dark
        {
            get => _chSkills_Dark;
            set
            {
                if (_chSkills_Dark != value)
                {
                    _chSkills_Dark = value;
                    UpdateSkillInList(24, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Energy
        {
            get => _chSkills_Energy;
            set
            {
                if (_chSkills_Energy != value)
                {
                    _chSkills_Energy = value;
                    UpdateSkillInList(25, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Holy
        {
            get => _chSkills_Holy;
            set
            {
                if (_chSkills_Holy != value)
                {
                    _chSkills_Holy = value;
                    UpdateSkillInList(26, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Fire
        {
            get => _chSkills_Fire;
            set
            {
                if (_chSkills_Fire != value)
                {
                    _chSkills_Fire = value;
                    UpdateSkillInList(27, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chSkills_Ice
        {
            get => _chSkills_Ice;
            set
            {
                if (_chSkills_Ice != value)
                {
                    _chSkills_Ice = value;
                    UpdateSkillInList(28, value);
                    OnPropertyChanged();
                }
            }
        }

        public byte chUnknownCharacterSkill_3
        {
            get => _chUnknownCharacterSkill_3;
            set { if (_chUnknownCharacterSkill_3 != value) { _chUnknownCharacterSkill_3 = value; OnPropertyChanged(); } }
        }

        public byte chSkills_MagicResist
        {
            get => _chSkills_MagicResist;
            set
            {
                if (_chSkills_MagicResist != value)
                {
                    _chSkills_MagicResist = value;
                    UpdateSkillInList(29, value);
                    OnPropertyChanged();
                }
            }
        }

        // Character stat properties
        public short wCharacterLevel
        {
            get => _wCharacterLevel;
            set { if (_wCharacterLevel != value) { _wCharacterLevel = value; OnPropertyChanged(); } }
        }

        public int dwCharacterExp
        {
            get => _dwCharacterExp;
            set { if (_dwCharacterExp != value) { _dwCharacterExp = value; OnPropertyChanged(); } }
        }

        public float fCurrentHP
        {
            get => _fCurrentHP;
            set { if (_fCurrentHP != value) { _fCurrentHP = value; OnPropertyChanged(); } }
        }

        public float fBaseHP
        {
            get => _fBaseHP;
            set { if (_fBaseHP != value) { _fBaseHP = value; OnPropertyChanged(); } }
        }

        public short wCurrentAP
        {
            get => _wCurrentAP;
            set { if (_wCurrentAP != value) { _wCurrentAP = value; OnPropertyChanged(); } }
        }

        public short wBaseAP
        {
            get => _wBaseAP;
            set { if (_wBaseAP != value) { _wBaseAP = value; OnPropertyChanged(); } }
        }

        public int unsure
        {
            get => _unsure;
            set { if (_unsure != value) { _unsure = value; OnPropertyChanged(); } }
        }

        public int AI
        {
            get => _ai;
            set { if (_ai != value) { _ai = value; OnPropertyChanged(); } }
        }

        public byte[] chUnmappedCharacterItem
        {
            get => _chUnmappedCharacterItem;
            set { if (_chUnmappedCharacterItem != value) { _chUnmappedCharacterItem = value; OnPropertyChanged(); } }
        }

        public int wSkillPoints
        {
            get => _wSkillPoints;
            set { if (_wSkillPoints != value) { _wSkillPoints = value; OnPropertyChanged(); } }
        }

        // SkillList property with change notification
        private List<Skill> _skillList = new();
        public List<Skill> SkillList
        {
            get => _skillList;
            set
            {
                if (_skillList != value)
                {
                    _skillList = value;
                    OnPropertyChanged();
                }
            }
        }

        // Default constructor
        public CharacterBlock() : this(null) { }

        // Constructor using binary reader
        public CharacterBlock(BinaryReader reader)
        {
            // Initialize collections
            _triplets = new IntTriple[7];
            _iUnmappedBlock = new int[36];
            _chUnknownCharacterSkill_2 = new byte[3];
            _chUnmappedCharacterItem = new byte[34];
            _skillList = new List<Skill>();

            if (reader == null) return;  // Early return for default constructor

            // Read position values
            _fPosX = reader.ReadSingle();
            _fPosZ = reader.ReadSingle();
            _fPosY = reader.ReadSingle();
            _fRotation = reader.ReadSingle();

            // Read triplets
            for (int i = 0; i < 7; i++)
            {
                _triplets[i].A = reader.ReadInt32();
                _triplets[i].B = reader.ReadInt32();
                _triplets[i].C = reader.ReadInt32();
            }

            // Read spare int
            _spareInt = reader.ReadInt32();

            // Read equipped items
            _equippedItems = new EquippedItems(reader);

            // Read unmapped block
            Buffer.BlockCopy(reader.ReadBytes(4 * 36), 0, _iUnmappedBlock, 0, 4 * 36);

            // Read skills
            _chSkills_HandToHand = reader.ReadByte();
            _chUnknownCharacterSkill_1 = reader.ReadByte();
            _chCharacterSpeed = reader.ReadByte();
            _chSkills_Sword = reader.ReadByte();
            _chSkills_Axe = reader.ReadByte();
            _chSkills_Blunt = reader.ReadByte();
            _chSkills_Staff = reader.ReadByte();
            _chSkills_Bow = reader.ReadByte();
            _chSkills_HeavyArms = reader.ReadByte();
            _chSkills_Parry = reader.ReadByte();
            _chSkills_CounterAttack = reader.ReadByte();
            _chSkills_Dodge = reader.ReadByte();
            _chSkills_CriticalHit = reader.ReadByte();
            _chSkills_DoubleAttack = reader.ReadByte();
            _chSkills_Push = reader.ReadByte();
            _chSkills_Kick = reader.ReadByte();
            _chSkills_Trip = reader.ReadByte();
            _chSkills_AimedAttack = reader.ReadByte();
            _chSkills_Backstab = reader.ReadByte();
            _chSkills_Assess = reader.ReadByte();
            _chSkills_Appraise = reader.ReadByte();
            _chSkills_Picklock = reader.ReadByte();
            _chSkills_Sneak = reader.ReadByte();
            _chSkills_Hide = reader.ReadByte();
            Buffer.BlockCopy(reader.ReadBytes(3), 0, _chUnknownCharacterSkill_2, 0, 3);
            _chSkills_Summon = reader.ReadByte();
            _chSkills_Heal = reader.ReadByte();
            _chSkills_Dark = reader.ReadByte();
            _chSkills_Energy = reader.ReadByte();
            _chSkills_Holy = reader.ReadByte();
            _chSkills_Fire = reader.ReadByte();
            _chSkills_Ice = reader.ReadByte();
            _chUnknownCharacterSkill_3 = reader.ReadByte();
            _chSkills_MagicResist = reader.ReadByte();

            // Read character stats
            _wCharacterLevel = reader.ReadInt16();
            _dwCharacterExp = reader.ReadInt32();
            _fCurrentHP = reader.ReadSingle();
            _fBaseHP = reader.ReadSingle();
            _wCurrentAP = reader.ReadInt16();
            _wBaseAP = reader.ReadInt16();
            _unsure = reader.ReadInt32();
            _ai = reader.ReadInt32();
            Buffer.BlockCopy(reader.ReadBytes(34), 0, _chUnmappedCharacterItem, 0, 34);
            _wSkillPoints = reader.ReadInt32();
        }

        // Helper method to update a skill in the list when a byte value changes
        private void UpdateSkillInList(int index, byte value)
        {
            if (_skillList != null && index < _skillList.Count)
            {
                _skillList[index].Value = value * 10;
            }
        }

        // Method to populate skill list from byte values
        public void PopulateSkillList()
        {
            SkillList = new List<Skill> {
                new("Hand to Hand", _chSkills_HandToHand),
                new("Sword", _chSkills_Sword),
                new("Axe", _chSkills_Axe),
                new("Blunt", _chSkills_Blunt),
                new("Staff", _chSkills_Staff),
                new("Bow", _chSkills_Bow),
                new("Heavy Arms", _chSkills_HeavyArms),
                new("Parry", _chSkills_Parry),
                new("Counter Attack", _chSkills_CounterAttack),
                new("Dodge", _chSkills_Dodge),
                new("Critical Hit", _chSkills_CriticalHit),
                new("Double Attack", _chSkills_DoubleAttack),
                new("Push", _chSkills_Push),
                new("Kick", _chSkills_Kick),
                new("Trip", _chSkills_Trip),
                new("Aimed Attack", _chSkills_AimedAttack),
                new("Backstab", _chSkills_Backstab),
                new("Assess", _chSkills_Assess),
                new("Appraise", _chSkills_Appraise),
                new("Picklock", _chSkills_Picklock),
                new("Sneak", _chSkills_Sneak),
                new("Hide", _chSkills_Hide),
                new("Summon", _chSkills_Summon),
                new("Heal", _chSkills_Heal),
                new("Dark", _chSkills_Dark),
                new("Energy", _chSkills_Energy),
                new("Holy", _chSkills_Holy),
                new("Fire", _chSkills_Fire),
                new("Ice", _chSkills_Ice),
                new("Magic Resist", _chSkills_MagicResist)
            };
        }

        // Method to update byte fields from skill list
        public void UpdateSkillBytes()
        {
            if (SkillList == null || SkillList.Count < 30)
                return;

            // Temporarily disable property change notifications to avoid multiple events
            bool raiseEvents = SuspendPropertyChangedNotifications();

            // Update byte fields from skill list
            _chSkills_HandToHand = (byte)(SkillList[0].Value );
            _chSkills_Sword = (byte)(SkillList[1].Value);
            _chSkills_Axe = (byte)(SkillList[2].Value);
            _chSkills_Blunt = (byte)(SkillList[3].Value);
            _chSkills_Staff = (byte)(SkillList[4].Value);
            _chSkills_Bow = (byte)(SkillList[5].Value);
            _chSkills_HeavyArms = (byte)(SkillList[6].Value);
            _chSkills_Parry = (byte)(SkillList[7].Value);
            _chSkills_CounterAttack = (byte)(SkillList[8].Value);
            _chSkills_Dodge = (byte)(SkillList[9].Value);
            _chSkills_CriticalHit = (byte)(SkillList[10].Value);
            _chSkills_DoubleAttack = (byte)(SkillList[11].Value);
            _chSkills_Push = (byte)(SkillList[12].Value);
            _chSkills_Kick = (byte)(SkillList[13].Value);
            _chSkills_Trip = (byte)(SkillList[14].Value);
            _chSkills_AimedAttack = (byte)(SkillList[15].Value);
            _chSkills_Backstab = (byte)(SkillList[16].Value);
            _chSkills_Assess = (byte)(SkillList[17].Value);
            _chSkills_Appraise = (byte)(SkillList[18].Value);
            _chSkills_Picklock = (byte)(SkillList[19].Value);
            _chSkills_Sneak = (byte)(SkillList[20].Value);
            _chSkills_Hide = (byte)(SkillList[21].Value);
            _chSkills_Summon = (byte)(SkillList[22].Value);
            _chSkills_Heal = (byte)(SkillList[23].Value);
            _chSkills_Dark = (byte)(SkillList[24].Value);
            _chSkills_Energy = (byte)(SkillList[25].Value);
            _chSkills_Holy = (byte)(SkillList[26].Value);
            _chSkills_Fire = (byte)(SkillList[27].Value);
            _chSkills_Ice = (byte)(SkillList[28].Value);
            _chSkills_MagicResist = (byte)(SkillList[29].Value);

            // Resume property change notifications
            if (raiseEvents)
                ResumePropertyChangedNotifications();
        }

        // Write method remains similar but uses properties
        public void Write(BinaryWriter writer)
        {
            writer.Write(fPosX);
            writer.Write(fPosZ);
            writer.Write(fPosY);
            writer.Write(fRotation);

            for (int i = 0; i < 7; i++)
            {
                writer.Write(Triplets[i].A);
                writer.Write(Triplets[i].B);
                writer.Write(Triplets[i].C);
            }
            writer.Write(spareInt);

            equippedItems.Write(writer);

            foreach (int value in iUnmappedBlock)
            {
                writer.Write(value);
            }

            // Start Skills
            writer.Write(chSkills_HandToHand);
            writer.Write(chUnknownCharacterSkill_1);
            writer.Write(chCharacterSpeed);
            writer.Write(chSkills_Sword);
            writer.Write(chSkills_Axe);
            writer.Write(chSkills_Blunt);
            writer.Write(chSkills_Staff);
            writer.Write(chSkills_Bow);
            writer.Write(chSkills_HeavyArms);
            writer.Write(chSkills_Parry);
            writer.Write(chSkills_CounterAttack);
            writer.Write(chSkills_Dodge);
            writer.Write(chSkills_CriticalHit);
            writer.Write(chSkills_DoubleAttack);
            writer.Write(chSkills_Push);
            writer.Write(chSkills_Kick);
            writer.Write(chSkills_Trip);
            writer.Write(chSkills_AimedAttack);
            writer.Write(chSkills_Backstab);
            writer.Write(chSkills_Assess);
            writer.Write(chSkills_Appraise);
            writer.Write(chSkills_Picklock);
            writer.Write(chSkills_Sneak);
            writer.Write(chSkills_Hide);
            writer.Write(chUnknownCharacterSkill_2[0]);
            writer.Write(chUnknownCharacterSkill_2[1]);
            writer.Write(chUnknownCharacterSkill_2[2]);
            writer.Write(chSkills_Summon);
            writer.Write(chSkills_Heal);
            writer.Write(chSkills_Dark);
            writer.Write(chSkills_Energy);
            writer.Write(chSkills_Holy);
            writer.Write(chSkills_Fire);
            writer.Write(chSkills_Ice);
            writer.Write(chUnknownCharacterSkill_3);
            writer.Write(chSkills_MagicResist);

            // End of Skills
            writer.Write(wCharacterLevel);
            writer.Write(dwCharacterExp);
            writer.Write(fCurrentHP);
            writer.Write(fBaseHP);
            writer.Write(wCurrentAP);
            writer.Write(wBaseAP);
            writer.Write(unsure);
            writer.Write(AI);

            foreach (byte value in chUnmappedCharacterItem)
            {
                writer.Write(value);
            }

            writer.Write(wSkillPoints);
        }

        // Helper methods for property change notification batching
        private bool _notificationsEnabled = true;

        private bool SuspendPropertyChangedNotifications()
        {
            bool oldValue = _notificationsEnabled;
            _notificationsEnabled = false;
            return oldValue;
        }

        private void ResumePropertyChangedNotifications()
        {
            _notificationsEnabled = true;
            OnPropertyChanged(string.Empty); // Trigger update of all bindings
        }
    }
}