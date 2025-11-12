namespace SummonerSaveFileEditor
{
    public static class Constants
    {
        public const uint CHAR_LENGTH = 384u;
        public const uint OTHER_LENGTH = 376u;

        public const int MAX_CHARS = 4;

        // Name hashes
        // I have no idea if these change depending on the language the game is in, but my guess is
        // that they probably do. These are only for English. I haven't tested any other languages.
        public const uint JOSEPH = 3922549381u;
        public const uint FLECE = 1519808046u;
        public const uint ROSALIND = 1027133455u;
        public const uint JEKHAR = 2427679853u;

        public const int THUMBNAIL_WIDTH = 201;               // Width of thumbnail in pixels
        public const int THUMBNAIL_HEIGHT = 151;              // Height of thumbnail in pixels

        // Offsets for the save file
        public const int TIME_OFFSET = 0x000000AC;
        public const int DESCRIPTION_OFFSET = 0x000000B0;
        public const int SECTION_SIZES_START = 0x000001B0;  // Offset header metadata
        public const int IMAGE_PIXEL_START = 0x00000200;     // Offset for thumbnail pixel data

        public const int INVENTORY_START = 0x000150E9;

        // I think I've narrowed this down to conversation data based on areas (probably area_dlg.tbl), but
        // I'm not sure what to do with it yet.
        public const int CONVO_DATA_START = 0x00017189;
        public const int ITEM_FLAG_START = 0x00026DF9;
        public const int CHARACTER_START = 0x00027667;
        public const int CAMERA_START = 0x00037EB3;
        public const int CONTAINER_START = 0x00037EDB;

        public const int QUEST_FLAGS_START = 0x0003978F;
        public const int LEVEL_ITEM_START = 0x000397A8;
        public const int CHECKSUM_START = 0x00039FAC;
        public const int AUTO_MAP_LABELS_START = 0x000406EB;
        public const int HOT_BUTTONS_START = 0x000420EF;

        // Despite labelling the constants above, I'm preserving everything after the CONT section for now.
        public const int POST_CONT_START = 0x0003978F;


        // Constants for container section
        public const int CONT_SECTION_SIZE = 6324;
        public const int CONT_HEADER_SIZE = 8;  // "CONT" + container count (4 bytes + 4 bytes)
        public const int CONTAINER_FIXED_SIZE = 17;  // Position (12 bytes) + content count (4 bytes) + flags (1 byte)
        public const int CONTAINER_ITEM_SIZE = 8;  // ReferenceId (4 bytes) + Quantity (2 bytes) + Charges (2 bytes)
        public const int GOLDPILE_SIZE = 20; // Position (12 bytes) + Amount (4 bytes) + Unknown (4 bytes)

    }
}
