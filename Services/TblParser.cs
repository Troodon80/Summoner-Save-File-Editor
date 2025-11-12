using SummonerSaveFileEditor.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SummonerSaveFileEditor.Services
{
    public static class TblParser
    {
        public static List<TblEntry> ParseTbl(byte[] tblData)
        {
            var entries = new List<TblEntry>();

            using (var stream = new MemoryStream(tblData))
            using (var reader = new StreamReader(stream, Encoding.ASCII))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (!line.StartsWith("$"))
                        continue;

                    int separator = line.IndexOf(':');
                    if (separator <= 0 || separator + 1 >= line.Length)
                        continue;

                    string key = line.Substring(0, separator).Trim();
                    string value = line.Substring(separator + 1).Trim().Trim('\"');

                    entries.Add(new TblEntry
                    {
                        Key = key,
                        Value = value
                    });
                }
            }
            return entries;
        }
    }
}