# Summoner Save File Editor

This project provides a Windows Forms GUI save-game editor for Summoner (2001 PC), with comprehensive support for editing character stats, skills, equipment, inventory, and additional save-file fields beyond those handled by earlier publicly released editors.

## Features

- **Character Editing**
  - Modify stats for Joseph, Flece, Rosalind, Jekhar, and current Summon (as applicable)
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

- **Container Editing**
  - Modify the contents of existing containers which have been dropped by enemies

- **Quest Visibility**
  - Enable or disable quests' visibility (note: does not affect quest progress)

- **Level Items**
  - Enable or disable level items; or just use the list to check and see what you have or have not obtained
    - These are items in the world, usually quest related

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
   - **Character tabs**: Edit stats, equipment, skills, and location for each character (and Summon)
   - **Inventory**: Manage items, quantities and charges, item identification, and gold
   - **Creatures**: Edit enemies and NPCs (Use with caution)
   - **Camera**: Adjust camera settings (Disabled until properly verified)
   - **Containers**: Sacks dropped by enemies which contain items (not to be confused with large containers with an activation scripts)
   - **Quests**: Quest visibility display; whether or not they appear in the journal (note: disabling has no affect on actual quest progress)
   - **Level Items**: Items in the world, whether or not they've been collected/whether they're visible in the world; you cannot modify the actual items within these containers, as those items are set in TBL files. You could use this as a checklist to see what you're missing.
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
