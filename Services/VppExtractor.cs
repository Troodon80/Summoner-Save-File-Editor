using SummonerSaveFileEditor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace SummonerSaveFileEditor.Services
{
    public static class VppExtractor
    {
        public static int FirstFileOffset { get; private set; }

        public static async Task<List<VppEntry>> LoadVppAsync(string filePath)
        {
            var entries = new List<VppEntry>();

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(stream, Encoding.ASCII))
            {
                reader.BaseStream.Seek(0x04, SeekOrigin.Begin); // skip magic
                int version = reader.ReadInt32();
                int entryCount = reader.ReadInt32();

                FirstFileOffset = 0x800 + (entryCount * 0x40);

                reader.BaseStream.Seek(0x800, SeekOrigin.Begin);

                int currentOffset = FirstFileOffset;

                for (int i = 0; i < entryCount; i++)
                {
                    byte[] nameBytes = reader.ReadBytes(0x3C);
                    string name = Encoding.ASCII.GetString(nameBytes).TrimEnd('\0');
                    int size = reader.ReadInt32();

                    entries.Add(new VppEntry
                    {
                        FileName = name,
                        FileSize = size,
                        FileOffset = currentOffset
                    });

                    currentOffset += size;
                }
            }

            return entries;
        }

        public static async Task<Dictionary<string, List<TblEntry>>> ExtractTblFilesAsync(string filePath, string fileName = "")
        {
            var result = new Dictionary<string, List<TblEntry>>();
            
            var entries = await LoadVppAsync(filePath);

            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (var reader = new BinaryReader(stream))
            {
                foreach (var entry in entries)
                {
                    // Filter by filename or extension
                    if (!string.IsNullOrEmpty(fileName))
                    {
                        if (!entry.FileName.Equals(fileName, StringComparison.OrdinalIgnoreCase))
                            continue;
                    }
                    else if (!entry.FileName.EndsWith(".tbl", StringComparison.OrdinalIgnoreCase))
                    {
                        continue;
                    }

                    reader.BaseStream.Seek(entry.FileOffset, SeekOrigin.Begin);
                    byte[] data = reader.ReadBytes(entry.FileSize);

                    var parsedEntries = TblParser.ParseTbl(data);
                    result.Add(entry.FileName, parsedEntries);
                }
            }

            return result;
        }
        
        public static async Task<byte[]> ExtractFileDataAsync(string vppFilePath, string fileName)
        {
            var entries = await LoadVppAsync(vppFilePath);
            
            foreach (var entry in entries)
            {
                if (entry.FileName.Equals(fileName, StringComparison.OrdinalIgnoreCase))
                {
                    using (var stream = new FileStream(vppFilePath, FileMode.Open, FileAccess.Read))
                    using (var reader = new BinaryReader(stream))
                    {
                        reader.BaseStream.Seek(entry.FileOffset, SeekOrigin.Begin);
                        return reader.ReadBytes(entry.FileSize);
                    }
                }
            }
            
            return null;
        }
    }
}