using SummonerSaveFileEditor.Models;
using SummonerSaveFileEditor.Services;
using SummonerSaveFileEditor.ViewModels;
using System;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SummonerSaveFileEditor
{
    public partial class SummonerSaveFileEditor : Form
    {
        private SaveGameViewModel _saveGameViewModel = new();
        private List<InventoryItem> _knownItems;
        private List<EquipmentItem> _equipmentItems;
        private Dictionary<uint, string> _charnameList;

        private List<ItemFlagEntry> _itemFlags = new();
        private int _originalInventorySize = 0;

        // I hate that this hacky solution is needed, but Microsoft doesn't provide a better way to
        // handle this the IndexChanged event for ListView controls. It fires multiple times and
        // causes issues when trying to update the UI based on the selected item.
        private System.Windows.Forms.Timer _selectionTimer;
        private bool _initializedTimer = false;
        private void EnsureTimerInitialized()
        {
            if (!_initializedTimer)
            {
                _selectionTimer = new System.Windows.Forms.Timer();
                _selectionTimer.Interval = 50; // Short delay to let selection settle
                _selectionTimer.Tick += SelectionTimer_Tick;
                _initializedTimer = true;
            }
        }

        private readonly string[] _characterTabNames = { "Joseph", "Flece", "Rosalind", "Jekhar" };

        public SummonerSaveFileEditor()
        {
            InitializeComponent();
            EnsureTimerInitialized();
            tblCreatureEdit.Enabled = false;
            this.Load += async (_, __) =>
            {
                await LoadAllResourcesAsync();
                SettingsManager.ApplyWindowState(this);
                UpdateCharacterTabsState();
            };
            numTime.ValueChanged += (s, e) => UpdateTimeLabel();

            SetupEquipmentSlotLogic();

        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SettingsManager.SaveWindowState(this);
            base.OnFormClosing(e);
        }

        private void UpdateCreatureEditPanel()
        {
            bool hasCreatures = lvCreatureList.Items.Count > 0;
            bool hasSelection = lvCreatureList.SelectedItems.Count > 0;

            tblCreatureEdit.Enabled = hasCreatures && hasSelection;
        }

        private void UpdateTitleWithFileName(string filePath)
        {
            // Extract just the file name from the full path
            string fileName = Path.GetFileName(filePath);

            // Set the form title to include the filename in square brackets
            this.Text = $"Summoner Save File Editor - [{fileName}]";
        }

        private void ClearAllBindings(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                control.DataBindings.Clear();

                // Recurse for container controls like TabPages, Panels, GroupBoxes, etc.
                if (control.HasChildren)
                {
                    ClearAllBindings(control);
                }
            }
        }

        private void BindTimeAndDescription()
        {
            // Bind the description TextBox to the Description property
            txtDescription.DataBindings.Add(
                "Text",
                _saveGameViewModel,
                "Description",
                false,
                DataSourceUpdateMode.OnPropertyChanged
            );
            // Bind the time NumericUpDown to the GameTimeSeconds property
            // Using custom binding to handle float to decimal conversion
            var binding = new Binding("Value", _saveGameViewModel, "GameTimeSeconds", true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Format += (s, e) =>
            {
                if (e.Value is float f)
                    e.Value = (decimal)f;
            };
            binding.Parse += (s, e) =>
            {
                if (e.Value is decimal d)
                    e.Value = (float)d;
            };
            numTime.DataBindings.Add(binding);

            // Also update the formatted time display
            UpdateTimeLabel();
        }

        // Helper method to format and display the time
        private void UpdateTimeLabel()
        {
            if (_saveGameViewModel != null)
            {
                int totalSeconds = (int)_saveGameViewModel.GameTimeSeconds;
                // Convert to HH:mm:ss
                int hours = totalSeconds / 3600;
                int minutes = (totalSeconds % 3600) / 60;
                lblTime.Text = $"{(int)hours:D2}:{minutes:D2}";
            }
        }

        private void DisplayThumbnailImage()
        {
            if (_saveGameViewModel?.ImageThumbnail?.ImageBitmap != null)
            {
                try
                {
                    // Clean up previous image to prevent memory leaks
                    imgPreview.Image?.Dispose();

                    // Set the bitmap directly from the ImageThumbnail object
                    imgPreview.Image = new Bitmap(_saveGameViewModel.ImageThumbnail.ImageBitmap);

                    // Optional: Set the display mode
                    imgPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error displaying thumbnail: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BindCharacterPanels()
        {
            if (_saveGameViewModel.Joseph != null)
            {
                numJoLevel.DataBindings.Add("Text", _saveGameViewModel.Joseph, "Level");
                numJoExperience.DataBindings.Add("Text", _saveGameViewModel.Joseph, "Experience");
                numJoSkill.DataBindings.Add("Text", _saveGameViewModel.Joseph, "SkillPoints");


                numJoBaseHP.DataBindings.Add("Text", _saveGameViewModel.Joseph, "BaseHP");
                numJoCurrentHP.DataBindings.Add("Text", _saveGameViewModel.Joseph, "CurrentHP");
                numJoBaseAP.DataBindings.Add("Text", _saveGameViewModel.Joseph, "BaseAP");
                numJoCurrentAP.DataBindings.Add("Text", _saveGameViewModel.Joseph, "CurrentAP");

                numJoSpeed.DataBindings.Add("Text", _saveGameViewModel.Joseph, "Speed");
            }

            if (_saveGameViewModel.Flece != null)
            {
                numFlLevel.DataBindings.Add("Text", _saveGameViewModel.Flece, "Level");
                numFlExperience.DataBindings.Add("Text", _saveGameViewModel.Flece, "Experience");
                numFlSkill.DataBindings.Add("Text", _saveGameViewModel.Flece, "SkillPoints");

                numFlBaseHP.DataBindings.Add("Text", _saveGameViewModel.Flece, "BaseHP");
                numFlCurrentHP.DataBindings.Add("Text", _saveGameViewModel.Flece, "CurrentHP");
                numFlBaseAP.DataBindings.Add("Text", _saveGameViewModel.Flece, "BaseAP");
                numFlCurrentAP.DataBindings.Add("Text", _saveGameViewModel.Flece, "CurrentAP");

                numFlSpeed.DataBindings.Add("Text", _saveGameViewModel.Flece, "Speed");

            }

            if (_saveGameViewModel.Rosalind != null)
            {
                numRoLevel.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "Level");
                numRoExperience.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "Experience");
                numRoSkill.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "SkillPoints");

                numRoBaseHP.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "BaseHP");
                numRoCurrentHP.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "CurrentHP");
                numRoBaseAP.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "BaseAP");
                numRoCurrentAP.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "CurrentAP");

                numRoSpeed.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "Speed");
            }

            if (_saveGameViewModel.Jekhar != null)
            {
                numJeLevel.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "Level");
                numJeExperience.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "Experience");
                numJeSkill.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "SkillPoints");

                numJeBaseHP.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "BaseHP");
                numJeCurrentHP.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "CurrentHP");
                numJeBaseAP.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "BaseAP");
                numJeCurrentAP.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "CurrentAP");

                numJeSpeed.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "Speed");
            }
        }

        private void BindCharacterSkillsAndEquipment()
        {
            // Setup all the equipment combo boxes
            SetupEquipmentComboBoxes(_saveGameViewModel.Joseph,
                cbJoAmulet, cbJoRing1, cbJoRing2, cbJoGauntlets, cbJoBoots,
                cbJoWeapon, cbJoShield, cbJoTorso, cbJoLeggings);

            SetupEquipmentComboBoxes(_saveGameViewModel.Flece,
                cbFlAmulet, cbFlRing1, cbFlRing2, cbFlGauntlets, cbFlBoots,
                cbFlWeapon, cbFlShield, cbFlTorso, cbFlLeggings);

            SetupEquipmentComboBoxes(_saveGameViewModel.Rosalind,
                cbRoAmulet, cbRoRing1, cbRoRing2, cbRoGauntlets, cbRoBoots,
                cbRoWeapon, cbRoShield, cbRoTorso, cbRoLeggings);

            SetupEquipmentComboBoxes(_saveGameViewModel.Jekhar,
                cbJeAmulet, cbJeRing1, cbJeRing2, cbJeGauntlets, cbJeBoots,
                cbJeWeapon, cbJeShield, cbJeTorso, cbJeLeggings);
        }

        private void SetupEquipmentComboBoxes(CharacterViewModel character,
    ComboBox amulet, ComboBox ring1, ComboBox ring2, ComboBox gauntlets,
    ComboBox boots, ComboBox weapon, ComboBox shield, ComboBox torso,
    ComboBox leggings)
        {
            if (character == null) return;

            // Set initial values
            SetComboBoxSelection(amulet, character.AmuletId);
            SetComboBoxSelection(ring1, character.Ring1Id);
            SetComboBoxSelection(ring2, character.Ring2Id);
            SetComboBoxSelection(gauntlets, character.GauntletsId);
            SetComboBoxSelection(boots, character.BootsId);
            SetComboBoxSelection(weapon, character.WeaponId);
            SetComboBoxSelection(shield, character.ShieldId);
            SetComboBoxSelection(torso, character.TorsoId);
            SetComboBoxSelection(leggings, character.LeggingsId);

            // Attach event handlers
            amulet.SelectedIndexChanged += (s, e) => UpdateEquipment(amulet, character, EquipmentSlot.Amulet);
            ring1.SelectedIndexChanged += (s, e) => UpdateEquipment(ring1, character, EquipmentSlot.Ring1);
            ring2.SelectedIndexChanged += (s, e) => UpdateEquipment(ring2, character, EquipmentSlot.Ring2);
            gauntlets.SelectedIndexChanged += (s, e) => UpdateEquipment(gauntlets, character, EquipmentSlot.Gauntlets);
            boots.SelectedIndexChanged += (s, e) => UpdateEquipment(boots, character, EquipmentSlot.Boots);
            weapon.SelectedIndexChanged += (s, e) => UpdateEquipment(weapon, character, EquipmentSlot.Weapon);
            shield.SelectedIndexChanged += (s, e) => UpdateEquipment(shield, character, EquipmentSlot.Shield);
            torso.SelectedIndexChanged += (s, e) => UpdateEquipment(torso, character, EquipmentSlot.Torso);
            leggings.SelectedIndexChanged += (s, e) => UpdateEquipment(leggings, character, EquipmentSlot.Leggings);
        }

        private void SetComboBoxSelection(ComboBox comboBox, int itemId)
        {
            if (comboBox.Items.Count == 0) return;

            // Default to "None" (first item)
            comboBox.SelectedIndex = 0;

            // Find the matching item
            for (int i = 0; i < comboBox.Items.Count; i++)
            {
                if (comboBox.Items[i] is EquipmentItem item && item.Index == itemId)
                {
                    comboBox.SelectedIndex = i;
                    return;
                }
            }
        }

        private void UpdateEquipment(ComboBox comboBox, CharacterViewModel character, EquipmentSlot slot)
        {
            if (comboBox.SelectedItem is EquipmentItem item)
            {
                // -1 represents "None" selection
                int itemIndex = item.Index;

                switch (slot)
                {
                    case EquipmentSlot.Amulet:
                        character.AmuletId = itemIndex;
                        break;
                    case EquipmentSlot.Ring1:
                        character.Ring1Id = itemIndex;
                        break;
                    case EquipmentSlot.Ring2:
                        character.Ring2Id = itemIndex;
                        break;
                    case EquipmentSlot.Gauntlets:
                        character.GauntletsId = itemIndex;
                        break;
                    case EquipmentSlot.Boots:
                        character.BootsId = itemIndex;
                        break;
                    case EquipmentSlot.Weapon:
                        character.WeaponId = itemIndex;
                        break;
                    case EquipmentSlot.Shield:
                        character.ShieldId = itemIndex;
                        break;
                    case EquipmentSlot.Torso:
                        character.TorsoId = itemIndex;
                        break;
                    case EquipmentSlot.Leggings:
                        character.LeggingsId = itemIndex;
                        break;
                }
                if (itemIndex != -1)
                    _knownItems[itemIndex].IdentifiedBit = false;

            }
        }

        private void BindSkillLists()
        {
            if (_saveGameViewModel.Joseph != null)
            {
                lvJosephSkills.Items.Clear();
                foreach (var skill in _saveGameViewModel.Joseph.Skills)
                {
                    lvJosephSkills.Items.Add(new ListViewItem(new[]
                    {
                        skill.Name,
                        (skill.Value / 10).ToString()
                    })
                    { Tag = skill });
                }
            }

            if (_saveGameViewModel.Flece != null)
            {
                lvFleceSkills.Items.Clear();
                foreach (var skill in _saveGameViewModel.Flece.Skills)
                {
                    lvFleceSkills.Items.Add(new ListViewItem(new[]
                    {
                        skill.Name,
                        (skill.Value / 10).ToString()
                    })
                    { Tag = skill });
                }
            }

            if (_saveGameViewModel.Rosalind != null)
            {
                lvRosalindSkills.Items.Clear();
                foreach (var skill in _saveGameViewModel.Rosalind.Skills)
                {
                    lvRosalindSkills.Items.Add(new ListViewItem(new[]
                    {
                        skill.Name,
                        (skill.Value / 10).ToString()
                    })
                    { Tag = skill });
                }
            }

            if (_saveGameViewModel.Jekhar != null)
            {
                lvJekharSkills.Items.Clear();
                foreach (var skill in _saveGameViewModel.Jekhar.Skills)
                {
                    lvJekharSkills.Items.Add(new ListViewItem(new[]
                    {
                        skill.Name,
                        (skill.Value / 10).ToString()
                    })
                    { Tag = skill });
                }
            }
        }

        private void PopulateCreatureList()
        {
            lvCreatureList.Items.Clear();
            foreach (var creature in _saveGameViewModel.Creatures)
            {
                string name = "Unknown";
                if (_charnameList != null && _charnameList.TryGetValue(creature.Header.creatureId, out string characterName))
                {
                    name = characterName;
                }

                // Create type string representation
                string typeString = GetCreatureTypeString(creature.Header.creatureType);

                // Create ListViewItem with Hash as first column
                var item = new ListViewItem(creature.Header.creatureId.ToString())
                {
                    Tag = creature
                };

                // Add the other columns as subitems
                item.SubItems.Add(name);
                item.SubItems.Add(creature.Header.creatureType.ToString());
                item.SubItems.Add(typeString);
                lvCreatureList.Items.Add(item);
            }

            // Update the edit panel state after populating the list
            UpdateCreatureEditPanel();
        }

        // Helper method to convert creature type to string description
        private string GetCreatureTypeString(int creatureType)
        {
            // You could expand this with more type mappings if you know them
            return creatureType switch
            {
                4 => "NPC",
                5 => "Hostile",
                6 => "Monster",
                7 => "Character",
                // Add more mappings as needed
                9 => "Scripted",
                _ => $"Type {creatureType}"
            };
        }

        private void EnableDisableControls(Control container, bool enable)
        {
            foreach (Control control in container.Controls)
            {
                // Skip certain controls if needed (like headers, labels, etc.)
                // if (control is Label) continue;

                control.Enabled = enable;

                // Recursive call for container controls
                if (control.HasChildren)
                {
                    EnableDisableControls(control, enable);
                }
            }
        }

        private void lvCreatureList_SelectedIndexChanged(object sender, EventArgs e)
        {
            _selectionTimer.Stop();
            _selectionTimer.Start();
        }

        private void SelectionTimer_Tick(object sender, EventArgs e)
        {
            // Stop the timer
            _selectionTimer.Stop();

            UpdateCreatureEditPanel();

            // Now update UI with final selection state
            bool hasSelection = lvCreatureList.SelectedItems.Count > 0;

            // First check if we need to make any UI changes at all
            if (tblCreatureEdit.Enabled != hasSelection)
            {
                // Only update enabled state if it actually needs to change
                tblCreatureEdit.Enabled = hasSelection;
            }

            if (hasSelection && lvCreatureList.SelectedItems[0].Tag is Creature creature)
            {
                // Disable event handlers while setting values
                numCreatureLevel.ValueChanged -= CreaturePropertyChanged;
                numCreatureBaseHP.ValueChanged -= CreaturePropertyChanged;
                numCreatureCurrentHP.ValueChanged -= CreaturePropertyChanged;
                numCreatureBaseAP.ValueChanged -= CreaturePropertyChanged;
                numCreatureCurrentAP.ValueChanged -= CreaturePropertyChanged;

                // Populate controls with creature data
                numCreatureLevel.Value = creature.CreatureBlock.wCreatureLevel;
                numCreatureBaseHP.Value = (decimal)creature.CreatureBlock.fBaseHP;
                numCreatureCurrentHP.Value = (decimal)creature.CreatureBlock.fCurrentHP;
                numCreatureBaseAP.Value = creature.CreatureBlock.wBaseAP;
                numCreatureCurrentAP.Value = creature.CreatureBlock.wCurrentAP;

                // Re-enable event handlers
                numCreatureLevel.ValueChanged += CreaturePropertyChanged;
                numCreatureBaseHP.ValueChanged += CreaturePropertyChanged;
                numCreatureCurrentHP.ValueChanged += CreaturePropertyChanged;
                numCreatureBaseAP.ValueChanged += CreaturePropertyChanged;
                numCreatureCurrentAP.ValueChanged += CreaturePropertyChanged;
            }
        }

        private void CreaturePropertyChanged(object sender, EventArgs e)
        {
            if (lvCreatureList.SelectedItems.Count == 0) return;

            if (lvCreatureList.SelectedItems[0].Tag is Creature creature)
            {
                // Create a temporary copy to modify the struct
                var creatureBlock = creature.CreatureBlock;

                // Update creature properties based on controls
                creatureBlock.wCreatureLevel = (short)numCreatureLevel.Value;
                creatureBlock.fBaseHP = (float)numCreatureBaseHP.Value;
                creatureBlock.fCurrentHP = (float)numCreatureCurrentHP.Value;
                creatureBlock.wBaseAP = (short)numCreatureBaseAP.Value;
                creatureBlock.wCurrentAP = (short)numCreatureCurrentAP.Value;

                // Assign back the modified struct
                creature.CreatureBlock = creatureBlock;

                // Update the original creature in the list
                lvCreatureList.SelectedItems[0].Tag = creature;

                string name = "Unknown";
                if (_charnameList != null && _charnameList.TryGetValue(creature.Header.creatureId, out string characterName))
                {
                    name = characterName;
                }                // Update the list view display if needed
                lvCreatureList.SelectedItems[0].SubItems[1].Text = name;
            }
        }

        private void BindFloat(NumericUpDown nud, object source, string property)
        {
            var binding = new Binding("Value", source, property, true, DataSourceUpdateMode.OnPropertyChanged);
            binding.Format += (s, e) =>
            {
                if (e.Value is float f)
                    e.Value = (decimal)f;
            };
            binding.Parse += (s, e) =>
            {
                try
                {
                    if (e.Value is decimal d)
                        e.Value = (float)d;
                }
                catch (Exception ex)
                {
                    // Log error but prevent exception from breaking the binding
                    Debug.WriteLine($"Error parsing value: {ex.Message}");
                    e.Value = 0f; // Default value
                }
            };

            // Remove any existing bindings first
            nud.DataBindings.Clear();

            // Add the binding
            nud.DataBindings.Add(binding);

            // Add leave handler to ensure focus can move away
            nud.Leave += (s, e) =>
            {
                // Replace the inaccessible ValidateEditText() with a workaround
                if (nud.Focused)
                {
                    try
                    {
                        nud.Value = nud.Value; // Trigger validation by reassigning the value
                    }
                    catch (Exception ex)
                    {
                        Debug.WriteLine($"Error during validation: {ex.Message}");
                    }
                }
            };
        }

        private void PopulateContainersList()
        {
            lvContainers.Items.Clear();
            foreach (var container in _saveGameViewModel.Containers)
            {
                // Create ListViewItem with container ID as first column
                var item = new ListViewItem($"({container.Position.X:F1}, {container.Position.Y:F1}, {container.Position.Z:F1})")
                {
                    Tag = container
                };

                // Add position and item count as subitems
                item.SubItems.Add(container.IsLocked ? "Locked" : "Unlocked");

                lvContainers.Items.Add(item);
            }
            UpdateContainerCountLabel();
        }

        private void DisplayContainerContents()
        {
            lvContainerContent.Items.Clear();

            if (lvContainers.SelectedItems.Count == 0)
                return;

            if (lvContainers.SelectedItems[0].Tag is Container container)
            {
                foreach (var content in container.Contents)
                {
                    string itemName = "Unknown Item";

                    // Try to find the item name in the known items list
                    var equipmentItem = _equipmentItems?.FirstOrDefault(i => i.Index == content.ReferenceId);
                    if (equipmentItem != null)
                    {
                        itemName = equipmentItem.Name;
                    }

                    var item = new ListViewItem(itemName)
                    {
                        Tag = content
                    };

                    item.SubItems.Add(content.Quantity.ToString());
                    item.SubItems.Add(content.Charges.ToString());

                    lvContainerContent.Items.Add(item);
                }
            }
        }

        private void BindCameraControls()
        {
            if (_saveGameViewModel.Camera == null) return;

            numCameraUnknown.DataBindings.Add("Value", _saveGameViewModel.Camera, "Unknown", true, DataSourceUpdateMode.OnPropertyChanged);

            //BindFloat(numericUpDown1, _saveGameViewModel.Camera, "Unknown");
            numCameraFoV.DataBindings.Add("Value", _saveGameViewModel.Camera, "FieldOfView", true, DataSourceUpdateMode.OnPropertyChanged);

            //BindFloat(numericUpDown2, _saveGameViewModel.Camera, "FieldOfView");

            BindFloat(numCameraFoV, _saveGameViewModel.Camera, "FieldOfView");
            BindFloat(numCameraPitch, _saveGameViewModel.Camera, "Pitch");
            BindFloat(numCameraYaw, _saveGameViewModel.Camera, "Yaw");
            BindFloat(numCameraZoom, _saveGameViewModel.Camera, "Zoom");
            BindFloat(numCameraPosX, _saveGameViewModel.Camera, "PositionX");
            BindFloat(numCameraPosY, _saveGameViewModel.Camera, "PositionY");
            BindFloat(numCameraPosZ, _saveGameViewModel.Camera, "PositionZ");

            numCameraMode.DataBindings.Add("Value", _saveGameViewModel.Camera, "CameraMode", true, DataSourceUpdateMode.OnPropertyChanged);

            //BindFloat(numericUpDown9, _saveGameViewModel.Camera, "CameraMode");

            //numericUpDown1.DataBindings.Add("Value", _saveGameViewModel.Camera, "Unknown");
            //numericUpDown2.DataBindings.Add("Value", _saveGameViewModel.Camera, "FieldOfView");
            //numericUpDown3.DataBindings.Add("Value", _saveGameViewModel.Camera, "Pitch");
            //numericUpDown4.DataBindings.Add("Value", _saveGameViewModel.Camera, "Yaw");
            //numericUpDown5.DataBindings.Add("Value", _saveGameViewModel.Camera, "Zoom");
            //numericUpDown6.DataBindings.Add("Value", _saveGameViewModel.Camera, "PositionX");
            //numericUpDown7.DataBindings.Add("Value", _saveGameViewModel.Camera, "PositionY");
            //numericUpDown8.DataBindings.Add("Value", _saveGameViewModel.Camera, "PositionZ");
            //numericUpDown9.DataBindings.Add("Value", _saveGameViewModel.Camera, "CameraMode");
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string initialDirectory = null;

            try
            {
                // First try to use the last folder the user accessed
                string lastFolder = SettingsManager.GetLastFolder();
                if (lastFolder != null)
                {
                    initialDirectory = lastFolder;
                }
                // If no last folder, check for game's savegames folder
                else
                {
                    string gameInstallPath = ResourceLoader.GetGameInstallationPath();
                    if (!string.IsNullOrEmpty(gameInstallPath))
                    {
                        string saveGamesPath = Path.Combine(gameInstallPath, "savegame");
                        if (Directory.Exists(saveGamesPath))
                        {
                            initialDirectory = saveGamesPath;
                        }
                        else
                        {
                            // Fallback to game install path if savegames folder doesn't exist
                            initialDirectory = gameInstallPath;
                        }
                    }
                    else
                    {
                        // Final fallback
                        initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    }
                }

                //using var dialog = new OpenFileDialog
                //{
                //    Filter = "Summoner Save Files (*.sav)|*.sav",
                //    Title = "Open Save File",
                //    InitialDirectory = initialDirectory
                //};

                //if (dialog.ShowDialog() == DialogResult.OK)
                //{
                using (var browser = new SaveGameBrowserForm(initialDirectory))
                {
                    if (browser.ShowDialog() == DialogResult.OK)
                    {
                        string selectedFilePath = browser.SelectedFilePath;

                        UpdateTitleWithFileName(selectedFilePath);

                        using var reader = new BinaryReader(File.OpenRead(selectedFilePath));
                        _saveGameViewModel = SaveFileService.ReadSaveFile(reader, _knownItems, out _originalInventorySize);
                        SaveFileService.ReadSaveGameHeader(reader, _saveGameViewModel);
                        SaveFileService.ReadTimeAndDescription(reader, out float seconds, out string desc);
                        SaveFileService.ReadPostThumbnailData(reader, _saveGameViewModel);

                        SaveFileService.ReadItemFlags(reader, _knownItems, out _itemFlags);
                        SaveFileService.ReadAreaBlockData(reader, _saveGameViewModel);
                        SaveFileService.ReadCharactersAndCreatures(reader, _saveGameViewModel);
                        SaveFileService.ReadCamera(reader, _saveGameViewModel);
                        SaveFileService.ReadContainerSection(reader, _saveGameViewModel);
                        SaveFileService.ReadPostContainerData(reader, _saveGameViewModel);

                        _saveGameViewModel.GameTimeSeconds = seconds;
                        _saveGameViewModel.Description = desc;

                        PopulateEquipmentComboBoxes();
                        PopulateGameItemsList();
                        PopulateContainersList();
                        PopulateContainerGameItemsList();
                        ClearAllBindings(this);

                        BindTimeAndDescription();
                        BindInventoryControls();
                        BindCharacterPanels();
                        BindCharacterSkillsAndEquipment();
                        BindSkillLists();
                        PopulateCreatureList();
                        BindCameraControls();

                        UpdateCharacterTabsState();

                        DisplayThumbnailImage();

                        SettingsManager.SaveLastFolder(Path.GetDirectoryName(selectedFilePath));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void WriteToPreallocatedFile(string filePath, long minimumLength, Action<BinaryWriter> writeAction)
        {
            using (var fs = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                if (fs.Length == 0)
                    fs.SetLength(minimumLength);     // Pre-allocate the file size

                // Reset position to beginning of file
                fs.Position = 0;

                // Write the actual data
                using (var writer = new BinaryWriter(fs))
                {
                    writeAction(writer);
                }
            }
        }

        private void saveChangesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool isLoaded = SaveFileExtensions.IsLoaded(_saveGameViewModel);
            if (!isLoaded)
            {
                MessageBox.Show("No save file loaded. Please open a save file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Try to determine the best initial directory
            string initialDirectory = null;

            // First try to use the last folder the user accessed
            string lastFolder = SettingsManager.GetLastFolder();
            if (lastFolder != null)
            {
                initialDirectory = lastFolder;
            }
            // If no last folder, check for game's savegames folder
            else
            {
                string gameInstallPath = ResourceLoader.GetGameInstallationPath();
                if (!string.IsNullOrEmpty(gameInstallPath))
                {
                    string saveGamesPath = Path.Combine(gameInstallPath, "savegame");
                    if (Directory.Exists(saveGamesPath))
                    {
                        initialDirectory = saveGamesPath;
                    }
                    else
                    {
                        // Fallback to game install path if savegames folder doesn't exist
                        initialDirectory = gameInstallPath;
                    }
                }
                else
                {
                    // Final fallback
                    initialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                }
            }

            using (var browser = new SaveGameBrowserForm(initialDirectory, true))
            {
                if (browser.ShowDialog() == DialogResult.OK)
                {
                    string selectedFilePath = browser.SelectedFilePath;

                    foreach (var flag in _itemFlags)
                    {
                        // Find matching item in _knownItems
                        var knownItem = _knownItems.FirstOrDefault(item => item.Hash == flag.Hash);
                        if (knownItem != null)
                        {
                            flag.IdentifiedBit = knownItem.IdentifiedBit;
                        }
                    }

                    WriteToPreallocatedFile(selectedFilePath, 270755, writer =>
                    {
                        SaveFileService.WriteSaveFile(writer, _saveGameViewModel, _knownItems, _originalInventorySize);
                        SaveFileService.WriteSaveGameHeader(writer, _saveGameViewModel);
                        //SaveFileService.WriteTimeAndDescription(writer, _saveGameViewModel.GameTimeSeconds, _saveGameViewModel.Description);
                        SaveFileService.WritePostThumbnailData(writer, _saveGameViewModel);

                        SaveFileService.WriteItemFlags(writer, _itemFlags);
                        SaveFileService.WriteAreaBlockData(writer, _saveGameViewModel);

                        SaveFileService.WriteCharactersAndCreatures(writer, _saveGameViewModel);
                        SaveFileService.WriteCamera(writer, _saveGameViewModel);
                        SaveFileService.WriteContainerSection(writer, _saveGameViewModel);
                        SaveFileService.WritePostContainerData(writer, _saveGameViewModel);

                    });

                    SettingsManager.SaveLastFolder(Path.GetDirectoryName(selectedFilePath));
                    MessageBox.Show("Save completed successfully.", "Save File", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Summoner Save Editor\nVersion {Application.ProductVersion}", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SetupEquipmentSlotLogic()
        {
            // Setup event handlers for all character equipment combo boxes

            // Joseph
            cbJoWeapon.SelectedIndexChanged += (sender, e) => CheckWeaponAndUpdateShield(cbJoWeapon, cbJoShield);
            cbJoTorso.SelectedIndexChanged += (sender, e) => CheckTorsoAndUpdateLeggings(cbJoTorso, cbJoLeggings);

            // Flece
            cbFlWeapon.SelectedIndexChanged += (sender, e) => CheckWeaponAndUpdateShield(cbFlWeapon, cbFlShield);
            cbFlTorso.SelectedIndexChanged += (sender, e) => CheckTorsoAndUpdateLeggings(cbFlTorso, cbFlLeggings);

            // Rosalind
            cbRoWeapon.SelectedIndexChanged += (sender, e) => CheckWeaponAndUpdateShield(cbRoWeapon, cbRoShield);
            cbRoTorso.SelectedIndexChanged += (sender, e) => CheckTorsoAndUpdateLeggings(cbRoTorso, cbRoLeggings);

            // Jekhar
            cbJeWeapon.SelectedIndexChanged += (sender, e) => CheckWeaponAndUpdateShield(cbJeWeapon, cbJeShield);
            cbJeTorso.SelectedIndexChanged += (sender, e) => CheckTorsoAndUpdateLeggings(cbJeTorso, cbJeLeggings);
        }

        private void CheckWeaponAndUpdateShield(ComboBox weaponComboBox, ComboBox shieldComboBox)
        {
            if (weaponComboBox.SelectedItem == null)
                return;

            var selectedWeapon = weaponComboBox.SelectedItem as EquipmentItem;
            if (selectedWeapon != null)
            {
                // Check if weapon is two-handed based on Category
                bool isTwoHanded = selectedWeapon.DoubleSlot;

                // Disable shield if two-handed weapon is equipped
                shieldComboBox.Enabled = !isTwoHanded;

                // If shield is being disabled and it has an item selected, clear it
                if (isTwoHanded && shieldComboBox.SelectedIndex >= 0)
                {
                    shieldComboBox.SelectedIndex = 0;
                }
            }
        }

        private void CheckTorsoAndUpdateLeggings(ComboBox torsoComboBox, ComboBox leggingsComboBox)
        {
            if (torsoComboBox.SelectedItem == null)
                return;

            var selectedTorso = torsoComboBox.SelectedItem as EquipmentItem;
            if (selectedTorso != null)
            {
                // Use the DoubleSlot property to determine if it takes up both slots
                bool isDoubleSlot = selectedTorso.DoubleSlot;

                // Disable leggings if torso is double-slot
                leggingsComboBox.Enabled = !isDoubleSlot;

                // If leggings is being disabled and it has an item selected, clear it
                if (isDoubleSlot && leggingsComboBox.SelectedIndex >= 0)
                {
                    leggingsComboBox.SelectedIndex = 0;
                }
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            openFileToolStripMenuItem_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            saveChangesToolStripMenuItem_Click(sender, e);
        }

        private void BindInventoryControls()
        {
            lvInventory.Items.Clear();

            numGold.DataBindings.Add("Value", _saveGameViewModel, "Gold", true, DataSourceUpdateMode.OnPropertyChanged);

            foreach (var item in _saveGameViewModel.Inventory)
            {
                var listViewItem = item.GetInventoryListViewItem();
                listViewItem.Tag = item; // Store reference to the item
                lvInventory.Items.Add(listViewItem);
            }
        }

        private async Task LoadAllResourcesAsync()
        {
            try
            {
                var result = await ResourceLoader.LoadResourcesAsync();
                _knownItems = result.inventoryItems;
                _equipmentItems = result.equipmentItems;
                _charnameList = result.characterNames;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load resources: {ex.Message}");
            }
        }

        private void PopulateGameItemsList()
        {
            if (_knownItems == null || _knownItems.Count == 0)
                return;

            lvGameItems.Items.Clear();

            //foreach (var item in _knownItems.OrderBy(i => i.Category).ThenBy(i => i.Name))
            foreach (var item in _knownItems.OrderBy(i => i.Name))
            {
                var viewModel = new InventoryItemViewModel(item);

                // Add to the save game's inventory collection
                //_saveGameViewModel.Inventory.Add(viewModel);

                // Add to the ListView
                var listViewItem = viewModel.GetGameItemListViewItem();
                listViewItem.Tag = viewModel.Model;
                lvGameItems.Items.Add(listViewItem);
            }
        }

        private void PopulateEquipmentComboBoxes()
        {
            // Define default "None" item
            EquipmentItem noItem = new()
            {
                Name = "None",
                Category = "None",
                Index = -1
            };

            foreach (var combo in GetAllEquipmentComboBoxes())
                combo.Items.Clear();
            // Add to all ComboBoxes
            foreach (var combo in GetAllEquipmentComboBoxes())
                combo.Items.Add(noItem);

            foreach (var item in _equipmentItems)
            {
                Usability use = item.GetUsability();

                switch (item.Category)
                {
                    case "Necklace":
                        if (use.HasFlag(Usability.Joseph)) cbJoAmulet.Items.Add(item);
                        if (use.HasFlag(Usability.Flece)) cbFlAmulet.Items.Add(item);
                        if (use.HasFlag(Usability.Rosalind)) cbRoAmulet.Items.Add(item);
                        if (use.HasFlag(Usability.Jekhar)) cbJeAmulet.Items.Add(item);
                        break;

                    case "Ring":
                        if (use.HasFlag(Usability.Joseph)) { cbJoRing1.Items.Add(item); cbJoRing2.Items.Add(item); }
                        if (use.HasFlag(Usability.Flece)) { cbFlRing1.Items.Add(item); cbFlRing2.Items.Add(item); }
                        if (use.HasFlag(Usability.Rosalind)) { cbRoRing1.Items.Add(item); cbRoRing2.Items.Add(item); }
                        if (use.HasFlag(Usability.Jekhar)) { cbJeRing1.Items.Add(item); cbJeRing2.Items.Add(item); }
                        break;

                    case "Gauntlets":
                        if (use.HasFlag(Usability.Joseph)) cbJoGauntlets.Items.Add(item);
                        if (use.HasFlag(Usability.Flece)) cbFlGauntlets.Items.Add(item);
                        if (use.HasFlag(Usability.Rosalind)) cbRoGauntlets.Items.Add(item);
                        if (use.HasFlag(Usability.Jekhar)) cbJeGauntlets.Items.Add(item);
                        break;

                    case "Boots":
                        if (use.HasFlag(Usability.Joseph)) cbJoBoots.Items.Add(item);
                        if (use.HasFlag(Usability.Flece)) cbFlBoots.Items.Add(item);
                        if (use.HasFlag(Usability.Rosalind)) cbRoBoots.Items.Add(item);
                        if (use.HasFlag(Usability.Jekhar)) cbJeBoots.Items.Add(item);
                        break;

                    case "Axe":
                    case "Blunt":
                    case "Bow":
                    case "Staff":
                    case "Polearm":
                    case "Sword":
                    case "NPC Weapon":
                    case "Dagger":
                    case "Prop":
                        if (use.HasFlag(Usability.Joseph)) cbJoWeapon.Items.Add(item);
                        if (use.HasFlag(Usability.Flece)) cbFlWeapon.Items.Add(item);
                        if (use.HasFlag(Usability.Rosalind)) cbRoWeapon.Items.Add(item);
                        if (use.HasFlag(Usability.Jekhar)) cbJeWeapon.Items.Add(item);
                        break;

                    case "Shield":
                        if (use.HasFlag(Usability.Joseph)) cbJoShield.Items.Add(item);
                        if (use.HasFlag(Usability.Flece)) cbFlShield.Items.Add(item);
                        if (use.HasFlag(Usability.Rosalind)) cbRoShield.Items.Add(item);
                        if (use.HasFlag(Usability.Jekhar)) cbJeShield.Items.Add(item);
                        break;

                    case "Torso":
                        if (use.HasFlag(Usability.Joseph)) cbJoTorso.Items.Add(item);
                        if (use.HasFlag(Usability.Flece)) cbFlTorso.Items.Add(item);
                        if (use.HasFlag(Usability.Rosalind)) cbRoTorso.Items.Add(item);
                        if (use.HasFlag(Usability.Jekhar)) cbJeTorso.Items.Add(item);
                        break;

                    case "Leggings":
                        if (use.HasFlag(Usability.Joseph)) cbJoLeggings.Items.Add(item);
                        if (use.HasFlag(Usability.Flece)) cbFlLeggings.Items.Add(item);
                        if (use.HasFlag(Usability.Rosalind)) cbRoLeggings.Items.Add(item);
                        if (use.HasFlag(Usability.Jekhar)) cbJeLeggings.Items.Add(item);
                        break;
                }
            }
        }

        private void PopulateContainerGameItemsList()
        {
            lvContainerGameItems.Items.Clear();

            if (_equipmentItems == null || _equipmentItems.Count == 0)
                return;

            foreach (var item in _equipmentItems.OrderBy(i => i.Name))
            {
                var listViewItem = new ListViewItem(item.Name)
                {
                    Tag = item
                };

                listViewItem.SubItems.Add(item.Category);

                lvContainerGameItems.Items.Add(listViewItem);
            }
        }

        private void lvContainers_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayContainerContents();

            if (lvContainers.SelectedItems.Count > 0 && lvContainers.SelectedItems[0].Tag is Container container)
            {
                UpdateContainerPositionControls(container);
                UpdateContainerItemsLabel(container);
            }
        }
        private void UpdateContainerPositionControls(Container container)
        {
            if (container != null)
            {
                numContainerPosX.Value = (decimal)container.Position.X;
                numContainerPosY.Value = (decimal)container.Position.Y;
                numContainerPosZ.Value = (decimal)container.Position.Z;
            }
        }

        private void btnAddContainer_Click(object sender, EventArgs e)
        {
            // Create a new container with default position
            var newContainer = new Container
            {
                Position = new Vector3(0, 0, 0),
                ContentCount = 0,
                Flags = 0 // Not locked by default
            };

            // Add to the model
            _saveGameViewModel.Containers.Add(newContainer);

            // Add to the ListView
            var item = new ListViewItem($"({newContainer.Position.X:F1}, {newContainer.Position.Y:F1}, {newContainer.Position.Z:F1})")
            {
                Tag = newContainer
            };
            item.SubItems.Add(newContainer.IsLocked ? "Locked" : "Unlocked");
            lvContainers.Items.Add(item);

            // Select the new container
            lvContainers.Items[lvContainers.Items.Count - 1].Selected = true;
            lvContainers.EnsureVisible(lvContainers.Items.Count - 1);

            UpdateContainerCountLabel();
        }

        private void btnRemoveContainer_Click(object sender, EventArgs e)
        {
            if (lvContainers.SelectedItems.Count == 0)
                return;

            if (MessageBox.Show("Are you sure you want to remove the selected container?",
                               "Confirm Container Removal",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (lvContainers.SelectedItems[0].Tag is Container container)
                {
                    // Remove from model
                    _saveGameViewModel.Containers.Remove(container);

                    // Remove from ListView
                    lvContainers.Items.Remove(lvContainers.SelectedItems[0]);

                    // Update container counts
                    UpdateContainerCountLabel();
                    UpdateContainerItemsLabel();
                }
            }
        }

        private void btnModifyContainer_Click(object sender, EventArgs e)
        {
            if (lvContainers.SelectedItems.Count == 0)
                return;

            if (lvContainers.SelectedItems[0].Tag is Container container)
            {
                // Update the position
                container.Position = new Vector3(
                    (float)numContainerPosX.Value,
                    (float)numContainerPosY.Value,
                    (float)numContainerPosZ.Value
                );

                // Update the ListView item
                lvContainers.SelectedItems[0].Text = $"({container.Position.X:F1}, {container.Position.Y:F1}, {container.Position.Z:F1})";
            }
        }

        private void btnToggleContainerLock_Click(object sender, EventArgs e)
        {
            if (lvContainers.SelectedItems.Count == 0)
                return;

            if (lvContainers.SelectedItems[0].Tag is Container container)
            {
                // Toggle the lock flag
                if (container.IsLocked)
                    container.Flags &= unchecked((byte)~0x01); // Clear the lock bit
                else
                    container.Flags |= 0x01; // Set the lock bit

                // Update the ListView item
                lvContainers.SelectedItems[0].SubItems[1].Text = container.IsLocked ? "Locked" : "Unlocked";
            }
        }

        private void UpdateContainerCountLabel()
        {
            // Constants for container section
            const int CONT_SECTION_SIZE = 6324;
            const int CONT_HEADER_SIZE = 8;  // "CONT" + container count (4 bytes + 4 bytes)
            const int CONTAINER_FIXED_SIZE = 17;  // Position (12 bytes) + content count (4 bytes) + flags (1 byte)
            const int CONTAINER_ITEM_SIZE = 8;  // ReferenceId (4 bytes) + Quantity (2 bytes) + Charges (2 bytes)

            // Calculate current used space
            int usedSpace = CONT_HEADER_SIZE;

            foreach (var container in _saveGameViewModel.Containers)
            {
                usedSpace += CONTAINER_FIXED_SIZE + (container.Contents.Count * CONTAINER_ITEM_SIZE);
            }

            // Calculate remaining space
            int remainingSpace = CONT_SECTION_SIZE - usedSpace;

            // Calculate theoretical maximum additional empty containers
            int maxAdditionalEmptyContainers = remainingSpace / CONTAINER_FIXED_SIZE;

            // Update the label
            int currentCount = _saveGameViewModel.Containers.Count;
            int maxTotalContainers = currentCount + maxAdditionalEmptyContainers;
            lblContainers.Text = $"Containers ({currentCount}/{maxTotalContainers})";
        }

        private void UpdateContainerItemsLabel(Container container = null)
        {
            if (container == null && lvContainers.SelectedItems.Count > 0)
            {
                container = lvContainers.SelectedItems[0].Tag as Container;
            }

            if (container != null)
            {
                int itemCount = container.Contents.Count;
                lblContainerContent.Text = $"Container Contents ({itemCount}/16)";
            }
            else
            {
                lblContainerContent.Text = "Container Contents (0/16)";
            }
        }

        private void btnAddToContainer_Click(object sender, EventArgs e)
        {
            if (lvContainers.SelectedItems.Count == 0 || lvContainerGameItems.SelectedItems.Count == 0)
                return;

            if (lvContainers.SelectedItems[0].Tag is Container container)
            {
                // Check if adding the selected items would exceed the 16-item limit
                int currentCount = container.Contents.Count;
                int selectedCount = lvContainerGameItems.SelectedItems.Count;

                if (currentCount + selectedCount > 16)
                {
                    MessageBox.Show(
                        $"Cannot add {selectedCount} items. Containers are limited to 16 items maximum.\n\n" +
                        $"Current items: {currentCount}\nRemaining slots: {16 - currentCount}",
                        "Container Capacity Exceeded",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                foreach (ListViewItem selectedItem in lvContainerGameItems.SelectedItems)
                {
                    if (selectedItem.Tag is EquipmentItem equipmentItem)
                    {
                        // Create a new container item
                        var containerItem = new ContainerItem
                        {
                            ReferenceId = equipmentItem.Index,
                            Quantity = (short)numContainerItemQuantity.Value,
                            Charges = (short)numContainerItemCharges.Value
                        };

                        // Add to the container
                        container.Contents.Add(containerItem);
                        container.ContentCount = container.Contents.Count;

                        // Add to the ListView
                        var item = new ListViewItem(equipmentItem.Name)
                        {
                            Tag = containerItem
                        };
                        item.SubItems.Add(containerItem.Quantity.ToString());
                        item.SubItems.Add(containerItem.Charges.ToString());
                        lvContainerContent.Items.Add(item);
                    }
                }

                // Update the label to show the new count
                UpdateContainerItemsLabel(container);
                UpdateContainerCountLabel();
            }
        }

        private void btnRemoveFromContainer_Click(object sender, EventArgs e)
        {
            if (lvContainers.SelectedItems.Count == 0 || lvContainerContent.SelectedItems.Count == 0)
                return;

            if (lvContainers.SelectedItems[0].Tag is Container container)
            {
                // Create a list of items to remove (to avoid collection modification issues)
                List<ListViewItem> itemsToRemove = new List<ListViewItem>();
                foreach (ListViewItem selectedItem in lvContainerContent.SelectedItems)
                {
                    itemsToRemove.Add(selectedItem);
                }

                // Remove items from both the ListView and container
                foreach (ListViewItem item in itemsToRemove)
                {
                    if (item.Tag is ContainerItem containerItem)
                    {
                        container.Contents.Remove(containerItem);
                        lvContainerContent.Items.Remove(item);
                    }
                }

                // Update the container's content count
                container.ContentCount = container.Contents.Count;

                // Update the label to show the new count
                UpdateContainerItemsLabel(container);
            }
        }

        private void btnApplyToContainerItems_Click(object sender, EventArgs e)
        {
            if (lvContainerContent.SelectedItems.Count == 0)
                return;

            short quantity = (short)numContainerItemQuantity.Value;
            short charges = (short)numContainerItemCharges.Value;

            foreach (ListViewItem selectedItem in lvContainerContent.SelectedItems)
            {
                if (selectedItem.Tag is ContainerItem containerItem)
                {
                    // Update the model
                    containerItem.Quantity = quantity;
                    containerItem.Charges = charges;

                    // Update the ListView
                    selectedItem.SubItems[1].Text = quantity.ToString();
                    selectedItem.SubItems[2].Text = charges.ToString();
                }
            }
        }


        private List<ComboBox> GetAllEquipmentComboBoxes()
        {
            return new List<ComboBox>
            {
                cbJoAmulet, cbJoRing1, cbJoRing2, cbJoGauntlets, cbJoBoots, cbJoWeapon, cbJoShield, cbJoTorso, cbJoLeggings,
                cbFlAmulet, cbFlRing1, cbFlRing2, cbFlGauntlets, cbFlBoots, cbFlWeapon, cbFlShield, cbFlTorso, cbFlLeggings,
                cbRoAmulet, cbRoRing1, cbRoRing2, cbRoGauntlets, cbRoBoots, cbRoWeapon, cbRoShield, cbRoTorso, cbRoLeggings,
                cbJeAmulet, cbJeRing1, cbJeRing2, cbJeGauntlets, cbJeBoots, cbJeWeapon, cbJeShield, cbJeTorso, cbJeLeggings
            };
        }

        private void UpdateSkillValue(ListView skillList, NumericUpDown skillValue)
        {
            if (skillList.SelectedItems.Count == 0)
                return;

            var item = skillList.SelectedItems[0];
            if (item.Tag is Skill skill)
            {
                skillValue.Value = skill.Value / 10m;
            }
        }

        private void lvJosephSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSkillValue(lvJosephSkills, numJoSkillValue);
        }

        private void lvFleceSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSkillValue(lvFleceSkills, numFlSkillValue);
        }

        private void lvRosalindSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSkillValue(lvRosalindSkills, numRoSkillValue);
        }

        private void lvJekharSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSkillValue(lvJekharSkills, numJeSkillValue);
        }

        private void UpdateSkillListValue(ListView skillList, NumericUpDown skillValue)
        {
            if (skillList.SelectedItems.Count == 0)
                return;
            var item = skillList.SelectedItems[0];
            if (item.Tag is Skill skill)
            {
                skill.Value = (int)(skillValue.Value * 10);
                item.SubItems[1].Text = (skill.Value / 10).ToString();

                if (skillList == lvJosephSkills && _saveGameViewModel.Joseph != null)
                    _saveGameViewModel.Joseph.NotifySkillChanged();
                else if (skillList == lvFleceSkills && _saveGameViewModel.Flece != null)
                    _saveGameViewModel.Flece.NotifySkillChanged();
                else if (skillList == lvRosalindSkills && _saveGameViewModel.Rosalind != null)
                    _saveGameViewModel.Rosalind.NotifySkillChanged();
                else if (skillList == lvJekharSkills && _saveGameViewModel.Jekhar != null)
                    _saveGameViewModel.Jekhar.NotifySkillChanged();
            }
        }

        private void btnJoUpdateSkill_Click_1(object sender, EventArgs e)
        {
            UpdateSkillListValue(lvJosephSkills, numJoSkillValue);
        }

        private void btnFlUpdateSkill_Click_1(object sender, EventArgs e)
        {
            UpdateSkillListValue(lvFleceSkills, numFlSkillValue);
        }

        private void btnRoUpdateSkill_Click_1(object sender, EventArgs e)
        {
            UpdateSkillListValue(lvRosalindSkills, numRoSkillValue);
        }

        private void btnJeUpdateSkill_Click(object sender, EventArgs e)
        {
            UpdateSkillListValue(lvJekharSkills, numJeSkillValue);
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            // Check if any items are selected in the game items list
            if (lvGameItems.SelectedItems.Count == 0)
            {
                //MessageBox.Show("Please select an item to add to inventory.", "No Item Selected",
                //    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Process each selected item
            foreach (ListViewItem selectedItem in lvGameItems.SelectedItems)
            {
                if (selectedItem.Tag is InventoryItem gameItem)
                {
                    // Check if item already exists in inventory
                    var existingItem = _saveGameViewModel.Inventory.FirstOrDefault(i => i.Hash == gameItem.Hash);

                    if (existingItem != null)
                    {
                        // Increment quantity of existing item
                        existingItem.Quantity++;

                        // Update the ListView display for this item
                        foreach (ListViewItem lvItem in lvInventory.Items)
                        {
                            if (lvItem.Tag == existingItem)
                            {
                                lvItem.SubItems[1].Text = existingItem.Quantity.ToString();
                                break;
                            }
                        }
                    }
                    else
                    {
                        // Create a new inventory item based on the selected game item
                        var newItem = new InventoryItem();
                        newItem.Init(gameItem.Name, gameItem.Hash, 1, gameItem.MaxCharge);
                        newItem.Category = gameItem.Category;
                        newItem.Type = gameItem.Type;
                        //newItem.IdentifiedBit = true; // Default to identified for added items

                        // Create a view model for the inventory
                        var viewModel = new InventoryItemViewModel(newItem);

                        // Add to the save game's inventory collection
                        _saveGameViewModel.Inventory.Add(viewModel);

                        // Add to the ListView
                        var listViewItem = viewModel.GetInventoryListViewItem();
                        listViewItem.Tag = viewModel;
                        lvInventory.Items.Add(listViewItem);
                    }
                }
            }
        }

        private void btnToggleIdentified_Click(object sender, EventArgs e)
        {
            if (lvGameItems.SelectedItems.Count == 0)
                return;

            foreach (ListViewItem item in lvGameItems.SelectedItems)
            {
                if (item.Tag is InventoryItem gameItem)
                {
                    // Toggle the identified state
                    gameItem.IdentifiedBit = !gameItem.IdentifiedBit;

                    // Update the UI
                    item.SubItems[0].Text = gameItem.Name;
                    item.SubItems[1].Text = !gameItem.IdentifiedBit ? "Identified" : "Unidentified";
                }
            }
        }

        private void btnAddAllItems_Click(object sender, EventArgs e)
        {
            // Confirm with the user since this could add many items
            DialogResult result = MessageBox.Show(
                "Are you sure you want to add ALL game items to your inventory?\n\n" +
                "This will add hundreds of items at once.",
                "Confirm Add All Items",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            // Check if items are available
            if (_knownItems == null || _knownItems.Count == 0)
            {
                MessageBox.Show("No items available to add.", "No Items",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int addedCount = 0;
            int updatedCount = 0;

            // Process all items from the known items list
            foreach (var gameItem in _knownItems)
            {
                // Check if item already exists in inventory
                var existingItem = _saveGameViewModel.Inventory.FirstOrDefault(i => i.Hash == gameItem.Hash);

                if (existingItem != null)
                {
                    // Increment quantity of existing item
                    existingItem.Quantity++;
                    updatedCount++;

                    // Update the ListView display for this item
                    foreach (ListViewItem lvItem in lvInventory.Items)
                    {
                        if (lvItem.Tag == existingItem)
                        {
                            lvItem.SubItems[1].Text = existingItem.Quantity.ToString();
                            break;
                        }
                    }
                }
                else
                {
                    // Create a new inventory item
                    var newItem = new InventoryItem();
                    newItem.Init(gameItem.Name, gameItem.Hash, 1, gameItem.MaxCharge);
                    newItem.Category = gameItem.Category;
                    newItem.Type = gameItem.Type;

                    // Create a view model for the inventory
                    var viewModel = new InventoryItemViewModel(newItem);

                    // Add to the save game's inventory collection
                    _saveGameViewModel.Inventory.Add(viewModel);

                    // Add to the ListView
                    var listViewItem = viewModel.GetInventoryListViewItem();
                    listViewItem.Tag = viewModel;
                    lvInventory.Items.Add(listViewItem);

                    // Update item flags
                    //SyncItemIdentification(gameItem.Hash, true);
                    addedCount++;
                }
            }

            MessageBox.Show($"Added {addedCount} new items to your inventory and updated {updatedCount}.",
                "Items Added", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void UpdateCharacterTabsState()
        {
            // Character tabs start at index 1 (index 0 is the Start page)
            // Update Joseph tab (index 1)
            if (tabMain.TabPages.Count > 1)
                UpdateCharacterTab(1, _saveGameViewModel?.Joseph != null);

            // Update Flece tab (index 2)
            if (tabMain.TabPages.Count > 2)
                UpdateCharacterTab(2, _saveGameViewModel?.Flece != null);

            // Update Rosalind tab (index 3)
            if (tabMain.TabPages.Count > 3)
                UpdateCharacterTab(3, _saveGameViewModel?.Rosalind != null);

            // Update Jekhar tab (index 4)
            if (tabMain.TabPages.Count > 4)
                UpdateCharacterTab(4, _saveGameViewModel?.Jekhar != null);
        }

        private void UpdateCharacterTab(int tabIndex, bool characterFound)
        {
            TabPage tab = tabMain.TabPages[tabIndex];
            tab.Enabled = characterFound;

            // Get original name (map tab index to character name array)
            string originalName = _characterTabNames[tabIndex - 1]; // Adjust index for character array

            // Set the tab text to original name with optional indicator
            tab.Text = characterFound ? originalName : $"{originalName} (Not Found)";
        }

        private void btnMaxCreatureStats_Click(object sender, EventArgs e)
        {
            if (lvCreatureList.SelectedItems.Count == 0) return;

            if (lvCreatureList.SelectedItems[0].Tag is Creature creature)
            {
                // Create a temporary copy to modify the struct
                var creatureBlock = creature.CreatureBlock;

                // Set max values (adjust these as needed for your game)
                creatureBlock.wCreatureLevel = Convert.ToInt16(numCreatureLevel.Maximum);  // Set to max level
                creatureBlock.fBaseHP = (float)numCreatureBaseHP.Maximum;
                creatureBlock.fCurrentHP = (float)numCreatureCurrentHP.Maximum;
                creatureBlock.wBaseAP = Convert.ToInt16(numCreatureCurrentHP.Maximum);
                creatureBlock.wCurrentAP = Convert.ToInt16(numCreatureCurrentAP.Maximum);

                // Assign back the modified struct
                creature.CreatureBlock = creatureBlock;

                // Update the original creature in the list
                lvCreatureList.SelectedItems[0].Tag = creature;

                // Update controls to show new values
                numCreatureLevel.Value = creatureBlock.wCreatureLevel;
                numCreatureBaseHP.Value = (decimal)creatureBlock.fBaseHP;
                numCreatureCurrentHP.Value = (decimal)creatureBlock.fCurrentHP;
                numCreatureBaseAP.Value = creatureBlock.wBaseAP;
                numCreatureCurrentAP.Value = creatureBlock.wCurrentAP;
            }
        }

        private void btnClearInventory_Click(object sender, EventArgs e)
        {
            // Confirm with the user before clearing inventory
            DialogResult result = MessageBox.Show(
                "Are you sure you want to clear your entire inventory?\n\nThis action cannot be undone.",
                "Confirm Clear Inventory",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                // Clear the ListView
                lvInventory.Items.Clear();

                // Clear the data model
                _saveGameViewModel.Inventory.Clear();

                MessageBox.Show("Inventory has been cleared.",
                    "Inventory Cleared",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            // Check if any items are selected in the inventory list
            if (lvInventory.SelectedItems.Count == 0)
                return;

            // Process each selected item (work with a copy of the collection to avoid modification issues)
            var selectedItems = new List<ListViewItem>();
            foreach (ListViewItem item in lvInventory.SelectedItems)
            {
                selectedItems.Add(item);
            }

            // Remove each selected item from both the ListView and the data model
            foreach (ListViewItem item in selectedItems)
            {
                if (item.Tag is InventoryItemViewModel viewModel)
                {
                    // Remove from the data model
                    _saveGameViewModel.Inventory.Remove(viewModel);

                    // Remove from the ListView
                    lvInventory.Items.Remove(item);
                }
            }
        }

        private void btnApplyToSelected_Click(object sender, EventArgs e)
        {
            // Check if any items are selected
            if (lvInventory.SelectedItems.Count == 0)
                return;

            // Get the values to apply
            int newQuantity = (int)numQuantity.Value;
            int newCharges = (int)numCharges.Value;

            // Apply to each selected item
            foreach (ListViewItem item in lvInventory.SelectedItems)
            {
                if (item.Tag is InventoryItemViewModel viewModel)
                {
                    // Update the data model
                    viewModel.Quantity = newQuantity;
                    viewModel.Charge = newCharges;

                    // Update the ListView display
                    item.SubItems[1].Text = newQuantity.ToString();
                    item.SubItems[2].Text = $"{newCharges}";

                    // Only update charges if the item actually has charge functionality
                    //if (viewModel.Model.MaxCharge > 0)
                    //{
                    //    item.SubItems[2].Text = $"{newCharges}/{viewModel.Model.MaxCharge}";
                    //}
                }
            }
        }

        private void btnApplyToAll_Click(object sender, EventArgs e)
        {
            // Get the values to apply
            int newQuantity = (int)numQuantity.Value;
            int newCharges = (int)numCharges.Value;

            // Apply to all items in the inventory
            foreach (ListViewItem item in lvInventory.Items)
            {
                if (item.Tag is InventoryItemViewModel viewModel)
                {
                    // Update the data model
                    viewModel.Quantity = newQuantity;
                    viewModel.Charge = newCharges;

                    // Update the ListView display
                    item.SubItems[1].Text = newQuantity.ToString();

                    // Only update charges if the item actually has charge functionality
                    if (viewModel.Model.MaxCharge > 0)
                    {
                        item.SubItems[2].Text = $"{newCharges}/{viewModel.Model.MaxCharge}";
                    }
                }
            }
        }

        private void btnMaxGold_Click(object sender, EventArgs e)
        {
            numGold.Value = numGold.Maximum;
        }
    }
}