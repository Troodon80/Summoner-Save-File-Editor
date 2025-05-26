using System;
using System.Collections.Generic;
using System.Numerics;

namespace SummonerSaveFileEditor.Models
{
    public class Container
    {
        public Vector3 Position { get; set; }
        public int ContentCount { get; set; }
        public byte Flags { get; set; }
        public bool IsLocked => (Flags & 0x01) != 0;
        public List<ContainerItem> Contents { get; set; } = new List<ContainerItem>();

        public override string ToString() => 
            $"Container at ({Position.X:F2}, {Position.Y:F2}, {Position.Z:F2}), Locked: {IsLocked}, Items: {Contents.Count}";
    }

    public class ContainerItem
    {
        public int ReferenceId { get; set; }
        public short Quantity { get; set; }
        public short Charges { get; set; }

        public override string ToString() => 
            $"Item Index: {ReferenceId}, Quantity: {Quantity}, Charges: {Charges})";
    }
}