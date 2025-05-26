using SummonerSaveFileEditor.Data;
using SummonerSaveFileEditor.Models;
using SummonerSaveFileEditor.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Security.Policy;
using System.Text;

namespace SummonerSaveFileEditor.Services
{
    public static class SaveFileService
    {
        public static SaveGameViewModel ReadSaveFile(BinaryReader reader, List<InventoryItem> knownItems, out int originalInventorySize)
        {
            var viewModel = new SaveGameViewModel();
            originalInventorySize = 0;

            // Read gold
            reader.BaseStream.Seek(Constants.INVENTORY_START, SeekOrigin.Begin);
            string invHeader = Encoding.ASCII.GetString(reader.ReadBytes(4));
            if (invHeader != "INVT") throw new InvalidDataException("Invalid inventory header");

            int gold = reader.ReadInt32();
            viewModel.Gold = gold;

            originalInventorySize = reader.ReadInt32();
            for (int i = 0; i < originalInventorySize; i++)
            {
                int hash = reader.ReadInt32();
                int quantity = reader.ReadInt32();
                int charge = reader.ReadInt32();

                var name = knownItems.FirstOrDefault(x => x.Hash == hash)?.Name ?? $"Unknown {hash}";
                var item = new InventoryItem { Hash = hash, Quantity = quantity, Charge = charge, Name = name };
                viewModel.Inventory.Add(new InventoryItemViewModel(item));
            }

            return viewModel;
        }

        public static void WriteSaveFile(BinaryWriter writer, SaveGameViewModel viewModel, List<InventoryItem> knownItems, int originalInventorySize)
        {
            writer.BaseStream.Seek(Constants.INVENTORY_START, SeekOrigin.Begin);
            writer.Write(Encoding.ASCII.GetBytes("INVT"));
            writer.Write(viewModel.Gold);
            writer.Write(viewModel.Inventory.Count);

            foreach (var itemVm in viewModel.Inventory.ToList())
            {
                writer.Write(itemVm.Hash);
                writer.Write(itemVm.Quantity);
                writer.Write(itemVm.Charge);
            }

            writer.Write(viewModel.Inventory.Count * 12 + 16);

            int pad = originalInventorySize - viewModel.Inventory.Count;
            for (int i = 0; i < pad; i++)
            {
                writer.Write(0); writer.Write(0); writer.Write(0);
            }
        }
        public static void ReadSaveGameHeader(BinaryReader reader, SaveGameViewModel viewModel)
        {
            reader.BaseStream.Seek(0, SeekOrigin.Begin);

            // Read the main SAVg header
            string savgHeader = Encoding.ASCII.GetString(reader.ReadBytes(4));
            if (savgHeader != "SAVg") throw new InvalidDataException("Invalid save game header");

            // Read version or format number (typically follows header)
            int version = reader.ReadInt32();

            // Read area strings - we have two fixed-length area strings
            byte[] areaMainBytes = reader.ReadBytes(128);
            string areaMain = Encoding.ASCII.GetString(areaMainBytes).TrimEnd('\0');

            byte[] areaSubBytes = reader.ReadBytes(36);
            string areaSub = Encoding.ASCII.GetString(areaSubBytes).TrimEnd('\0');

            // Store data in view model
            viewModel.SaveFileVersion = version;
            viewModel.AreaMain = areaMain;
            viewModel.AreaSub = areaSub;

            // Read time and description and store in the view model
            reader.BaseStream.Seek(Constants.TIME_OFFSET, SeekOrigin.Begin);
            float timeSeconds = reader.ReadSingle();
            viewModel.GameTimeSeconds = timeSeconds;

            reader.BaseStream.Seek(Constants.DESCRIPTION_OFFSET, SeekOrigin.Begin);
            byte[] descBytes = reader.ReadBytes(256);
            string description = Encoding.UTF8.GetString(descBytes).TrimEnd('\0');
            viewModel.Description = description;

            // Image header is typically after the core header data
            ReadImageHeader(reader, viewModel);
        }

        public static void ReadImageHeader(BinaryReader reader, SaveGameViewModel viewModel)
        {
            // Position to the start of the image header (0x01B0)
            reader.BaseStream.Seek(Constants.THUMBNAIL_METADATA_OFFSET, SeekOrigin.Begin);

            var header = new ImageThumbnail
            {
                PixelLength = reader.ReadInt32(),
                DataEndOffset = reader.ReadInt32(),
                MaxReserve = reader.ReadInt32(),
                MetaTableSize = reader.ReadInt32(),
                MetaTableOffset = reader.ReadInt32(),
                BackupOffset = reader.ReadInt32(),
                Flags = reader.ReadInt32(),
                BackupMetaOffset = reader.ReadInt32(),
                FrameCount = reader.ReadInt32(),
                PaletteSize = reader.ReadInt32(),
                BackupQuickCheck = reader.ReadInt32(),
                BackupDataSize = reader.ReadInt32(),
                QuantTableOffset = reader.ReadInt32(),
                MagicSignature = reader.ReadInt32(),
                Reserved1 = reader.ReadInt32(),
                Reserved2 = reader.ReadInt32(),
                Reserved3 = reader.ReadInt32(),
                Reserved4 = reader.ReadInt32(),
                Reserved5 = reader.ReadInt32(),
                Reserved6 = reader.ReadInt32()
            };

            // Now read the pixel data
            //reader.BaseStream.Seek(0x0200, SeekOrigin.Begin);
            header.PixelData = reader.ReadBytes(header.PixelLength);

            viewModel.ImageThumbnail = header;
        }

        public static void ReadPostThumbnailData(BinaryReader reader, SaveGameViewModel viewModel)
        {
            // Calculate where the thumbnail data ends
            var thumbnailMetadataOffset = Constants.THUMBNAIL_METADATA_OFFSET;
            var thumbnailPixelLength = viewModel.ImageThumbnail?.PixelLength ?? 0;
            long thumbnailEndOffset = thumbnailMetadataOffset + 0x50 + thumbnailPixelLength; // 0x50 is the size of the metadata header

            // Position to the end of the thumbnail
            reader.BaseStream.Seek(thumbnailEndOffset, SeekOrigin.Begin);

            // Calculate the size of the data between thumbnail and ITEM section
            long dataSize = Constants.INVENTORY_START - thumbnailEndOffset;

            // Read the data
            viewModel.PostThumbnailData = reader.ReadBytes((int)dataSize);
        }

        public static void WriteSaveGameHeader(BinaryWriter writer, SaveGameViewModel viewModel)
        {
            writer.BaseStream.Seek(0, SeekOrigin.Begin);

            // Write the SAVg header
            writer.Write(Encoding.ASCII.GetBytes("SAVg"));

            // Write version
            writer.Write(viewModel.SaveFileVersion);

            // Write area strings (pad to fixed length)
            byte[] areaMainBytes = new byte[128];
            byte[] areaSubBytes = new byte[36];

            if (!string.IsNullOrEmpty(viewModel.AreaMain))
                Encoding.ASCII.GetBytes(viewModel.AreaMain).CopyTo(areaMainBytes, 0);

            if (!string.IsNullOrEmpty(viewModel.AreaSub))
                Encoding.ASCII.GetBytes(viewModel.AreaSub).CopyTo(areaSubBytes, 0);

            writer.Write(areaMainBytes);
            writer.Write(areaSubBytes);

            // Write time and description at their correct offsets
            writer.BaseStream.Seek(Constants.TIME_OFFSET, SeekOrigin.Begin);
            writer.Write(viewModel.GameTimeSeconds);

            writer.BaseStream.Seek(Constants.DESCRIPTION_OFFSET, SeekOrigin.Begin);
            byte[] descBytes = new byte[256];
            Encoding.UTF8.GetBytes(viewModel.Description ?? "").CopyTo(descBytes, 0);
            writer.Write(descBytes);

            // Write image header and data
            WriteImageHeader(writer, viewModel);
        }

        public static void WriteImageHeader(BinaryWriter writer, SaveGameViewModel viewModel)
        {
            // Create default header if none exists
            var header = viewModel.ImageThumbnail ?? ImageThumbnail.CreateDefault();

            // Position to the start of the image header (0x01B0)
            writer.BaseStream.Seek(Constants.THUMBNAIL_METADATA_OFFSET, SeekOrigin.Begin);

            writer.Write(header.PixelLength);
            writer.Write(header.DataEndOffset);
            writer.Write(header.MaxReserve);
            writer.Write(header.MetaTableSize);
            writer.Write(header.MetaTableOffset);
            writer.Write(header.BackupOffset);
            writer.Write(header.Flags);
            writer.Write(header.BackupMetaOffset);
            writer.Write(header.FrameCount);
            writer.Write(header.PaletteSize);
            writer.Write(header.BackupQuickCheck);
            writer.Write(header.BackupDataSize);
            writer.Write(header.QuantTableOffset);
            writer.Write(header.MagicSignature);
            writer.Write(header.Reserved1);
            writer.Write(header.Reserved2);
            writer.Write(header.Reserved3);
            writer.Write(header.Reserved4);
            writer.Write(header.Reserved5);
            writer.Write(header.Reserved6);

            // Now write the pixel data
            //writer.BaseStream.Seek(0x0200, SeekOrigin.Begin);
            if (header.PixelData != null)
            {
                writer.Write(header.PixelData);
            }
        }

        public static void WritePostThumbnailData(BinaryWriter writer, SaveGameViewModel viewModel)
        {
            // Calculate where the thumbnail data ends
            var thumbnailMetadataOffset = Constants.THUMBNAIL_METADATA_OFFSET;
            var thumbnailPixelLength = viewModel.ImageThumbnail?.PixelLength ?? 60702;
            long thumbnailEndOffset = thumbnailMetadataOffset + 0x50 + thumbnailPixelLength; // 0x50 is the size of the metadata header

            // Position to the end of the thumbnail
            writer.BaseStream.Seek(thumbnailEndOffset, SeekOrigin.Begin);

            // Write the data if it exists
            if (viewModel.PostThumbnailData != null && viewModel.PostThumbnailData.Length > 0)
            {
                writer.Write(viewModel.PostThumbnailData);
            }
        }

        public static void ReadCharactersAndCreatures(BinaryReader reader, SaveGameViewModel viewModel)
        {
            reader.BaseStream.Seek(Constants.CHARACTER_START, SeekOrigin.Begin);
            LevelEntityHeader levelHeader = new LevelEntityHeader
            {
                LentSignature = Encoding.ASCII.GetString(reader.ReadBytes(4)),
                FirstEntityOffset = reader.ReadUInt32(),
                EndRegionOffset = reader.ReadUInt32(),
                PossibleBitfield = reader.ReadUInt32(),
                PossibleSaveId = reader.ReadUInt32(),
                PossibleMaxEntitySpan = reader.ReadUInt32(),
                PossibleCodeRef1 = reader.ReadUInt32(),
                PossibleCodeRef2 = reader.ReadUInt32(),
                PossibleDataTable = reader.ReadUInt32(),
                PossibleFuncAddr1 = reader.ReadUInt32(),
                PossibleFuncAddr2 = reader.ReadUInt32(),
                PossibleFuncAddr3 = reader.ReadUInt32(),
                EntityCount = reader.ReadUInt32()
            };

            if (levelHeader.LentSignature != "LENT") throw new InvalidDataException("Invalid level entity header");

            // Store the header in viewModel
            viewModel.LevelEntityHeader = levelHeader;

            for (int i = 0; i < levelHeader.EntityCount; i++)
            {
                var header = new CreatureHeader(reader);


                if (header.creatureType == 7) // Character
                {
                    var block = new CharacterBlock(reader);
                    block.PopulateSkillList();
                    var character = new Character { Header = header, CharacterBlock = block };

                    switch (header.creatureId)
                    {
                        case Constants.JOSEPH:
                            viewModel.Joseph = new CharacterViewModel(character);
                            break;
                        case Constants.FLECE:
                            viewModel.Flece = new CharacterViewModel(character);
                            break;
                        case Constants.ROSALIND:
                            viewModel.Rosalind = new CharacterViewModel(character);
                            break;
                        case Constants.JEKHAR:
                            viewModel.Jekhar = new CharacterViewModel(character);
                            break;
                    }
                }
                else
                {
                    var block = new CreatureBlock(reader);
                    var creature = new Creature(header, block);
                    viewModel.Creatures.Add(creature);
                }
            }

            long dataPosition = reader.BaseStream.Position;
            long dataSize = Constants.CAMERA_START - dataPosition;
            // Read additional data block after characters and creatures
            viewModel.PostCreatureData = reader.ReadBytes((int)dataSize);
        }

        public static void WriteCharactersAndCreatures(BinaryWriter writer, SaveGameViewModel viewModel)
        {
            var activeCharacters = new List<Character>();

            if (viewModel.Joseph != null) activeCharacters.Add(viewModel.Joseph.ToCharacter());
            if (viewModel.Flece != null) activeCharacters.Add(viewModel.Flece.ToCharacter());
            if (viewModel.Rosalind != null) activeCharacters.Add(viewModel.Rosalind.ToCharacter());
            if (viewModel.Jekhar != null) activeCharacters.Add(viewModel.Jekhar.ToCharacter());

            int total = activeCharacters.Count + viewModel.Creatures.Count;

            writer.BaseStream.Seek(Constants.CHARACTER_START, SeekOrigin.Begin);
            
            writer.Write(Encoding.ASCII.GetBytes(viewModel.LevelEntityHeader.LentSignature));
            writer.Write(viewModel.LevelEntityHeader.FirstEntityOffset);
            writer.Write(viewModel.LevelEntityHeader.EndRegionOffset);
            writer.Write(viewModel.LevelEntityHeader.PossibleBitfield);
            writer.Write(viewModel.LevelEntityHeader.PossibleSaveId);
            writer.Write(viewModel.LevelEntityHeader.PossibleMaxEntitySpan);
            writer.Write(viewModel.LevelEntityHeader.PossibleCodeRef1);
            writer.Write(viewModel.LevelEntityHeader.PossibleCodeRef2);
            writer.Write(viewModel.LevelEntityHeader.PossibleDataTable);
            writer.Write(viewModel.LevelEntityHeader.PossibleFuncAddr1);
            writer.Write(viewModel.LevelEntityHeader.PossibleFuncAddr2);
            writer.Write(viewModel.LevelEntityHeader.PossibleFuncAddr3);
            //writer.Write(viewModel.LevelEntityHeader.EntityCount);

            writer.Write(total);

            foreach (var character in activeCharacters)
            {
                character.Header.Write(writer);
                character.CharacterBlock.Write(writer);
            }

            foreach (var creature in viewModel.Creatures)
            {
                creature.Header.Write(writer);
                creature.CreatureBlock.Write(writer);
            }

            // Write additional data block after characters and creatures
            if (viewModel.PostCreatureData != null && viewModel.PostCreatureData.Length > 0)
            {
                writer.Write(viewModel.PostCreatureData);
            }

        }

        public static void ReadItemFlags(BinaryReader reader, List<InventoryItem> knownItems, out List<ItemFlagEntry> itemFlags)
        {
            reader.BaseStream.Seek(Constants.ITEM_FLAG_START, SeekOrigin.Begin);

            var header = Encoding.ASCII.GetString(reader.ReadBytes(4));
            if (header != "ITEM") throw new InvalidDataException("Missing item flag block header");

            int itemCount = reader.ReadInt32();
            int flagsOffset = 8 + (itemCount * 4);
            int totalLength = flagsOffset + ((itemCount + 7) / 8);

            reader.BaseStream.Seek(Constants.ITEM_FLAG_START, SeekOrigin.Begin);
            var block = reader.ReadBytes(totalLength);

            itemFlags = new List<ItemFlagEntry>(itemCount);

            for (int i = 0; i < itemCount; i++)
            {
                int hash = BitConverter.ToInt32(block, 8 + i * 4);
                int byteIndex = flagsOffset + (i / 8);
                int bitIndex = i % 8;
                bool identifiedBit = (block[byteIndex] & (1 << bitIndex)) != 0;

                itemFlags.Add(new ItemFlagEntry { Hash = hash, IdentifiedBit = identifiedBit });

                var match = knownItems.FirstOrDefault(item => item.Hash == hash);
                if (match != null) match.IdentifiedBit = identifiedBit;
            }
        }

        public static void WriteItemFlags(BinaryWriter writer, List<ItemFlagEntry> itemFlags)
        {
            if (itemFlags == null || itemFlags.Count != 521)
                throw new InvalidOperationException("Expected 521 item flags");

            int itemCount = 521;
            int flagsOffset = 8 + (itemCount * 4);
            int totalLength = flagsOffset + ((itemCount + 7) / 8);

            byte[] block = new byte[totalLength];
            Encoding.ASCII.GetBytes("ITEM").CopyTo(block, 0);
            BitConverter.GetBytes(itemCount).CopyTo(block, 4);

            for (int i = 0; i < itemCount; i++)
            {
                BitConverter.GetBytes(itemFlags[i].Hash).CopyTo(block, 8 + i * 4);

                if (!itemFlags[i].IdentifiedBit) continue;
                int byteIndex = flagsOffset + (i / 8);
                int bitIndex = i % 8;
                block[byteIndex] |= (byte)(1 << bitIndex);
            }

            writer.BaseStream.Seek(Constants.ITEM_FLAG_START, SeekOrigin.Begin);
            writer.Write(block);
        }

        public static void ReadThumbnail(BinaryReader reader, out byte[] imageData)
        {
            reader.BaseStream.Seek(0, SeekOrigin.Begin);
            imageData = reader.ReadBytes((int)reader.BaseStream.Length);
        }

        public static void ReadTimeAndDescription(BinaryReader reader, out float timeSeconds, out string description)
        {
            reader.BaseStream.Seek(Constants.TIME_OFFSET, SeekOrigin.Begin);
            timeSeconds = reader.ReadSingle();

            reader.BaseStream.Seek(Constants.DESCRIPTION_OFFSET, SeekOrigin.Begin);
            var bytes = reader.ReadBytes(256);
            description = Encoding.UTF8.GetString(bytes).TrimEnd('\0');
        }

        public static void WriteTimeAndDescription(BinaryWriter writer, float timeSeconds, string description)
        {
            writer.BaseStream.Seek(Constants.TIME_OFFSET, SeekOrigin.Begin);
            writer.Write(timeSeconds);

            writer.BaseStream.Seek(Constants.DESCRIPTION_OFFSET, SeekOrigin.Begin);
            byte[] descBytes = new byte[256];
            Encoding.UTF8.GetBytes(description ?? "").CopyTo(descBytes, 0);
            writer.Write(descBytes);
        }

        public static void ReadCamera(BinaryReader reader, SaveGameViewModel viewModel)
        {
            reader.BaseStream.Seek(Constants.CAMERA_START, SeekOrigin.Begin);
            string invHeader = Encoding.ASCII.GetString(reader.ReadBytes(4));
            if (invHeader != "CMRA") throw new InvalidDataException("Invalid camera header");

            var block = new CameraBlock
            {
                Unknown = reader.ReadInt32(),
                FieldOfView = reader.ReadSingle(),
                Pitch = reader.ReadSingle(),
                Yaw = reader.ReadSingle(),
                Zoom = reader.ReadSingle(),
                PositionX = reader.ReadSingle(),
                PositionY = reader.ReadSingle(),
                PositionZ = reader.ReadSingle(),
                CameraMode = reader.ReadInt32()
            };

            viewModel.Camera = new CameraViewModel(block);
        }

        public static void WriteCamera(BinaryWriter writer, SaveGameViewModel viewModel)
        {
            var block = viewModel.Camera.ToCameraBlock(); // you’ll need this method
            writer.BaseStream.Seek(Constants.CAMERA_START, SeekOrigin.Begin);
            writer.Write(Encoding.ASCII.GetBytes("CMRA"));

            writer.Write(block.Unknown);
            writer.Write(block.FieldOfView);
            writer.Write(block.Pitch);
            writer.Write(block.Yaw);
            writer.Write(block.Zoom);
            writer.Write(block.PositionX);
            writer.Write(block.PositionY);
            writer.Write(block.PositionZ);
            writer.Write(block.CameraMode);
        }

        public static void ReadContainerSection(BinaryReader reader, SaveGameViewModel viewModel)
        {
            // Position at CONT section
            reader.BaseStream.Position = Constants.CONT_START;

            // Read section header
            string signature = new string(reader.ReadChars(4));
            if (signature != "CONT")
                throw new FormatException($"Invalid CONT section header at offset 0x{Constants.CONT_START:X8}. Found '{signature}' instead of 'CONT'");

            // Read container count
            int containerCount = reader.ReadInt32();
            var containers = new List<Container>(containerCount);

            // Parse each container
            for (int i = 0; i < containerCount; i++)
            {
                var container = new Container
                {
                    Position = new Vector3(
                        reader.ReadSingle(),    // X
                        reader.ReadSingle(),    // Y
                        reader.ReadSingle()     // Z
                    ),
                    ContentCount = reader.ReadInt32(),
                    Flags = reader.ReadByte()
                };

                int contentCount = container.ContentCount;
                // Read content count and items
                for (int j = 0; j < contentCount; j++)
                {
                    var item = new ContainerItem
                    {
                        ReferenceId = reader.ReadInt32(),
                        Quantity = reader.ReadInt16(),
                        Charges = reader.ReadInt16()
                    };
                    container.Contents.Add(item);
                }

                containers.Add(container);
            }

            viewModel.Containers = containers;
        }

        /// <summary>
        /// Writes container data to the save file.
        /// </summary>
        public static void WriteContainerSection(BinaryWriter writer, SaveGameViewModel viewModel)
        {
            // Position at CONT section
            writer.BaseStream.Position = Constants.CONT_START;

            // Write section header
            writer.Write(new char[] { 'C', 'O', 'N', 'T' });

            // Write container count
            writer.Write(viewModel.Containers.Count);

            // Write each container
            foreach (var container in viewModel.Containers)
            {
                // Write position
                writer.Write(container.Position.X);
                writer.Write(container.Position.Y);
                writer.Write(container.Position.Z);

                // Write content count
                writer.Write(container.Contents.Count);

                // Write flags
                writer.Write(container.Flags);

                // Write each item
                foreach (var item in container.Contents)
                {
                    writer.Write(item.ReferenceId);
                    writer.Write(item.Quantity);
                    writer.Write(item.Charges);
                }
            }
        }

        public static void ReadPostContainerData(BinaryReader reader, SaveGameViewModel viewModel)
        {
            // Position at POST_CONT_START section
            reader.BaseStream.Seek(Constants.POST_CONT_START, SeekOrigin.Begin);

            // Calculate remaining bytes until end of file
            long remainingBytes = reader.BaseStream.Length - reader.BaseStream.Position;

            // Read all remaining data to the end of the file
            viewModel.RemainingData = reader.ReadBytes((int)remainingBytes);
        }

        public static void WritePostContainerData(BinaryWriter writer, SaveGameViewModel viewModel)
        {
            // Position at POST_CONT_START section
            writer.BaseStream.Seek(Constants.POST_CONT_START, SeekOrigin.Begin);

            // Write the data if it exists
            if (viewModel.RemainingData != null && viewModel.RemainingData.Length > 0)
            {
                writer.Write(viewModel.RemainingData);
            }
        }

        public static void ReadAreaBlockData(BinaryReader reader, SaveGameViewModel viewModel)
        {
            reader.BaseStream.Seek(Constants.POST_INVT_START, SeekOrigin.Begin);

            var areaData = new Dictionary<AreaBlock, byte[]>();

            foreach (var block in AreaBlockTable.Table)
            {
                if (block.Name.EndsWith("_m1"))
                    continue;

                int entryCount = block.EntryCount;
                int referenceCount = block.ReferenceCount;

                int entryCountAligned = ((entryCount + 7) & ~7);                    // A aligned to 8 bytes
                int referenceCountAligned = ((referenceCount * 4 + 7) & ~7);        // B * 4 aligned to 8 bytes

                // Calculate size based on the formula
                int baseSize = 4 + (entryCount * 4) + (entryCount * 4) + (referenceCount * 4) + entryCountAligned + referenceCountAligned;

                // Read this block's data
                byte[] blockData = reader.ReadBytes(baseSize);
                areaData[block] = blockData;
            }

            viewModel.AreaBlockData = areaData;
        }

        public static void WriteAreaBlockData(BinaryWriter writer, SaveGameViewModel viewModel)
        {
            writer.BaseStream.Seek(Constants.POST_INVT_START, SeekOrigin.Begin);

            if (viewModel.AreaBlockData == null)
                return;

            foreach (var block in AreaBlockTable.Table)
            {
                if (block.Name.EndsWith("_m1"))
                    continue;


                if (viewModel.AreaBlockData.TryGetValue(block, out byte[] blockData))
                {
                    writer.Write(blockData);
                }
                else
                {
                    // If we don't have data for this block, calculate the size and write zeros
                    int entryCount = block.EntryCount;
                    int referenceCount = block.ReferenceCount;

                    int entryCountAligned = ((entryCount + 7) & ~7);                    // A aligned to 8 bytes
                    int referenceCountAligned = ((referenceCount * 4 + 7) & ~7);        // B * 4 aligned to 8 bytes

                    // Calculate size based on the formula
                    int baseSize = 4 + (entryCount * 4) + (entryCount * 4) + (referenceCount * 4) + entryCountAligned + referenceCountAligned;

                    writer.Write(new byte[baseSize]);
                }
            }
        }
    }
}
