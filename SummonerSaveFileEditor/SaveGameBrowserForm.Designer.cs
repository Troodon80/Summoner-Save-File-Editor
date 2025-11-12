namespace SummonerSaveFileEditor
{
    partial class SaveGameBrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lvSaveFiles = new ListView();
            imgPreview = new PictureBox();
            lblTime = new Label();
            txtDescription = new TextBox();
            btnOpen = new Button();
            btnCancel = new Button();
            lblFileName = new Label();
            txtFileName = new TextBox();
            btnRefresh = new Button();
            splitContainer1 = new SplitContainer();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)imgPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lvSaveFiles
            // 
            lvSaveFiles.Dock = DockStyle.Fill;
            lvSaveFiles.Location = new Point(0, 0);
            lvSaveFiles.Name = "lvSaveFiles";
            lvSaveFiles.Size = new Size(454, 401);
            lvSaveFiles.TabIndex = 0;
            lvSaveFiles.UseCompatibleStateImageBehavior = false;
            // 
            // imgPreview
            // 
            imgPreview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            imgPreview.BackColor = Color.Black;
            imgPreview.Location = new Point(6, 26);
            imgPreview.Name = "imgPreview";
            imgPreview.Size = new Size(320, 240);
            imgPreview.TabIndex = 1;
            imgPreview.TabStop = false;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Location = new Point(6, 275);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(97, 15);
            lblTime.TabIndex = 2;
            lblTime.Text = "Game Time: --:--";
            // 
            // txtDescription
            // 
            txtDescription.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtDescription.BackColor = SystemColors.Window;
            txtDescription.Location = new Point(6, 298);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.ReadOnly = true;
            txtDescription.Size = new Size(320, 103);
            txtDescription.TabIndex = 3;
            // 
            // btnOpen
            // 
            btnOpen.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnOpen.Location = new Point(682, 461);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 23);
            btnOpen.TabIndex = 4;
            btnOpen.Text = "Open";
            btnOpen.UseVisualStyleBackColor = true;
            btnOpen.Click += btnOpen_Click;
            // 
            // btnCancel
            // 
            btnCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(601, 461);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblFileName
            // 
            lblFileName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(12, 465);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(61, 15);
            lblFileName.TabIndex = 6;
            lblFileName.Text = "File name:";
            // 
            // txtFileName
            // 
            txtFileName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFileName.Location = new Point(78, 461);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(435, 23);
            txtFileName.TabIndex = 7;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnRefresh.Location = new Point(520, 461);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 8;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            splitContainer1.Location = new Point(12, 12);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(lvSaveFiles);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panel1);
            splitContainer1.Size = new Size(786, 401);
            splitContainer1.SplitterDistance = 454;
            splitContainer1.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(imgPreview);
            panel1.Controls.Add(lblTime);
            panel1.Controls.Add(txtDescription);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(328, 401);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 8);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 4;
            label1.Text = "Game Preview:";
            // 
            // SaveGameBrowserForm
            // 
            AcceptButton = btnOpen;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(810, 496);
            Controls.Add(splitContainer1);
            Controls.Add(btnRefresh);
            Controls.Add(txtFileName);
            Controls.Add(lblFileName);
            Controls.Add(btnCancel);
            Controls.Add(btnOpen);
            MinimizeBox = false;
            MinimumSize = new Size(600, 400);
            Name = "SaveGameBrowserForm";
            ShowIcon = false;
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Summoner Save Game Browser";
            ((System.ComponentModel.ISupportInitialize)imgPreview).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private ListView lvSaveFiles;
        private PictureBox imgPreview;
        private Label lblTime;
        private TextBox txtDescription;
        private Button btnOpen;
        private Button btnCancel;
        private Label lblFileName;
        private TextBox txtFileName;
        private Button btnRefresh;
        private SplitContainer splitContainer1;
        private Panel panel1;
        private Label label1;
    }
}