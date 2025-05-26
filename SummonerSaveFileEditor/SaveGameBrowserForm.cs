using SummonerSaveFileEditor.Models;
using SummonerSaveFileEditor.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace SummonerSaveFileEditor
{
    public partial class SaveGameBrowserForm : Form
    {
        [System.ComponentModel.DesignerSerializationVisibility(System.ComponentModel.DesignerSerializationVisibility.Visible)]
        public string SelectedFilePath { get; private set; }
        private readonly string _initialDirectory;
        private readonly bool _saveMode;
        private string _defaultFileName = "summonerX.sav";

        // Minimal data class to hold preview information
        private class SaveFilePreview
        {
            public string FilePath { get; set; }
            public string FileName { get; set; }
            public DateTime LastModified { get; set; }
            public ImageThumbnail Thumbnail { get; set; }
            public float GameTime { get; set; }
            public string Description { get; set; }
        }

        private List<SaveFilePreview> _saveFiles = new List<SaveFilePreview>();

        public SaveGameBrowserForm(string initialDirectory, bool saveMode = false)
        {
            InitializeComponent();
            _initialDirectory = initialDirectory;
            _saveMode = saveMode;

            Text = saveMode ? "Save Game" : "Open Game";
            btnOpen.Text = saveMode ? "Save" : "Open";

            if (saveMode)
            {
                txtFileName.Visible = true;
                lblFileName.Visible = true;
                txtFileName.Text = _defaultFileName;
            }
            else
            {
                txtFileName.Visible = false;
                lblFileName.Visible = false;
            }

            // Set up list view
            lvSaveFiles.View = View.Details;
            lvSaveFiles.FullRowSelect = true;
            lvSaveFiles.HideSelection = false;
            lvSaveFiles.Columns.Add("Name", 200);
            lvSaveFiles.Columns.Add("Date", 150);
            lvSaveFiles.Columns.Add("Game Time", 100);

            // Enable sorting when clicking column headers
            lvSaveFiles.ColumnClick += LvSaveFiles_ColumnClick;

            Load += SaveGameBrowserForm_Load;
            lvSaveFiles.SelectedIndexChanged += LvSaveFiles_SelectedIndexChanged;
            lvSaveFiles.DoubleClick += LvSaveFiles_DoubleClick;
        }

        // Current sort column and order
        private int _sortColumn = 1; // Default sort by date column (index 1)
        private bool _sortAscending = false; // Default sort descending (newest first)

        private void LvSaveFiles_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // If clicking the same column, toggle sort order
            if (e.Column == _sortColumn)
            {
                _sortAscending = !_sortAscending;
            }
            else
            {
                // New column, default to ascending for Name, descending for Date and Game Time
                _sortColumn = e.Column;
                _sortAscending = e.Column == 0; // Ascending for filename, descending for others
            }

            // Sort the list based on the selected column
            SortListView();
        }

        private void SortListView()
        {
            // Create a new sorter for the ListView
            lvSaveFiles.ListViewItemSorter = new ListViewItemComparer(_sortColumn, _sortAscending);
        }

        // ListViewItem comparison class
        private class ListViewItemComparer : IComparer<ListViewItem>, System.Collections.IComparer
        {
            private int _column;
            private bool _ascending;

            public ListViewItemComparer(int column, bool ascending)
            {
                _column = column;
                _ascending = ascending;
            }

            public int Compare(ListViewItem x, ListViewItem y)
            {
                int result = 0;

                // Compare based on column type
                if (_column == 0) // Filename
                {
                    result = string.Compare(x.Text, y.Text);
                }
                else if (_column == 1) // Date
                {
                    // Try to parse dates
                    if (x.Tag is SaveFilePreview previewX && y.Tag is SaveFilePreview previewY)
                    {
                        result = DateTime.Compare(previewX.LastModified, previewY.LastModified);
                    }
                }
                else if (_column == 2) // Game Time
                {
                    // Try to parse game time
                    if (x.Tag is SaveFilePreview previewX && y.Tag is SaveFilePreview previewY)
                    {
                        result = previewX.GameTime.CompareTo(previewY.GameTime);
                    }
                }

                // Apply sort direction
                return _ascending ? result : -result;
            }

            // Implementation for System.Collections.IComparer (required for ListViewItemSorter)
            public int Compare(object x, object y)
            {
                return Compare(x as ListViewItem, y as ListViewItem);
            }
        }

        private void SaveGameBrowserForm_Load(object sender, EventArgs e)
        {
            // Center the form on the screen
            CenterToParent();

            // Load save files
            LoadSaveFiles(_initialDirectory);
            SortListView();

            if (lvSaveFiles.Items.Count > 0)
            {
                lvSaveFiles.Items[0].Selected = true;
                lvSaveFiles.Select();
            }
        }

        private void LoadSaveFiles(string directory)
        {
            try
            {
                lvSaveFiles.Items.Clear();
                _saveFiles.Clear();

                if (!Directory.Exists(directory))
                {
                    MessageBox.Show($"Directory does not exist: {directory}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get all .sav files
                string[] saveFilePaths = Directory.GetFiles(directory, "*.sav", SearchOption.TopDirectoryOnly);

                foreach (string filePath in saveFilePaths)
                {
                    try
                    {
                        SaveFilePreview preview = LoadSaveFilePreview(filePath);
                        if (preview != null)
                        {
                            _saveFiles.Add(preview);

                            // Add to ListView
                            ListViewItem item = new ListViewItem(preview.FileName);
                            item.SubItems.Add(preview.LastModified.ToString("g"));

                            // Format game time as HH:MM
                            int totalSeconds = (int)preview.GameTime;
                            int hours = totalSeconds / 3600;
                            int minutes = (totalSeconds % 3600) / 60;
                            item.SubItems.Add($"{hours:D2}:{minutes:D2}");

                            item.Tag = preview;
                            lvSaveFiles.Items.Add(item);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Just skip problematic files but log them
                        System.Diagnostics.Debug.WriteLine($"Error loading preview for {filePath}: {ex.Message}");
                    }
                }

                // Clear preview if no files
                if (lvSaveFiles.Items.Count == 0)
                {
                    ClearPreview();
                    if (!_saveMode)
                    {
                        btnOpen.Enabled = false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading save files: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private SaveFilePreview LoadSaveFilePreview(string filePath)
        {
            try
            {
                FileInfo fileInfo = new FileInfo(filePath);

                using (var reader = new BinaryReader(File.OpenRead(filePath)))
                {
                    // Read just enough to get the thumbnail and time info
                    // This is a simplified version of your SaveFileService.ReadSaveFile method

                    // Skip to the time and description section
                    reader.BaseStream.Position = Constants.TIME_OFFSET; // Offset to time

                    float gameTime = reader.ReadSingle();

                    // Read description (64 bytes, null-terminated)
                    byte[] descBytes = reader.ReadBytes(256);
                    string description = System.Text.Encoding.ASCII.GetString(descBytes)
                        .TrimEnd('\0');

                    // Read thumbnail
                    reader.BaseStream.Position = 0x200; // Offset to thumbnail

                    // Read thumbnail data
                    byte[] thumbnailData = reader.ReadBytes(60702);
                    var thumbnail = new ImageThumbnail { PixelData = thumbnailData };

                    return new SaveFilePreview
                    {
                        FilePath = filePath,
                        FileName = fileInfo.Name,
                        LastModified = fileInfo.LastWriteTime,
                        Thumbnail = thumbnail,
                        GameTime = gameTime,
                        Description = description
                    };
                }
            }
            catch
            {
                // If we can't read the file, just return null
                return null;
            }
        }

        private void LvSaveFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSaveFiles.SelectedItems.Count > 0 &&
                lvSaveFiles.SelectedItems[0].Tag is SaveFilePreview preview)
            {
                // Update the preview
                if (preview.Thumbnail?.ImageBitmap != null)
                {
                    // Clean up previous image to prevent memory leaks
                    imgPreview.Image?.Dispose();

                    // Set the new image
                    imgPreview.Image = new Bitmap(preview.Thumbnail.ImageBitmap);
                    imgPreview.SizeMode = PictureBoxSizeMode.StretchImage;
                }

                // Display game time
                int totalSeconds = (int)preview.GameTime;
                int hours = totalSeconds / 3600;
                int minutes = (totalSeconds % 3600) / 60;
                lblTime.Text = $"Game Time: {hours:D2}:{minutes:D2}";

                // Display description
                txtDescription.Text = preview.Description;

                // Update file name in save mode
                if (_saveMode)
                {
                    txtFileName.Text = preview.FileName;
                }

                // Enable open button
                btnOpen.Enabled = true;

                // Store the selected path
                SelectedFilePath = preview.FilePath;
            }
            else
            {
                ClearPreview();

                // Disable open button only in open mode
                if (!_saveMode)
                {
                    btnOpen.Enabled = false;
                }
            }
        }

        private void LvSaveFiles_DoubleClick(object sender, EventArgs e)
        {
            if (lvSaveFiles.SelectedItems.Count > 0)
            {
                btnOpen.PerformClick();
            }
        }

        private void ClearPreview()
        {
            imgPreview.Image?.Dispose();
            imgPreview.Image = null;
            lblTime.Text = "Game Time: --:--";
            txtDescription.Text = "";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (_saveMode)
            {
                // For save mode, use the entered filename
                string fileName = txtFileName.Text.Trim();
                if (string.IsNullOrEmpty(fileName))
                {
                    MessageBox.Show("Please enter a filename.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Add .sav extension if not present
                if (!fileName.EndsWith(".sav", StringComparison.OrdinalIgnoreCase))
                {
                    fileName += ".sav";
                }

                SelectedFilePath = Path.Combine(_initialDirectory, fileName);

                // Confirm overwrite if file exists
                if (File.Exists(SelectedFilePath))
                {
                    var result = MessageBox.Show(
                        $"File '{fileName}' already exists. Do you want to replace it?",
                        "Confirm Save As", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            else if (string.IsNullOrEmpty(SelectedFilePath) || !File.Exists(SelectedFilePath))
            {
                MessageBox.Show("Please select a valid save file.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadSaveFiles(_initialDirectory);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Clean up any resources
                ClearPreview();
            }
            base.Dispose(disposing);
        }
    }
}