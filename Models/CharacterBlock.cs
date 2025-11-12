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

    // This is related to buffs/debuffs (status effects) on the character/creature.
    // This is for the Blessed status:
    //Index     0	byte
    //Type	    4	byte
    //SubType   21	byte
    //Value1    117170	int
    //Value2    1072800000	int
    //Value3    0	int
    //Value4    1063339950	int
    //
    // This is for Regenerate:
    //Index     0	byte
    //Type      5	byte
    //SubType   2	byte
    //Value1    111192	int
    //Value2    11192	int
    //Value3    20000	int
    //Value4    1110441984	int

    public struct UnknownSeptet
    {
        public byte Index;
        public byte Type;
        public byte SubType;
        public int Value1;
        public int Value2;
        public int Value3;
        public int Value4;
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
        private float _fPosX;                           // Offset 0
        private float _fPosZ;                           // Offset 4
        private float _fPosY;                           // Offset 8
        private float _fRotation;                       // Offset 12

        private int _iUnknownInt1;                      // Offset 16
        private int _iUnknownInt2;                      // Offset 20
        private int _iStateFlags;                       // Offset 24 (Bit 26 indicates death/invalid/no longer loaded)

        private bool _bIsDead;                          // Not written/read directly

        // Based on minimal testing, it seems these are for buffs, though I'm not entirely certain what fields are what.
        private UnknownSeptet[] _unknownSeptet;         // Offset 28 (4 * 19 bytes = 76 bytes)

        private EquippedItems _equippedItems;           // Offset 104 (9 * 4 bytes = 36 bytes)
        private int[] _iUnmappedBlock;                  // Offset 140 (36 * 4 bytes = 144 bytes)
        private uint _iNumEntries;

        // Skill backing fields
        private byte _chSkills_HandToHand;              // Offset 284
        private byte _chUnknownCharacterSkill_1;        // Offset 285
        private byte _chCharacterSpeed;                 // Offset 286
        private byte _chSkills_Sword;                   // Offset 287
        private byte _chSkills_Axe;                     // Offset 288
        private byte _chSkills_Blunt;                   // Offset 289
        private byte _chSkills_Staff;                   // Offset 290
        private byte _chSkills_Bow;                     // Offset 291
        private byte _chSkills_HeavyArms;               // Offset 292
        private byte _chSkills_Parry;                   // Offset 293
        private byte _chSkills_CounterAttack;           // Offset 294
        private byte _chSkills_Dodge;                   // Offset 295
        private byte _chSkills_CriticalHit;             // Offset 296
        private byte _chSkills_DoubleAttack;            // Offset 297
        private byte _chSkills_Push;                    // Offset 298
        private byte _chSkills_Kick;                    // Offset 299
        private byte _chSkills_Trip;                    // Offset 300
        private byte _chSkills_AimedAttack;             // Offset 301
        private byte _chSkills_Backstab;                // Offset 302
        private byte _chSkills_Assess;                  // Offset 303
        private byte _chSkills_Appraise;                // Offset 304
        private byte _chSkills_Picklock;                // Offset 305
        private byte _chSkills_Sneak;                   // Offset 306
        private byte _chSkills_Hide;                    // Offset 307
        private byte[] _chUnknownCharacterSkill_2;      // Offset 308 (3 bytes: 308, 309, 310)
        private byte _chSkills_Summon;                  // Offset 311
        private byte _chSkills_Heal;                    // Offset 312
        private byte _chSkills_Dark;                    // Offset 313
        private byte _chSkills_Energy;                  // Offset 314
        private byte _chSkills_Holy;                    // Offset 315
        private byte _chSkills_Fire;                    // Offset 316
        private byte _chSkills_Ice;                     // Offset 317
        private byte _chUnknownCharacterSkill_3;        // Offset 318
        private byte _chSkills_MagicResist;             // Offset 319

        // Character stats backing fields
        private short _wCharacterLevel;                 // Offset 320
        private int _dwCharacterExp;                    // Offset 322
        private float _fCurrentHP;                      // Offset 326
        private float _fBaseHP;                         // Offset 330
        private short _wCurrentAP;                      // Offset 334
        private short _wBaseAP;                         // Offset 336
        private int _unsure;                            // Offset 338
        private int _ai;                                // Offset 342
        private byte[] _chUnmappedCharacterItem;        // Offset 346 (34 bytes: 346-379)
        private int _wSkillPoints;                      // Offset 380
                                                        // Total size: 384

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

        public UnknownSeptet[] UnknownSeptets
        {
            get => _unknownSeptet;
            set { if (_unknownSeptet != value) { _unknownSeptet = value; OnPropertyChanged(); } }
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
            _unknownSeptet = new UnknownSeptet[4];
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

            _iUnknownInt1 = reader.ReadInt32();
            _iUnknownInt2 = reader.ReadInt32();
            _iStateFlags = reader.ReadInt32();

            _bIsDead = (_iStateFlags & 0x4000000) != 0; // Bit 26 indicates death/invalid/no longer loaded

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

            writer.Write(iUnknownInt1);
            writer.Write(iUnknownInt2);
            writer.Write(iStateFlags);

            for (int i = 0; i < 4; i++)
            {
                writer.Write(UnknownSeptets[i].Index);
                writer.Write(UnknownSeptets[i].Type);
                writer.Write(UnknownSeptets[i].SubType);
                writer.Write(UnknownSeptets[i].Value1);
                writer.Write(UnknownSeptets[i].Value2);
                writer.Write(UnknownSeptets[i].Value3);
                writer.Write(UnknownSeptets[i].Value4);
            }

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