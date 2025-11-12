using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace SummonerSaveFileEditor.Models
{
    public class EntityBlock : INotifyPropertyChanged
    {
        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (_notificationsEnabled)
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Entity type - comes from the CreatureHeader
        private int _creatureType;
        public int CreatureType
        {
            get => _creatureType;
            set { if (_creatureType != value) { _creatureType = value; OnPropertyChanged(); } }
        }

        // Helper property to determine if this is a character
        public bool IsCharacter => _creatureType == 7;

        // Common fields for both entity types
        private float _fPosX;
        private float _fPosZ;
        private float _fPosY;
        private float _fRotation;
        private int _iUnknownInt1;
        private int _iUnknownInt2;
        private int _iStateFlags;
        private UnknownSeptet[] _unknownSeptet;
        private int[] _iUnmappedBlock;

        // Character-specific fields
        private EquippedItems _equippedItems;
        private uint _iNumEntries;
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
        private short _wCharacterLevel;
        private int _dwCharacterExp;
        private byte[] _chUnmappedCharacterItem;
        private int _wSkillPoints;
        private List<Skill> _skillList = new List<Skill>();

        // Stats found in both entity types but at different offsets
        private float _fCurrentHP;
        private float _fBaseHP;
        private short _wCurrentAP;
        private short _wBaseAP;
        private int _unsure;
        private int _ai;

        // Creature-specific fields
        private short _wCreatureLevel;
        private int[] _memoryBlock;
        private int[] _memoryBlockFormatted;
        private short _wUnknown_End;

        // Common properties
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

        public int iUnknownInt1
        {
            get => _iUnknownInt1;
            set { if (_iUnknownInt1 != value) { _iUnknownInt1 = value; OnPropertyChanged(); } }
        }

        public int iUnknownInt2
        {
            get => _iUnknownInt2;
            set { if (_iUnknownInt2 != value) { _iUnknownInt2 = value; OnPropertyChanged(); } }
        }

        public int iStateFlags
        {
            get => _iStateFlags;
            set { if (_iStateFlags != value) { _iStateFlags = value; OnPropertyChanged(); } }
        }

        public bool bIsDead
        {
            get => (_iStateFlags & 0x4000000) != 0; // Bit 26 indicates death
            set
            {
                if (value != bIsDead)
                {
                    if (value) _iStateFlags |= 0x4000000; // Set bit 26
                    else _iStateFlags &= ~0x4000000; // Clear bit 26
                    OnPropertyChanged();
                }
            }
        }

        public UnknownSeptet[] UnknownSextets
        {
            get => _unknownSeptet;
            set { if (_unknownSeptet != value) { _unknownSeptet = value; OnPropertyChanged(); } }
        }

        public int[] iUnmappedBlock
        {
            get => _iUnmappedBlock;
            set { if (_iUnmappedBlock != value) { _iUnmappedBlock = value; OnPropertyChanged(); } }
        }

        // Common stats properties
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

        // Level property that works for both types
        public short Level
        {
            get => IsCharacter ? _wCharacterLevel : _wCreatureLevel;
            set
            {
                if (IsCharacter)
                {
                    if (_wCharacterLevel != value)
                    {
                        _wCharacterLevel = value;
                        OnPropertyChanged();
                    }
                }
                else
                {
                    if (_wCreatureLevel != value)
                    {
                        _wCreatureLevel = value;
                        OnPropertyChanged();
                    }
                }
            }
        }

        // Character-specific properties
        public EquippedItems equippedItems
        {
            get => _equippedItems;
            set
            {
                if (IsCharacter && (!_equippedItems.Equals(value)))
                {
                    _equippedItems = value;
                    OnPropertyChanged();
                }
            }
        }

        public uint iNumEntries
        {
            get => _iNumEntries;
            set { if (IsCharacter && _iNumEntries != value) { _iNumEntries = value; OnPropertyChanged(); } }
        }

        public byte chSkills_HandToHand
        {
            get => _chSkills_HandToHand;
            set
            {
                if (IsCharacter && _chSkills_HandToHand != value)
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
            set { if (IsCharacter && _chUnknownCharacterSkill_1 != value) { _chUnknownCharacterSkill_1 = value; OnPropertyChanged(); } }
        }

        public byte chCharacterSpeed
        {
            get => _chCharacterSpeed;
            set { if (IsCharacter && _chCharacterSpeed != value) { _chCharacterSpeed = value; OnPropertyChanged(); } }
        }

        public byte chSkills_Sword
        {
            get => _chSkills_Sword;
            set
            {
                if (IsCharacter && _chSkills_Sword != value)
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
                if (IsCharacter && _chSkills_Axe != value)
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
                if (IsCharacter && _chSkills_Blunt != value)
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
                if (IsCharacter && _chSkills_Staff != value)
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
                if (IsCharacter && _chSkills_Bow != value)
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
                if (IsCharacter && _chSkills_HeavyArms != value)
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
                if (IsCharacter && _chSkills_Parry != value)
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
                if (IsCharacter && _chSkills_CounterAttack != value)
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
                if (IsCharacter && _chSkills_Dodge != value)
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
                if (IsCharacter && _chSkills_CriticalHit != value)
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
                if (IsCharacter && _chSkills_DoubleAttack != value)
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
                if (IsCharacter && _chSkills_Push != value)
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
                if (IsCharacter && _chSkills_Kick != value)
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
                if (IsCharacter && _chSkills_Trip != value)
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
                if (IsCharacter && _chSkills_AimedAttack != value)
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
                if (IsCharacter && _chSkills_Backstab != value)
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
                if (IsCharacter && _chSkills_Assess != value)
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
                if (IsCharacter && _chSkills_Appraise != value)
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
                if (IsCharacter && _chSkills_Picklock != value)
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
                if (IsCharacter && _chSkills_Sneak != value)
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
                if (IsCharacter && _chSkills_Hide != value)
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
            set { if (IsCharacter && _chUnknownCharacterSkill_2 != value) { _chUnknownCharacterSkill_2 = value; OnPropertyChanged(); } }
        }

        public byte chSkills_Summon
        {
            get => _chSkills_Summon;
            set
            {
                if (IsCharacter && _chSkills_Summon != value)
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
                if (IsCharacter && _chSkills_Heal != value)
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
                if (IsCharacter && _chSkills_Dark != value)
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
                if (IsCharacter && _chSkills_Energy != value)
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
                if (IsCharacter && _chSkills_Holy != value)
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
                if (IsCharacter && _chSkills_Fire != value)
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
                if (IsCharacter && _chSkills_Ice != value)
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
            set { if (IsCharacter && _chUnknownCharacterSkill_3 != value) { _chUnknownCharacterSkill_3 = value; OnPropertyChanged(); } }
        }

        public byte chSkills_MagicResist
        {
            get => _chSkills_MagicResist;
            set
            {
                if (IsCharacter && _chSkills_MagicResist != value)
                {
                    _chSkills_MagicResist = value;
                    UpdateSkillInList(29, value);
                    OnPropertyChanged();
                }
            }
        }

        // Character-specific stats
        public short wCharacterLevel
        {
            get => _wCharacterLevel;
            set { if (IsCharacter && _wCharacterLevel != value) { _wCharacterLevel = value; OnPropertyChanged(); } }
        }

        public int dwCharacterExp
        {
            get => _dwCharacterExp;
            set { if (IsCharacter && _dwCharacterExp != value) { _dwCharacterExp = value; OnPropertyChanged(); } }
        }

        public byte[] chUnmappedCharacterItem
        {
            get => _chUnmappedCharacterItem;
            set { if (IsCharacter && _chUnmappedCharacterItem != value) { _chUnmappedCharacterItem = value; OnPropertyChanged(); } }
        }

        public int wSkillPoints
        {
            get => _wSkillPoints;
            set { if (IsCharacter && _wSkillPoints != value) { _wSkillPoints = value; OnPropertyChanged(); } }
        }

        public List<Skill> SkillList
        {
            get => _skillList;
            set
            {
                if (IsCharacter && _skillList != value)
                {
                    _skillList = value;
                    OnPropertyChanged();
                }
            }
        }

        // Creature-specific properties
        public short wCreatureLevel
        {
            get => _wCreatureLevel;
            set { if (!IsCharacter && _wCreatureLevel != value) { _wCreatureLevel = value; OnPropertyChanged(); } }
        }

        public int[] MemoryBlock
        {
            get => _memoryBlock;
            set { if (!IsCharacter && _memoryBlock != value) { _memoryBlock = value; OnPropertyChanged(); } }
        }

        public int[] MemoryBlockFormatted
        {
            get => _memoryBlockFormatted;
            set { if (!IsCharacter && _memoryBlockFormatted != value) { _memoryBlockFormatted = value; OnPropertyChanged(); } }
        }

        public short wUnknown_End
        {
            get => _wUnknown_End;
            set { if (!IsCharacter && _wUnknown_End != value) { _wUnknown_End = value; OnPropertyChanged(); } }
        }

        // Constructors
        public EntityBlock(int creatureType = 7)
        {
            _creatureType = creatureType;

            // Initialize common fields
            _unknownSeptet = new UnknownSeptet[4];
            _iUnmappedBlock = new int[36];

            // Initialize type-specific fields
            if (IsCharacter)
            {
                _equippedItems = new EquippedItems();
                _chUnknownCharacterSkill_2 = new byte[3];
                _chUnmappedCharacterItem = new byte[34];
                _skillList = new List<Skill>();
            }
            else
            {
                _memoryBlock = new int[62];
                _memoryBlockFormatted = new int[0];
            }
        }

        // Default constructor
        public EntityBlock() : this(7) { }  // Default to character type

        // Constructor with BinaryReader
        public EntityBlock(BinaryReader reader, int creatureType) : this(creatureType)
        {
            if (reader == null) return;

            // Read common fields
            _fPosX = reader.ReadSingle();
            _fPosZ = reader.ReadSingle();
            _fPosY = reader.ReadSingle();
            _fRotation = reader.ReadSingle();

            _iUnknownInt1 = reader.ReadInt32();
            _iUnknownInt2 = reader.ReadInt32();
            _iStateFlags = reader.ReadInt32();

            for (int i = 0; i < 4; i++)
            {
                _unknownSeptet[i].Index = reader.ReadByte();
                _unknownSeptet[i].Type = reader.ReadByte();
                _unknownSeptet[i].SubType = reader.ReadByte();
                _unknownSeptet[i].Value1 = reader.ReadInt32();
                _unknownSeptet[i].Value2 = reader.ReadInt32();
                _unknownSeptet[i].Value3 = reader.ReadInt32();
                _unknownSeptet[i].Value4 = reader.ReadInt32();
            }

            if (IsCharacter)
            {
                // Read character-specific data
                _equippedItems = new EquippedItems(reader);

                // Read unmapped block
                Buffer.BlockCopy(reader.ReadBytes(4 * 36), 0, _iUnmappedBlock, 0, 4 * 36);

                // Read all the character skills
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
            else
            {
                // Skip equipment section for non-characters
                reader.ReadBytes(36); // Skip 9 integers

                // Read unmapped block
                Buffer.BlockCopy(reader.ReadBytes(4 * 36), 0, _iUnmappedBlock, 0, 4 * 36);

                // Read creature-specific data
                _wCreatureLevel = reader.ReadInt16();
                _fCurrentHP = reader.ReadSingle();
                _fBaseHP = reader.ReadSingle();
                _wCurrentAP = reader.ReadInt16();
                _wBaseAP = reader.ReadInt16();
                _unsure = reader.ReadInt32();
                _ai = reader.ReadInt32();

                // Read memory block (62 integers = 248 bytes)
                Buffer.BlockCopy(reader.ReadBytes(248), 0, _memoryBlock, 0, 248);

                _wUnknown_End = reader.ReadInt16();
            }
        }

        // Write method
        public void Write(BinaryWriter writer)
        {
            // Write common fields
            writer.Write(fPosX);
            writer.Write(fPosZ);
            writer.Write(fPosY);
            writer.Write(fRotation);

            writer.Write(iUnknownInt1);
            writer.Write(iUnknownInt2);
            writer.Write(iStateFlags);

            for (int i = 0; i < 4; i++)
            {
                writer.Write(UnknownSextets[i].Index);
                writer.Write(UnknownSextets[i].Type);
                writer.Write(UnknownSextets[i].SubType);
                writer.Write(UnknownSextets[i].Value1);
                writer.Write(UnknownSextets[i].Value2);
                writer.Write(UnknownSextets[i].Value3);
                writer.Write(UnknownSextets[i].Value4);
            }

            if (IsCharacter)
            {
                // Write character-specific data
                equippedItems.Write(writer);

                // Write unmapped block
                foreach (int value in iUnmappedBlock)
                {
                    writer.Write(value);
                }

                // Write skills
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

                // Write character stats
                writer.Write(wCharacterLevel);
                writer.Write(dwCharacterExp);
                writer.Write(fCurrentHP);
                writer.Write(fBaseHP);
                writer.Write(wCurrentAP);
                writer.Write(wBaseAP);
                writer.Write(unsure);
                writer.Write(AI);

                // Write unmapped character item
                foreach (byte value in chUnmappedCharacterItem)
                {
                    writer.Write(value);
                }

                writer.Write(wSkillPoints);
            }
            else
            {
                // For creatures, write zeros for the equipment section (9 integers = 36 bytes)
                for (int i = 0; i < 9; i++)
                {
                    writer.Write(0);
                }

                // Write unmapped block
                foreach (int value in iUnmappedBlock)
                {
                    writer.Write(value);
                }

                // Write creature-specific data
                writer.Write(wCreatureLevel);
                writer.Write(fCurrentHP);
                writer.Write(fBaseHP);
                writer.Write(wCurrentAP);
                writer.Write(wBaseAP);
                writer.Write(unsure);
                writer.Write(AI);

                // Write memory block
                foreach (int value in MemoryBlock)
                {
                    writer.Write(value);
                }

                writer.Write(wUnknown_End);
            }
        }

        // Helper method to update a skill in the list when a byte value changes
        private void UpdateSkillInList(int index, byte value)
        {
            if (!IsCharacter || _skillList == null || index >= _skillList.Count)
                return;

            _skillList[index].Value = value * 10;
        }

        // Method to populate skill list from byte values
        public void PopulateSkillList()
        {
            if (!IsCharacter)
                return;

            SkillList = new List<Skill> {
                new Skill("Hand to Hand", _chSkills_HandToHand),
                new Skill("Sword", _chSkills_Sword),
                new Skill("Axe", _chSkills_Axe),
                new Skill("Blunt", _chSkills_Blunt),
                new Skill("Staff", _chSkills_Staff),
                new Skill("Bow", _chSkills_Bow),
                new Skill("Heavy Arms", _chSkills_HeavyArms),
                new Skill("Parry", _chSkills_Parry),
                new Skill("Counter Attack", _chSkills_CounterAttack),
                new Skill("Dodge", _chSkills_Dodge),
                new Skill("Critical Hit", _chSkills_CriticalHit),
                new Skill("Double Attack", _chSkills_DoubleAttack),
                new Skill("Push", _chSkills_Push),
                new Skill("Kick", _chSkills_Kick),
                new Skill("Trip", _chSkills_Trip),
                new Skill("Aimed Attack", _chSkills_AimedAttack),
                new Skill("Backstab", _chSkills_Backstab),
                new Skill("Assess", _chSkills_Assess),
                new Skill("Appraise", _chSkills_Appraise),
                new Skill("Picklock", _chSkills_Picklock),
                new Skill("Sneak", _chSkills_Sneak),
                new Skill("Hide", _chSkills_Hide),
                new Skill("Summon", _chSkills_Summon),
                new Skill("Heal", _chSkills_Heal),
                new Skill("Dark", _chSkills_Dark),
                new Skill("Energy", _chSkills_Energy),
                new Skill("Holy", _chSkills_Holy),
                new Skill("Fire", _chSkills_Fire),
                new Skill("Ice", _chSkills_Ice),
                new Skill("Magic Resist", _chSkills_MagicResist)
            };
        }

        // Method to update byte fields from skill list
        public void UpdateSkillBytes()
        {
            if (!IsCharacter || SkillList == null || SkillList.Count < 30)
                return;

            bool raiseEvents = SuspendNotifications();

            _chSkills_HandToHand = (byte)(SkillList[0].Value);
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

            if (raiseEvents)
                ResumeNotifications();
        }

        // Helper methods for property change notification batching
        private bool _notificationsEnabled = true;

        public bool SuspendNotifications()
        {
            bool oldValue = _notificationsEnabled;
            _notificationsEnabled = false;
            return oldValue;
        }

        public void ResumeNotifications()
        {
            _notificationsEnabled = true;
            OnPropertyChanged(string.Empty); // Trigger update of all bindings
        }
    }
}