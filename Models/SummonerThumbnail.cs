using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace SummonerSaveFileEditor.Models
{
    /// <summary>
    /// Handles the extraction and verification of thumbnail images from Summoner save files.
    /// </summary>
    public class SummonerThumbnail
    {
        #region Constants


        #endregion

        #region Properties

        /// <summary>
        /// Length of the pixel data in bytes
        /// </summary>
        public uint PixelLength { get; private set; }

        /// <summary>
        /// The extracted thumbnail as a bitmap
        /// </summary>
        public Bitmap ThumbnailImage { get; private set; }

        /// <summary>
        /// Width of the thumbnail in pixels
        /// </summary>
        public int Width { get; private set; }

        /// <summary>
        /// Height of the thumbnail in pixels
        /// </summary>
        public int Height { get; private set; }

        /// <summary>
        /// Raw save file data
        /// </summary>
        private byte[] SaveData { get; set; }

        #endregion

        #region Constructors

        /// <summary>
        /// Private constructor used by factory methods
        /// </summary>
        private SummonerThumbnail()
        {
            Width = Constants.THUMBNAIL_WIDTH;
            Height = Constants.THUMBNAIL_HEIGHT;
        }

        #endregion


        #region Public Methods
        /// <summary>
        /// Extracts an image from raw save data.
        /// </summary>
        /// <param name="saveData">The raw save file data.</param>
        /// <returns>A Bitmap object containing the extracted image.</returns>
        // public Bitmap ExtractImage(byte[] saveData, int offset = 0x200, int width = 0, int height = 0, PixelFormat pixelFormat = PixelFormat.Format24bppRgb)
        public static Bitmap ExtractImage(byte[] saveData)
        {
            int requiredLength = Constants.THUMBNAIL_PIXEL_OFFSET + Constants.THUMBNAIL_WIDTH * Constants.THUMBNAIL_HEIGHT * 2; // Assuming 2 bytes per pixel for RGB565
            if (saveData.Length < requiredLength)
            {
                throw new InvalidDataException("Save file is shorter than expected.");
            }

            Bitmap bitmap = new Bitmap(Constants.THUMBNAIL_WIDTH, Constants.THUMBNAIL_HEIGHT, PixelFormat.Format24bppRgb);

            int src = Constants.THUMBNAIL_PIXEL_OFFSET;
            for (int y = 0; y < Constants.THUMBNAIL_HEIGHT; y++)
            {
                for (int x = 0; x < Constants.THUMBNAIL_WIDTH; x++, src += 2)
                {
                    ushort pixelValue = (ushort)(saveData[src] | (saveData[src + 1] << 8));

                    // Convert RGB565 to RGB888
                    int r = ((pixelValue >> 11) & 0x1F) * 255 / 31;
                    int g = ((pixelValue >> 5) & 0x3F) * 255 / 63;
                    int b = (pixelValue & 0x1F) * 255 / 31;

                    bitmap.SetPixel(x, y, Color.FromArgb(r, g, b));
                }
            }

            return bitmap;
        }
        #endregion
    }
}
