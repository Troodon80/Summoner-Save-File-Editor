using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace SummonerSaveFileEditor.Models
{
    public class ImageThumbnail
    {
        // Image header fields (80 bytes total)
        public int PixelLength { get; set; }
        public int DataEndOffset { get; set; }
        public int MetaTableSize { get; set; }
        public int MetaTableOffset { get; set; }
        public int BackupOffset { get; set; }
        public int Flags { get; set; }
        public int BackupMetaOffset { get; set; }
        public int FrameCount { get; set; }
        public int PaletteSize { get; set; }
        public int BackupQuickCheck { get; set; }
        public int BackupDataSize { get; set; }
        public int QuantTableOffset { get; set; }
        public int MagicSignature { get; set; }
        public int Reserved1 { get; set; }
        public int Reserved2 { get; set; }
        public int Reserved3 { get; set; }
        public int Reserved4 { get; set; }
        public int Reserved5 { get; set; }
        public int Reserved6 { get; set; }
        public int MaxReserve { get; set; }

        private byte[] _pixelData;
        private Bitmap _imageBitmap;

        // Standard dimensions
        public int Width => Constants.THUMBNAIL_WIDTH;
        public int Height => Constants.THUMBNAIL_HEIGHT;

        public byte[] PixelData
        {
            get => _pixelData;
            set
            {
                _pixelData = value;
                // Create the bitmap when pixel data is set
                if (_pixelData != null && _pixelData.Length > 0)
                {
                    _imageBitmap?.Dispose(); // Clean up previous bitmap
                    _imageBitmap = ConvertRgb565ToBitmap(_pixelData, Width, Height);
                }
            }
        }

        // Provides direct access to the bitmap image
        public Bitmap ImageBitmap => _imageBitmap;

        // Helper method to create a default header with empty image
        public static ImageThumbnail CreateDefault()
        {
            return new ImageThumbnail
            {
                PixelLength = 60702,
                DataEndOffset = 60702,
                MaxReserve = 60702,
                MetaTableSize = 0,
                MetaTableOffset = 0x0200 + 60702,
                BackupOffset = 0,
                Flags = 0,
                BackupMetaOffset = 0,
                FrameCount = 1,
                PaletteSize = 0,
                BackupQuickCheck = 0,
                BackupDataSize = 0,
                QuantTableOffset = 0,
                MagicSignature = 0,
                PixelData = new byte[60702]
            };
        }

        // Converts RGB565 format to a standard bitmap
        private Bitmap ConvertRgb565ToBitmap(byte[] pixelData, int width, int height)
        {
            if (pixelData == null || pixelData.Length < width * height * 2)
                return null;

            Bitmap bitmap = new Bitmap(width, height);

            // Convert RGB565 to RGB888
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    int index = (y * width + x) * 2;
                    if (index + 1 >= pixelData.Length) break;

                    // Read 16-bit value (little-endian)
                    ushort pixel565 = (ushort)((pixelData[index + 1] << 8) | pixelData[index]);

                    // Extract RGB components (5 bits red, 6 bits green, 5 bits blue)
                    int r = ((pixel565 >> 11) & 0x1F) * 255 / 31;
                    int g = ((pixel565 >> 5) & 0x3F) * 255 / 63;
                    int b = (pixel565 & 0x1F) * 255 / 31;

                    // Set pixel in bitmap
                    bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return bitmap;
        }
    }
}