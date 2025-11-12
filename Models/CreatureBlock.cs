using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace SummonerSaveFileEditor.Models
{
    public class CreatureBlock : INotifyPropertyChanged
    {
        // INotifyPropertyChanged implementation
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        // Position backing fields
        private float _fPosX;
        private float _fPosZ;
        private float _fPosY;
        private float _fRotation;

        private int _iUnknownInt1;
        private int _iUnknownInt2;
        private int _iStateFlags;
        private bool _bIsDead;
        private UnknownSeptet[] _unknownSeptet;
        private short _wCreatureLevel;
        private float _fCurrentHP;
        private float _fBaseHP;
        private short _wCurrentAP;
        private short _wBaseAP;
        private int _unsure;
        private int _ai;
        private int[] _memoryBlock;
        private int[] _memoryBlockFormatted;
        private short _wUnknown_End;

        // Position properties
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
            get => (_iStateFlags & 0x4000000) != 0; // Bit 8 indicates death
            set
            {
                if (value != bIsDead)
                {
                    if (value) _iStateFlags |= 0x4000000; // Set bit 8
                    else _iStateFlags &= ~0x4000000; // Clear bit 8
                    OnPropertyChanged();
                }
            }
        }

        // Status and memory properties
        public UnknownSeptet[] UnknownSeptets
        {
            get => _unknownSeptet;
            set { if (_unknownSeptet != value) { _unknownSeptet = value; OnPropertyChanged(); } }
        }

        public short wCreatureLevel
        {
            get => _wCreatureLevel;
            set { if (_wCreatureLevel != value) { _wCreatureLevel = value; OnPropertyChanged(); } }
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

        public int[] MemoryBlock
        {
            get => _memoryBlock;
            set { if (_memoryBlock != value) { _memoryBlock = value; OnPropertyChanged(); } }
        }

        public int[] MemoryBlockFormatted
        {
            get => _memoryBlockFormatted;
            set { if (_memoryBlockFormatted != value) { _memoryBlockFormatted = value; OnPropertyChanged(); } }
        }

        public short wUnknown_End
        {
            get => _wUnknown_End;
            set { if (_wUnknown_End != value) { _wUnknown_End = value; OnPropertyChanged(); } }
        }

        // Default constructor
        public CreatureBlock() : this(null) { }

        // Constructor with BinaryReader
        public CreatureBlock(BinaryReader reader)
        {
            // Initialize arrays
            _unknownSeptet = new UnknownSeptet[4];
            _memoryBlock = new int[62];
            _memoryBlockFormatted = new int[0]; 

            if (reader == null) return;  // Early return for default constructor

            _fPosX = reader.ReadSingle();
            _fPosZ = reader.ReadSingle();
            _fPosY = reader.ReadSingle();
            _fRotation = reader.ReadSingle();

            _iUnknownInt1 = reader.ReadInt32();
            _iUnknownInt2 = reader.ReadInt32();
            _iStateFlags = reader.ReadInt32();

            _bIsDead = (_iStateFlags & 0x4000000) != 0; // Bit 26 indicates death/invalid/no longer loaded

            //bool temp1 = (_iStateFlags & 0x100) != 0;     // Bit 8
            //bool temp2 = (_iStateFlags & 0x4000000) != 0;   // Bit 18

            // This is an extremely basic way to read and (below) write the data which already exists.
            // The engine writes depending on type. Only types 5 and 9 do a full read, while the others
            // only read +0x0B (Data) and +0x0F (Value). I'm just preserving what already exists.
            // Since we're not adding or removing entities, this is sufficient.
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

            _wCreatureLevel = reader.ReadInt16();
            _fCurrentHP = reader.ReadSingle();
            _fBaseHP = reader.ReadSingle();
            _wCurrentAP = reader.ReadInt16();
            _wBaseAP = reader.ReadInt16();

            _unsure = reader.ReadInt32();
            _ai = reader.ReadInt32();

            Buffer.BlockCopy(reader.ReadBytes(248), 0, _memoryBlock, 0, 248);

            _wUnknown_End = reader.ReadInt16();
        }

        // Write method
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

            writer.Write(wCreatureLevel);
            writer.Write(fCurrentHP);
            writer.Write(fBaseHP);
            writer.Write(wCurrentAP);
            writer.Write(wBaseAP);
            writer.Write(unsure);
            writer.Write(AI);

            for (int i = 0; i < MemoryBlock.Length; i++)
            {
                writer.Write(MemoryBlock[i]);
            }
            writer.Write(wUnknown_End);
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