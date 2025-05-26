# Summoner Save File Editor

A Windows Forms application for viewing and editing save files (.sav) for the classic RPG game Summoner. This tool provides a comprehensive interface for modifying character stats, inventory items, equipment, skills, and more.

## Features

- **Character Editing**
  - Modify stats for Joseph, Flece, Rosalind, and Jekhar
  - Adjust level, experience, and skill points
  - Change HP and AP values (current and maximum)
  - Customize equipment loadout
  - Level up character skills

- **Inventory Management**
  - Add or remove items
  - Modify item quantities and charges
  - Mass add all available items
  - Toggle item identification states
  - Adjust gold amount

- **Creature Modification**
  - View and edit all creatures in the save file
  - Adjust creature HP, AP, and level
  - Modify creature position data

- **General Save Data**
  - Edit save description
  - Modify game time
  - View save thumbnail image

## Requirements

- .NET 9.0 or higher
- Windows operating system

## Installation

1. Download the latest release from the [Releases](https://github.com/Troodon80/Summoner-Save-File-Editor/releases) page
2. Extract the ZIP file to your preferred location
3. Run `SummonerSaveFileEditor.exe`

## Usage

1. On first load, select your Summoner installation directory
2. Click "Open" to select a Summoner save file (.sav)
2. Navigate between tabs to edit different aspects of the save:
   - **Start**: Description, time, and thumbnail view
   - **Character tabs**: Edit stats, equipment, and skills for each character
   - **Inventory**: Manage items, quantities and charges, item identification, and gold
   - **Creatures**: Edit enemies and NPCs (Use with caution)
   - **Camera**: Adjust camera settings (Disabled until properly verified)
   - **Containers**: Edit containers; specifically, loot containers dropped by enemies, not other loot found in the world (even if the backpack/leather bag looks the same, they're controlled by some world/area state flags instead)
3. Make your desired changes
4. Click "Save" to write your changes to a new save file or overwrite an existing file (always make backups in either case!)

## Technical Details

This editor reads and writes the binary structure of Summoner save files, allowing precise modification while maintaining the integrity of the save file format. It includes features for parsing the game's resource files to provide accurate item and character data.

## Contributing

Contributions are welcome! Feel free to fork the repository and submit pull requests.

## Licence

[GPL-3.0](LICENSE)

---

*Note: This editor is a fan-made tool and is not affiliated with or endorsed by the original creators of Summoner.*
