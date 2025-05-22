namespace SummonerSaveFileEditor
{
    public static class Constants
    {
        // Name hashes
        // I have no idea if these change depending on the language the game is in, but my guess is
        // that they probably do. These are only for English. I haven't tested any other languages.
        public const uint JOSEPH = 3922549381u;
        public const uint FLECE = 1519808046u;
        public const uint ROSALIND = 1027133455u;
        public const uint JEKHAR = 2427679853u;

        // Offsets for the save file
        public const int TIME_OFFSET = 0x000000AC;
        public const int DESCRIPTION_OFFSET = 0x000000B0;
        public const int INVENTORY_START = 0x000150E9;

        // This one is weird, it doesn't seem related to inventory or items but falls between both.
        // I assume it's a string-hashed table related to different areas based on what I can see,
        // it looks over strings like "masad", "eleh", etc. and checks for a '_m1' suffix, but I
        // have no idea what this data is used for. For now, we'll read from this offset and keep
        // it intact.
        public const int POST_INVT_START = 0x00017189;
        public const int ITEM_FLAG_START = 0x00026DF9;
        public const int CHARACTER_START = 0x00027667;
        public const int CAMERA_START = 0x00037EB3;
        public const int CONT_START = 0x00037EDB;

        public const uint CHAR_LENGTH = 384u;
        public const uint OTHER_LENGTH = 376u;

        public const int MAX_CHARS = 4;

        #region Image Offsets
        // Thumbnail constants
        public const int THUMBNAIL_METADATA_OFFSET = 0x000001B0;  // Offset for thumbnail metadata
        public const int THUMBNAIL_PIXEL_OFFSET = 0x00000200;     // Offset for thumbnail pixel data
        public const int THUMBNAIL_WIDTH = 201;               // Width of thumbnail in pixels
        public const int THUMBNAIL_HEIGHT = 151;              // Height of thumbnail in pixels

        #endregion
    }
}
