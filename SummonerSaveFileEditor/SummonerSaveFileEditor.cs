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
        private List<QuestEntry> _questNames;
        private List<LevelItem> _levelItems;
        private List<DialogueFile> _dialogueFiles;


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

        private readonly string[] _characterTabNames = { "Joseph", "Flece", "Rosalind", "Jekhar", "Summon" };

        // Tab for conversations not to be included on the main form yet.
        private TabPage _conversationTab;

        private bool _conversationTreeBuilt = false;

        public SummonerSaveFileEditor()
        {
            InitializeComponent();
            EnsureTimerInitialized();
            tblCreatureEdit.Enabled = false;
            this.Load += async (_, __) =>
            {
                await LoadAllResourcesAsync();
                SettingsManager.ApplyWindowState(this);
                UpdateCharacterTabs();
            };
            numTime.ValueChanged += (s, e) => UpdateTimeLabel();

            _conversationTab = tabMain.TabPages[12];
            tabMain.TabPages.Remove(_conversationTab);

            tabMain.SelectedIndexChanged += tabMain_SelectedIndexChanged;

            SetupEquipmentSlotLogic();
        }

        private async void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabMain.SelectedTab == tabPageConversations)
            {
                if (!_conversationTreeBuilt)
                {
                    // Build the tree asynchronously
                    await BuildConversationTreeAsync();
                }
                
                // Load conversation data if needed and update the tree
                if (_saveGameViewModel != null && !_saveGameViewModel.ConversationDataLoaded && _saveGameViewModel.RawConversationData != null)
                {
                    Cursor = Cursors.WaitCursor;
                    try
                    {
                        ConversationDataService.LoadConversationDataOnDemand(_saveGameViewModel, _dialogueFiles);
                        UpdateConversationTreeState();
                    }
                    finally
                    {
                        Cursor = Cursors.Default;
                    }
                }
            }
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
                numJoSkillPoints.DataBindings.Add("Text", _saveGameViewModel.Joseph, "SkillPoints");

                BindFloat(numJoBaseHP, _saveGameViewModel.Joseph, "BaseHP");
                BindFloat(numJoCurrentHP, _saveGameViewModel.Joseph, "CurrentHP");
                numJoBaseAP.DataBindings.Add("Text", _saveGameViewModel.Joseph, "BaseAP");
                numJoCurrentAP.DataBindings.Add("Text", _saveGameViewModel.Joseph, "CurrentAP");

                numJoSpeed.DataBindings.Add("Text", _saveGameViewModel.Joseph, "Speed");

                BindFloat(numJoPosX, _saveGameViewModel.Joseph, "PosX");
                BindFloat(numJoPosY, _saveGameViewModel.Joseph, "PosY");
                BindFloat(numJoPosZ, _saveGameViewModel.Joseph, "PosZ");
            }

            if (_saveGameViewModel.Flece != null)
            {
                numFlLevel.DataBindings.Add("Text", _saveGameViewModel.Flece, "Level");
                numFlExperience.DataBindings.Add("Text", _saveGameViewModel.Flece, "Experience");
                numFlSkillPoints.DataBindings.Add("Text", _saveGameViewModel.Flece, "SkillPoints");

                BindFloat(numFlBaseHP, _saveGameViewModel.Flece, "BaseHP");
                BindFloat(numFlCurrentHP, _saveGameViewModel.Flece, "CurrentHP");
                numFlBaseAP.DataBindings.Add("Text", _saveGameViewModel.Flece, "BaseAP");
                numFlCurrentAP.DataBindings.Add("Text", _saveGameViewModel.Flece, "CurrentAP");

                numFlSpeed.DataBindings.Add("Text", _saveGameViewModel.Flece, "Speed");

                BindFloat(numFlPosX, _saveGameViewModel.Flece, "PosX");
                BindFloat(numFlPosY, _saveGameViewModel.Flece, "PosY");
                BindFloat(numFlPosZ, _saveGameViewModel.Flece, "PosZ");
            }

            if (_saveGameViewModel.Rosalind != null)
            {
                numRoLevel.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "Level");
                numRoExperience.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "Experience");
                numRoSkillPoints.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "SkillPoints");

                BindFloat(numRoBaseHP, _saveGameViewModel.Rosalind, "BaseHP");
                BindFloat(numRoCurrentHP, _saveGameViewModel.Rosalind, "CurrentHP");
                numRoBaseAP.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "BaseAP");
                numRoCurrentAP.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "CurrentAP");

                numRoSpeed.DataBindings.Add("Text", _saveGameViewModel.Rosalind, "Speed");

                BindFloat(numRoPosX, _saveGameViewModel.Rosalind, "PosX");
                BindFloat(numRoPosY, _saveGameViewModel.Rosalind, "PosY");
                BindFloat(numRoPosZ, _saveGameViewModel.Rosalind, "PosZ");
            }

            if (_saveGameViewModel.Jekhar != null)
            {
                numJeLevel.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "Level");
                numJeExperience.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "Experience");
                numJeSkillPoints.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "SkillPoints");

                BindFloat(numJeBaseHP, _saveGameViewModel.Jekhar, "BaseHP");
                BindFloat(numJeCurrentHP, _saveGameViewModel.Jekhar, "CurrentHP");
                numJeBaseAP.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "BaseAP");
                numJeCurrentAP.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "CurrentAP");

                numJeSpeed.DataBindings.Add("Text", _saveGameViewModel.Jekhar, "Speed");

                BindFloat(numJePosX, _saveGameViewModel.Jekhar, "PosX");
                BindFloat(numJePosY, _saveGameViewModel.Jekhar, "PosY");
                BindFloat(numJePosZ, _saveGameViewModel.Jekhar, "PosZ");
            }

            if (_saveGameViewModel.Summon != null)
            {
                numSuLevel.DataBindings.Add("Text", _saveGameViewModel.Summon, "Level");
                numSuExperience.DataBindings.Add("Text", _saveGameViewModel.Summon, "Experience");
                numSuSkillPoints.DataBindings.Add("Text", _saveGameViewModel.Summon, "SkillPoints");

                BindFloat(numSuBaseHP, _saveGameViewModel.Summon, "BaseHP");
                BindFloat(numSuCurrentHP, _saveGameViewModel.Summon, "CurrentHP");
                numSuBaseAP.DataBindings.Add("Text", _saveGameViewModel.Summon, "BaseAP");
                numSuCurrentAP.DataBindings.Add("Text", _saveGameViewModel.Summon, "CurrentAP");

                numSuSpeed.DataBindings.Add("Text", _saveGameViewModel.Summon, "Speed");

                BindFloat(numSuPosX, _saveGameViewModel.Summon, "PosX");
                BindFloat(numSuPosY, _saveGameViewModel.Summon, "PosY");
                BindFloat(numSuPosZ, _saveGameViewModel.Summon, "PosZ");
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

            SetupEquipmentComboBoxes(_saveGameViewModel.Summon,
                cbSuAmulet, cbSuRing1, cbSuRing2, cbSuGauntlets, cbSuBoots,
                cbSuWeapon, cbSuShield, cbSuTorso, cbSuLeggings);
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

            if (_saveGameViewModel.Summon != null)
            {
                lvSummonSkills.Items.Clear();
                foreach (var skill in _saveGameViewModel.Summon.Skills)
                {
                    lvSummonSkills.Items.Add(new ListViewItem(new[]
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
            lblCreatureStatus.Visible = false;
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

                bool isDead = creature.CreatureBlock.bIsDead;
                // Create ListViewItem with Hash as first column
                var item = new ListViewItem($"{(creature.Header.creatureId & 0xFF):X2}{((creature.Header.creatureId >> 8) & 0xFF):X2}{((creature.Header.creatureId >> 16) & 0xFF):X2}{((creature.Header.creatureId >> 24) & 0xFF):X2}")
                {
                    Tag = creature
                };

                // Add the other columns as subitems
                item.SubItems.Add(name);
                item.SubItems.Add(creature.Header.creatureType.ToString());
                item.SubItems.Add(typeString);
                item.SubItems.Add(isDead ? "Dead" : "Alive");
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
                4 or 5 or 6 => "NPC",
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
                numEntityLevel.ValueChanged -= CreaturePropertyChanged;
                numEntityBaseHP.ValueChanged -= CreaturePropertyChanged;
                numEntityCurrentHP.ValueChanged -= CreaturePropertyChanged;
                numEntityBaseAP.ValueChanged -= CreaturePropertyChanged;
                numEntityCurrentAP.ValueChanged -= CreaturePropertyChanged;
                numEntityPosX.ValueChanged -= CreaturePropertyChanged;
                numEntityPosY.ValueChanged -= CreaturePropertyChanged;
                numEntityPosZ.ValueChanged -= CreaturePropertyChanged;

                // Check if creature is dead
                bool isDead = creature.CreatureBlock.bIsDead;

                lblCreatureStatus.Text = isDead ? "This creature is dead and cannot be edited." : "";
                lblCreatureStatus.ForeColor = isDead ? Color.Red : Color.Green;
                lblCreatureStatus.Visible = true;

                // Disable edit controls when creature is dead
                numEntityLevel.Enabled = !isDead;
                numEntityBaseHP.Enabled = !isDead;
                numEntityCurrentHP.Enabled = !isDead;
                numEntityBaseAP.Enabled = !isDead;
                numEntityCurrentAP.Enabled = !isDead;
                numEntityPosX.Enabled = !isDead;
                numEntityPosY.Enabled = !isDead;
                numEntityPosZ.Enabled = !isDead;
                btnMaxOther.Enabled = !isDead;

                numEntityLevel.Value = isDead ? 0 : creature.CreatureBlock.wCreatureLevel;
                numEntityBaseHP.Value = isDead ? 0 : (decimal)creature.CreatureBlock.fBaseHP;
                numEntityCurrentHP.Value = isDead ? 0 : (decimal)creature.CreatureBlock.fCurrentHP;
                numEntityBaseAP.Value = isDead ? 0 : creature.CreatureBlock.wBaseAP;
                numEntityCurrentAP.Value = isDead ? 0 : creature.CreatureBlock.wCurrentAP;

                numEntityPosX.Value = isDead ? 0 : (decimal)creature.CreatureBlock.fPosX;
                numEntityPosY.Value = isDead ? 0 : (decimal)creature.CreatureBlock.fPosY;
                numEntityPosZ.Value = isDead ? 0 : (decimal)creature.CreatureBlock.fPosZ;

                // If dead, don't re-enable event handlers. We'll just preserve the current values.
                if (isDead)
                    return;

                // Re-enable event handlers
                numEntityLevel.ValueChanged += CreaturePropertyChanged;
                numEntityBaseHP.ValueChanged += CreaturePropertyChanged;
                numEntityCurrentHP.ValueChanged += CreaturePropertyChanged;
                numEntityBaseAP.ValueChanged += CreaturePropertyChanged;
                numEntityCurrentAP.ValueChanged += CreaturePropertyChanged;
                numEntityPosX.ValueChanged += CreaturePropertyChanged;
                numEntityPosY.ValueChanged += CreaturePropertyChanged;
                numEntityPosZ.ValueChanged += CreaturePropertyChanged;
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
                creatureBlock.wCreatureLevel = (short)numEntityLevel.Value;
                creatureBlock.fBaseHP = (float)numEntityBaseHP.Value;
                creatureBlock.fCurrentHP = (float)numEntityCurrentHP.Value;
                creatureBlock.wBaseAP = (short)numEntityBaseAP.Value;
                creatureBlock.wCurrentAP = (short)numEntityCurrentAP.Value;

                creatureBlock.fPosX = (float)numEntityPosX.Value;
                creatureBlock.fPosY = (float)numEntityPosY.Value;
                creatureBlock.fPosZ = (float)numEntityPosZ.Value;
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
            UpdateContainerCountLabels();
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

        private bool _questListEventAttached = false;
        private void BindQuestList()
        {
            // Configure ListView for checkboxes if not already done
            if (lvQuestList.CheckBoxes == false)
                lvQuestList.CheckBoxes = true;

            lvQuestList.Items.Clear();

            if (_questNames == null) return;

            foreach (var quest in _questNames)
            {
                // Create ListViewItem with quest info
                var item = new ListViewItem(new[] { quest.Name ?? "(Unnamed)" })
                {
                    Tag = quest,
                    Checked = quest.Visible  // Set the checkbox state based on the quest visibility
                };
                lvQuestList.Items.Add(item);
            }

            // Handle checkbox state changes if not already set up
            if (!_questListEventAttached)
            {
                lvQuestList.ItemCheck += LvQuestList_ItemCheck;
                _questListEventAttached = true;
            }
        }

        private void LvQuestList_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (e.Index < 0 || e.Index >= lvQuestList.Items.Count)
                return;

            var item = lvQuestList.Items[e.Index];
            bool newValue = e.NewValue == CheckState.Checked;

            // Update the model directly when checkbox state changes
            if (item.Tag is QuestEntry quest)
            {
                quest.Visible = newValue;
            }
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

                using (var browser = new SaveGameBrowserForm(initialDirectory))
                {
                    if (browser.ShowDialog() == DialogResult.OK)
                    {
                        _saveGameViewModel.ConversationDataLoaded = false; // Reset conversation data state
                        string selectedFilePath = browser.SelectedFilePath;

                        UpdateTitleWithFileName(selectedFilePath);

                        using var reader = new BinaryReader(File.OpenRead(selectedFilePath));
                        _saveGameViewModel = SaveFileService.ReadInventoryData(reader, _knownItems, out _originalInventorySize);
                        SaveFileService.ReadSaveGameHeader(reader, _saveGameViewModel);
                        SaveFileService.ReadTimeAndDescription(reader, out float seconds, out string desc);
                        SaveFileService.ReadPostThumbnailData(reader, _saveGameViewModel);

                        SaveFileService.ReadItemFlags(reader, _knownItems, out _itemFlags);
                        SaveFileService.ReadConversationData(reader, _saveGameViewModel, _dialogueFiles);
                        SaveFileService.ReadEntityData(reader, _saveGameViewModel);
                        SaveFileService.ReadCamera(reader, _saveGameViewModel);
                        SaveFileService.ReadContainerData(reader, _saveGameViewModel);

                        SaveFileService.ReadQuestFlags(reader, _questNames);
                        SaveFileService.ReadLevelItemData(reader, _saveGameViewModel, _levelItems);
                        SaveFileService.ReadPostContainerData(reader, _saveGameViewModel);

                        _saveGameViewModel.GameTimeSeconds = seconds;
                        _saveGameViewModel.Description = desc;

                        PopulateEquipmentComboBoxes();
                        PopulateGameItemsList();
                        PopulateContainersList();
                        PopulateContainerGameItemsList();
                        PopulateGoldPilesList();
                        DisplayLevelItems();

                        ClearAllBindings(this);

                        BindTimeAndDescription();
                        BindInventoryControls();
                        BindCharacterPanels();
                        BindCharacterSkillsAndEquipment();
                        BindSkillLists();
                        PopulateCreatureList();
                        BindCameraControls();
                        BindQuestList();

                        UpdateCharacterTabs();

                        DisplayThumbnailImage();

                        SettingsManager.SaveLastFolder(Path.GetDirectoryName(selectedFilePath));

                        // If conversation tab is already showing, update the tree
                        if (tabMain.SelectedTab == tabPageConversations && _conversationTreeBuilt)
                        {
                            ConversationDataService.LoadConversationDataOnDemand(_saveGameViewModel, _dialogueFiles);
                            UpdateConversationTreeState();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private async Task BuildConversationTreeAsync()
        {
            if (_dialogueFiles == null || _dialogueFiles.Count == 0)
                return;
            
            // Show loading indicator if needed
            Cursor = Cursors.WaitCursor;
            
            try
            {
                // Create all nodes in a background task
                var rootNodes = await Task.Run(() => {
                    var nodes = new List<TreeNode>();
                    
                    // Group dialogues by area
                    var dialoguesByArea = _dialogueFiles
                        .GroupBy(d => d.DisplayName)
                        .OrderBy(g => g.Key);
                    
                    // Create area nodes first
                    foreach (var areaGroup in dialoguesByArea)
                    {
                        string areaName = areaGroup.Key;
                        
                        // Create the area node
                        var areaNode = new TreeNode(areaName) { Tag = "Area" };
                        
                        // Collect all characters from all files in this area
                        var areaCharacters = new List<(DialogueCharacter Character, string BlockName)>();
                        
                        foreach (var dialogueFile in areaGroup)
                        {                            
                            // Add each character with its associated block name
                            foreach (var character in dialogueFile.Characters)
                            {
                                areaCharacters.Add((character, dialogueFile.DisplayName));
                            }
                        }
                        
                        // Add all characters sorted by name
                        foreach (var (character, blockName) in areaCharacters.OrderBy(c => c.Character.Name))
                        {
                            var characterNode = new TreeNode(character.Name) { Tag = character };
                            
                            // Add topics for this character
                            foreach (var topic in character.Topics)
                            {
                                // Create the topic node (default to not seen)
                                var topicNode = new TreeNode(topic.FullText)
                                {
                                    Tag = topic,
                                    ForeColor = SystemColors.GrayText
                                };
                                
                                // If initial topic, make it bold
                                if (character.InitialTopics.Contains(topic.FullText) ||
                                    character.InitialTopics.Contains(topic.BaseText))
                                {
                                    // Font creation must be done on UI thread
                                    topicNode.NodeFont = new Font(tvConversations.Font, FontStyle.Bold);
                                }
                                
                                characterNode.Nodes.Add(topicNode);
                                
                                // Add response text and actions as child nodes
                                if (!string.IsNullOrEmpty(topic.ResponseText))
                                {
                                    var responseNode = new TreeNode($"Response: {topic.ResponseText}")
                                    {
                                        Tag = topic.ResponseText,
                                        ForeColor = Color.DarkBlue
                                    };
                                    topicNode.Nodes.Add(responseNode);
                                }
                                
                                foreach (var action in topic.Actions)
                                {
                                    topicNode.Nodes.Add(new TreeNode(action)
                                    {
                                        Tag = "Action",
                                        ForeColor = Color.DarkGreen
                                    });
                                }
                            }
                            
                            areaNode.Nodes.Add(characterNode);
                        }
                        
                        nodes.Add(areaNode);
                    }
                    
                    return nodes;
                });
                
                // Update the UI with our prepared nodes
                tvConversations.BeginUpdate();
                tvConversations.Nodes.Clear();
                tvConversations.Nodes.AddRange(rootNodes.ToArray());
                tvConversations.EndUpdate();
                
                // Update flag to indicate tree is built
                _conversationTreeBuilt = true;
            }
            finally
            {
                // Always restore cursor
                Cursor = Cursors.Default;
            }
        }

        private void UpdateConversationTreeState()
        {
            if (_saveGameViewModel?.ConversationData == null || _dialogueFiles == null)
                return;
                
            // Update the in-memory DialogueFiles with conversation state
            ConversationDataService.UpdateDialogueConversationState(
                _dialogueFiles, _saveGameViewModel.ConversationData);
                
            // Apply state to existing tree nodes
            tvConversations.BeginUpdate();
            
            foreach (TreeNode areaNode in tvConversations.Nodes)
            {
                foreach (TreeNode characterNode in areaNode.Nodes)
                {
                    if (characterNode.Tag is DialogueCharacter character)
                    {
                        foreach (TreeNode topicNode in characterNode.Nodes)
                        {
                            if (topicNode.Tag is DialogueTopic topic)
                            {
                                // Update the topic node appearance based on seen state
                                topicNode.ForeColor = topic.HasSeen ? SystemColors.WindowText : SystemColors.GrayText;
                            }
                        }
                    }
                }
            }
            
            tvConversations.EndUpdate();
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
                        SaveFileService.WriteInventoryData(writer, _saveGameViewModel, _knownItems, _originalInventorySize);
                        SaveFileService.WriteSaveGameHeader(writer, _saveGameViewModel);
                        //SaveFileService.WriteTimeAndDescription(writer, _saveGameViewModel.GameTimeSeconds, _saveGameViewModel.Description);
                        SaveFileService.WritePostThumbnailData(writer, _saveGameViewModel);

                        SaveFileService.WriteItemFlags(writer, _itemFlags);
                        SaveFileService.WriteConversationData(writer, _saveGameViewModel);

                        SaveFileService.WriteCharactersAndCreatures(writer, _saveGameViewModel);
                        SaveFileService.WriteCamera(writer, _saveGameViewModel);
                        SaveFileService.WriteContainerSection(writer, _saveGameViewModel);
                        SaveFileService.WritePostContainerData(writer, _saveGameViewModel);
                        SaveFileService.WriteQuestFlags(writer, _questNames);

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

            // Summon
            cbSuWeapon.SelectedIndexChanged += (sender, e) => CheckWeaponAndUpdateShield(cbSuWeapon, cbSuShield);
            cbSuTorso.SelectedIndexChanged += (sender, e) => CheckTorsoAndUpdateLeggings(cbSuTorso, cbSuLeggings);
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
                _questNames = result.questsNames;
                _levelItems = result.levelItems;
                _dialogueFiles = result.dialogueFiles;
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
                        cbSuAmulet.Items.Add(item);
                        break;

                    case "Ring":
                        if (use.HasFlag(Usability.Joseph)) { cbJoRing1.Items.Add(item); cbJoRing2.Items.Add(item); }
                        if (use.HasFlag(Usability.Flece)) { cbFlRing1.Items.Add(item); cbFlRing2.Items.Add(item); }
                        if (use.HasFlag(Usability.Rosalind)) { cbRoRing1.Items.Add(item); cbRoRing2.Items.Add(item); }
                        if (use.HasFlag(Usability.Jekhar)) { cbJeRing1.Items.Add(item); cbJeRing2.Items.Add(item); }
                        cbSuRing1.Items.Add(item); cbSuRing2.Items.Add(item);
                        break;

                    case "Gauntlets":
                        if (use.HasFlag(Usability.Joseph)) cbJoGauntlets.Items.Add(item);
                        if (use.HasFlag(Usability.Flece)) cbFlGauntlets.Items.Add(item);
                        if (use.HasFlag(Usability.Rosalind)) cbRoGauntlets.Items.Add(item);
                        if (use.HasFlag(Usability.Jekhar)) cbJeGauntlets.Items.Add(item);
                        cbSuGauntlets.Items.Add(item);
                        break;

                    case "Boots":
                        if (use.HasFlag(Usability.Joseph)) cbJoBoots.Items.Add(item);
                        if (use.HasFlag(Usability.Flece)) cbFlBoots.Items.Add(item);
                        if (use.HasFlag(Usability.Rosalind)) cbRoBoots.Items.Add(item);
                        if (use.HasFlag(Usability.Jekhar)) cbJeBoots.Items.Add(item);
                        cbSuBoots.Items.Add(item);
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
                        cbSuWeapon.Items.Add(item);
                        break;

                    case "Shield":
                        if (use.HasFlag(Usability.Joseph)) cbJoShield.Items.Add(item);
                        if (use.HasFlag(Usability.Flece)) cbFlShield.Items.Add(item);
                        if (use.HasFlag(Usability.Rosalind)) cbRoShield.Items.Add(item);
                        if (use.HasFlag(Usability.Jekhar)) cbJeShield.Items.Add(item);
                        cbSuShield.Items.Add(item);
                        break;

                    case "Torso":
                        if (use.HasFlag(Usability.Joseph)) cbJoTorso.Items.Add(item);
                        if (use.HasFlag(Usability.Flece)) cbFlTorso.Items.Add(item);
                        if (use.HasFlag(Usability.Rosalind)) cbRoTorso.Items.Add(item);
                        if (use.HasFlag(Usability.Jekhar)) cbJeTorso.Items.Add(item);
                        cbSuTorso.Items.Add(item);
                        break;

                    case "Leggings":
                        if (use.HasFlag(Usability.Joseph)) cbJoLeggings.Items.Add(item);
                        if (use.HasFlag(Usability.Flece)) cbFlLeggings.Items.Add(item);
                        if (use.HasFlag(Usability.Rosalind)) cbRoLeggings.Items.Add(item);
                        if (use.HasFlag(Usability.Jekhar)) cbJeLeggings.Items.Add(item);
                        cbSuLeggings.Items.Add(item);
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
                UpdateContainerCountLabels(container);
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

            UpdateContainerCountLabels();
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
                    UpdateContainerCountLabels();
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

        private void UpdateContainerCountLabels(Container selectedContainer = null)
        {

            // Constants
            int usedSpace = Constants.CONT_HEADER_SIZE;
            int containerCount = _saveGameViewModel.Containers?.Count ?? 0;
            int goldPileCount = _saveGameViewModel.GoldPiles?.Count ?? 0;

            // Calculate used space for containers and their items
            int maxItemsPerContainer = 16;
            int totalContainerItems = 0;
            foreach (var container in _saveGameViewModel.Containers)
            {
                int itemCount = container.Contents?.Count ?? 0;
                usedSpace += Constants.CONTAINER_FIXED_SIZE + (itemCount * Constants.CONTAINER_ITEM_SIZE);
                totalContainerItems += itemCount;
            }

            // Gold piles
            usedSpace += goldPileCount * Constants.GOLDPILE_SIZE;

            // Remaining space
            int remainingSpace = Constants.CONT_SECTION_SIZE - usedSpace;

            // Max additional empty containers and gold piles
            int maxAdditionalContainers = remainingSpace / Constants.CONTAINER_FIXED_SIZE;
            int maxAdditionalGoldPiles = remainingSpace / Constants.GOLDPILE_SIZE;

            // For container items, calculate the max possible for the selected container
            int selectedContainerItems = 0;
            if (selectedContainer == null && lvContainers.SelectedItems.Count > 0)
                selectedContainer = lvContainers.SelectedItems[0].Tag as Container;

            if (selectedContainer != null)
                selectedContainerItems = selectedContainer.Contents?.Count ?? 0;

            // Calculate how many more items can fit in the CONT block for this container
            int spaceForMoreItems = remainingSpace / Constants.CONTAINER_ITEM_SIZE;
            int maxItemsThisContainer = Math.Min(maxItemsPerContainer, selectedContainerItems + spaceForMoreItems);

            // Update labels
            lblContainers.Text = $"Containers ({containerCount}/{containerCount + maxAdditionalContainers})";
            lblGoldPiles.Text = $"Gold Piles ({goldPileCount}/{goldPileCount + maxAdditionalGoldPiles})";
            if (selectedContainer != null)
                lblContainerContent.Text = $"Container Contents ({selectedContainerItems}/{maxItemsThisContainer})";
            else
                lblContainerContent.Text = $"Container Contents (0/{maxItemsPerContainer})";
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
                UpdateContainerCountLabels(container);
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
                UpdateContainerCountLabels(container);
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
                cbJeAmulet, cbJeRing1, cbJeRing2, cbJeGauntlets, cbJeBoots, cbJeWeapon, cbJeShield, cbJeTorso, cbJeLeggings,
                cbSuAmulet, cbSuRing1, cbSuRing2, cbSuGauntlets, cbSuBoots, cbSuWeapon, cbSuShield, cbSuTorso, cbSuLeggings
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

        private void lvSummonSkills_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateSkillValue(lvSummonSkills, numSuSkillValue);
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
                else if (skillList == lvSummonSkills && _saveGameViewModel.Summon != null)
                    _saveGameViewModel.Summon.NotifySkillChanged();
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

        private void btnSuUpdateSkill_Click(object sender, EventArgs e)
        {
            UpdateSkillListValue(lvSummonSkills, numSuSkillValue);
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

        private void UpdateCharacterTabs()
        {
            // Character tabs start at index 1 (index 0 is the Start page)
            for (int tabIndex = 1; tabIndex <= _characterTabNames.Length; tabIndex++)
            {
                if (tabMain.TabPages.Count <= tabIndex)
                    continue;

                TabPage tab = tabMain.TabPages[tabIndex];
                string originalName = _characterTabNames[tabIndex - 1];
                bool characterFound = false;
                string tabText = originalName;

                switch (tabIndex)
                {
                    case 1:
                        characterFound = _saveGameViewModel?.Joseph != null;
                        break;
                    case 2:
                        characterFound = _saveGameViewModel?.Flece != null;
                        break;
                    case 3:
                        characterFound = _saveGameViewModel?.Rosalind != null;
                        break;
                    case 4:
                        characterFound = _saveGameViewModel?.Jekhar != null;
                        break;
                    case 5: // Summon tab
                        characterFound = _saveGameViewModel?.Summon != null;
                        if (characterFound)
                        {
                            // Use SummonName if available, otherwise fallback to "Summon"
                            string summonName = _saveGameViewModel.LevelEntityHeader.SummonName ?? "Summon";
                            uint hash = SummonerHash.ComputeHash(summonName);
                            //int hash = summonName.GetHashCode();
                            tabText = $"Summon ({summonName})";
                        }
                        break;
                }

                tab.Enabled = characterFound;
                tab.Text = characterFound ? tabText : $"{originalName} (Not Found)";
            }
        }

        private void btnMaxCreatureStats_Click(object sender, EventArgs e)
        {
            if (lvCreatureList.SelectedItems.Count == 0) return;

            if (lvCreatureList.SelectedItems[0].Tag is Creature creature)
            {
                // Create a temporary copy to modify the struct
                var creatureBlock = creature.CreatureBlock;

                creatureBlock.wCreatureLevel = Convert.ToInt16(numEntityLevel.Maximum);
                creatureBlock.fBaseHP = (float)numEntityBaseHP.Maximum;
                creatureBlock.fCurrentHP = (float)numEntityCurrentHP.Maximum;
                creatureBlock.wBaseAP = Convert.ToInt16(numEntityCurrentHP.Maximum);
                creatureBlock.wCurrentAP = Convert.ToInt16(numEntityCurrentAP.Maximum);

                // Assign back the modified struct
                creature.CreatureBlock = creatureBlock;

                // Update the original creature in the list
                lvCreatureList.SelectedItems[0].Tag = creature;

                // Update controls to show new values
                numEntityLevel.Value = creatureBlock.wCreatureLevel;
                numEntityBaseHP.Value = (decimal)creatureBlock.fBaseHP;
                numEntityCurrentHP.Value = (decimal)creatureBlock.fCurrentHP;
                numEntityBaseAP.Value = creatureBlock.wBaseAP;
                numEntityCurrentAP.Value = creatureBlock.wCurrentAP;
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

        // 1. Populate the Gold Piles ListView
        private void PopulateGoldPilesList()
        {
            lvGoldPiles.Items.Clear();
            foreach (var pile in _saveGameViewModel.GoldPiles)
            {
                var item = new ListViewItem($"{pile.Position.X:F1}, {pile.Position.Y:F1}, {pile.Position.Z:F1}")
                {
                    Tag = pile
                };
                item.SubItems.Add(pile.Amount.ToString());
                item.SubItems.Add(pile.Unknown.ToString());
                lvGoldPiles.Items.Add(item);
            }
            UpdateGoldPileButtons();
        }

        // 2. Enable/disable buttons based on selection
        private void lvGoldPiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateGoldPileButtons();
            if (lvGoldPiles.SelectedItems.Count > 0 && lvGoldPiles.SelectedItems[0].Tag is GoldPile pile)
            {
                numGoldPilePosX.Value = (decimal)pile.Position.X;
                numGoldPilePosY.Value = (decimal)pile.Position.Y;
                numGoldPilePosZ.Value = (decimal)pile.Position.Z;
                numGoldPileAmount.Value = pile.Amount;
            }
        }

        private void UpdateGoldPileButtons()
        {
            bool hasSelection = lvGoldPiles.SelectedItems.Count > 0;
            btnRemoveGoldPile.Enabled = hasSelection;
            btnModifyGoldPile.Enabled = hasSelection;
        }

        // 3. Add a new gold pile
        private void btnAddGoldPile_Click(object sender, EventArgs e)
        {
            var newPile = new GoldPile
            {
                Position = new Vector3(
                    (float)numGoldPilePosX.Value,
                    (float)numGoldPilePosY.Value,
                    (float)numGoldPilePosZ.Value
                ),
                Amount = (int)numGoldPileAmount.Value,
                Unknown = 0 // Set as needed
            };
            _saveGameViewModel.GoldPiles.Add(newPile);
            PopulateGoldPilesList();
            lvGoldPiles.Items[lvGoldPiles.Items.Count - 1].Selected = true;
            lvGoldPiles.EnsureVisible(lvGoldPiles.Items.Count - 1);
        }

        // 4. Remove selected gold pile
        private void btnRemoveGoldPile_Click(object sender, EventArgs e)
        {
            if (lvGoldPiles.SelectedItems.Count == 0) return;
            var pile = lvGoldPiles.SelectedItems[0].Tag as GoldPile;
            if (pile != null)
            {
                _saveGameViewModel.GoldPiles.Remove(pile);
                PopulateGoldPilesList();
            }
        }

        // 5. Modify selected gold pile
        private void btnModifyGoldPile_Click(object sender, EventArgs e)
        {
            if (lvGoldPiles.SelectedItems.Count == 0) return;
            var pile = lvGoldPiles.SelectedItems[0].Tag as GoldPile;
            if (pile != null)
            {
                pile.Position = new Vector3(
                    (float)numGoldPilePosX.Value,
                    (float)numGoldPilePosY.Value,
                    (float)numGoldPilePosZ.Value
                );
                pile.Amount = (int)numGoldPileAmount.Value;
                // Optionally update Unknown if you have a control for it
                PopulateGoldPilesList();
                // Reselect the modified item
                foreach (ListViewItem item in lvGoldPiles.Items)
                {
                    if (item.Tag == pile)
                    {
                        item.Selected = true;
                        lvGoldPiles.EnsureVisible(item.Index);
                        break;
                    }
                }
            }
        }

        private void lvLevelItems_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            // Skip this logic for group headers
            if (lvLevelItems.Items[e.Index].Tag == null || !(lvLevelItems.Items[e.Index].Tag is LevelItem item))
                return;

            // Update the item's state - checkbox corresponds to whether it exists in the world
            item.Exists = e.NewValue == CheckState.Checked;
        }

        private void DisplayLevelItems()
        {
            lvLevelItems.BeginUpdate();
            lvLevelItems.Items.Clear();
            lvLevelItems.Groups.Clear();

            // Enable ShowGroups property
            lvLevelItems.ShowGroups = true;

            if (_saveGameViewModel.LevelItems == null || _saveGameViewModel.LevelItems.Count == 0)
            {
                lvLevelItems.EndUpdate();
                return;
            }

            // Group by level name
            var levelGroups = _saveGameViewModel.LevelItems
                .GroupBy(item => item.LevelName)
                .OrderBy(g => g.Key);

            foreach (var group in levelGroups)
            {
                // Create a true ListView group
                ListViewGroup lvGroup = new ListViewGroup($"{group.Key}");
                lvLevelItems.Groups.Add(lvGroup);

                // Add items for this level
                foreach (var item in group.OrderBy(i => i.Name))
                {
                    var listItem = new ListViewItem("")
                    {
                        Tag = item,
                        Checked = item.Exists,
                        Group = lvGroup  // Assign the item to this group
                    };

                    listItem.SubItems.Add(item.Name);
                    listItem.SubItems.Add(item.Item);
                    listItem.SubItems.Add(item.LevelName);
                    listItem.SubItems.Add(item.Count.ToString());
                    listItem.SubItems.Add(item.Navpoint);

                    if (!item.Exists)
                    {
                        // Gray out items that have been collected
                        listItem.ForeColor = SystemColors.GrayText;
                    }

                    lvLevelItems.Items.Add(listItem);
                }
            }

            lvLevelItems.EndUpdate();
        }
    }
}