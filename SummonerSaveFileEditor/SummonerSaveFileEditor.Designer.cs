using SummonerSaveFileEditor.Models;
using System.Windows.Forms;

namespace SummonerSaveFileEditor
{
    partial class SummonerSaveFileEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SummonerSaveFileEditor));
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label10 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            tabPageOther = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            tblCreatureEdit = new TableLayoutPanel();
            LabelOtherLevel = new Label();
            numCreatureLevel = new NumericUpDown();
            btnMaxOtherLevel = new Button();
            LabelOtherMaxHP = new Label();
            numCreatureBaseHP = new NumericUpDown();
            btnMaxOtherBaseHP = new Button();
            LabelOtherCurrHP = new Label();
            numCreatureCurrentHP = new NumericUpDown();
            btnMaxOtherCurrentHP = new Button();
            LabelOtherMaxAP = new Label();
            numCreatureBaseAP = new NumericUpDown();
            btnMaxOtherBaseAP = new Button();
            LabelOtherCurrAP = new Label();
            numCreatureCurrentAP = new NumericUpDown();
            btnMaxOtherCurrentAP = new Button();
            btnMaxOther = new Button();
            lvCreatureList = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            tabPageCamera = new TabPage();
            label19 = new Label();
            tbleCameraPanel = new TableLayoutPanel();
            numCameraMode = new NumericUpDown();
            numCameraUnknown = new NumericUpDown();
            numCameraPosZ = new NumericUpDown();
            numCameraFoV = new NumericUpDown();
            numCameraPosY = new NumericUpDown();
            numCameraPitch = new NumericUpDown();
            numCameraPosX = new NumericUpDown();
            numCameraYaw = new NumericUpDown();
            numCameraZoom = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label8 = new Label();
            label9 = new Label();
            label11 = new Label();
            label12 = new Label();
            label17 = new Label();
            label18 = new Label();
            tabPageInventory = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblGameItems = new Label();
            pnlInventoryControls = new Panel();
            gbGold = new GroupBox();
            btnMaxGold = new Button();
            numGold = new NumericUpDown();
            btnAddItem = new Button();
            btnToggleIdentified = new Button();
            btnRemoveItem = new Button();
            btnClearInventory = new Button();
            GBoxItemQuantity = new GroupBox();
            btnApplyToAll = new Button();
            btnApplyToSelected = new Button();
            numCharges = new NumericUpDown();
            numQuantity = new NumericUpDown();
            lblCharges = new Label();
            lblQuantity = new Label();
            btnAddAllItems = new Button();
            lvGameItems = new ListView();
            columnHeader17 = new ColumnHeader();
            columnHeader16 = new ColumnHeader();
            lvInventory = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            lblInventory = new Label();
            tabPageJekhar = new TabPage();
            tblJekhar = new TableLayoutPanel();
            lblJeAmulet = new Label();
            lblJeRing1 = new Label();
            lblJeRing2 = new Label();
            lblJeGauntlets = new Label();
            lblJeWeapon = new Label();
            lblJeShield = new Label();
            lblJeBoots = new Label();
            lblJeTorso = new Label();
            lblJeCurrentHP = new Label();
            cbJeLeggings = new ComboBox();
            cbJeTorso = new ComboBox();
            cbJeBoots = new ComboBox();
            cbJeShield = new ComboBox();
            cbJeWeapon = new ComboBox();
            cbJeGauntlets = new ComboBox();
            cbJeRing2 = new ComboBox();
            cbJeRing1 = new ComboBox();
            cbJeAmulet = new ComboBox();
            numJeCurrentHP = new NumericUpDown();
            btnJeMaxCurrentHP = new Button();
            lblJeCurrentAP = new Label();
            numJeCurrentAP = new NumericUpDown();
            btnJeMaxCurrentAP = new Button();
            lblJeSpeed = new Label();
            numJeSpeed = new NumericUpDown();
            btnJeMaxSpeed = new Button();
            lblJeLeggings = new Label();
            btnJeMaxAll = new Button();
            btnJeMaxBaseAP = new Button();
            numJeBaseAP = new NumericUpDown();
            btnJeMaxBaseHP = new Button();
            lblJeBaseAP = new Label();
            numJeBaseHP = new NumericUpDown();
            numJeLevel = new NumericUpDown();
            lblJeBaseHP = new Label();
            numJeExperience = new NumericUpDown();
            lblJeSkillPoints = new Label();
            btnJeMaxLevel = new Button();
            lblJeLevel = new Label();
            lblJeExperience = new Label();
            btnJeMaxExp = new Button();
            numJeSkill = new NumericUpDown();
            btnJeMaxSkill = new Button();
            lvJekharSkills = new ListView();
            columnSkillName = new ColumnHeader();
            columnSkillValue = new ColumnHeader();
            tableLayoutPanel7 = new TableLayoutPanel();
            numJeSkillValue = new NumericUpDown();
            btnJeUpdateSkill = new Button();
            tabPageRosalind = new TabPage();
            tblRosalind = new TableLayoutPanel();
            tableLayoutPanel10 = new TableLayoutPanel();
            numRoSkillValue = new NumericUpDown();
            btnRoUpdateSkill = new Button();
            lvRosalindSkills = new ListView();
            columnHeader13 = new ColumnHeader();
            columnHeader14 = new ColumnHeader();
            lblRoAmulet = new Label();
            lblRoRing1 = new Label();
            lblRoRing2 = new Label();
            lblRoGauntlets = new Label();
            lblRoWeapon = new Label();
            lblRoShield = new Label();
            lblRoBoots = new Label();
            lblRoTorso = new Label();
            lblRoCurrentHP = new Label();
            cbRoLeggings = new ComboBox();
            cbRoTorso = new ComboBox();
            cbRoBoots = new ComboBox();
            cbRoShield = new ComboBox();
            cbRoWeapon = new ComboBox();
            cbRoGauntlets = new ComboBox();
            cbRoRing2 = new ComboBox();
            cbRoRing1 = new ComboBox();
            cbRoAmulet = new ComboBox();
            numRoCurrentHP = new NumericUpDown();
            btnRoMaxCurrentHP = new Button();
            lblRoCurrentAP = new Label();
            numRoCurrentAP = new NumericUpDown();
            btnRoMaxCurrentAP = new Button();
            lblRoSpeed = new Label();
            numRoSpeed = new NumericUpDown();
            btnRoMaxSpeed = new Button();
            lblRoLeggings = new Label();
            btnRoMaxAll = new Button();
            btnRoMaxBaseAP = new Button();
            numRoBaseAP = new NumericUpDown();
            btnRoMaxBaseHP = new Button();
            lblRoBaseAP = new Label();
            numRoBaseHP = new NumericUpDown();
            lblRoBaseHP = new Label();
            btnRoMaxSkill = new Button();
            numRoSkill = new NumericUpDown();
            btnRoMaxExp = new Button();
            lblRoSkillPoints = new Label();
            numRoLevel = new NumericUpDown();
            numRoExperience = new NumericUpDown();
            btnRoMaxLevel = new Button();
            lblRoLevel = new Label();
            lblRoExperience = new Label();
            tabPageFlece = new TabPage();
            tblFlece = new TableLayoutPanel();
            lblFlAmulet = new Label();
            lvFleceSkills = new ListView();
            columnHeader11 = new ColumnHeader();
            columnHeader12 = new ColumnHeader();
            tableLayoutPanel8 = new TableLayoutPanel();
            numFlSkillValue = new NumericUpDown();
            btnFlUpdateSkill = new Button();
            lblFlRing1 = new Label();
            lblFlRing2 = new Label();
            lblFlGauntlets = new Label();
            lblFlWeapon = new Label();
            lblFlShield = new Label();
            lblFlBoots = new Label();
            lblFlTorso = new Label();
            btnFlMaxAll = new Button();
            btnFlMaxBaseAP = new Button();
            lblFlCurrentHP = new Label();
            numFlBaseAP = new NumericUpDown();
            btnFlMaxBaseHP = new Button();
            lblFlBaseAP = new Label();
            cbFlLeggings = new ComboBox();
            cbFlTorso = new ComboBox();
            cbFlBoots = new ComboBox();
            numFlBaseHP = new NumericUpDown();
            cbFlShield = new ComboBox();
            lblFlBaseHP = new Label();
            cbFlWeapon = new ComboBox();
            btnFlMaxSkill = new Button();
            cbFlGauntlets = new ComboBox();
            numFlSkill = new NumericUpDown();
            btnFlMaxExp = new Button();
            lblFlSkillPoints = new Label();
            numFlLevel = new NumericUpDown();
            numFlExperience = new NumericUpDown();
            btnFlMaxLevel = new Button();
            lblFlLevel = new Label();
            cbFlRing2 = new ComboBox();
            lblFlExperience = new Label();
            cbFlRing1 = new ComboBox();
            cbFlAmulet = new ComboBox();
            numFlCurrentHP = new NumericUpDown();
            btnFlMaxCurrentHP = new Button();
            lblFlCurrentAP = new Label();
            numFlCurrentAP = new NumericUpDown();
            btnFlMaxCurrentAP = new Button();
            lblFlSpeed = new Label();
            numFlSpeed = new NumericUpDown();
            btnFlMaxSpeed = new Button();
            lblFlLeggings = new Label();
            tabPageJoseph = new TabPage();
            tblJoseph = new TableLayoutPanel();
            lblJoLevel = new Label();
            cbJoLeggings = new ComboBox();
            lvJosephSkills = new ListView();
            columnHeader9 = new ColumnHeader();
            columnHeader10 = new ColumnHeader();
            tableLayoutPanel9 = new TableLayoutPanel();
            numJoSkillValue = new NumericUpDown();
            btnJoUpdateSkill = new Button();
            numJoLevel = new NumericUpDown();
            cbJoTorso = new ComboBox();
            cbJoBoots = new ComboBox();
            cbJoShield = new ComboBox();
            btnJoMaxLevel = new Button();
            lblJoExperience = new Label();
            cbJoWeapon = new ComboBox();
            numJoExperience = new NumericUpDown();
            cbJoGauntlets = new ComboBox();
            btnJoMaxExperience = new Button();
            lblJoSkillPoints = new Label();
            cbJoRing2 = new ComboBox();
            numJoSkill = new NumericUpDown();
            cbJoRing1 = new ComboBox();
            btnJoMaxSkillPoints = new Button();
            cbJoAmulet = new ComboBox();
            lblJoMaxHP = new Label();
            btnJoMaxAll = new Button();
            btnJoMaxSpeed = new Button();
            numJoBaseHP = new NumericUpDown();
            numJoSpeed = new NumericUpDown();
            btnJoMaxCurrentAP = new Button();
            lblJoSpeed = new Label();
            btnJoMaxBaseHP = new Button();
            btnJoMaxBaseAP = new Button();
            lblJoCurrentHP = new Label();
            numJoCurrentAP = new NumericUpDown();
            numJoCurrentHP = new NumericUpDown();
            lblJoCurrentAP = new Label();
            btnJoMaxCurrentHP = new Button();
            lblJoBaseAP = new Label();
            numJoBaseAP = new NumericUpDown();
            lblJoAmulet = new Label();
            lblJoRing1 = new Label();
            lblJoRing2 = new Label();
            lblJoGauntlets = new Label();
            lblJoWeapon = new Label();
            lblJoShield = new Label();
            lblJoBoots = new Label();
            lblJoTorso = new Label();
            lblJoLeggings = new Label();
            tabPageStart = new TabPage();
            tableLayoutPanel11 = new TableLayoutPanel();
            imgPreview = new PictureBox();
            txtDescription = new TextBox();
            btnOpenFile = new Button();
            btnSaveFile = new Button();
            lblTime = new Label();
            numTime = new NumericUpDown();
            tabMain = new TabControl();
            tabPageContainer = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnRemoveContainer = new Button();
            btnAddContainer = new Button();
            btnToggleContainerLock = new Button();
            numContainerPosZ = new NumericUpDown();
            label22 = new Label();
            numContainerPosY = new NumericUpDown();
            label21 = new Label();
            numContainerPosX = new NumericUpDown();
            label20 = new Label();
            btnModifyContainer = new Button();
            lvContainerGameItems = new ListView();
            columnHeader21 = new ColumnHeader();
            tableLayoutPanel4 = new TableLayoutPanel();
            btnAddToContainer = new Button();
            btnRemoveFromContainer = new Button();
            btnApplyToContainerItems = new Button();
            numContainerItemQuantity = new NumericUpDown();
            numContainerItemCharges = new NumericUpDown();
            label23 = new Label();
            label24 = new Label();
            lblContainers = new Label();
            lblContainerContent = new Label();
            lvContainers = new ListView();
            columnHeader6 = new ColumnHeader();
            columnHeader20 = new ColumnHeader();
            lvContainerContent = new ListView();
            columnHeader7 = new ColumnHeader();
            columnHeader18 = new ColumnHeader();
            columnHeader19 = new ColumnHeader();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            applyChangesToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            aboutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            button1 = new Button();
            tabPageOther.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tblCreatureEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCreatureLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCreatureBaseHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCreatureCurrentHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCreatureBaseAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCreatureCurrentAP).BeginInit();
            tabPageCamera.SuspendLayout();
            tbleCameraPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCameraMode).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCameraUnknown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCameraPosZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCameraFoV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCameraPosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCameraPitch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCameraPosX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCameraYaw).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numCameraZoom).BeginInit();
            tabPageInventory.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            pnlInventoryControls.SuspendLayout();
            gbGold.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGold).BeginInit();
            GBoxItemQuantity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCharges).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            tabPageJekhar.SuspendLayout();
            tblJekhar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJeCurrentHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJeCurrentAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJeSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJeBaseAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJeBaseHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJeLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJeExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJeSkill).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJeSkillValue).BeginInit();
            tabPageRosalind.SuspendLayout();
            tblRosalind.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRoSkillValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoCurrentHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoCurrentAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoBaseAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoBaseHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoSkill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoExperience).BeginInit();
            tabPageFlece.SuspendLayout();
            tblFlece.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFlSkillValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlBaseAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlBaseHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlSkill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlCurrentHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlCurrentAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlSpeed).BeginInit();
            tabPageJoseph.SuspendLayout();
            tblJoseph.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJoSkillValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoSkill).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoBaseHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoCurrentAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoCurrentHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoBaseAP).BeginInit();
            tabPageStart.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imgPreview).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numTime).BeginInit();
            tabMain.SuspendLayout();
            tabPageContainer.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numContainerPosZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numContainerPosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numContainerPosX).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numContainerItemQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numContainerItemCharges).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(243, 0);
            label4.Name = "label4";
            label4.Size = new Size(163, 26);
            label4.TabIndex = 27;
            label4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Location = new Point(243, 26);
            label5.Name = "label5";
            label5.Size = new Size(163, 26);
            label5.TabIndex = 28;
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Location = new Point(243, 52);
            label6.Name = "label6";
            label6.Size = new Size(163, 26);
            label6.TabIndex = 29;
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Location = new Point(243, 78);
            label7.Name = "label7";
            label7.Size = new Size(163, 26);
            label7.TabIndex = 30;
            label7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Dock = DockStyle.Fill;
            label10.Location = new Point(243, 104);
            label10.Name = "label10";
            label10.Size = new Size(163, 26);
            label10.TabIndex = 31;
            label10.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Location = new Point(243, 130);
            label13.Name = "label13";
            label13.Size = new Size(163, 26);
            label13.TabIndex = 32;
            label13.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Location = new Point(243, 156);
            label14.Name = "label14";
            label14.Size = new Size(163, 26);
            label14.TabIndex = 33;
            label14.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Location = new Point(243, 182);
            label15.Name = "label15";
            label15.Size = new Size(163, 26);
            label15.TabIndex = 34;
            label15.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.Location = new Point(243, 208);
            label16.Name = "label16";
            label16.Size = new Size(163, 26);
            label16.TabIndex = 35;
            label16.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPageOther
            // 
            tabPageOther.Controls.Add(tableLayoutPanel5);
            tabPageOther.Location = new Point(4, 24);
            tabPageOther.Margin = new Padding(4, 3, 4, 3);
            tabPageOther.Name = "tabPageOther";
            tabPageOther.Padding = new Padding(4, 3, 4, 3);
            tabPageOther.Size = new Size(973, 507);
            tabPageOther.TabIndex = 4;
            tabPageOther.Text = "Other";
            tabPageOther.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9067364F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.09326F));
            tableLayoutPanel5.Controls.Add(tblCreatureEdit, 0, 0);
            tableLayoutPanel5.Controls.Add(lvCreatureList, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(4, 3);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(965, 501);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tblCreatureEdit
            // 
            tblCreatureEdit.ColumnCount = 3;
            tblCreatureEdit.ColumnStyles.Add(new ColumnStyle());
            tblCreatureEdit.ColumnStyles.Add(new ColumnStyle());
            tblCreatureEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tblCreatureEdit.Controls.Add(LabelOtherLevel, 0, 0);
            tblCreatureEdit.Controls.Add(numCreatureLevel, 1, 0);
            tblCreatureEdit.Controls.Add(btnMaxOtherLevel, 2, 0);
            tblCreatureEdit.Controls.Add(LabelOtherMaxHP, 0, 1);
            tblCreatureEdit.Controls.Add(numCreatureBaseHP, 1, 1);
            tblCreatureEdit.Controls.Add(btnMaxOtherBaseHP, 2, 1);
            tblCreatureEdit.Controls.Add(LabelOtherCurrHP, 0, 2);
            tblCreatureEdit.Controls.Add(numCreatureCurrentHP, 1, 2);
            tblCreatureEdit.Controls.Add(btnMaxOtherCurrentHP, 2, 2);
            tblCreatureEdit.Controls.Add(LabelOtherMaxAP, 0, 3);
            tblCreatureEdit.Controls.Add(numCreatureBaseAP, 1, 3);
            tblCreatureEdit.Controls.Add(btnMaxOtherBaseAP, 2, 3);
            tblCreatureEdit.Controls.Add(LabelOtherCurrAP, 0, 4);
            tblCreatureEdit.Controls.Add(numCreatureCurrentAP, 1, 4);
            tblCreatureEdit.Controls.Add(btnMaxOtherCurrentAP, 2, 4);
            tblCreatureEdit.Controls.Add(btnMaxOther, 1, 5);
            tblCreatureEdit.Dock = DockStyle.Fill;
            tblCreatureEdit.Location = new Point(0, 0);
            tblCreatureEdit.Margin = new Padding(0);
            tblCreatureEdit.Name = "tblCreatureEdit";
            tblCreatureEdit.RowCount = 7;
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.Size = new Size(250, 501);
            tblCreatureEdit.TabIndex = 25;
            // 
            // LabelOtherLevel
            // 
            LabelOtherLevel.AutoSize = true;
            LabelOtherLevel.Dock = DockStyle.Fill;
            LabelOtherLevel.Location = new Point(4, 0);
            LabelOtherLevel.Margin = new Padding(4, 0, 4, 0);
            LabelOtherLevel.Name = "LabelOtherLevel";
            LabelOtherLevel.Size = new Size(69, 29);
            LabelOtherLevel.TabIndex = 0;
            LabelOtherLevel.Text = "Level:";
            LabelOtherLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numCreatureLevel
            // 
            numCreatureLevel.Dock = DockStyle.Fill;
            numCreatureLevel.Location = new Point(81, 3);
            numCreatureLevel.Margin = new Padding(4, 3, 4, 3);
            numCreatureLevel.Maximum = new decimal(new int[] { 16752, 0, 0, 0 });
            numCreatureLevel.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numCreatureLevel.Name = "numCreatureLevel";
            numCreatureLevel.Size = new Size(107, 23);
            numCreatureLevel.TabIndex = 1;
            numCreatureLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numCreatureLevel.ValueChanged += CreaturePropertyChanged;
            // 
            // btnMaxOtherLevel
            // 
            btnMaxOtherLevel.Dock = DockStyle.Fill;
            btnMaxOtherLevel.Location = new Point(196, 3);
            btnMaxOtherLevel.Margin = new Padding(4, 3, 4, 3);
            btnMaxOtherLevel.Name = "btnMaxOtherLevel";
            btnMaxOtherLevel.Size = new Size(52, 23);
            btnMaxOtherLevel.TabIndex = 16;
            btnMaxOtherLevel.Text = "Max";
            btnMaxOtherLevel.UseVisualStyleBackColor = true;
            // 
            // LabelOtherMaxHP
            // 
            LabelOtherMaxHP.AutoSize = true;
            LabelOtherMaxHP.Dock = DockStyle.Fill;
            LabelOtherMaxHP.Location = new Point(4, 29);
            LabelOtherMaxHP.Margin = new Padding(4, 0, 4, 0);
            LabelOtherMaxHP.Name = "LabelOtherMaxHP";
            LabelOtherMaxHP.Size = new Size(69, 29);
            LabelOtherMaxHP.TabIndex = 17;
            LabelOtherMaxHP.Text = "Base HP:";
            LabelOtherMaxHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numCreatureBaseHP
            // 
            numCreatureBaseHP.Location = new Point(81, 32);
            numCreatureBaseHP.Margin = new Padding(4, 3, 4, 3);
            numCreatureBaseHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCreatureBaseHP.Name = "numCreatureBaseHP";
            numCreatureBaseHP.Size = new Size(107, 23);
            numCreatureBaseHP.TabIndex = 18;
            numCreatureBaseHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            numCreatureBaseHP.ValueChanged += CreaturePropertyChanged;
            // 
            // btnMaxOtherBaseHP
            // 
            btnMaxOtherBaseHP.Location = new Point(196, 32);
            btnMaxOtherBaseHP.Margin = new Padding(4, 3, 4, 3);
            btnMaxOtherBaseHP.Name = "btnMaxOtherBaseHP";
            btnMaxOtherBaseHP.Size = new Size(52, 23);
            btnMaxOtherBaseHP.TabIndex = 19;
            btnMaxOtherBaseHP.Text = "Max";
            btnMaxOtherBaseHP.UseVisualStyleBackColor = true;
            // 
            // LabelOtherCurrHP
            // 
            LabelOtherCurrHP.AutoSize = true;
            LabelOtherCurrHP.Dock = DockStyle.Fill;
            LabelOtherCurrHP.Location = new Point(4, 58);
            LabelOtherCurrHP.Margin = new Padding(4, 0, 4, 0);
            LabelOtherCurrHP.Name = "LabelOtherCurrHP";
            LabelOtherCurrHP.Size = new Size(69, 29);
            LabelOtherCurrHP.TabIndex = 17;
            LabelOtherCurrHP.Text = "Current HP:";
            LabelOtherCurrHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numCreatureCurrentHP
            // 
            numCreatureCurrentHP.Location = new Point(81, 61);
            numCreatureCurrentHP.Margin = new Padding(4, 3, 4, 3);
            numCreatureCurrentHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCreatureCurrentHP.Name = "numCreatureCurrentHP";
            numCreatureCurrentHP.Size = new Size(107, 23);
            numCreatureCurrentHP.TabIndex = 18;
            numCreatureCurrentHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            numCreatureCurrentHP.ValueChanged += CreaturePropertyChanged;
            // 
            // btnMaxOtherCurrentHP
            // 
            btnMaxOtherCurrentHP.Location = new Point(196, 61);
            btnMaxOtherCurrentHP.Margin = new Padding(4, 3, 4, 3);
            btnMaxOtherCurrentHP.Name = "btnMaxOtherCurrentHP";
            btnMaxOtherCurrentHP.Size = new Size(52, 23);
            btnMaxOtherCurrentHP.TabIndex = 19;
            btnMaxOtherCurrentHP.Text = "Max";
            btnMaxOtherCurrentHP.UseVisualStyleBackColor = true;
            // 
            // LabelOtherMaxAP
            // 
            LabelOtherMaxAP.AutoSize = true;
            LabelOtherMaxAP.Dock = DockStyle.Fill;
            LabelOtherMaxAP.Location = new Point(4, 87);
            LabelOtherMaxAP.Margin = new Padding(4, 0, 4, 0);
            LabelOtherMaxAP.Name = "LabelOtherMaxAP";
            LabelOtherMaxAP.Size = new Size(69, 29);
            LabelOtherMaxAP.TabIndex = 20;
            LabelOtherMaxAP.Text = "Base AP:";
            LabelOtherMaxAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numCreatureBaseAP
            // 
            numCreatureBaseAP.Location = new Point(81, 90);
            numCreatureBaseAP.Margin = new Padding(4, 3, 4, 3);
            numCreatureBaseAP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCreatureBaseAP.Name = "numCreatureBaseAP";
            numCreatureBaseAP.Size = new Size(107, 23);
            numCreatureBaseAP.TabIndex = 21;
            numCreatureBaseAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numCreatureBaseAP.ValueChanged += CreaturePropertyChanged;
            // 
            // btnMaxOtherBaseAP
            // 
            btnMaxOtherBaseAP.Location = new Point(196, 90);
            btnMaxOtherBaseAP.Margin = new Padding(4, 3, 4, 3);
            btnMaxOtherBaseAP.Name = "btnMaxOtherBaseAP";
            btnMaxOtherBaseAP.Size = new Size(52, 23);
            btnMaxOtherBaseAP.TabIndex = 22;
            btnMaxOtherBaseAP.Text = "Max";
            btnMaxOtherBaseAP.UseVisualStyleBackColor = true;
            // 
            // LabelOtherCurrAP
            // 
            LabelOtherCurrAP.AutoSize = true;
            LabelOtherCurrAP.Dock = DockStyle.Fill;
            LabelOtherCurrAP.Location = new Point(4, 116);
            LabelOtherCurrAP.Margin = new Padding(4, 0, 4, 0);
            LabelOtherCurrAP.Name = "LabelOtherCurrAP";
            LabelOtherCurrAP.Size = new Size(69, 29);
            LabelOtherCurrAP.TabIndex = 20;
            LabelOtherCurrAP.Text = "Current AP:";
            LabelOtherCurrAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numCreatureCurrentAP
            // 
            numCreatureCurrentAP.Location = new Point(81, 119);
            numCreatureCurrentAP.Margin = new Padding(4, 3, 4, 3);
            numCreatureCurrentAP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numCreatureCurrentAP.Name = "numCreatureCurrentAP";
            numCreatureCurrentAP.Size = new Size(107, 23);
            numCreatureCurrentAP.TabIndex = 21;
            numCreatureCurrentAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numCreatureCurrentAP.ValueChanged += CreaturePropertyChanged;
            // 
            // btnMaxOtherCurrentAP
            // 
            btnMaxOtherCurrentAP.Location = new Point(196, 119);
            btnMaxOtherCurrentAP.Margin = new Padding(4, 3, 4, 3);
            btnMaxOtherCurrentAP.Name = "btnMaxOtherCurrentAP";
            btnMaxOtherCurrentAP.Size = new Size(52, 23);
            btnMaxOtherCurrentAP.TabIndex = 22;
            btnMaxOtherCurrentAP.Text = "Max";
            btnMaxOtherCurrentAP.UseVisualStyleBackColor = true;
            // 
            // btnMaxOther
            // 
            btnMaxOther.Location = new Point(81, 148);
            btnMaxOther.Margin = new Padding(4, 3, 4, 3);
            btnMaxOther.Name = "btnMaxOther";
            btnMaxOther.Size = new Size(107, 23);
            btnMaxOther.TabIndex = 16;
            btnMaxOther.Text = "Max All";
            btnMaxOther.UseVisualStyleBackColor = true;
            // 
            // lvCreatureList
            // 
            lvCreatureList.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader15, columnHeader5, columnHeader8 });
            lvCreatureList.Dock = DockStyle.Fill;
            lvCreatureList.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvCreatureList.FullRowSelect = true;
            lvCreatureList.Location = new Point(254, 3);
            lvCreatureList.Margin = new Padding(4, 3, 4, 3);
            lvCreatureList.Name = "lvCreatureList";
            lvCreatureList.Size = new Size(707, 495);
            lvCreatureList.Sorting = SortOrder.Ascending;
            lvCreatureList.TabIndex = 21;
            lvCreatureList.UseCompatibleStateImageBehavior = false;
            lvCreatureList.View = View.Details;
            lvCreatureList.SelectedIndexChanged += lvCreatureList_SelectedIndexChanged;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Hash";
            columnHeader4.Width = 112;
            // 
            // columnHeader15
            // 
            columnHeader15.Text = "Name";
            columnHeader15.Width = 200;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Type";
            columnHeader5.Width = 80;
            // 
            // columnHeader8
            // 
            columnHeader8.Text = "Type";
            columnHeader8.Width = 80;
            // 
            // tabPageCamera
            // 
            tabPageCamera.Controls.Add(label19);
            tabPageCamera.Controls.Add(tbleCameraPanel);
            tabPageCamera.Location = new Point(4, 24);
            tabPageCamera.Name = "tabPageCamera";
            tabPageCamera.Padding = new Padding(3);
            tabPageCamera.Size = new Size(973, 507);
            tabPageCamera.TabIndex = 7;
            tabPageCamera.Text = "Camera";
            tabPageCamera.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(310, 36);
            label19.Name = "label19";
            label19.Size = new Size(270, 15);
            label19.TabIndex = 1;
            label19.Text = "Currently disabled until I can verify what these do.";
            // 
            // tbleCameraPanel
            // 
            tbleCameraPanel.ColumnCount = 2;
            tbleCameraPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbleCameraPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tbleCameraPanel.Controls.Add(numCameraMode, 1, 8);
            tbleCameraPanel.Controls.Add(numCameraUnknown, 1, 0);
            tbleCameraPanel.Controls.Add(numCameraPosZ, 1, 7);
            tbleCameraPanel.Controls.Add(numCameraFoV, 1, 1);
            tbleCameraPanel.Controls.Add(numCameraPosY, 1, 6);
            tbleCameraPanel.Controls.Add(numCameraPitch, 1, 2);
            tbleCameraPanel.Controls.Add(numCameraPosX, 1, 5);
            tbleCameraPanel.Controls.Add(numCameraYaw, 1, 3);
            tbleCameraPanel.Controls.Add(numCameraZoom, 1, 4);
            tbleCameraPanel.Controls.Add(label1, 0, 0);
            tbleCameraPanel.Controls.Add(label2, 0, 1);
            tbleCameraPanel.Controls.Add(label3, 0, 2);
            tbleCameraPanel.Controls.Add(label8, 0, 3);
            tbleCameraPanel.Controls.Add(label9, 0, 4);
            tbleCameraPanel.Controls.Add(label11, 0, 5);
            tbleCameraPanel.Controls.Add(label12, 0, 6);
            tbleCameraPanel.Controls.Add(label17, 0, 7);
            tbleCameraPanel.Controls.Add(label18, 0, 8);
            tbleCameraPanel.Enabled = false;
            tbleCameraPanel.Location = new Point(8, 6);
            tbleCameraPanel.Name = "tbleCameraPanel";
            tbleCameraPanel.RowCount = 10;
            tbleCameraPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tbleCameraPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tbleCameraPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tbleCameraPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tbleCameraPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tbleCameraPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tbleCameraPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tbleCameraPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tbleCameraPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tbleCameraPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tbleCameraPanel.Size = new Size(259, 338);
            tbleCameraPanel.TabIndex = 0;
            // 
            // numCameraMode
            // 
            numCameraMode.DecimalPlaces = 5;
            numCameraMode.Location = new Point(132, 235);
            numCameraMode.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numCameraMode.Name = "numCameraMode";
            numCameraMode.Size = new Size(124, 23);
            numCameraMode.TabIndex = 1;
            // 
            // numCameraUnknown
            // 
            numCameraUnknown.DecimalPlaces = 5;
            numCameraUnknown.Location = new Point(132, 3);
            numCameraUnknown.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numCameraUnknown.Name = "numCameraUnknown";
            numCameraUnknown.Size = new Size(124, 23);
            numCameraUnknown.TabIndex = 1;
            // 
            // numCameraPosZ
            // 
            numCameraPosZ.DecimalPlaces = 5;
            numCameraPosZ.Location = new Point(132, 206);
            numCameraPosZ.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numCameraPosZ.Name = "numCameraPosZ";
            numCameraPosZ.Size = new Size(124, 23);
            numCameraPosZ.TabIndex = 1;
            // 
            // numCameraFoV
            // 
            numCameraFoV.DecimalPlaces = 5;
            numCameraFoV.Location = new Point(132, 32);
            numCameraFoV.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numCameraFoV.Name = "numCameraFoV";
            numCameraFoV.Size = new Size(124, 23);
            numCameraFoV.TabIndex = 1;
            // 
            // numCameraPosY
            // 
            numCameraPosY.DecimalPlaces = 5;
            numCameraPosY.Location = new Point(132, 177);
            numCameraPosY.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numCameraPosY.Name = "numCameraPosY";
            numCameraPosY.Size = new Size(124, 23);
            numCameraPosY.TabIndex = 1;
            // 
            // numCameraPitch
            // 
            numCameraPitch.DecimalPlaces = 5;
            numCameraPitch.Location = new Point(132, 61);
            numCameraPitch.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numCameraPitch.Name = "numCameraPitch";
            numCameraPitch.Size = new Size(124, 23);
            numCameraPitch.TabIndex = 1;
            // 
            // numCameraPosX
            // 
            numCameraPosX.DecimalPlaces = 5;
            numCameraPosX.Location = new Point(132, 148);
            numCameraPosX.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numCameraPosX.Name = "numCameraPosX";
            numCameraPosX.Size = new Size(124, 23);
            numCameraPosX.TabIndex = 1;
            // 
            // numCameraYaw
            // 
            numCameraYaw.DecimalPlaces = 5;
            numCameraYaw.Location = new Point(132, 90);
            numCameraYaw.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numCameraYaw.Name = "numCameraYaw";
            numCameraYaw.Size = new Size(124, 23);
            numCameraYaw.TabIndex = 1;
            // 
            // numCameraZoom
            // 
            numCameraZoom.DecimalPlaces = 5;
            numCameraZoom.Location = new Point(132, 119);
            numCameraZoom.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numCameraZoom.Name = "numCameraZoom";
            numCameraZoom.Size = new Size(124, 23);
            numCameraZoom.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Unknown";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 29);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Field of View?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 58);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 2;
            label3.Text = "Pitch?";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 87);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 2;
            label8.Text = "Yaw?";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 116);
            label9.Name = "label9";
            label9.Size = new Size(44, 15);
            label9.TabIndex = 2;
            label9.Text = "Zoom?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 145);
            label11.Name = "label11";
            label11.Size = new Size(60, 15);
            label11.TabIndex = 2;
            label11.Text = "Position X";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 174);
            label12.Name = "label12";
            label12.Size = new Size(60, 15);
            label12.TabIndex = 2;
            label12.Text = "Position Y";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 203);
            label17.Name = "label17";
            label17.Size = new Size(60, 15);
            label17.TabIndex = 2;
            label17.Text = "Position Z";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 232);
            label18.Name = "label18";
            label18.Size = new Size(38, 15);
            label18.TabIndex = 2;
            label18.Text = "Mode";
            // 
            // tabPageInventory
            // 
            tabPageInventory.Controls.Add(tableLayoutPanel1);
            tabPageInventory.Location = new Point(4, 24);
            tabPageInventory.Margin = new Padding(4, 3, 4, 3);
            tabPageInventory.Name = "tabPageInventory";
            tabPageInventory.Padding = new Padding(4, 3, 4, 3);
            tabPageInventory.Size = new Size(973, 507);
            tabPageInventory.TabIndex = 5;
            tabPageInventory.Text = "Inventory";
            tabPageInventory.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.48877F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 252F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 53.51123F));
            tableLayoutPanel1.Controls.Add(lblGameItems, 0, 0);
            tableLayoutPanel1.Controls.Add(pnlInventoryControls, 1, 1);
            tableLayoutPanel1.Controls.Add(lvGameItems, 0, 1);
            tableLayoutPanel1.Controls.Add(lvInventory, 2, 1);
            tableLayoutPanel1.Controls.Add(lblInventory, 2, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(4, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(965, 501);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // lblGameItems
            // 
            lblGameItems.AutoSize = true;
            lblGameItems.Dock = DockStyle.Fill;
            lblGameItems.Location = new Point(4, 0);
            lblGameItems.Margin = new Padding(4, 0, 4, 0);
            lblGameItems.Name = "lblGameItems";
            lblGameItems.Size = new Size(323, 29);
            lblGameItems.TabIndex = 17;
            lblGameItems.Text = "Game Items";
            lblGameItems.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlInventoryControls
            // 
            pnlInventoryControls.Controls.Add(gbGold);
            pnlInventoryControls.Controls.Add(btnAddItem);
            pnlInventoryControls.Controls.Add(btnToggleIdentified);
            pnlInventoryControls.Controls.Add(btnRemoveItem);
            pnlInventoryControls.Controls.Add(btnClearInventory);
            pnlInventoryControls.Controls.Add(GBoxItemQuantity);
            pnlInventoryControls.Controls.Add(btnAddAllItems);
            pnlInventoryControls.Dock = DockStyle.Fill;
            pnlInventoryControls.Location = new Point(331, 29);
            pnlInventoryControls.Margin = new Padding(0);
            pnlInventoryControls.Name = "pnlInventoryControls";
            pnlInventoryControls.Size = new Size(252, 472);
            pnlInventoryControls.TabIndex = 23;
            // 
            // gbGold
            // 
            gbGold.Controls.Add(btnMaxGold);
            gbGold.Controls.Add(numGold);
            gbGold.Location = new Point(4, 3);
            gbGold.Margin = new Padding(4, 3, 4, 3);
            gbGold.Name = "gbGold";
            gbGold.Padding = new Padding(4, 3, 4, 3);
            gbGold.Size = new Size(244, 63);
            gbGold.TabIndex = 10;
            gbGold.TabStop = false;
            gbGold.Text = "Gold";
            // 
            // btnMaxGold
            // 
            btnMaxGold.Location = new Point(177, 23);
            btnMaxGold.Margin = new Padding(4, 3, 4, 3);
            btnMaxGold.Name = "btnMaxGold";
            btnMaxGold.Size = new Size(59, 26);
            btnMaxGold.TabIndex = 1;
            btnMaxGold.Text = "Max";
            btnMaxGold.UseVisualStyleBackColor = true;
            btnMaxGold.Click += btnMaxGold_Click;
            // 
            // numGold
            // 
            numGold.Location = new Point(8, 24);
            numGold.Margin = new Padding(4, 3, 4, 3);
            numGold.Maximum = new decimal(new int[] { 2000000000, 0, 0, 0 });
            numGold.Name = "numGold";
            numGold.Size = new Size(161, 23);
            numGold.TabIndex = 0;
            // 
            // btnAddItem
            // 
            btnAddItem.Location = new Point(12, 72);
            btnAddItem.Margin = new Padding(4, 3, 4, 3);
            btnAddItem.Name = "btnAddItem";
            btnAddItem.Size = new Size(228, 26);
            btnAddItem.TabIndex = 12;
            btnAddItem.Text = "Add Selected to Inventory 🡆";
            btnAddItem.UseVisualStyleBackColor = true;
            btnAddItem.Click += btnAddItem_Click;
            // 
            // btnToggleIdentified
            // 
            btnToggleIdentified.Location = new Point(12, 184);
            btnToggleIdentified.Name = "btnToggleIdentified";
            btnToggleIdentified.Size = new Size(228, 26);
            btnToggleIdentified.TabIndex = 21;
            btnToggleIdentified.Text = "🡄 Toggle Identified";
            btnToggleIdentified.UseVisualStyleBackColor = true;
            btnToggleIdentified.Click += btnToggleIdentified_Click;
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(12, 156);
            btnRemoveItem.Margin = new Padding(4, 3, 4, 3);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(228, 26);
            btnRemoveItem.TabIndex = 13;
            btnRemoveItem.Text = "Remove Selected";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += btnRemoveItem_Click;
            // 
            // btnClearInventory
            // 
            btnClearInventory.Location = new Point(12, 128);
            btnClearInventory.Margin = new Padding(4, 3, 4, 3);
            btnClearInventory.Name = "btnClearInventory";
            btnClearInventory.Size = new Size(228, 26);
            btnClearInventory.TabIndex = 14;
            btnClearInventory.Text = "Clear Inventory";
            btnClearInventory.UseVisualStyleBackColor = true;
            btnClearInventory.Click += btnClearInventory_Click;
            // 
            // GBoxItemQuantity
            // 
            GBoxItemQuantity.Controls.Add(btnApplyToAll);
            GBoxItemQuantity.Controls.Add(btnApplyToSelected);
            GBoxItemQuantity.Controls.Add(numCharges);
            GBoxItemQuantity.Controls.Add(numQuantity);
            GBoxItemQuantity.Controls.Add(lblCharges);
            GBoxItemQuantity.Controls.Add(lblQuantity);
            GBoxItemQuantity.Location = new Point(4, 216);
            GBoxItemQuantity.Margin = new Padding(4, 3, 4, 3);
            GBoxItemQuantity.Name = "GBoxItemQuantity";
            GBoxItemQuantity.Padding = new Padding(4, 3, 4, 3);
            GBoxItemQuantity.Size = new Size(244, 147);
            GBoxItemQuantity.TabIndex = 11;
            GBoxItemQuantity.TabStop = false;
            GBoxItemQuantity.Text = "Item Quantity";
            // 
            // btnApplyToAll
            // 
            btnApplyToAll.Location = new Point(8, 109);
            btnApplyToAll.Margin = new Padding(4, 3, 4, 3);
            btnApplyToAll.Name = "btnApplyToAll";
            btnApplyToAll.Size = new Size(228, 26);
            btnApplyToAll.TabIndex = 12;
            btnApplyToAll.Text = "Apply to All 🡆";
            btnApplyToAll.UseVisualStyleBackColor = true;
            btnApplyToAll.Click += btnApplyToAll_Click;
            // 
            // btnApplyToSelected
            // 
            btnApplyToSelected.Location = new Point(8, 80);
            btnApplyToSelected.Margin = new Padding(4, 3, 4, 3);
            btnApplyToSelected.Name = "btnApplyToSelected";
            btnApplyToSelected.Size = new Size(228, 26);
            btnApplyToSelected.TabIndex = 13;
            btnApplyToSelected.Text = "Apply to Selected 🡆";
            btnApplyToSelected.UseVisualStyleBackColor = true;
            btnApplyToSelected.Click += btnApplyToSelected_Click;
            // 
            // numCharges
            // 
            numCharges.Location = new Point(140, 48);
            numCharges.Margin = new Padding(4, 3, 4, 3);
            numCharges.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numCharges.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numCharges.Name = "numCharges";
            numCharges.Size = new Size(96, 23);
            numCharges.TabIndex = 12;
            numCharges.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(140, 22);
            numQuantity.Margin = new Padding(4, 3, 4, 3);
            numQuantity.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(96, 23);
            numQuantity.TabIndex = 12;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblCharges
            // 
            lblCharges.Location = new Point(8, 49);
            lblCharges.Margin = new Padding(4, 0, 4, 0);
            lblCharges.Name = "lblCharges";
            lblCharges.Size = new Size(73, 21);
            lblCharges.TabIndex = 12;
            lblCharges.Text = "Charges:";
            // 
            // lblQuantity
            // 
            lblQuantity.Location = new Point(8, 23);
            lblQuantity.Margin = new Padding(4, 0, 4, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(73, 21);
            lblQuantity.TabIndex = 12;
            lblQuantity.Text = "Quantity:";
            // 
            // btnAddAllItems
            // 
            btnAddAllItems.Location = new Point(12, 100);
            btnAddAllItems.Margin = new Padding(4, 3, 4, 3);
            btnAddAllItems.Name = "btnAddAllItems";
            btnAddAllItems.Size = new Size(228, 26);
            btnAddAllItems.TabIndex = 15;
            btnAddAllItems.Text = "Add ALL Items 🡆";
            btnAddAllItems.UseVisualStyleBackColor = true;
            btnAddAllItems.Click += btnAddAllItems_Click;
            // 
            // lvGameItems
            // 
            lvGameItems.Columns.AddRange(new ColumnHeader[] { columnHeader17, columnHeader16 });
            lvGameItems.Dock = DockStyle.Fill;
            lvGameItems.FullRowSelect = true;
            lvGameItems.Location = new Point(3, 32);
            lvGameItems.Name = "lvGameItems";
            lvGameItems.Size = new Size(325, 466);
            lvGameItems.TabIndex = 22;
            lvGameItems.UseCompatibleStateImageBehavior = false;
            lvGameItems.View = View.Details;
            // 
            // columnHeader17
            // 
            columnHeader17.Text = "Item Name";
            columnHeader17.Width = 180;
            // 
            // columnHeader16
            // 
            columnHeader16.Text = "Flag";
            columnHeader16.Width = 100;
            // 
            // lvInventory
            // 
            lvInventory.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            lvInventory.Dock = DockStyle.Fill;
            lvInventory.FullRowSelect = true;
            lvInventory.Location = new Point(587, 32);
            lvInventory.Margin = new Padding(4, 3, 4, 3);
            lvInventory.Name = "lvInventory";
            lvInventory.Size = new Size(374, 466);
            lvInventory.TabIndex = 20;
            lvInventory.UseCompatibleStateImageBehavior = false;
            lvInventory.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Item Name";
            columnHeader1.Width = 180;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Quantity";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Charges";
            columnHeader3.Width = 80;
            // 
            // lblInventory
            // 
            lblInventory.AutoSize = true;
            lblInventory.Dock = DockStyle.Fill;
            lblInventory.Location = new Point(587, 0);
            lblInventory.Margin = new Padding(4, 0, 4, 0);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(374, 29);
            lblInventory.TabIndex = 9;
            lblInventory.Text = "Inventory";
            lblInventory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPageJekhar
            // 
            tabPageJekhar.Controls.Add(tblJekhar);
            tabPageJekhar.Location = new Point(4, 24);
            tabPageJekhar.Margin = new Padding(4, 3, 4, 3);
            tabPageJekhar.Name = "tabPageJekhar";
            tabPageJekhar.Padding = new Padding(4, 3, 4, 3);
            tabPageJekhar.Size = new Size(973, 507);
            tabPageJekhar.TabIndex = 3;
            tabPageJekhar.Text = "Jekhar";
            // 
            // tblJekhar
            // 
            tblJekhar.ColumnCount = 6;
            tblJekhar.ColumnStyles.Add(new ColumnStyle());
            tblJekhar.ColumnStyles.Add(new ColumnStyle());
            tblJekhar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tblJekhar.ColumnStyles.Add(new ColumnStyle());
            tblJekhar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tblJekhar.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 282F));
            tblJekhar.Controls.Add(lblJeAmulet, 3, 0);
            tblJekhar.Controls.Add(lblJeRing1, 3, 1);
            tblJekhar.Controls.Add(lblJeRing2, 3, 2);
            tblJekhar.Controls.Add(lblJeGauntlets, 3, 3);
            tblJekhar.Controls.Add(lblJeWeapon, 3, 4);
            tblJekhar.Controls.Add(lblJeShield, 3, 5);
            tblJekhar.Controls.Add(lblJeBoots, 3, 6);
            tblJekhar.Controls.Add(lblJeTorso, 3, 7);
            tblJekhar.Controls.Add(lblJeCurrentHP, 0, 4);
            tblJekhar.Controls.Add(cbJeLeggings, 4, 8);
            tblJekhar.Controls.Add(cbJeTorso, 4, 7);
            tblJekhar.Controls.Add(cbJeBoots, 4, 6);
            tblJekhar.Controls.Add(cbJeShield, 4, 5);
            tblJekhar.Controls.Add(cbJeWeapon, 4, 4);
            tblJekhar.Controls.Add(cbJeGauntlets, 4, 3);
            tblJekhar.Controls.Add(cbJeRing2, 4, 2);
            tblJekhar.Controls.Add(cbJeRing1, 4, 1);
            tblJekhar.Controls.Add(cbJeAmulet, 4, 0);
            tblJekhar.Controls.Add(numJeCurrentHP, 1, 4);
            tblJekhar.Controls.Add(btnJeMaxCurrentHP, 2, 4);
            tblJekhar.Controls.Add(lblJeCurrentAP, 0, 6);
            tblJekhar.Controls.Add(numJeCurrentAP, 1, 6);
            tblJekhar.Controls.Add(btnJeMaxCurrentAP, 2, 6);
            tblJekhar.Controls.Add(lblJeSpeed, 0, 7);
            tblJekhar.Controls.Add(numJeSpeed, 1, 7);
            tblJekhar.Controls.Add(btnJeMaxSpeed, 2, 7);
            tblJekhar.Controls.Add(lblJeLeggings, 3, 8);
            tblJekhar.Controls.Add(btnJeMaxAll, 1, 8);
            tblJekhar.Controls.Add(btnJeMaxBaseAP, 2, 5);
            tblJekhar.Controls.Add(numJeBaseAP, 1, 5);
            tblJekhar.Controls.Add(btnJeMaxBaseHP, 2, 3);
            tblJekhar.Controls.Add(lblJeBaseAP, 0, 5);
            tblJekhar.Controls.Add(numJeBaseHP, 1, 3);
            tblJekhar.Controls.Add(numJeLevel, 1, 0);
            tblJekhar.Controls.Add(lblJeBaseHP, 0, 3);
            tblJekhar.Controls.Add(numJeExperience, 1, 1);
            tblJekhar.Controls.Add(lblJeSkillPoints, 0, 2);
            tblJekhar.Controls.Add(btnJeMaxLevel, 2, 0);
            tblJekhar.Controls.Add(lblJeLevel, 0, 0);
            tblJekhar.Controls.Add(lblJeExperience, 0, 1);
            tblJekhar.Controls.Add(btnJeMaxExp, 2, 1);
            tblJekhar.Controls.Add(numJeSkill, 1, 2);
            tblJekhar.Controls.Add(btnJeMaxSkill, 2, 2);
            tblJekhar.Controls.Add(lvJekharSkills, 5, 0);
            tblJekhar.Controls.Add(tableLayoutPanel7, 5, 8);
            tblJekhar.Dock = DockStyle.Fill;
            tblJekhar.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblJekhar.Location = new Point(4, 3);
            tblJekhar.Margin = new Padding(4, 3, 4, 3);
            tblJekhar.Name = "tblJekhar";
            tblJekhar.RowCount = 10;
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.Size = new Size(965, 501);
            tblJekhar.TabIndex = 27;
            // 
            // lblJeAmulet
            // 
            lblJeAmulet.AutoSize = true;
            lblJeAmulet.Dock = DockStyle.Fill;
            lblJeAmulet.Location = new Point(256, 0);
            lblJeAmulet.Margin = new Padding(4, 0, 4, 0);
            lblJeAmulet.Name = "lblJeAmulet";
            lblJeAmulet.Size = new Size(62, 29);
            lblJeAmulet.TabIndex = 32;
            lblJeAmulet.Text = "Amulet";
            lblJeAmulet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJeRing1
            // 
            lblJeRing1.AutoSize = true;
            lblJeRing1.Dock = DockStyle.Fill;
            lblJeRing1.Location = new Point(256, 29);
            lblJeRing1.Margin = new Padding(4, 0, 4, 0);
            lblJeRing1.Name = "lblJeRing1";
            lblJeRing1.Size = new Size(62, 29);
            lblJeRing1.TabIndex = 33;
            lblJeRing1.Text = "Left Right";
            lblJeRing1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJeRing2
            // 
            lblJeRing2.AutoSize = true;
            lblJeRing2.Dock = DockStyle.Fill;
            lblJeRing2.Location = new Point(256, 58);
            lblJeRing2.Margin = new Padding(4, 0, 4, 0);
            lblJeRing2.Name = "lblJeRing2";
            lblJeRing2.Size = new Size(62, 29);
            lblJeRing2.TabIndex = 34;
            lblJeRing2.Text = "Right Ring";
            lblJeRing2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJeGauntlets
            // 
            lblJeGauntlets.AutoSize = true;
            lblJeGauntlets.Dock = DockStyle.Fill;
            lblJeGauntlets.Location = new Point(256, 87);
            lblJeGauntlets.Margin = new Padding(4, 0, 4, 0);
            lblJeGauntlets.Name = "lblJeGauntlets";
            lblJeGauntlets.Size = new Size(62, 29);
            lblJeGauntlets.TabIndex = 35;
            lblJeGauntlets.Text = "Gauntlets";
            lblJeGauntlets.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJeWeapon
            // 
            lblJeWeapon.AutoSize = true;
            lblJeWeapon.Dock = DockStyle.Fill;
            lblJeWeapon.Location = new Point(256, 116);
            lblJeWeapon.Margin = new Padding(4, 0, 4, 0);
            lblJeWeapon.Name = "lblJeWeapon";
            lblJeWeapon.Size = new Size(62, 29);
            lblJeWeapon.TabIndex = 36;
            lblJeWeapon.Text = "Weapon";
            lblJeWeapon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJeShield
            // 
            lblJeShield.AutoSize = true;
            lblJeShield.Dock = DockStyle.Fill;
            lblJeShield.Location = new Point(256, 145);
            lblJeShield.Margin = new Padding(4, 0, 4, 0);
            lblJeShield.Name = "lblJeShield";
            lblJeShield.Size = new Size(62, 29);
            lblJeShield.TabIndex = 37;
            lblJeShield.Text = "Shield";
            lblJeShield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJeBoots
            // 
            lblJeBoots.AutoSize = true;
            lblJeBoots.Dock = DockStyle.Fill;
            lblJeBoots.Location = new Point(256, 174);
            lblJeBoots.Margin = new Padding(4, 0, 4, 0);
            lblJeBoots.Name = "lblJeBoots";
            lblJeBoots.Size = new Size(62, 29);
            lblJeBoots.TabIndex = 38;
            lblJeBoots.Text = "Boots";
            lblJeBoots.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJeTorso
            // 
            lblJeTorso.AutoSize = true;
            lblJeTorso.Dock = DockStyle.Fill;
            lblJeTorso.Location = new Point(256, 203);
            lblJeTorso.Margin = new Padding(4, 0, 4, 0);
            lblJeTorso.Name = "lblJeTorso";
            lblJeTorso.Size = new Size(62, 29);
            lblJeTorso.TabIndex = 39;
            lblJeTorso.Text = "Torso";
            lblJeTorso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJeCurrentHP
            // 
            lblJeCurrentHP.AutoSize = true;
            lblJeCurrentHP.Dock = DockStyle.Fill;
            lblJeCurrentHP.Location = new Point(4, 116);
            lblJeCurrentHP.Margin = new Padding(4, 0, 4, 0);
            lblJeCurrentHP.Name = "lblJeCurrentHP";
            lblJeCurrentHP.Size = new Size(69, 29);
            lblJeCurrentHP.TabIndex = 26;
            lblJeCurrentHP.Text = "Current HP:";
            lblJeCurrentHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbJeLeggings
            // 
            cbJeLeggings.Dock = DockStyle.Fill;
            cbJeLeggings.DropDownHeight = 300;
            cbJeLeggings.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJeLeggings.FormattingEnabled = true;
            cbJeLeggings.IntegralHeight = false;
            cbJeLeggings.Location = new Point(326, 235);
            cbJeLeggings.Margin = new Padding(4, 3, 4, 3);
            cbJeLeggings.Name = "cbJeLeggings";
            cbJeLeggings.Size = new Size(252, 23);
            cbJeLeggings.TabIndex = 23;
            // 
            // cbJeTorso
            // 
            cbJeTorso.Dock = DockStyle.Fill;
            cbJeTorso.DropDownHeight = 300;
            cbJeTorso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJeTorso.FormattingEnabled = true;
            cbJeTorso.IntegralHeight = false;
            cbJeTorso.Location = new Point(326, 206);
            cbJeTorso.Margin = new Padding(4, 3, 4, 3);
            cbJeTorso.Name = "cbJeTorso";
            cbJeTorso.Size = new Size(252, 23);
            cbJeTorso.TabIndex = 23;
            // 
            // cbJeBoots
            // 
            cbJeBoots.Dock = DockStyle.Fill;
            cbJeBoots.DropDownHeight = 300;
            cbJeBoots.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJeBoots.FormattingEnabled = true;
            cbJeBoots.IntegralHeight = false;
            cbJeBoots.Location = new Point(326, 177);
            cbJeBoots.Margin = new Padding(4, 3, 4, 3);
            cbJeBoots.Name = "cbJeBoots";
            cbJeBoots.Size = new Size(252, 23);
            cbJeBoots.TabIndex = 23;
            // 
            // cbJeShield
            // 
            cbJeShield.Dock = DockStyle.Fill;
            cbJeShield.DropDownHeight = 300;
            cbJeShield.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJeShield.FormattingEnabled = true;
            cbJeShield.IntegralHeight = false;
            cbJeShield.Location = new Point(326, 148);
            cbJeShield.Margin = new Padding(4, 3, 4, 3);
            cbJeShield.Name = "cbJeShield";
            cbJeShield.Size = new Size(252, 23);
            cbJeShield.TabIndex = 23;
            // 
            // cbJeWeapon
            // 
            cbJeWeapon.Dock = DockStyle.Fill;
            cbJeWeapon.DropDownHeight = 300;
            cbJeWeapon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJeWeapon.FormattingEnabled = true;
            cbJeWeapon.IntegralHeight = false;
            cbJeWeapon.Location = new Point(326, 119);
            cbJeWeapon.Margin = new Padding(4, 3, 4, 3);
            cbJeWeapon.Name = "cbJeWeapon";
            cbJeWeapon.Size = new Size(252, 23);
            cbJeWeapon.TabIndex = 23;
            // 
            // cbJeGauntlets
            // 
            cbJeGauntlets.Dock = DockStyle.Fill;
            cbJeGauntlets.DropDownHeight = 300;
            cbJeGauntlets.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJeGauntlets.FormattingEnabled = true;
            cbJeGauntlets.IntegralHeight = false;
            cbJeGauntlets.Location = new Point(326, 90);
            cbJeGauntlets.Margin = new Padding(4, 3, 4, 3);
            cbJeGauntlets.Name = "cbJeGauntlets";
            cbJeGauntlets.Size = new Size(252, 23);
            cbJeGauntlets.TabIndex = 23;
            // 
            // cbJeRing2
            // 
            cbJeRing2.Dock = DockStyle.Fill;
            cbJeRing2.DropDownHeight = 300;
            cbJeRing2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJeRing2.FormattingEnabled = true;
            cbJeRing2.IntegralHeight = false;
            cbJeRing2.Location = new Point(326, 61);
            cbJeRing2.Margin = new Padding(4, 3, 4, 3);
            cbJeRing2.Name = "cbJeRing2";
            cbJeRing2.Size = new Size(252, 23);
            cbJeRing2.TabIndex = 23;
            // 
            // cbJeRing1
            // 
            cbJeRing1.Dock = DockStyle.Fill;
            cbJeRing1.DropDownHeight = 300;
            cbJeRing1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJeRing1.FormattingEnabled = true;
            cbJeRing1.IntegralHeight = false;
            cbJeRing1.Location = new Point(326, 32);
            cbJeRing1.Margin = new Padding(4, 3, 4, 3);
            cbJeRing1.Name = "cbJeRing1";
            cbJeRing1.Size = new Size(252, 23);
            cbJeRing1.TabIndex = 23;
            // 
            // cbJeAmulet
            // 
            cbJeAmulet.Dock = DockStyle.Fill;
            cbJeAmulet.DropDownHeight = 300;
            cbJeAmulet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJeAmulet.FormattingEnabled = true;
            cbJeAmulet.IntegralHeight = false;
            cbJeAmulet.Location = new Point(326, 3);
            cbJeAmulet.Margin = new Padding(4, 3, 4, 3);
            cbJeAmulet.Name = "cbJeAmulet";
            cbJeAmulet.Size = new Size(252, 23);
            cbJeAmulet.TabIndex = 23;
            // 
            // numJeCurrentHP
            // 
            numJeCurrentHP.Dock = DockStyle.Fill;
            numJeCurrentHP.Location = new Point(81, 119);
            numJeCurrentHP.Margin = new Padding(4, 3, 4, 3);
            numJeCurrentHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numJeCurrentHP.Name = "numJeCurrentHP";
            numJeCurrentHP.Size = new Size(107, 23);
            numJeCurrentHP.TabIndex = 24;
            numJeCurrentHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            // 
            // btnJeMaxCurrentHP
            // 
            btnJeMaxCurrentHP.Dock = DockStyle.Fill;
            btnJeMaxCurrentHP.Location = new Point(196, 119);
            btnJeMaxCurrentHP.Margin = new Padding(4, 3, 4, 3);
            btnJeMaxCurrentHP.Name = "btnJeMaxCurrentHP";
            btnJeMaxCurrentHP.Size = new Size(52, 23);
            btnJeMaxCurrentHP.TabIndex = 25;
            btnJeMaxCurrentHP.Text = "Max";
            btnJeMaxCurrentHP.UseVisualStyleBackColor = true;
            // 
            // lblJeCurrentAP
            // 
            lblJeCurrentAP.AutoSize = true;
            lblJeCurrentAP.Dock = DockStyle.Fill;
            lblJeCurrentAP.Location = new Point(4, 174);
            lblJeCurrentAP.Margin = new Padding(4, 0, 4, 0);
            lblJeCurrentAP.Name = "lblJeCurrentAP";
            lblJeCurrentAP.Size = new Size(69, 29);
            lblJeCurrentAP.TabIndex = 23;
            lblJeCurrentAP.Text = "Current AP:";
            lblJeCurrentAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numJeCurrentAP
            // 
            numJeCurrentAP.Dock = DockStyle.Fill;
            numJeCurrentAP.Location = new Point(81, 177);
            numJeCurrentAP.Margin = new Padding(4, 3, 4, 3);
            numJeCurrentAP.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numJeCurrentAP.Name = "numJeCurrentAP";
            numJeCurrentAP.Size = new Size(107, 23);
            numJeCurrentAP.TabIndex = 24;
            numJeCurrentAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnJeMaxCurrentAP
            // 
            btnJeMaxCurrentAP.Dock = DockStyle.Fill;
            btnJeMaxCurrentAP.Location = new Point(196, 177);
            btnJeMaxCurrentAP.Margin = new Padding(4, 3, 4, 3);
            btnJeMaxCurrentAP.Name = "btnJeMaxCurrentAP";
            btnJeMaxCurrentAP.Size = new Size(52, 23);
            btnJeMaxCurrentAP.TabIndex = 25;
            btnJeMaxCurrentAP.Text = "Max";
            btnJeMaxCurrentAP.UseVisualStyleBackColor = true;
            // 
            // lblJeSpeed
            // 
            lblJeSpeed.AutoSize = true;
            lblJeSpeed.Dock = DockStyle.Fill;
            lblJeSpeed.Location = new Point(4, 203);
            lblJeSpeed.Margin = new Padding(4, 0, 4, 0);
            lblJeSpeed.Name = "lblJeSpeed";
            lblJeSpeed.Size = new Size(69, 29);
            lblJeSpeed.TabIndex = 23;
            lblJeSpeed.Text = "Speed:";
            lblJeSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numJeSpeed
            // 
            numJeSpeed.Dock = DockStyle.Fill;
            numJeSpeed.Location = new Point(81, 206);
            numJeSpeed.Margin = new Padding(4, 3, 4, 3);
            numJeSpeed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numJeSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJeSpeed.Name = "numJeSpeed";
            numJeSpeed.Size = new Size(107, 23);
            numJeSpeed.TabIndex = 24;
            numJeSpeed.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnJeMaxSpeed
            // 
            btnJeMaxSpeed.Dock = DockStyle.Fill;
            btnJeMaxSpeed.Location = new Point(196, 206);
            btnJeMaxSpeed.Margin = new Padding(4, 3, 4, 3);
            btnJeMaxSpeed.Name = "btnJeMaxSpeed";
            btnJeMaxSpeed.Size = new Size(52, 23);
            btnJeMaxSpeed.TabIndex = 25;
            btnJeMaxSpeed.Text = "Max";
            btnJeMaxSpeed.UseVisualStyleBackColor = true;
            // 
            // lblJeLeggings
            // 
            lblJeLeggings.AutoSize = true;
            lblJeLeggings.Dock = DockStyle.Fill;
            lblJeLeggings.Location = new Point(256, 232);
            lblJeLeggings.Margin = new Padding(4, 0, 4, 0);
            lblJeLeggings.Name = "lblJeLeggings";
            lblJeLeggings.Size = new Size(62, 29);
            lblJeLeggings.TabIndex = 40;
            lblJeLeggings.Text = "Leggings";
            lblJeLeggings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnJeMaxAll
            // 
            btnJeMaxAll.Dock = DockStyle.Fill;
            btnJeMaxAll.Location = new Point(81, 235);
            btnJeMaxAll.Margin = new Padding(4, 3, 4, 3);
            btnJeMaxAll.Name = "btnJeMaxAll";
            btnJeMaxAll.Size = new Size(107, 23);
            btnJeMaxAll.TabIndex = 19;
            btnJeMaxAll.Text = "Max All";
            btnJeMaxAll.UseVisualStyleBackColor = true;
            // 
            // btnJeMaxBaseAP
            // 
            btnJeMaxBaseAP.Dock = DockStyle.Fill;
            btnJeMaxBaseAP.Location = new Point(196, 148);
            btnJeMaxBaseAP.Margin = new Padding(4, 3, 4, 3);
            btnJeMaxBaseAP.Name = "btnJeMaxBaseAP";
            btnJeMaxBaseAP.Size = new Size(52, 23);
            btnJeMaxBaseAP.TabIndex = 28;
            btnJeMaxBaseAP.Text = "Max";
            btnJeMaxBaseAP.UseVisualStyleBackColor = true;
            // 
            // numJeBaseAP
            // 
            numJeBaseAP.Dock = DockStyle.Fill;
            numJeBaseAP.Location = new Point(81, 148);
            numJeBaseAP.Margin = new Padding(4, 3, 4, 3);
            numJeBaseAP.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numJeBaseAP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJeBaseAP.Name = "numJeBaseAP";
            numJeBaseAP.Size = new Size(107, 23);
            numJeBaseAP.TabIndex = 27;
            numJeBaseAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnJeMaxBaseHP
            // 
            btnJeMaxBaseHP.Dock = DockStyle.Fill;
            btnJeMaxBaseHP.Location = new Point(196, 90);
            btnJeMaxBaseHP.Margin = new Padding(4, 3, 4, 3);
            btnJeMaxBaseHP.Name = "btnJeMaxBaseHP";
            btnJeMaxBaseHP.Size = new Size(52, 23);
            btnJeMaxBaseHP.TabIndex = 31;
            btnJeMaxBaseHP.Text = "Max";
            btnJeMaxBaseHP.UseVisualStyleBackColor = true;
            // 
            // lblJeBaseAP
            // 
            lblJeBaseAP.AutoSize = true;
            lblJeBaseAP.Dock = DockStyle.Fill;
            lblJeBaseAP.Location = new Point(4, 145);
            lblJeBaseAP.Margin = new Padding(4, 0, 4, 0);
            lblJeBaseAP.Name = "lblJeBaseAP";
            lblJeBaseAP.Size = new Size(69, 29);
            lblJeBaseAP.TabIndex = 26;
            lblJeBaseAP.Text = "Max AP:";
            lblJeBaseAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numJeBaseHP
            // 
            numJeBaseHP.Dock = DockStyle.Fill;
            numJeBaseHP.Location = new Point(81, 90);
            numJeBaseHP.Margin = new Padding(4, 3, 4, 3);
            numJeBaseHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numJeBaseHP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJeBaseHP.Name = "numJeBaseHP";
            numJeBaseHP.Size = new Size(107, 23);
            numJeBaseHP.TabIndex = 30;
            numJeBaseHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            // 
            // numJeLevel
            // 
            numJeLevel.Dock = DockStyle.Fill;
            numJeLevel.Location = new Point(81, 3);
            numJeLevel.Margin = new Padding(4, 3, 4, 3);
            numJeLevel.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numJeLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJeLevel.Name = "numJeLevel";
            numJeLevel.Size = new Size(107, 23);
            numJeLevel.TabIndex = 1;
            numJeLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblJeBaseHP
            // 
            lblJeBaseHP.AutoSize = true;
            lblJeBaseHP.Dock = DockStyle.Fill;
            lblJeBaseHP.Location = new Point(4, 87);
            lblJeBaseHP.Margin = new Padding(4, 0, 4, 0);
            lblJeBaseHP.Name = "lblJeBaseHP";
            lblJeBaseHP.Size = new Size(69, 29);
            lblJeBaseHP.TabIndex = 29;
            lblJeBaseHP.Text = "Max HP:";
            lblJeBaseHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numJeExperience
            // 
            numJeExperience.Dock = DockStyle.Fill;
            numJeExperience.Location = new Point(81, 32);
            numJeExperience.Margin = new Padding(4, 3, 4, 3);
            numJeExperience.Maximum = new decimal(new int[] { 6327001, 0, 0, 0 });
            numJeExperience.Name = "numJeExperience";
            numJeExperience.Size = new Size(107, 23);
            numJeExperience.TabIndex = 2;
            // 
            // lblJeSkillPoints
            // 
            lblJeSkillPoints.AutoSize = true;
            lblJeSkillPoints.Dock = DockStyle.Fill;
            lblJeSkillPoints.Location = new Point(4, 58);
            lblJeSkillPoints.Margin = new Padding(4, 0, 4, 0);
            lblJeSkillPoints.Name = "lblJeSkillPoints";
            lblJeSkillPoints.Size = new Size(69, 29);
            lblJeSkillPoints.TabIndex = 3;
            lblJeSkillPoints.Text = "Skill Points:";
            lblJeSkillPoints.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnJeMaxLevel
            // 
            btnJeMaxLevel.Dock = DockStyle.Fill;
            btnJeMaxLevel.Location = new Point(196, 3);
            btnJeMaxLevel.Margin = new Padding(4, 3, 4, 3);
            btnJeMaxLevel.Name = "btnJeMaxLevel";
            btnJeMaxLevel.Size = new Size(52, 23);
            btnJeMaxLevel.TabIndex = 19;
            btnJeMaxLevel.Text = "Max";
            btnJeMaxLevel.UseVisualStyleBackColor = true;
            // 
            // lblJeLevel
            // 
            lblJeLevel.AutoSize = true;
            lblJeLevel.Dock = DockStyle.Fill;
            lblJeLevel.Location = new Point(4, 0);
            lblJeLevel.Margin = new Padding(4, 0, 4, 0);
            lblJeLevel.Name = "lblJeLevel";
            lblJeLevel.Size = new Size(69, 29);
            lblJeLevel.TabIndex = 0;
            lblJeLevel.Text = "Level:";
            lblJeLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJeExperience
            // 
            lblJeExperience.AutoSize = true;
            lblJeExperience.Dock = DockStyle.Fill;
            lblJeExperience.Location = new Point(4, 29);
            lblJeExperience.Margin = new Padding(4, 0, 4, 0);
            lblJeExperience.Name = "lblJeExperience";
            lblJeExperience.Size = new Size(69, 29);
            lblJeExperience.TabIndex = 2;
            lblJeExperience.Text = "Experience:";
            lblJeExperience.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnJeMaxExp
            // 
            btnJeMaxExp.Dock = DockStyle.Fill;
            btnJeMaxExp.Location = new Point(196, 32);
            btnJeMaxExp.Margin = new Padding(4, 3, 4, 3);
            btnJeMaxExp.Name = "btnJeMaxExp";
            btnJeMaxExp.Size = new Size(52, 23);
            btnJeMaxExp.TabIndex = 19;
            btnJeMaxExp.Text = "Max";
            btnJeMaxExp.UseVisualStyleBackColor = true;
            // 
            // numJeSkill
            // 
            numJeSkill.Dock = DockStyle.Fill;
            numJeSkill.Location = new Point(81, 61);
            numJeSkill.Margin = new Padding(4, 3, 4, 3);
            numJeSkill.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
            numJeSkill.Name = "numJeSkill";
            numJeSkill.Size = new Size(107, 23);
            numJeSkill.TabIndex = 2;
            // 
            // btnJeMaxSkill
            // 
            btnJeMaxSkill.Dock = DockStyle.Fill;
            btnJeMaxSkill.Location = new Point(196, 61);
            btnJeMaxSkill.Margin = new Padding(4, 3, 4, 3);
            btnJeMaxSkill.Name = "btnJeMaxSkill";
            btnJeMaxSkill.Size = new Size(52, 23);
            btnJeMaxSkill.TabIndex = 19;
            btnJeMaxSkill.Text = "Max";
            btnJeMaxSkill.UseVisualStyleBackColor = true;
            // 
            // lvJekharSkills
            // 
            lvJekharSkills.Columns.AddRange(new ColumnHeader[] { columnSkillName, columnSkillValue });
            lvJekharSkills.Dock = DockStyle.Fill;
            lvJekharSkills.FullRowSelect = true;
            lvJekharSkills.Location = new Point(586, 3);
            lvJekharSkills.Margin = new Padding(4, 3, 4, 3);
            lvJekharSkills.Name = "lvJekharSkills";
            tblJekhar.SetRowSpan(lvJekharSkills, 8);
            lvJekharSkills.Size = new Size(375, 226);
            lvJekharSkills.TabIndex = 0;
            lvJekharSkills.UseCompatibleStateImageBehavior = false;
            lvJekharSkills.View = View.Details;
            lvJekharSkills.SelectedIndexChanged += lvJekharSkills_SelectedIndexChanged;
            // 
            // columnSkillName
            // 
            columnSkillName.Text = "Skill Name";
            columnSkillName.Width = 216;
            // 
            // columnSkillValue
            // 
            columnSkillValue.Text = "Value";
            columnSkillValue.Width = 63;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 2;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Controls.Add(numJeSkillValue, 0, 0);
            tableLayoutPanel7.Controls.Add(btnJeUpdateSkill, 1, 0);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(582, 232);
            tableLayoutPanel7.Margin = new Padding(0);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 1;
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel7.Size = new Size(383, 29);
            tableLayoutPanel7.TabIndex = 23;
            // 
            // numJeSkillValue
            // 
            numJeSkillValue.Dock = DockStyle.Fill;
            numJeSkillValue.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numJeSkillValue.Location = new Point(4, 3);
            numJeSkillValue.Margin = new Padding(4, 3, 4, 3);
            numJeSkillValue.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numJeSkillValue.Name = "numJeSkillValue";
            numJeSkillValue.Size = new Size(183, 23);
            numJeSkillValue.TabIndex = 3;
            // 
            // btnJeUpdateSkill
            // 
            btnJeUpdateSkill.Dock = DockStyle.Fill;
            btnJeUpdateSkill.Location = new Point(195, 3);
            btnJeUpdateSkill.Margin = new Padding(4, 3, 4, 3);
            btnJeUpdateSkill.Name = "btnJeUpdateSkill";
            btnJeUpdateSkill.Size = new Size(184, 23);
            btnJeUpdateSkill.TabIndex = 4;
            btnJeUpdateSkill.Text = "Update Skill";
            btnJeUpdateSkill.UseVisualStyleBackColor = true;
            btnJeUpdateSkill.Click += btnJeUpdateSkill_Click;
            // 
            // tabPageRosalind
            // 
            tabPageRosalind.Controls.Add(tblRosalind);
            tabPageRosalind.Location = new Point(4, 24);
            tabPageRosalind.Margin = new Padding(4, 3, 4, 3);
            tabPageRosalind.Name = "tabPageRosalind";
            tabPageRosalind.Padding = new Padding(4, 3, 4, 3);
            tabPageRosalind.Size = new Size(973, 507);
            tabPageRosalind.TabIndex = 2;
            tabPageRosalind.Text = "Rosalind";
            // 
            // tblRosalind
            // 
            tblRosalind.ColumnCount = 6;
            tblRosalind.ColumnStyles.Add(new ColumnStyle());
            tblRosalind.ColumnStyles.Add(new ColumnStyle());
            tblRosalind.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tblRosalind.ColumnStyles.Add(new ColumnStyle());
            tblRosalind.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tblRosalind.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 282F));
            tblRosalind.Controls.Add(tableLayoutPanel10, 5, 8);
            tblRosalind.Controls.Add(lvRosalindSkills, 5, 0);
            tblRosalind.Controls.Add(lblRoAmulet, 3, 0);
            tblRosalind.Controls.Add(lblRoRing1, 3, 1);
            tblRosalind.Controls.Add(lblRoRing2, 3, 2);
            tblRosalind.Controls.Add(lblRoGauntlets, 3, 3);
            tblRosalind.Controls.Add(lblRoWeapon, 3, 4);
            tblRosalind.Controls.Add(lblRoShield, 3, 5);
            tblRosalind.Controls.Add(lblRoBoots, 3, 6);
            tblRosalind.Controls.Add(lblRoTorso, 3, 7);
            tblRosalind.Controls.Add(lblRoCurrentHP, 0, 4);
            tblRosalind.Controls.Add(cbRoLeggings, 4, 8);
            tblRosalind.Controls.Add(cbRoTorso, 4, 7);
            tblRosalind.Controls.Add(cbRoBoots, 4, 6);
            tblRosalind.Controls.Add(cbRoShield, 4, 5);
            tblRosalind.Controls.Add(cbRoWeapon, 4, 4);
            tblRosalind.Controls.Add(cbRoGauntlets, 4, 3);
            tblRosalind.Controls.Add(cbRoRing2, 4, 2);
            tblRosalind.Controls.Add(cbRoRing1, 4, 1);
            tblRosalind.Controls.Add(cbRoAmulet, 4, 0);
            tblRosalind.Controls.Add(numRoCurrentHP, 1, 4);
            tblRosalind.Controls.Add(btnRoMaxCurrentHP, 2, 4);
            tblRosalind.Controls.Add(lblRoCurrentAP, 0, 6);
            tblRosalind.Controls.Add(numRoCurrentAP, 1, 6);
            tblRosalind.Controls.Add(btnRoMaxCurrentAP, 2, 6);
            tblRosalind.Controls.Add(lblRoSpeed, 0, 7);
            tblRosalind.Controls.Add(numRoSpeed, 1, 7);
            tblRosalind.Controls.Add(btnRoMaxSpeed, 2, 7);
            tblRosalind.Controls.Add(lblRoLeggings, 3, 8);
            tblRosalind.Controls.Add(btnRoMaxAll, 1, 8);
            tblRosalind.Controls.Add(btnRoMaxBaseAP, 2, 5);
            tblRosalind.Controls.Add(numRoBaseAP, 1, 5);
            tblRosalind.Controls.Add(btnRoMaxBaseHP, 2, 3);
            tblRosalind.Controls.Add(lblRoBaseAP, 0, 5);
            tblRosalind.Controls.Add(numRoBaseHP, 1, 3);
            tblRosalind.Controls.Add(lblRoBaseHP, 0, 3);
            tblRosalind.Controls.Add(btnRoMaxSkill, 2, 2);
            tblRosalind.Controls.Add(numRoSkill, 1, 2);
            tblRosalind.Controls.Add(btnRoMaxExp, 2, 1);
            tblRosalind.Controls.Add(lblRoSkillPoints, 0, 2);
            tblRosalind.Controls.Add(numRoLevel, 1, 0);
            tblRosalind.Controls.Add(numRoExperience, 1, 1);
            tblRosalind.Controls.Add(btnRoMaxLevel, 2, 0);
            tblRosalind.Controls.Add(lblRoLevel, 0, 0);
            tblRosalind.Controls.Add(lblRoExperience, 0, 1);
            tblRosalind.Dock = DockStyle.Fill;
            tblRosalind.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblRosalind.Location = new Point(4, 3);
            tblRosalind.Margin = new Padding(4, 3, 4, 3);
            tblRosalind.Name = "tblRosalind";
            tblRosalind.RowCount = 10;
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.Size = new Size(965, 501);
            tblRosalind.TabIndex = 26;
            // 
            // tableLayoutPanel10
            // 
            tableLayoutPanel10.ColumnCount = 2;
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Controls.Add(numRoSkillValue, 0, 0);
            tableLayoutPanel10.Controls.Add(btnRoUpdateSkill, 1, 0);
            tableLayoutPanel10.Dock = DockStyle.Fill;
            tableLayoutPanel10.Location = new Point(582, 232);
            tableLayoutPanel10.Margin = new Padding(0);
            tableLayoutPanel10.Name = "tableLayoutPanel10";
            tableLayoutPanel10.RowCount = 1;
            tableLayoutPanel10.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel10.Size = new Size(383, 29);
            tableLayoutPanel10.TabIndex = 26;
            // 
            // numRoSkillValue
            // 
            numRoSkillValue.Dock = DockStyle.Fill;
            numRoSkillValue.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numRoSkillValue.Location = new Point(4, 3);
            numRoSkillValue.Margin = new Padding(4, 3, 4, 3);
            numRoSkillValue.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numRoSkillValue.Name = "numRoSkillValue";
            numRoSkillValue.Size = new Size(183, 23);
            numRoSkillValue.TabIndex = 3;
            // 
            // btnRoUpdateSkill
            // 
            btnRoUpdateSkill.Dock = DockStyle.Fill;
            btnRoUpdateSkill.Location = new Point(195, 3);
            btnRoUpdateSkill.Margin = new Padding(4, 3, 4, 3);
            btnRoUpdateSkill.Name = "btnRoUpdateSkill";
            btnRoUpdateSkill.Size = new Size(184, 23);
            btnRoUpdateSkill.TabIndex = 4;
            btnRoUpdateSkill.Text = "Update Skill";
            btnRoUpdateSkill.UseVisualStyleBackColor = true;
            btnRoUpdateSkill.Click += btnRoUpdateSkill_Click_1;
            // 
            // lvRosalindSkills
            // 
            lvRosalindSkills.Columns.AddRange(new ColumnHeader[] { columnHeader13, columnHeader14 });
            lvRosalindSkills.Dock = DockStyle.Fill;
            lvRosalindSkills.FullRowSelect = true;
            lvRosalindSkills.Location = new Point(586, 3);
            lvRosalindSkills.Margin = new Padding(4, 3, 4, 3);
            lvRosalindSkills.Name = "lvRosalindSkills";
            tblRosalind.SetRowSpan(lvRosalindSkills, 8);
            lvRosalindSkills.Size = new Size(375, 226);
            lvRosalindSkills.TabIndex = 29;
            lvRosalindSkills.UseCompatibleStateImageBehavior = false;
            lvRosalindSkills.View = View.Details;
            lvRosalindSkills.SelectedIndexChanged += lvRosalindSkills_SelectedIndexChanged;
            // 
            // columnHeader13
            // 
            columnHeader13.Text = "Skill Name";
            columnHeader13.Width = 216;
            // 
            // columnHeader14
            // 
            columnHeader14.Text = "Value";
            columnHeader14.Width = 63;
            // 
            // lblRoAmulet
            // 
            lblRoAmulet.AutoSize = true;
            lblRoAmulet.Dock = DockStyle.Fill;
            lblRoAmulet.Location = new Point(256, 0);
            lblRoAmulet.Margin = new Padding(4, 0, 4, 0);
            lblRoAmulet.Name = "lblRoAmulet";
            lblRoAmulet.Size = new Size(62, 29);
            lblRoAmulet.TabIndex = 29;
            lblRoAmulet.Text = "Amulet";
            lblRoAmulet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoRing1
            // 
            lblRoRing1.AutoSize = true;
            lblRoRing1.Dock = DockStyle.Fill;
            lblRoRing1.Location = new Point(256, 29);
            lblRoRing1.Margin = new Padding(4, 0, 4, 0);
            lblRoRing1.Name = "lblRoRing1";
            lblRoRing1.Size = new Size(62, 29);
            lblRoRing1.TabIndex = 30;
            lblRoRing1.Text = "Left Right";
            lblRoRing1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoRing2
            // 
            lblRoRing2.AutoSize = true;
            lblRoRing2.Dock = DockStyle.Fill;
            lblRoRing2.Location = new Point(256, 58);
            lblRoRing2.Margin = new Padding(4, 0, 4, 0);
            lblRoRing2.Name = "lblRoRing2";
            lblRoRing2.Size = new Size(62, 29);
            lblRoRing2.TabIndex = 31;
            lblRoRing2.Text = "Right Ring";
            lblRoRing2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoGauntlets
            // 
            lblRoGauntlets.AutoSize = true;
            lblRoGauntlets.Dock = DockStyle.Fill;
            lblRoGauntlets.Location = new Point(256, 87);
            lblRoGauntlets.Margin = new Padding(4, 0, 4, 0);
            lblRoGauntlets.Name = "lblRoGauntlets";
            lblRoGauntlets.Size = new Size(62, 29);
            lblRoGauntlets.TabIndex = 32;
            lblRoGauntlets.Text = "Gauntlets";
            lblRoGauntlets.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoWeapon
            // 
            lblRoWeapon.AutoSize = true;
            lblRoWeapon.Dock = DockStyle.Fill;
            lblRoWeapon.Location = new Point(256, 116);
            lblRoWeapon.Margin = new Padding(4, 0, 4, 0);
            lblRoWeapon.Name = "lblRoWeapon";
            lblRoWeapon.Size = new Size(62, 29);
            lblRoWeapon.TabIndex = 33;
            lblRoWeapon.Text = "Weapon";
            lblRoWeapon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoShield
            // 
            lblRoShield.AutoSize = true;
            lblRoShield.Dock = DockStyle.Fill;
            lblRoShield.Location = new Point(256, 145);
            lblRoShield.Margin = new Padding(4, 0, 4, 0);
            lblRoShield.Name = "lblRoShield";
            lblRoShield.Size = new Size(62, 29);
            lblRoShield.TabIndex = 34;
            lblRoShield.Text = "Shield";
            lblRoShield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoBoots
            // 
            lblRoBoots.AutoSize = true;
            lblRoBoots.Dock = DockStyle.Fill;
            lblRoBoots.Location = new Point(256, 174);
            lblRoBoots.Margin = new Padding(4, 0, 4, 0);
            lblRoBoots.Name = "lblRoBoots";
            lblRoBoots.Size = new Size(62, 29);
            lblRoBoots.TabIndex = 35;
            lblRoBoots.Text = "Boots";
            lblRoBoots.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoTorso
            // 
            lblRoTorso.AutoSize = true;
            lblRoTorso.Dock = DockStyle.Fill;
            lblRoTorso.Location = new Point(256, 203);
            lblRoTorso.Margin = new Padding(4, 0, 4, 0);
            lblRoTorso.Name = "lblRoTorso";
            lblRoTorso.Size = new Size(62, 29);
            lblRoTorso.TabIndex = 36;
            lblRoTorso.Text = "Torso";
            lblRoTorso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoCurrentHP
            // 
            lblRoCurrentHP.AutoSize = true;
            lblRoCurrentHP.Dock = DockStyle.Fill;
            lblRoCurrentHP.Location = new Point(4, 116);
            lblRoCurrentHP.Margin = new Padding(4, 0, 4, 0);
            lblRoCurrentHP.Name = "lblRoCurrentHP";
            lblRoCurrentHP.Size = new Size(69, 29);
            lblRoCurrentHP.TabIndex = 26;
            lblRoCurrentHP.Text = "Current HP:";
            lblRoCurrentHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbRoLeggings
            // 
            cbRoLeggings.Dock = DockStyle.Fill;
            cbRoLeggings.DropDownHeight = 300;
            cbRoLeggings.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoLeggings.FormattingEnabled = true;
            cbRoLeggings.IntegralHeight = false;
            cbRoLeggings.Location = new Point(326, 235);
            cbRoLeggings.Margin = new Padding(4, 3, 4, 3);
            cbRoLeggings.Name = "cbRoLeggings";
            cbRoLeggings.Size = new Size(252, 23);
            cbRoLeggings.TabIndex = 23;
            // 
            // cbRoTorso
            // 
            cbRoTorso.Dock = DockStyle.Fill;
            cbRoTorso.DropDownHeight = 300;
            cbRoTorso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoTorso.FormattingEnabled = true;
            cbRoTorso.IntegralHeight = false;
            cbRoTorso.Location = new Point(326, 206);
            cbRoTorso.Margin = new Padding(4, 3, 4, 3);
            cbRoTorso.Name = "cbRoTorso";
            cbRoTorso.Size = new Size(252, 23);
            cbRoTorso.TabIndex = 23;
            // 
            // cbRoBoots
            // 
            cbRoBoots.Dock = DockStyle.Fill;
            cbRoBoots.DropDownHeight = 300;
            cbRoBoots.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoBoots.FormattingEnabled = true;
            cbRoBoots.IntegralHeight = false;
            cbRoBoots.Location = new Point(326, 177);
            cbRoBoots.Margin = new Padding(4, 3, 4, 3);
            cbRoBoots.Name = "cbRoBoots";
            cbRoBoots.Size = new Size(252, 23);
            cbRoBoots.TabIndex = 23;
            // 
            // cbRoShield
            // 
            cbRoShield.Dock = DockStyle.Fill;
            cbRoShield.DropDownHeight = 300;
            cbRoShield.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoShield.FormattingEnabled = true;
            cbRoShield.IntegralHeight = false;
            cbRoShield.Location = new Point(326, 148);
            cbRoShield.Margin = new Padding(4, 3, 4, 3);
            cbRoShield.Name = "cbRoShield";
            cbRoShield.Size = new Size(252, 23);
            cbRoShield.TabIndex = 23;
            // 
            // cbRoWeapon
            // 
            cbRoWeapon.Dock = DockStyle.Fill;
            cbRoWeapon.DropDownHeight = 300;
            cbRoWeapon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoWeapon.FormattingEnabled = true;
            cbRoWeapon.IntegralHeight = false;
            cbRoWeapon.Location = new Point(326, 119);
            cbRoWeapon.Margin = new Padding(4, 3, 4, 3);
            cbRoWeapon.Name = "cbRoWeapon";
            cbRoWeapon.Size = new Size(252, 23);
            cbRoWeapon.TabIndex = 23;
            // 
            // cbRoGauntlets
            // 
            cbRoGauntlets.Dock = DockStyle.Fill;
            cbRoGauntlets.DropDownHeight = 300;
            cbRoGauntlets.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoGauntlets.FormattingEnabled = true;
            cbRoGauntlets.IntegralHeight = false;
            cbRoGauntlets.Location = new Point(326, 90);
            cbRoGauntlets.Margin = new Padding(4, 3, 4, 3);
            cbRoGauntlets.Name = "cbRoGauntlets";
            cbRoGauntlets.Size = new Size(252, 23);
            cbRoGauntlets.TabIndex = 23;
            // 
            // cbRoRing2
            // 
            cbRoRing2.Dock = DockStyle.Fill;
            cbRoRing2.DropDownHeight = 300;
            cbRoRing2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoRing2.FormattingEnabled = true;
            cbRoRing2.IntegralHeight = false;
            cbRoRing2.Location = new Point(326, 61);
            cbRoRing2.Margin = new Padding(4, 3, 4, 3);
            cbRoRing2.Name = "cbRoRing2";
            cbRoRing2.Size = new Size(252, 23);
            cbRoRing2.TabIndex = 23;
            // 
            // cbRoRing1
            // 
            cbRoRing1.Dock = DockStyle.Fill;
            cbRoRing1.DropDownHeight = 300;
            cbRoRing1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoRing1.FormattingEnabled = true;
            cbRoRing1.IntegralHeight = false;
            cbRoRing1.Location = new Point(326, 32);
            cbRoRing1.Margin = new Padding(4, 3, 4, 3);
            cbRoRing1.Name = "cbRoRing1";
            cbRoRing1.Size = new Size(252, 23);
            cbRoRing1.TabIndex = 23;
            // 
            // cbRoAmulet
            // 
            cbRoAmulet.Dock = DockStyle.Fill;
            cbRoAmulet.DropDownHeight = 300;
            cbRoAmulet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbRoAmulet.FormattingEnabled = true;
            cbRoAmulet.IntegralHeight = false;
            cbRoAmulet.Location = new Point(326, 3);
            cbRoAmulet.Margin = new Padding(4, 3, 4, 3);
            cbRoAmulet.Name = "cbRoAmulet";
            cbRoAmulet.Size = new Size(252, 23);
            cbRoAmulet.TabIndex = 23;
            // 
            // numRoCurrentHP
            // 
            numRoCurrentHP.Dock = DockStyle.Fill;
            numRoCurrentHP.Location = new Point(81, 119);
            numRoCurrentHP.Margin = new Padding(4, 3, 4, 3);
            numRoCurrentHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numRoCurrentHP.Name = "numRoCurrentHP";
            numRoCurrentHP.Size = new Size(107, 23);
            numRoCurrentHP.TabIndex = 24;
            numRoCurrentHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            // 
            // btnRoMaxCurrentHP
            // 
            btnRoMaxCurrentHP.Dock = DockStyle.Fill;
            btnRoMaxCurrentHP.Location = new Point(196, 119);
            btnRoMaxCurrentHP.Margin = new Padding(4, 3, 4, 3);
            btnRoMaxCurrentHP.Name = "btnRoMaxCurrentHP";
            btnRoMaxCurrentHP.Size = new Size(52, 23);
            btnRoMaxCurrentHP.TabIndex = 25;
            btnRoMaxCurrentHP.Text = "Max";
            btnRoMaxCurrentHP.UseVisualStyleBackColor = true;
            // 
            // lblRoCurrentAP
            // 
            lblRoCurrentAP.AutoSize = true;
            lblRoCurrentAP.Dock = DockStyle.Fill;
            lblRoCurrentAP.Location = new Point(4, 174);
            lblRoCurrentAP.Margin = new Padding(4, 0, 4, 0);
            lblRoCurrentAP.Name = "lblRoCurrentAP";
            lblRoCurrentAP.Size = new Size(69, 29);
            lblRoCurrentAP.TabIndex = 23;
            lblRoCurrentAP.Text = "Current AP:";
            lblRoCurrentAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numRoCurrentAP
            // 
            numRoCurrentAP.Dock = DockStyle.Fill;
            numRoCurrentAP.Location = new Point(81, 177);
            numRoCurrentAP.Margin = new Padding(4, 3, 4, 3);
            numRoCurrentAP.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numRoCurrentAP.Name = "numRoCurrentAP";
            numRoCurrentAP.Size = new Size(107, 23);
            numRoCurrentAP.TabIndex = 24;
            numRoCurrentAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnRoMaxCurrentAP
            // 
            btnRoMaxCurrentAP.Dock = DockStyle.Fill;
            btnRoMaxCurrentAP.Location = new Point(196, 177);
            btnRoMaxCurrentAP.Margin = new Padding(4, 3, 4, 3);
            btnRoMaxCurrentAP.Name = "btnRoMaxCurrentAP";
            btnRoMaxCurrentAP.Size = new Size(52, 23);
            btnRoMaxCurrentAP.TabIndex = 25;
            btnRoMaxCurrentAP.Text = "Max";
            btnRoMaxCurrentAP.UseVisualStyleBackColor = true;
            // 
            // lblRoSpeed
            // 
            lblRoSpeed.AutoSize = true;
            lblRoSpeed.Dock = DockStyle.Fill;
            lblRoSpeed.Location = new Point(4, 203);
            lblRoSpeed.Margin = new Padding(4, 0, 4, 0);
            lblRoSpeed.Name = "lblRoSpeed";
            lblRoSpeed.Size = new Size(69, 29);
            lblRoSpeed.TabIndex = 23;
            lblRoSpeed.Text = "Speed:";
            lblRoSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numRoSpeed
            // 
            numRoSpeed.Dock = DockStyle.Fill;
            numRoSpeed.Location = new Point(81, 206);
            numRoSpeed.Margin = new Padding(4, 3, 4, 3);
            numRoSpeed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numRoSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRoSpeed.Name = "numRoSpeed";
            numRoSpeed.Size = new Size(107, 23);
            numRoSpeed.TabIndex = 24;
            numRoSpeed.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnRoMaxSpeed
            // 
            btnRoMaxSpeed.Dock = DockStyle.Fill;
            btnRoMaxSpeed.Location = new Point(196, 206);
            btnRoMaxSpeed.Margin = new Padding(4, 3, 4, 3);
            btnRoMaxSpeed.Name = "btnRoMaxSpeed";
            btnRoMaxSpeed.Size = new Size(52, 23);
            btnRoMaxSpeed.TabIndex = 25;
            btnRoMaxSpeed.Text = "Max";
            btnRoMaxSpeed.UseVisualStyleBackColor = true;
            // 
            // lblRoLeggings
            // 
            lblRoLeggings.AutoSize = true;
            lblRoLeggings.Dock = DockStyle.Fill;
            lblRoLeggings.Location = new Point(256, 232);
            lblRoLeggings.Margin = new Padding(4, 0, 4, 0);
            lblRoLeggings.Name = "lblRoLeggings";
            lblRoLeggings.Size = new Size(62, 29);
            lblRoLeggings.TabIndex = 37;
            lblRoLeggings.Text = "Leggings";
            lblRoLeggings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRoMaxAll
            // 
            btnRoMaxAll.Dock = DockStyle.Fill;
            btnRoMaxAll.Location = new Point(81, 235);
            btnRoMaxAll.Margin = new Padding(4, 3, 4, 3);
            btnRoMaxAll.Name = "btnRoMaxAll";
            btnRoMaxAll.Size = new Size(107, 23);
            btnRoMaxAll.TabIndex = 18;
            btnRoMaxAll.Text = "Max All";
            btnRoMaxAll.UseVisualStyleBackColor = true;
            // 
            // btnRoMaxBaseAP
            // 
            btnRoMaxBaseAP.Dock = DockStyle.Fill;
            btnRoMaxBaseAP.Location = new Point(196, 148);
            btnRoMaxBaseAP.Margin = new Padding(4, 3, 4, 3);
            btnRoMaxBaseAP.Name = "btnRoMaxBaseAP";
            btnRoMaxBaseAP.Size = new Size(52, 23);
            btnRoMaxBaseAP.TabIndex = 28;
            btnRoMaxBaseAP.Text = "Max";
            btnRoMaxBaseAP.UseVisualStyleBackColor = true;
            // 
            // numRoBaseAP
            // 
            numRoBaseAP.Dock = DockStyle.Fill;
            numRoBaseAP.Location = new Point(81, 148);
            numRoBaseAP.Margin = new Padding(4, 3, 4, 3);
            numRoBaseAP.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numRoBaseAP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRoBaseAP.Name = "numRoBaseAP";
            numRoBaseAP.Size = new Size(107, 23);
            numRoBaseAP.TabIndex = 27;
            numRoBaseAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnRoMaxBaseHP
            // 
            btnRoMaxBaseHP.Dock = DockStyle.Fill;
            btnRoMaxBaseHP.Location = new Point(196, 90);
            btnRoMaxBaseHP.Margin = new Padding(4, 3, 4, 3);
            btnRoMaxBaseHP.Name = "btnRoMaxBaseHP";
            btnRoMaxBaseHP.Size = new Size(52, 23);
            btnRoMaxBaseHP.TabIndex = 28;
            btnRoMaxBaseHP.Text = "Max";
            btnRoMaxBaseHP.UseVisualStyleBackColor = true;
            // 
            // lblRoBaseAP
            // 
            lblRoBaseAP.AutoSize = true;
            lblRoBaseAP.Dock = DockStyle.Fill;
            lblRoBaseAP.Location = new Point(4, 145);
            lblRoBaseAP.Margin = new Padding(4, 0, 4, 0);
            lblRoBaseAP.Name = "lblRoBaseAP";
            lblRoBaseAP.Size = new Size(69, 29);
            lblRoBaseAP.TabIndex = 26;
            lblRoBaseAP.Text = "Max AP:";
            lblRoBaseAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numRoBaseHP
            // 
            numRoBaseHP.Dock = DockStyle.Fill;
            numRoBaseHP.Location = new Point(81, 90);
            numRoBaseHP.Margin = new Padding(4, 3, 4, 3);
            numRoBaseHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numRoBaseHP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRoBaseHP.Name = "numRoBaseHP";
            numRoBaseHP.Size = new Size(107, 23);
            numRoBaseHP.TabIndex = 27;
            numRoBaseHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            // 
            // lblRoBaseHP
            // 
            lblRoBaseHP.AutoSize = true;
            lblRoBaseHP.Dock = DockStyle.Fill;
            lblRoBaseHP.Location = new Point(4, 87);
            lblRoBaseHP.Margin = new Padding(4, 0, 4, 0);
            lblRoBaseHP.Name = "lblRoBaseHP";
            lblRoBaseHP.Size = new Size(69, 29);
            lblRoBaseHP.TabIndex = 26;
            lblRoBaseHP.Text = "Max HP:";
            lblRoBaseHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnRoMaxSkill
            // 
            btnRoMaxSkill.Dock = DockStyle.Fill;
            btnRoMaxSkill.Location = new Point(196, 61);
            btnRoMaxSkill.Margin = new Padding(4, 3, 4, 3);
            btnRoMaxSkill.Name = "btnRoMaxSkill";
            btnRoMaxSkill.Size = new Size(52, 23);
            btnRoMaxSkill.TabIndex = 18;
            btnRoMaxSkill.Text = "Max";
            btnRoMaxSkill.UseVisualStyleBackColor = true;
            // 
            // numRoSkill
            // 
            numRoSkill.Dock = DockStyle.Fill;
            numRoSkill.Location = new Point(81, 61);
            numRoSkill.Margin = new Padding(4, 3, 4, 3);
            numRoSkill.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
            numRoSkill.Name = "numRoSkill";
            numRoSkill.Size = new Size(107, 23);
            numRoSkill.TabIndex = 2;
            // 
            // btnRoMaxExp
            // 
            btnRoMaxExp.Dock = DockStyle.Fill;
            btnRoMaxExp.Location = new Point(196, 32);
            btnRoMaxExp.Margin = new Padding(4, 3, 4, 3);
            btnRoMaxExp.Name = "btnRoMaxExp";
            btnRoMaxExp.Size = new Size(52, 23);
            btnRoMaxExp.TabIndex = 17;
            btnRoMaxExp.Text = "Max";
            btnRoMaxExp.UseVisualStyleBackColor = true;
            // 
            // lblRoSkillPoints
            // 
            lblRoSkillPoints.AutoSize = true;
            lblRoSkillPoints.Dock = DockStyle.Fill;
            lblRoSkillPoints.Location = new Point(4, 58);
            lblRoSkillPoints.Margin = new Padding(4, 0, 4, 0);
            lblRoSkillPoints.Name = "lblRoSkillPoints";
            lblRoSkillPoints.Size = new Size(69, 29);
            lblRoSkillPoints.TabIndex = 3;
            lblRoSkillPoints.Text = "Skill Points:";
            lblRoSkillPoints.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numRoLevel
            // 
            numRoLevel.Dock = DockStyle.Fill;
            numRoLevel.Location = new Point(81, 3);
            numRoLevel.Margin = new Padding(4, 3, 4, 3);
            numRoLevel.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numRoLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRoLevel.Name = "numRoLevel";
            numRoLevel.Size = new Size(107, 23);
            numRoLevel.TabIndex = 1;
            numRoLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numRoExperience
            // 
            numRoExperience.Dock = DockStyle.Fill;
            numRoExperience.Location = new Point(81, 32);
            numRoExperience.Margin = new Padding(4, 3, 4, 3);
            numRoExperience.Maximum = new decimal(new int[] { 6327001, 0, 0, 0 });
            numRoExperience.Name = "numRoExperience";
            numRoExperience.Size = new Size(107, 23);
            numRoExperience.TabIndex = 2;
            // 
            // btnRoMaxLevel
            // 
            btnRoMaxLevel.Dock = DockStyle.Fill;
            btnRoMaxLevel.Location = new Point(196, 3);
            btnRoMaxLevel.Margin = new Padding(4, 3, 4, 3);
            btnRoMaxLevel.Name = "btnRoMaxLevel";
            btnRoMaxLevel.Size = new Size(52, 23);
            btnRoMaxLevel.TabIndex = 18;
            btnRoMaxLevel.Text = "Max";
            btnRoMaxLevel.UseVisualStyleBackColor = true;
            // 
            // lblRoLevel
            // 
            lblRoLevel.AutoSize = true;
            lblRoLevel.Dock = DockStyle.Fill;
            lblRoLevel.Location = new Point(4, 0);
            lblRoLevel.Margin = new Padding(4, 0, 4, 0);
            lblRoLevel.Name = "lblRoLevel";
            lblRoLevel.Size = new Size(69, 29);
            lblRoLevel.TabIndex = 0;
            lblRoLevel.Text = "Level:";
            lblRoLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoExperience
            // 
            lblRoExperience.AutoSize = true;
            lblRoExperience.Dock = DockStyle.Fill;
            lblRoExperience.Location = new Point(4, 29);
            lblRoExperience.Margin = new Padding(4, 0, 4, 0);
            lblRoExperience.Name = "lblRoExperience";
            lblRoExperience.Size = new Size(69, 29);
            lblRoExperience.TabIndex = 2;
            lblRoExperience.Text = "Experience:";
            lblRoExperience.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPageFlece
            // 
            tabPageFlece.BackgroundImageLayout = ImageLayout.Stretch;
            tabPageFlece.Controls.Add(tblFlece);
            tabPageFlece.Location = new Point(4, 24);
            tabPageFlece.Margin = new Padding(4, 3, 4, 3);
            tabPageFlece.Name = "tabPageFlece";
            tabPageFlece.Padding = new Padding(4, 3, 4, 3);
            tabPageFlece.Size = new Size(973, 507);
            tabPageFlece.TabIndex = 1;
            tabPageFlece.Text = "Flece";
            // 
            // tblFlece
            // 
            tblFlece.ColumnCount = 6;
            tblFlece.ColumnStyles.Add(new ColumnStyle());
            tblFlece.ColumnStyles.Add(new ColumnStyle());
            tblFlece.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tblFlece.ColumnStyles.Add(new ColumnStyle());
            tblFlece.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tblFlece.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 282F));
            tblFlece.Controls.Add(lblFlAmulet, 3, 0);
            tblFlece.Controls.Add(lvFleceSkills, 5, 0);
            tblFlece.Controls.Add(tableLayoutPanel8, 5, 8);
            tblFlece.Controls.Add(lblFlRing1, 3, 1);
            tblFlece.Controls.Add(lblFlRing2, 3, 2);
            tblFlece.Controls.Add(lblFlGauntlets, 3, 3);
            tblFlece.Controls.Add(lblFlWeapon, 3, 4);
            tblFlece.Controls.Add(lblFlShield, 3, 5);
            tblFlece.Controls.Add(lblFlBoots, 3, 6);
            tblFlece.Controls.Add(lblFlTorso, 3, 7);
            tblFlece.Controls.Add(btnFlMaxAll, 1, 8);
            tblFlece.Controls.Add(btnFlMaxBaseAP, 2, 5);
            tblFlece.Controls.Add(lblFlCurrentHP, 0, 4);
            tblFlece.Controls.Add(numFlBaseAP, 1, 5);
            tblFlece.Controls.Add(btnFlMaxBaseHP, 2, 3);
            tblFlece.Controls.Add(lblFlBaseAP, 0, 5);
            tblFlece.Controls.Add(cbFlLeggings, 4, 8);
            tblFlece.Controls.Add(cbFlTorso, 4, 7);
            tblFlece.Controls.Add(cbFlBoots, 4, 6);
            tblFlece.Controls.Add(numFlBaseHP, 1, 3);
            tblFlece.Controls.Add(cbFlShield, 4, 5);
            tblFlece.Controls.Add(lblFlBaseHP, 0, 3);
            tblFlece.Controls.Add(cbFlWeapon, 4, 4);
            tblFlece.Controls.Add(btnFlMaxSkill, 2, 2);
            tblFlece.Controls.Add(cbFlGauntlets, 4, 3);
            tblFlece.Controls.Add(numFlSkill, 1, 2);
            tblFlece.Controls.Add(btnFlMaxExp, 2, 1);
            tblFlece.Controls.Add(lblFlSkillPoints, 0, 2);
            tblFlece.Controls.Add(numFlLevel, 1, 0);
            tblFlece.Controls.Add(numFlExperience, 1, 1);
            tblFlece.Controls.Add(btnFlMaxLevel, 2, 0);
            tblFlece.Controls.Add(lblFlLevel, 0, 0);
            tblFlece.Controls.Add(cbFlRing2, 4, 2);
            tblFlece.Controls.Add(lblFlExperience, 0, 1);
            tblFlece.Controls.Add(cbFlRing1, 4, 1);
            tblFlece.Controls.Add(cbFlAmulet, 4, 0);
            tblFlece.Controls.Add(numFlCurrentHP, 1, 4);
            tblFlece.Controls.Add(btnFlMaxCurrentHP, 2, 4);
            tblFlece.Controls.Add(lblFlCurrentAP, 0, 6);
            tblFlece.Controls.Add(numFlCurrentAP, 1, 6);
            tblFlece.Controls.Add(btnFlMaxCurrentAP, 2, 6);
            tblFlece.Controls.Add(lblFlSpeed, 0, 7);
            tblFlece.Controls.Add(numFlSpeed, 1, 7);
            tblFlece.Controls.Add(btnFlMaxSpeed, 2, 7);
            tblFlece.Controls.Add(lblFlLeggings, 3, 8);
            tblFlece.Dock = DockStyle.Fill;
            tblFlece.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblFlece.Location = new Point(4, 3);
            tblFlece.Margin = new Padding(4, 3, 4, 3);
            tblFlece.Name = "tblFlece";
            tblFlece.RowCount = 10;
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.Size = new Size(965, 501);
            tblFlece.TabIndex = 27;
            // 
            // lblFlAmulet
            // 
            lblFlAmulet.AutoSize = true;
            lblFlAmulet.Dock = DockStyle.Fill;
            lblFlAmulet.Location = new Point(256, 0);
            lblFlAmulet.Margin = new Padding(4, 0, 4, 0);
            lblFlAmulet.Name = "lblFlAmulet";
            lblFlAmulet.Size = new Size(62, 29);
            lblFlAmulet.TabIndex = 29;
            lblFlAmulet.Text = "Amulet";
            lblFlAmulet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lvFleceSkills
            // 
            lvFleceSkills.Columns.AddRange(new ColumnHeader[] { columnHeader11, columnHeader12 });
            lvFleceSkills.Dock = DockStyle.Fill;
            lvFleceSkills.FullRowSelect = true;
            lvFleceSkills.Location = new Point(586, 3);
            lvFleceSkills.Margin = new Padding(4, 3, 4, 3);
            lvFleceSkills.Name = "lvFleceSkills";
            tblFlece.SetRowSpan(lvFleceSkills, 8);
            lvFleceSkills.Size = new Size(375, 226);
            lvFleceSkills.TabIndex = 28;
            lvFleceSkills.UseCompatibleStateImageBehavior = false;
            lvFleceSkills.View = View.Details;
            lvFleceSkills.SelectedIndexChanged += lvFleceSkills_SelectedIndexChanged;
            // 
            // columnHeader11
            // 
            columnHeader11.Text = "Skill Name";
            columnHeader11.Width = 216;
            // 
            // columnHeader12
            // 
            columnHeader12.Text = "Value";
            columnHeader12.Width = 63;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(numFlSkillValue, 0, 0);
            tableLayoutPanel8.Controls.Add(btnFlUpdateSkill, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(582, 232);
            tableLayoutPanel8.Margin = new Padding(0);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(383, 29);
            tableLayoutPanel8.TabIndex = 24;
            // 
            // numFlSkillValue
            // 
            numFlSkillValue.Dock = DockStyle.Fill;
            numFlSkillValue.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numFlSkillValue.Location = new Point(4, 3);
            numFlSkillValue.Margin = new Padding(4, 3, 4, 3);
            numFlSkillValue.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numFlSkillValue.Name = "numFlSkillValue";
            numFlSkillValue.Size = new Size(183, 23);
            numFlSkillValue.TabIndex = 3;
            // 
            // btnFlUpdateSkill
            // 
            btnFlUpdateSkill.Dock = DockStyle.Fill;
            btnFlUpdateSkill.Location = new Point(195, 3);
            btnFlUpdateSkill.Margin = new Padding(4, 3, 4, 3);
            btnFlUpdateSkill.Name = "btnFlUpdateSkill";
            btnFlUpdateSkill.Size = new Size(184, 23);
            btnFlUpdateSkill.TabIndex = 4;
            btnFlUpdateSkill.Text = "Update Skill";
            btnFlUpdateSkill.UseVisualStyleBackColor = true;
            btnFlUpdateSkill.Click += btnFlUpdateSkill_Click_1;
            // 
            // lblFlRing1
            // 
            lblFlRing1.AutoSize = true;
            lblFlRing1.Dock = DockStyle.Fill;
            lblFlRing1.Location = new Point(256, 29);
            lblFlRing1.Margin = new Padding(4, 0, 4, 0);
            lblFlRing1.Name = "lblFlRing1";
            lblFlRing1.Size = new Size(62, 29);
            lblFlRing1.TabIndex = 30;
            lblFlRing1.Text = "Left Right";
            lblFlRing1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFlRing2
            // 
            lblFlRing2.AutoSize = true;
            lblFlRing2.Dock = DockStyle.Fill;
            lblFlRing2.Location = new Point(256, 58);
            lblFlRing2.Margin = new Padding(4, 0, 4, 0);
            lblFlRing2.Name = "lblFlRing2";
            lblFlRing2.Size = new Size(62, 29);
            lblFlRing2.TabIndex = 31;
            lblFlRing2.Text = "Right Ring";
            lblFlRing2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFlGauntlets
            // 
            lblFlGauntlets.AutoSize = true;
            lblFlGauntlets.Dock = DockStyle.Fill;
            lblFlGauntlets.Location = new Point(256, 87);
            lblFlGauntlets.Margin = new Padding(4, 0, 4, 0);
            lblFlGauntlets.Name = "lblFlGauntlets";
            lblFlGauntlets.Size = new Size(62, 29);
            lblFlGauntlets.TabIndex = 32;
            lblFlGauntlets.Text = "Gauntlets";
            lblFlGauntlets.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFlWeapon
            // 
            lblFlWeapon.AutoSize = true;
            lblFlWeapon.Dock = DockStyle.Fill;
            lblFlWeapon.Location = new Point(256, 116);
            lblFlWeapon.Margin = new Padding(4, 0, 4, 0);
            lblFlWeapon.Name = "lblFlWeapon";
            lblFlWeapon.Size = new Size(62, 29);
            lblFlWeapon.TabIndex = 33;
            lblFlWeapon.Text = "Weapon";
            lblFlWeapon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFlShield
            // 
            lblFlShield.AutoSize = true;
            lblFlShield.Dock = DockStyle.Fill;
            lblFlShield.Location = new Point(256, 145);
            lblFlShield.Margin = new Padding(4, 0, 4, 0);
            lblFlShield.Name = "lblFlShield";
            lblFlShield.Size = new Size(62, 29);
            lblFlShield.TabIndex = 34;
            lblFlShield.Text = "Shield";
            lblFlShield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFlBoots
            // 
            lblFlBoots.AutoSize = true;
            lblFlBoots.Dock = DockStyle.Fill;
            lblFlBoots.Location = new Point(256, 174);
            lblFlBoots.Margin = new Padding(4, 0, 4, 0);
            lblFlBoots.Name = "lblFlBoots";
            lblFlBoots.Size = new Size(62, 29);
            lblFlBoots.TabIndex = 35;
            lblFlBoots.Text = "Boots";
            lblFlBoots.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFlTorso
            // 
            lblFlTorso.AutoSize = true;
            lblFlTorso.Dock = DockStyle.Fill;
            lblFlTorso.Location = new Point(256, 203);
            lblFlTorso.Margin = new Padding(4, 0, 4, 0);
            lblFlTorso.Name = "lblFlTorso";
            lblFlTorso.Size = new Size(62, 29);
            lblFlTorso.TabIndex = 36;
            lblFlTorso.Text = "Torso";
            lblFlTorso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnFlMaxAll
            // 
            btnFlMaxAll.Dock = DockStyle.Fill;
            btnFlMaxAll.Location = new Point(81, 235);
            btnFlMaxAll.Margin = new Padding(4, 3, 4, 3);
            btnFlMaxAll.Name = "btnFlMaxAll";
            btnFlMaxAll.Size = new Size(107, 23);
            btnFlMaxAll.TabIndex = 18;
            btnFlMaxAll.Text = "Max All";
            btnFlMaxAll.UseVisualStyleBackColor = true;
            // 
            // btnFlMaxBaseAP
            // 
            btnFlMaxBaseAP.Dock = DockStyle.Fill;
            btnFlMaxBaseAP.Location = new Point(196, 148);
            btnFlMaxBaseAP.Margin = new Padding(4, 3, 4, 3);
            btnFlMaxBaseAP.Name = "btnFlMaxBaseAP";
            btnFlMaxBaseAP.Size = new Size(52, 23);
            btnFlMaxBaseAP.TabIndex = 28;
            btnFlMaxBaseAP.Text = "Max";
            btnFlMaxBaseAP.UseVisualStyleBackColor = true;
            // 
            // lblFlCurrentHP
            // 
            lblFlCurrentHP.AutoSize = true;
            lblFlCurrentHP.Dock = DockStyle.Fill;
            lblFlCurrentHP.Location = new Point(4, 116);
            lblFlCurrentHP.Margin = new Padding(4, 0, 4, 0);
            lblFlCurrentHP.Name = "lblFlCurrentHP";
            lblFlCurrentHP.Size = new Size(69, 29);
            lblFlCurrentHP.TabIndex = 26;
            lblFlCurrentHP.Text = "Current HP:";
            lblFlCurrentHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numFlBaseAP
            // 
            numFlBaseAP.Dock = DockStyle.Fill;
            numFlBaseAP.Location = new Point(81, 148);
            numFlBaseAP.Margin = new Padding(4, 3, 4, 3);
            numFlBaseAP.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numFlBaseAP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numFlBaseAP.Name = "numFlBaseAP";
            numFlBaseAP.Size = new Size(107, 23);
            numFlBaseAP.TabIndex = 27;
            numFlBaseAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnFlMaxBaseHP
            // 
            btnFlMaxBaseHP.Dock = DockStyle.Fill;
            btnFlMaxBaseHP.Location = new Point(196, 90);
            btnFlMaxBaseHP.Margin = new Padding(4, 3, 4, 3);
            btnFlMaxBaseHP.Name = "btnFlMaxBaseHP";
            btnFlMaxBaseHP.Size = new Size(52, 23);
            btnFlMaxBaseHP.TabIndex = 28;
            btnFlMaxBaseHP.Text = "Max";
            btnFlMaxBaseHP.UseVisualStyleBackColor = true;
            // 
            // lblFlBaseAP
            // 
            lblFlBaseAP.AutoSize = true;
            lblFlBaseAP.Dock = DockStyle.Fill;
            lblFlBaseAP.Location = new Point(4, 145);
            lblFlBaseAP.Margin = new Padding(4, 0, 4, 0);
            lblFlBaseAP.Name = "lblFlBaseAP";
            lblFlBaseAP.Size = new Size(69, 29);
            lblFlBaseAP.TabIndex = 26;
            lblFlBaseAP.Text = "Max AP:";
            lblFlBaseAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbFlLeggings
            // 
            cbFlLeggings.Dock = DockStyle.Fill;
            cbFlLeggings.DropDownHeight = 300;
            cbFlLeggings.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFlLeggings.FormattingEnabled = true;
            cbFlLeggings.IntegralHeight = false;
            cbFlLeggings.Location = new Point(326, 235);
            cbFlLeggings.Margin = new Padding(4, 3, 4, 3);
            cbFlLeggings.Name = "cbFlLeggings";
            cbFlLeggings.Size = new Size(252, 23);
            cbFlLeggings.TabIndex = 23;
            // 
            // cbFlTorso
            // 
            cbFlTorso.Dock = DockStyle.Fill;
            cbFlTorso.DropDownHeight = 300;
            cbFlTorso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFlTorso.FormattingEnabled = true;
            cbFlTorso.IntegralHeight = false;
            cbFlTorso.Location = new Point(326, 206);
            cbFlTorso.Margin = new Padding(4, 3, 4, 3);
            cbFlTorso.Name = "cbFlTorso";
            cbFlTorso.Size = new Size(252, 23);
            cbFlTorso.TabIndex = 23;
            // 
            // cbFlBoots
            // 
            cbFlBoots.Dock = DockStyle.Fill;
            cbFlBoots.DropDownHeight = 300;
            cbFlBoots.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFlBoots.FormattingEnabled = true;
            cbFlBoots.IntegralHeight = false;
            cbFlBoots.Location = new Point(326, 177);
            cbFlBoots.Margin = new Padding(4, 3, 4, 3);
            cbFlBoots.Name = "cbFlBoots";
            cbFlBoots.Size = new Size(252, 23);
            cbFlBoots.TabIndex = 23;
            // 
            // numFlBaseHP
            // 
            numFlBaseHP.Dock = DockStyle.Fill;
            numFlBaseHP.Location = new Point(81, 90);
            numFlBaseHP.Margin = new Padding(4, 3, 4, 3);
            numFlBaseHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numFlBaseHP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numFlBaseHP.Name = "numFlBaseHP";
            numFlBaseHP.Size = new Size(107, 23);
            numFlBaseHP.TabIndex = 27;
            numFlBaseHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            // 
            // cbFlShield
            // 
            cbFlShield.Dock = DockStyle.Fill;
            cbFlShield.DropDownHeight = 300;
            cbFlShield.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFlShield.FormattingEnabled = true;
            cbFlShield.IntegralHeight = false;
            cbFlShield.Location = new Point(326, 148);
            cbFlShield.Margin = new Padding(4, 3, 4, 3);
            cbFlShield.Name = "cbFlShield";
            cbFlShield.Size = new Size(252, 23);
            cbFlShield.TabIndex = 23;
            // 
            // lblFlBaseHP
            // 
            lblFlBaseHP.AutoSize = true;
            lblFlBaseHP.Dock = DockStyle.Fill;
            lblFlBaseHP.Location = new Point(4, 87);
            lblFlBaseHP.Margin = new Padding(4, 0, 4, 0);
            lblFlBaseHP.Name = "lblFlBaseHP";
            lblFlBaseHP.Size = new Size(69, 29);
            lblFlBaseHP.TabIndex = 26;
            lblFlBaseHP.Text = "Max HP:";
            lblFlBaseHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbFlWeapon
            // 
            cbFlWeapon.Dock = DockStyle.Fill;
            cbFlWeapon.DropDownHeight = 300;
            cbFlWeapon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFlWeapon.FormattingEnabled = true;
            cbFlWeapon.IntegralHeight = false;
            cbFlWeapon.Location = new Point(326, 119);
            cbFlWeapon.Margin = new Padding(4, 3, 4, 3);
            cbFlWeapon.Name = "cbFlWeapon";
            cbFlWeapon.Size = new Size(252, 23);
            cbFlWeapon.TabIndex = 23;
            // 
            // btnFlMaxSkill
            // 
            btnFlMaxSkill.Dock = DockStyle.Fill;
            btnFlMaxSkill.Location = new Point(196, 61);
            btnFlMaxSkill.Margin = new Padding(4, 3, 4, 3);
            btnFlMaxSkill.Name = "btnFlMaxSkill";
            btnFlMaxSkill.Size = new Size(52, 23);
            btnFlMaxSkill.TabIndex = 18;
            btnFlMaxSkill.Text = "Max";
            btnFlMaxSkill.UseVisualStyleBackColor = true;
            // 
            // cbFlGauntlets
            // 
            cbFlGauntlets.Dock = DockStyle.Fill;
            cbFlGauntlets.DropDownHeight = 300;
            cbFlGauntlets.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFlGauntlets.FormattingEnabled = true;
            cbFlGauntlets.IntegralHeight = false;
            cbFlGauntlets.Location = new Point(326, 90);
            cbFlGauntlets.Margin = new Padding(4, 3, 4, 3);
            cbFlGauntlets.Name = "cbFlGauntlets";
            cbFlGauntlets.Size = new Size(252, 23);
            cbFlGauntlets.TabIndex = 23;
            // 
            // numFlSkill
            // 
            numFlSkill.Dock = DockStyle.Fill;
            numFlSkill.Location = new Point(81, 61);
            numFlSkill.Margin = new Padding(4, 3, 4, 3);
            numFlSkill.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
            numFlSkill.Name = "numFlSkill";
            numFlSkill.Size = new Size(107, 23);
            numFlSkill.TabIndex = 2;
            // 
            // btnFlMaxExp
            // 
            btnFlMaxExp.Dock = DockStyle.Fill;
            btnFlMaxExp.Location = new Point(196, 32);
            btnFlMaxExp.Margin = new Padding(4, 3, 4, 3);
            btnFlMaxExp.Name = "btnFlMaxExp";
            btnFlMaxExp.Size = new Size(52, 23);
            btnFlMaxExp.TabIndex = 17;
            btnFlMaxExp.Text = "Max";
            btnFlMaxExp.UseVisualStyleBackColor = true;
            // 
            // lblFlSkillPoints
            // 
            lblFlSkillPoints.AutoSize = true;
            lblFlSkillPoints.Dock = DockStyle.Fill;
            lblFlSkillPoints.Location = new Point(4, 58);
            lblFlSkillPoints.Margin = new Padding(4, 0, 4, 0);
            lblFlSkillPoints.Name = "lblFlSkillPoints";
            lblFlSkillPoints.Size = new Size(69, 29);
            lblFlSkillPoints.TabIndex = 3;
            lblFlSkillPoints.Text = "Skill Points:";
            lblFlSkillPoints.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numFlLevel
            // 
            numFlLevel.Dock = DockStyle.Fill;
            numFlLevel.Location = new Point(81, 3);
            numFlLevel.Margin = new Padding(4, 3, 4, 3);
            numFlLevel.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numFlLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numFlLevel.Name = "numFlLevel";
            numFlLevel.Size = new Size(107, 23);
            numFlLevel.TabIndex = 1;
            numFlLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numFlExperience
            // 
            numFlExperience.Dock = DockStyle.Fill;
            numFlExperience.Location = new Point(81, 32);
            numFlExperience.Margin = new Padding(4, 3, 4, 3);
            numFlExperience.Maximum = new decimal(new int[] { 6327001, 0, 0, 0 });
            numFlExperience.Name = "numFlExperience";
            numFlExperience.Size = new Size(107, 23);
            numFlExperience.TabIndex = 2;
            // 
            // btnFlMaxLevel
            // 
            btnFlMaxLevel.Dock = DockStyle.Fill;
            btnFlMaxLevel.Location = new Point(196, 3);
            btnFlMaxLevel.Margin = new Padding(4, 3, 4, 3);
            btnFlMaxLevel.Name = "btnFlMaxLevel";
            btnFlMaxLevel.Size = new Size(52, 23);
            btnFlMaxLevel.TabIndex = 18;
            btnFlMaxLevel.Text = "Max";
            btnFlMaxLevel.UseVisualStyleBackColor = true;
            // 
            // lblFlLevel
            // 
            lblFlLevel.AutoSize = true;
            lblFlLevel.Dock = DockStyle.Fill;
            lblFlLevel.Location = new Point(4, 0);
            lblFlLevel.Margin = new Padding(4, 0, 4, 0);
            lblFlLevel.Name = "lblFlLevel";
            lblFlLevel.Size = new Size(69, 29);
            lblFlLevel.TabIndex = 0;
            lblFlLevel.Text = "Level:";
            lblFlLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbFlRing2
            // 
            cbFlRing2.Dock = DockStyle.Fill;
            cbFlRing2.DropDownHeight = 300;
            cbFlRing2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFlRing2.FormattingEnabled = true;
            cbFlRing2.IntegralHeight = false;
            cbFlRing2.Location = new Point(326, 61);
            cbFlRing2.Margin = new Padding(4, 3, 4, 3);
            cbFlRing2.Name = "cbFlRing2";
            cbFlRing2.Size = new Size(252, 23);
            cbFlRing2.TabIndex = 23;
            // 
            // lblFlExperience
            // 
            lblFlExperience.AutoSize = true;
            lblFlExperience.Dock = DockStyle.Fill;
            lblFlExperience.Location = new Point(4, 29);
            lblFlExperience.Margin = new Padding(4, 0, 4, 0);
            lblFlExperience.Name = "lblFlExperience";
            lblFlExperience.Size = new Size(69, 29);
            lblFlExperience.TabIndex = 2;
            lblFlExperience.Text = "Experience:";
            lblFlExperience.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbFlRing1
            // 
            cbFlRing1.Dock = DockStyle.Fill;
            cbFlRing1.DropDownHeight = 300;
            cbFlRing1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFlRing1.FormattingEnabled = true;
            cbFlRing1.IntegralHeight = false;
            cbFlRing1.Location = new Point(326, 32);
            cbFlRing1.Margin = new Padding(4, 3, 4, 3);
            cbFlRing1.Name = "cbFlRing1";
            cbFlRing1.Size = new Size(252, 23);
            cbFlRing1.TabIndex = 23;
            // 
            // cbFlAmulet
            // 
            cbFlAmulet.Dock = DockStyle.Fill;
            cbFlAmulet.DropDownHeight = 300;
            cbFlAmulet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbFlAmulet.FormattingEnabled = true;
            cbFlAmulet.IntegralHeight = false;
            cbFlAmulet.Location = new Point(326, 3);
            cbFlAmulet.Margin = new Padding(4, 3, 4, 3);
            cbFlAmulet.Name = "cbFlAmulet";
            cbFlAmulet.Size = new Size(252, 23);
            cbFlAmulet.TabIndex = 23;
            // 
            // numFlCurrentHP
            // 
            numFlCurrentHP.Dock = DockStyle.Fill;
            numFlCurrentHP.Location = new Point(81, 119);
            numFlCurrentHP.Margin = new Padding(4, 3, 4, 3);
            numFlCurrentHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numFlCurrentHP.Name = "numFlCurrentHP";
            numFlCurrentHP.Size = new Size(107, 23);
            numFlCurrentHP.TabIndex = 24;
            numFlCurrentHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            // 
            // btnFlMaxCurrentHP
            // 
            btnFlMaxCurrentHP.Dock = DockStyle.Fill;
            btnFlMaxCurrentHP.Location = new Point(196, 119);
            btnFlMaxCurrentHP.Margin = new Padding(4, 3, 4, 3);
            btnFlMaxCurrentHP.Name = "btnFlMaxCurrentHP";
            btnFlMaxCurrentHP.Size = new Size(52, 23);
            btnFlMaxCurrentHP.TabIndex = 25;
            btnFlMaxCurrentHP.Text = "Max";
            btnFlMaxCurrentHP.UseVisualStyleBackColor = true;
            // 
            // lblFlCurrentAP
            // 
            lblFlCurrentAP.AutoSize = true;
            lblFlCurrentAP.Dock = DockStyle.Fill;
            lblFlCurrentAP.Location = new Point(4, 174);
            lblFlCurrentAP.Margin = new Padding(4, 0, 4, 0);
            lblFlCurrentAP.Name = "lblFlCurrentAP";
            lblFlCurrentAP.Size = new Size(69, 29);
            lblFlCurrentAP.TabIndex = 23;
            lblFlCurrentAP.Text = "Current AP:";
            lblFlCurrentAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numFlCurrentAP
            // 
            numFlCurrentAP.Dock = DockStyle.Fill;
            numFlCurrentAP.Location = new Point(81, 177);
            numFlCurrentAP.Margin = new Padding(4, 3, 4, 3);
            numFlCurrentAP.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numFlCurrentAP.Name = "numFlCurrentAP";
            numFlCurrentAP.Size = new Size(107, 23);
            numFlCurrentAP.TabIndex = 24;
            numFlCurrentAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnFlMaxCurrentAP
            // 
            btnFlMaxCurrentAP.Dock = DockStyle.Fill;
            btnFlMaxCurrentAP.Location = new Point(196, 177);
            btnFlMaxCurrentAP.Margin = new Padding(4, 3, 4, 3);
            btnFlMaxCurrentAP.Name = "btnFlMaxCurrentAP";
            btnFlMaxCurrentAP.Size = new Size(52, 23);
            btnFlMaxCurrentAP.TabIndex = 25;
            btnFlMaxCurrentAP.Text = "Max";
            btnFlMaxCurrentAP.UseVisualStyleBackColor = true;
            // 
            // lblFlSpeed
            // 
            lblFlSpeed.AutoSize = true;
            lblFlSpeed.Dock = DockStyle.Fill;
            lblFlSpeed.Location = new Point(4, 203);
            lblFlSpeed.Margin = new Padding(4, 0, 4, 0);
            lblFlSpeed.Name = "lblFlSpeed";
            lblFlSpeed.Size = new Size(69, 29);
            lblFlSpeed.TabIndex = 23;
            lblFlSpeed.Text = "Speed:";
            lblFlSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numFlSpeed
            // 
            numFlSpeed.Dock = DockStyle.Fill;
            numFlSpeed.Location = new Point(81, 206);
            numFlSpeed.Margin = new Padding(4, 3, 4, 3);
            numFlSpeed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numFlSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numFlSpeed.Name = "numFlSpeed";
            numFlSpeed.Size = new Size(107, 23);
            numFlSpeed.TabIndex = 24;
            numFlSpeed.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnFlMaxSpeed
            // 
            btnFlMaxSpeed.Dock = DockStyle.Fill;
            btnFlMaxSpeed.Location = new Point(196, 206);
            btnFlMaxSpeed.Margin = new Padding(4, 3, 4, 3);
            btnFlMaxSpeed.Name = "btnFlMaxSpeed";
            btnFlMaxSpeed.Size = new Size(52, 23);
            btnFlMaxSpeed.TabIndex = 25;
            btnFlMaxSpeed.Text = "Max";
            btnFlMaxSpeed.UseVisualStyleBackColor = true;
            // 
            // lblFlLeggings
            // 
            lblFlLeggings.AutoSize = true;
            lblFlLeggings.Dock = DockStyle.Fill;
            lblFlLeggings.Location = new Point(256, 232);
            lblFlLeggings.Margin = new Padding(4, 0, 4, 0);
            lblFlLeggings.Name = "lblFlLeggings";
            lblFlLeggings.Size = new Size(62, 29);
            lblFlLeggings.TabIndex = 37;
            lblFlLeggings.Text = "Leggings";
            lblFlLeggings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPageJoseph
            // 
            tabPageJoseph.Controls.Add(tblJoseph);
            tabPageJoseph.Location = new Point(4, 24);
            tabPageJoseph.Margin = new Padding(4, 3, 4, 3);
            tabPageJoseph.Name = "tabPageJoseph";
            tabPageJoseph.Padding = new Padding(4, 3, 4, 3);
            tabPageJoseph.Size = new Size(973, 507);
            tabPageJoseph.TabIndex = 0;
            tabPageJoseph.Text = "Joseph";
            // 
            // tblJoseph
            // 
            tblJoseph.ColumnCount = 6;
            tblJoseph.ColumnStyles.Add(new ColumnStyle());
            tblJoseph.ColumnStyles.Add(new ColumnStyle());
            tblJoseph.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tblJoseph.ColumnStyles.Add(new ColumnStyle());
            tblJoseph.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tblJoseph.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 282F));
            tblJoseph.Controls.Add(lblJoLevel, 0, 0);
            tblJoseph.Controls.Add(cbJoLeggings, 4, 8);
            tblJoseph.Controls.Add(lvJosephSkills, 5, 0);
            tblJoseph.Controls.Add(tableLayoutPanel9, 5, 8);
            tblJoseph.Controls.Add(numJoLevel, 1, 0);
            tblJoseph.Controls.Add(cbJoTorso, 4, 7);
            tblJoseph.Controls.Add(cbJoBoots, 4, 6);
            tblJoseph.Controls.Add(cbJoShield, 4, 5);
            tblJoseph.Controls.Add(btnJoMaxLevel, 2, 0);
            tblJoseph.Controls.Add(lblJoExperience, 0, 1);
            tblJoseph.Controls.Add(cbJoWeapon, 4, 4);
            tblJoseph.Controls.Add(numJoExperience, 1, 1);
            tblJoseph.Controls.Add(cbJoGauntlets, 4, 3);
            tblJoseph.Controls.Add(btnJoMaxExperience, 2, 1);
            tblJoseph.Controls.Add(lblJoSkillPoints, 0, 2);
            tblJoseph.Controls.Add(cbJoRing2, 4, 2);
            tblJoseph.Controls.Add(numJoSkill, 1, 2);
            tblJoseph.Controls.Add(cbJoRing1, 4, 1);
            tblJoseph.Controls.Add(btnJoMaxSkillPoints, 2, 2);
            tblJoseph.Controls.Add(cbJoAmulet, 4, 0);
            tblJoseph.Controls.Add(lblJoMaxHP, 0, 3);
            tblJoseph.Controls.Add(btnJoMaxAll, 1, 8);
            tblJoseph.Controls.Add(btnJoMaxSpeed, 2, 7);
            tblJoseph.Controls.Add(numJoBaseHP, 1, 3);
            tblJoseph.Controls.Add(numJoSpeed, 1, 7);
            tblJoseph.Controls.Add(btnJoMaxCurrentAP, 2, 6);
            tblJoseph.Controls.Add(lblJoSpeed, 0, 7);
            tblJoseph.Controls.Add(btnJoMaxBaseHP, 2, 3);
            tblJoseph.Controls.Add(btnJoMaxBaseAP, 2, 5);
            tblJoseph.Controls.Add(lblJoCurrentHP, 0, 4);
            tblJoseph.Controls.Add(numJoCurrentAP, 1, 6);
            tblJoseph.Controls.Add(numJoCurrentHP, 1, 4);
            tblJoseph.Controls.Add(lblJoCurrentAP, 0, 6);
            tblJoseph.Controls.Add(btnJoMaxCurrentHP, 2, 4);
            tblJoseph.Controls.Add(lblJoBaseAP, 0, 5);
            tblJoseph.Controls.Add(numJoBaseAP, 1, 5);
            tblJoseph.Controls.Add(lblJoAmulet, 3, 0);
            tblJoseph.Controls.Add(lblJoRing1, 3, 1);
            tblJoseph.Controls.Add(lblJoRing2, 3, 2);
            tblJoseph.Controls.Add(lblJoGauntlets, 3, 3);
            tblJoseph.Controls.Add(lblJoWeapon, 3, 4);
            tblJoseph.Controls.Add(lblJoShield, 3, 5);
            tblJoseph.Controls.Add(lblJoBoots, 3, 6);
            tblJoseph.Controls.Add(lblJoTorso, 3, 7);
            tblJoseph.Controls.Add(lblJoLeggings, 3, 8);
            tblJoseph.Dock = DockStyle.Fill;
            tblJoseph.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblJoseph.Location = new Point(4, 3);
            tblJoseph.Name = "tblJoseph";
            tblJoseph.RowCount = 10;
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.Size = new Size(965, 501);
            tblJoseph.TabIndex = 24;
            // 
            // lblJoLevel
            // 
            lblJoLevel.AutoSize = true;
            lblJoLevel.Dock = DockStyle.Fill;
            lblJoLevel.Location = new Point(4, 0);
            lblJoLevel.Margin = new Padding(4, 0, 4, 0);
            lblJoLevel.Name = "lblJoLevel";
            lblJoLevel.Size = new Size(69, 29);
            lblJoLevel.TabIndex = 0;
            lblJoLevel.Text = "Level:";
            lblJoLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbJoLeggings
            // 
            cbJoLeggings.Dock = DockStyle.Fill;
            cbJoLeggings.DropDownHeight = 300;
            cbJoLeggings.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJoLeggings.FormattingEnabled = true;
            cbJoLeggings.IntegralHeight = false;
            cbJoLeggings.Location = new Point(326, 235);
            cbJoLeggings.Margin = new Padding(4, 3, 4, 3);
            cbJoLeggings.Name = "cbJoLeggings";
            cbJoLeggings.Size = new Size(252, 23);
            cbJoLeggings.TabIndex = 23;
            // 
            // lvJosephSkills
            // 
            lvJosephSkills.Columns.AddRange(new ColumnHeader[] { columnHeader9, columnHeader10 });
            lvJosephSkills.Dock = DockStyle.Fill;
            lvJosephSkills.FullRowSelect = true;
            lvJosephSkills.Location = new Point(586, 3);
            lvJosephSkills.Margin = new Padding(4, 3, 4, 3);
            lvJosephSkills.Name = "lvJosephSkills";
            tblJoseph.SetRowSpan(lvJosephSkills, 8);
            lvJosephSkills.Size = new Size(375, 226);
            lvJosephSkills.TabIndex = 27;
            lvJosephSkills.UseCompatibleStateImageBehavior = false;
            lvJosephSkills.View = View.Details;
            lvJosephSkills.SelectedIndexChanged += lvJosephSkills_SelectedIndexChanged;
            // 
            // columnHeader9
            // 
            columnHeader9.Text = "Skill Name";
            columnHeader9.Width = 216;
            // 
            // columnHeader10
            // 
            columnHeader10.Text = "Value";
            columnHeader10.Width = 63;
            // 
            // tableLayoutPanel9
            // 
            tableLayoutPanel9.ColumnCount = 2;
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Controls.Add(numJoSkillValue, 0, 0);
            tableLayoutPanel9.Controls.Add(btnJoUpdateSkill, 1, 0);
            tableLayoutPanel9.Dock = DockStyle.Fill;
            tableLayoutPanel9.Location = new Point(582, 232);
            tableLayoutPanel9.Margin = new Padding(0);
            tableLayoutPanel9.Name = "tableLayoutPanel9";
            tableLayoutPanel9.RowCount = 1;
            tableLayoutPanel9.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel9.Size = new Size(383, 29);
            tableLayoutPanel9.TabIndex = 25;
            // 
            // numJoSkillValue
            // 
            numJoSkillValue.Dock = DockStyle.Fill;
            numJoSkillValue.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numJoSkillValue.Location = new Point(4, 3);
            numJoSkillValue.Margin = new Padding(4, 3, 4, 3);
            numJoSkillValue.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numJoSkillValue.Name = "numJoSkillValue";
            numJoSkillValue.Size = new Size(183, 23);
            numJoSkillValue.TabIndex = 3;
            // 
            // btnJoUpdateSkill
            // 
            btnJoUpdateSkill.Dock = DockStyle.Fill;
            btnJoUpdateSkill.Location = new Point(195, 3);
            btnJoUpdateSkill.Margin = new Padding(4, 3, 4, 3);
            btnJoUpdateSkill.Name = "btnJoUpdateSkill";
            btnJoUpdateSkill.Size = new Size(184, 23);
            btnJoUpdateSkill.TabIndex = 4;
            btnJoUpdateSkill.Text = "Update Skill";
            btnJoUpdateSkill.UseVisualStyleBackColor = true;
            btnJoUpdateSkill.Click += btnJoUpdateSkill_Click_1;
            // 
            // numJoLevel
            // 
            numJoLevel.Dock = DockStyle.Fill;
            numJoLevel.Location = new Point(81, 3);
            numJoLevel.Margin = new Padding(4, 3, 4, 3);
            numJoLevel.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numJoLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJoLevel.Name = "numJoLevel";
            numJoLevel.Size = new Size(107, 23);
            numJoLevel.TabIndex = 1;
            numJoLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // cbJoTorso
            // 
            cbJoTorso.Dock = DockStyle.Fill;
            cbJoTorso.DropDownHeight = 300;
            cbJoTorso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJoTorso.FormattingEnabled = true;
            cbJoTorso.IntegralHeight = false;
            cbJoTorso.Location = new Point(326, 206);
            cbJoTorso.Margin = new Padding(4, 3, 4, 3);
            cbJoTorso.Name = "cbJoTorso";
            cbJoTorso.Size = new Size(252, 23);
            cbJoTorso.TabIndex = 23;
            // 
            // cbJoBoots
            // 
            cbJoBoots.Dock = DockStyle.Fill;
            cbJoBoots.DropDownHeight = 300;
            cbJoBoots.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJoBoots.FormattingEnabled = true;
            cbJoBoots.IntegralHeight = false;
            cbJoBoots.Location = new Point(326, 177);
            cbJoBoots.Margin = new Padding(4, 3, 4, 3);
            cbJoBoots.Name = "cbJoBoots";
            cbJoBoots.Size = new Size(252, 23);
            cbJoBoots.TabIndex = 23;
            // 
            // cbJoShield
            // 
            cbJoShield.Dock = DockStyle.Fill;
            cbJoShield.DropDownHeight = 300;
            cbJoShield.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJoShield.FormattingEnabled = true;
            cbJoShield.IntegralHeight = false;
            cbJoShield.Location = new Point(326, 148);
            cbJoShield.Margin = new Padding(4, 3, 4, 3);
            cbJoShield.Name = "cbJoShield";
            cbJoShield.Size = new Size(252, 23);
            cbJoShield.TabIndex = 23;
            // 
            // btnJoMaxLevel
            // 
            btnJoMaxLevel.Dock = DockStyle.Fill;
            btnJoMaxLevel.Location = new Point(196, 3);
            btnJoMaxLevel.Margin = new Padding(4, 3, 4, 3);
            btnJoMaxLevel.Name = "btnJoMaxLevel";
            btnJoMaxLevel.Size = new Size(52, 23);
            btnJoMaxLevel.TabIndex = 16;
            btnJoMaxLevel.Text = "Max";
            btnJoMaxLevel.UseVisualStyleBackColor = true;
            // 
            // lblJoExperience
            // 
            lblJoExperience.AutoSize = true;
            lblJoExperience.Dock = DockStyle.Fill;
            lblJoExperience.Location = new Point(4, 29);
            lblJoExperience.Margin = new Padding(4, 0, 4, 0);
            lblJoExperience.Name = "lblJoExperience";
            lblJoExperience.Size = new Size(69, 29);
            lblJoExperience.TabIndex = 2;
            lblJoExperience.Text = "Experience:";
            lblJoExperience.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbJoWeapon
            // 
            cbJoWeapon.Dock = DockStyle.Fill;
            cbJoWeapon.DropDownHeight = 300;
            cbJoWeapon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJoWeapon.FormattingEnabled = true;
            cbJoWeapon.IntegralHeight = false;
            cbJoWeapon.Location = new Point(326, 119);
            cbJoWeapon.Margin = new Padding(4, 3, 4, 3);
            cbJoWeapon.Name = "cbJoWeapon";
            cbJoWeapon.Size = new Size(252, 23);
            cbJoWeapon.TabIndex = 23;
            // 
            // numJoExperience
            // 
            numJoExperience.Dock = DockStyle.Fill;
            numJoExperience.Location = new Point(81, 32);
            numJoExperience.Margin = new Padding(4, 3, 4, 3);
            numJoExperience.Maximum = new decimal(new int[] { 6327001, 0, 0, 0 });
            numJoExperience.Name = "numJoExperience";
            numJoExperience.Size = new Size(107, 23);
            numJoExperience.TabIndex = 2;
            // 
            // cbJoGauntlets
            // 
            cbJoGauntlets.Dock = DockStyle.Fill;
            cbJoGauntlets.DropDownHeight = 300;
            cbJoGauntlets.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJoGauntlets.FormattingEnabled = true;
            cbJoGauntlets.IntegralHeight = false;
            cbJoGauntlets.Location = new Point(326, 90);
            cbJoGauntlets.Margin = new Padding(4, 3, 4, 3);
            cbJoGauntlets.Name = "cbJoGauntlets";
            cbJoGauntlets.Size = new Size(252, 23);
            cbJoGauntlets.TabIndex = 23;
            // 
            // btnJoMaxExperience
            // 
            btnJoMaxExperience.Dock = DockStyle.Fill;
            btnJoMaxExperience.Location = new Point(196, 32);
            btnJoMaxExperience.Margin = new Padding(4, 3, 4, 3);
            btnJoMaxExperience.Name = "btnJoMaxExperience";
            btnJoMaxExperience.Size = new Size(52, 23);
            btnJoMaxExperience.TabIndex = 16;
            btnJoMaxExperience.Text = "Max";
            btnJoMaxExperience.UseVisualStyleBackColor = true;
            // 
            // lblJoSkillPoints
            // 
            lblJoSkillPoints.AutoSize = true;
            lblJoSkillPoints.Dock = DockStyle.Fill;
            lblJoSkillPoints.Location = new Point(4, 58);
            lblJoSkillPoints.Margin = new Padding(4, 0, 4, 0);
            lblJoSkillPoints.Name = "lblJoSkillPoints";
            lblJoSkillPoints.Size = new Size(69, 29);
            lblJoSkillPoints.TabIndex = 3;
            lblJoSkillPoints.Text = "Skill Points:";
            lblJoSkillPoints.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbJoRing2
            // 
            cbJoRing2.Dock = DockStyle.Fill;
            cbJoRing2.DropDownHeight = 300;
            cbJoRing2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJoRing2.FormattingEnabled = true;
            cbJoRing2.IntegralHeight = false;
            cbJoRing2.Location = new Point(326, 61);
            cbJoRing2.Margin = new Padding(4, 3, 4, 3);
            cbJoRing2.Name = "cbJoRing2";
            cbJoRing2.Size = new Size(252, 23);
            cbJoRing2.TabIndex = 23;
            // 
            // numJoSkill
            // 
            numJoSkill.Dock = DockStyle.Fill;
            numJoSkill.Location = new Point(81, 61);
            numJoSkill.Margin = new Padding(4, 3, 4, 3);
            numJoSkill.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
            numJoSkill.Name = "numJoSkill";
            numJoSkill.Size = new Size(107, 23);
            numJoSkill.TabIndex = 2;
            // 
            // cbJoRing1
            // 
            cbJoRing1.Dock = DockStyle.Fill;
            cbJoRing1.DropDownHeight = 300;
            cbJoRing1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJoRing1.FormattingEnabled = true;
            cbJoRing1.IntegralHeight = false;
            cbJoRing1.Location = new Point(326, 32);
            cbJoRing1.Margin = new Padding(4, 3, 4, 3);
            cbJoRing1.Name = "cbJoRing1";
            cbJoRing1.Size = new Size(252, 23);
            cbJoRing1.TabIndex = 23;
            // 
            // btnJoMaxSkillPoints
            // 
            btnJoMaxSkillPoints.Dock = DockStyle.Fill;
            btnJoMaxSkillPoints.Location = new Point(196, 61);
            btnJoMaxSkillPoints.Margin = new Padding(4, 3, 4, 3);
            btnJoMaxSkillPoints.Name = "btnJoMaxSkillPoints";
            btnJoMaxSkillPoints.Size = new Size(52, 23);
            btnJoMaxSkillPoints.TabIndex = 16;
            btnJoMaxSkillPoints.Text = "Max";
            btnJoMaxSkillPoints.UseVisualStyleBackColor = true;
            // 
            // cbJoAmulet
            // 
            cbJoAmulet.Dock = DockStyle.Fill;
            cbJoAmulet.DropDownHeight = 300;
            cbJoAmulet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbJoAmulet.FormattingEnabled = true;
            cbJoAmulet.IntegralHeight = false;
            cbJoAmulet.Location = new Point(326, 3);
            cbJoAmulet.Margin = new Padding(4, 3, 4, 3);
            cbJoAmulet.Name = "cbJoAmulet";
            cbJoAmulet.Size = new Size(252, 23);
            cbJoAmulet.TabIndex = 23;
            // 
            // lblJoMaxHP
            // 
            lblJoMaxHP.AutoSize = true;
            lblJoMaxHP.Dock = DockStyle.Fill;
            lblJoMaxHP.Location = new Point(4, 87);
            lblJoMaxHP.Margin = new Padding(4, 0, 4, 0);
            lblJoMaxHP.Name = "lblJoMaxHP";
            lblJoMaxHP.Size = new Size(69, 29);
            lblJoMaxHP.TabIndex = 17;
            lblJoMaxHP.Text = "Max HP:";
            lblJoMaxHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnJoMaxAll
            // 
            btnJoMaxAll.Dock = DockStyle.Fill;
            btnJoMaxAll.Location = new Point(81, 235);
            btnJoMaxAll.Margin = new Padding(4, 3, 4, 3);
            btnJoMaxAll.Name = "btnJoMaxAll";
            btnJoMaxAll.Size = new Size(107, 23);
            btnJoMaxAll.TabIndex = 16;
            btnJoMaxAll.Text = "Max All";
            btnJoMaxAll.UseVisualStyleBackColor = true;
            // 
            // btnJoMaxSpeed
            // 
            btnJoMaxSpeed.Dock = DockStyle.Fill;
            btnJoMaxSpeed.Location = new Point(196, 206);
            btnJoMaxSpeed.Margin = new Padding(4, 3, 4, 3);
            btnJoMaxSpeed.Name = "btnJoMaxSpeed";
            btnJoMaxSpeed.Size = new Size(52, 23);
            btnJoMaxSpeed.TabIndex = 22;
            btnJoMaxSpeed.Text = "Max";
            btnJoMaxSpeed.UseVisualStyleBackColor = true;
            // 
            // numJoBaseHP
            // 
            numJoBaseHP.Dock = DockStyle.Fill;
            numJoBaseHP.Location = new Point(81, 90);
            numJoBaseHP.Margin = new Padding(4, 3, 4, 3);
            numJoBaseHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numJoBaseHP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJoBaseHP.Name = "numJoBaseHP";
            numJoBaseHP.Size = new Size(107, 23);
            numJoBaseHP.TabIndex = 18;
            numJoBaseHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            // 
            // numJoSpeed
            // 
            numJoSpeed.Dock = DockStyle.Fill;
            numJoSpeed.Location = new Point(81, 206);
            numJoSpeed.Margin = new Padding(4, 3, 4, 3);
            numJoSpeed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numJoSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJoSpeed.Name = "numJoSpeed";
            numJoSpeed.Size = new Size(107, 23);
            numJoSpeed.TabIndex = 21;
            numJoSpeed.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnJoMaxCurrentAP
            // 
            btnJoMaxCurrentAP.Dock = DockStyle.Fill;
            btnJoMaxCurrentAP.Location = new Point(196, 177);
            btnJoMaxCurrentAP.Margin = new Padding(4, 3, 4, 3);
            btnJoMaxCurrentAP.Name = "btnJoMaxCurrentAP";
            btnJoMaxCurrentAP.Size = new Size(52, 23);
            btnJoMaxCurrentAP.TabIndex = 22;
            btnJoMaxCurrentAP.Text = "Max";
            btnJoMaxCurrentAP.UseVisualStyleBackColor = true;
            // 
            // lblJoSpeed
            // 
            lblJoSpeed.AutoSize = true;
            lblJoSpeed.Dock = DockStyle.Fill;
            lblJoSpeed.Location = new Point(4, 203);
            lblJoSpeed.Margin = new Padding(4, 0, 4, 0);
            lblJoSpeed.Name = "lblJoSpeed";
            lblJoSpeed.Size = new Size(69, 29);
            lblJoSpeed.TabIndex = 20;
            lblJoSpeed.Text = "Speed:";
            lblJoSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnJoMaxBaseHP
            // 
            btnJoMaxBaseHP.Dock = DockStyle.Fill;
            btnJoMaxBaseHP.Location = new Point(196, 90);
            btnJoMaxBaseHP.Margin = new Padding(4, 3, 4, 3);
            btnJoMaxBaseHP.Name = "btnJoMaxBaseHP";
            btnJoMaxBaseHP.Size = new Size(52, 23);
            btnJoMaxBaseHP.TabIndex = 19;
            btnJoMaxBaseHP.Text = "Max";
            btnJoMaxBaseHP.UseVisualStyleBackColor = true;
            // 
            // btnJoMaxBaseAP
            // 
            btnJoMaxBaseAP.Dock = DockStyle.Fill;
            btnJoMaxBaseAP.Location = new Point(196, 148);
            btnJoMaxBaseAP.Margin = new Padding(4, 3, 4, 3);
            btnJoMaxBaseAP.Name = "btnJoMaxBaseAP";
            btnJoMaxBaseAP.Size = new Size(52, 23);
            btnJoMaxBaseAP.TabIndex = 22;
            btnJoMaxBaseAP.Text = "Max";
            btnJoMaxBaseAP.UseVisualStyleBackColor = true;
            // 
            // lblJoCurrentHP
            // 
            lblJoCurrentHP.AutoSize = true;
            lblJoCurrentHP.Dock = DockStyle.Fill;
            lblJoCurrentHP.Location = new Point(4, 116);
            lblJoCurrentHP.Margin = new Padding(4, 0, 4, 0);
            lblJoCurrentHP.Name = "lblJoCurrentHP";
            lblJoCurrentHP.Size = new Size(69, 29);
            lblJoCurrentHP.TabIndex = 17;
            lblJoCurrentHP.Text = "Current HP:";
            lblJoCurrentHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numJoCurrentAP
            // 
            numJoCurrentAP.Dock = DockStyle.Fill;
            numJoCurrentAP.Location = new Point(81, 177);
            numJoCurrentAP.Margin = new Padding(4, 3, 4, 3);
            numJoCurrentAP.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numJoCurrentAP.Name = "numJoCurrentAP";
            numJoCurrentAP.Size = new Size(107, 23);
            numJoCurrentAP.TabIndex = 21;
            numJoCurrentAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // numJoCurrentHP
            // 
            numJoCurrentHP.Dock = DockStyle.Fill;
            numJoCurrentHP.Location = new Point(81, 119);
            numJoCurrentHP.Margin = new Padding(4, 3, 4, 3);
            numJoCurrentHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numJoCurrentHP.Name = "numJoCurrentHP";
            numJoCurrentHP.Size = new Size(107, 23);
            numJoCurrentHP.TabIndex = 18;
            numJoCurrentHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            // 
            // lblJoCurrentAP
            // 
            lblJoCurrentAP.AutoSize = true;
            lblJoCurrentAP.Dock = DockStyle.Fill;
            lblJoCurrentAP.Location = new Point(4, 174);
            lblJoCurrentAP.Margin = new Padding(4, 0, 4, 0);
            lblJoCurrentAP.Name = "lblJoCurrentAP";
            lblJoCurrentAP.Size = new Size(69, 29);
            lblJoCurrentAP.TabIndex = 20;
            lblJoCurrentAP.Text = "Current AP:";
            lblJoCurrentAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnJoMaxCurrentHP
            // 
            btnJoMaxCurrentHP.Dock = DockStyle.Fill;
            btnJoMaxCurrentHP.Location = new Point(196, 119);
            btnJoMaxCurrentHP.Margin = new Padding(4, 3, 4, 3);
            btnJoMaxCurrentHP.Name = "btnJoMaxCurrentHP";
            btnJoMaxCurrentHP.Size = new Size(52, 23);
            btnJoMaxCurrentHP.TabIndex = 19;
            btnJoMaxCurrentHP.Text = "Max";
            btnJoMaxCurrentHP.UseVisualStyleBackColor = true;
            // 
            // lblJoBaseAP
            // 
            lblJoBaseAP.AutoSize = true;
            lblJoBaseAP.Dock = DockStyle.Fill;
            lblJoBaseAP.Location = new Point(4, 145);
            lblJoBaseAP.Margin = new Padding(4, 0, 4, 0);
            lblJoBaseAP.Name = "lblJoBaseAP";
            lblJoBaseAP.Size = new Size(69, 29);
            lblJoBaseAP.TabIndex = 20;
            lblJoBaseAP.Text = "Max AP:";
            lblJoBaseAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numJoBaseAP
            // 
            numJoBaseAP.Dock = DockStyle.Fill;
            numJoBaseAP.Location = new Point(81, 148);
            numJoBaseAP.Margin = new Padding(4, 3, 4, 3);
            numJoBaseAP.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numJoBaseAP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numJoBaseAP.Name = "numJoBaseAP";
            numJoBaseAP.Size = new Size(107, 23);
            numJoBaseAP.TabIndex = 21;
            numJoBaseAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // lblJoAmulet
            // 
            lblJoAmulet.AutoSize = true;
            lblJoAmulet.Dock = DockStyle.Fill;
            lblJoAmulet.Location = new Point(256, 0);
            lblJoAmulet.Margin = new Padding(4, 0, 4, 0);
            lblJoAmulet.Name = "lblJoAmulet";
            lblJoAmulet.Size = new Size(62, 29);
            lblJoAmulet.TabIndex = 24;
            lblJoAmulet.Text = "Amulet";
            lblJoAmulet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJoRing1
            // 
            lblJoRing1.AutoSize = true;
            lblJoRing1.Dock = DockStyle.Fill;
            lblJoRing1.Location = new Point(256, 29);
            lblJoRing1.Margin = new Padding(4, 0, 4, 0);
            lblJoRing1.Name = "lblJoRing1";
            lblJoRing1.Size = new Size(62, 29);
            lblJoRing1.TabIndex = 24;
            lblJoRing1.Text = "Left Right";
            lblJoRing1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJoRing2
            // 
            lblJoRing2.AutoSize = true;
            lblJoRing2.Dock = DockStyle.Fill;
            lblJoRing2.Location = new Point(256, 58);
            lblJoRing2.Margin = new Padding(4, 0, 4, 0);
            lblJoRing2.Name = "lblJoRing2";
            lblJoRing2.Size = new Size(62, 29);
            lblJoRing2.TabIndex = 24;
            lblJoRing2.Text = "Right Ring";
            lblJoRing2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJoGauntlets
            // 
            lblJoGauntlets.AutoSize = true;
            lblJoGauntlets.Dock = DockStyle.Fill;
            lblJoGauntlets.Location = new Point(256, 87);
            lblJoGauntlets.Margin = new Padding(4, 0, 4, 0);
            lblJoGauntlets.Name = "lblJoGauntlets";
            lblJoGauntlets.Size = new Size(62, 29);
            lblJoGauntlets.TabIndex = 24;
            lblJoGauntlets.Text = "Gauntlets";
            lblJoGauntlets.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJoWeapon
            // 
            lblJoWeapon.AutoSize = true;
            lblJoWeapon.Dock = DockStyle.Fill;
            lblJoWeapon.Location = new Point(256, 116);
            lblJoWeapon.Margin = new Padding(4, 0, 4, 0);
            lblJoWeapon.Name = "lblJoWeapon";
            lblJoWeapon.Size = new Size(62, 29);
            lblJoWeapon.TabIndex = 24;
            lblJoWeapon.Text = "Weapon";
            lblJoWeapon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJoShield
            // 
            lblJoShield.AutoSize = true;
            lblJoShield.Dock = DockStyle.Fill;
            lblJoShield.Location = new Point(256, 145);
            lblJoShield.Margin = new Padding(4, 0, 4, 0);
            lblJoShield.Name = "lblJoShield";
            lblJoShield.Size = new Size(62, 29);
            lblJoShield.TabIndex = 24;
            lblJoShield.Text = "Shield";
            lblJoShield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJoBoots
            // 
            lblJoBoots.AutoSize = true;
            lblJoBoots.Dock = DockStyle.Fill;
            lblJoBoots.Location = new Point(256, 174);
            lblJoBoots.Margin = new Padding(4, 0, 4, 0);
            lblJoBoots.Name = "lblJoBoots";
            lblJoBoots.Size = new Size(62, 29);
            lblJoBoots.TabIndex = 24;
            lblJoBoots.Text = "Boots";
            lblJoBoots.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJoTorso
            // 
            lblJoTorso.AutoSize = true;
            lblJoTorso.Dock = DockStyle.Fill;
            lblJoTorso.Location = new Point(256, 203);
            lblJoTorso.Margin = new Padding(4, 0, 4, 0);
            lblJoTorso.Name = "lblJoTorso";
            lblJoTorso.Size = new Size(62, 29);
            lblJoTorso.TabIndex = 24;
            lblJoTorso.Text = "Torso";
            lblJoTorso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJoLeggings
            // 
            lblJoLeggings.AutoSize = true;
            lblJoLeggings.Dock = DockStyle.Fill;
            lblJoLeggings.Location = new Point(256, 232);
            lblJoLeggings.Margin = new Padding(4, 0, 4, 0);
            lblJoLeggings.Name = "lblJoLeggings";
            lblJoLeggings.Size = new Size(62, 29);
            lblJoLeggings.TabIndex = 24;
            lblJoLeggings.Text = "Leggings";
            lblJoLeggings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPageStart
            // 
            tabPageStart.Controls.Add(tableLayoutPanel11);
            tabPageStart.Location = new Point(4, 24);
            tabPageStart.Name = "tabPageStart";
            tabPageStart.Padding = new Padding(3);
            tabPageStart.Size = new Size(973, 507);
            tabPageStart.TabIndex = 6;
            tabPageStart.Text = "Start";
            tabPageStart.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 4;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(imgPreview, 2, 0);
            tableLayoutPanel11.Controls.Add(txtDescription, 1, 0);
            tableLayoutPanel11.Controls.Add(btnOpenFile, 1, 3);
            tableLayoutPanel11.Controls.Add(btnSaveFile, 2, 3);
            tableLayoutPanel11.Controls.Add(lblTime, 2, 1);
            tableLayoutPanel11.Controls.Add(numTime, 1, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(3, 3);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 5;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 188F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 53F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 8F));
            tableLayoutPanel11.Size = new Size(967, 501);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // imgPreview
            // 
            imgPreview.BorderStyle = BorderStyle.FixedSingle;
            imgPreview.Dock = DockStyle.Fill;
            imgPreview.Location = new Point(483, 0);
            imgPreview.Margin = new Padding(0);
            imgPreview.Name = "imgPreview";
            imgPreview.Size = new Size(250, 188);
            imgPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPreview.TabIndex = 22;
            imgPreview.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.Location = new Point(233, 0);
            txtDescription.Margin = new Padding(0);
            txtDescription.MaxLength = 255;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 188);
            txtDescription.TabIndex = 25;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Dock = DockStyle.Fill;
            btnOpenFile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenFile.Location = new Point(237, 249);
            btnOpenFile.Margin = new Padding(4, 3, 4, 3);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(242, 47);
            btnOpenFile.TabIndex = 23;
            btnOpenFile.Text = "Open";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += openFileToolStripMenuItem_Click;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Dock = DockStyle.Fill;
            btnSaveFile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveFile.Location = new Point(487, 249);
            btnSaveFile.Margin = new Padding(4, 3, 4, 3);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(242, 47);
            btnSaveFile.TabIndex = 24;
            btnSaveFile.Text = "Save";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += saveChangesToolStripMenuItem_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Dock = DockStyle.Fill;
            lblTime.Location = new Point(486, 188);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(244, 29);
            lblTime.TabIndex = 1;
            lblTime.Text = "Time: 00:00";
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numTime
            // 
            numTime.DecimalPlaces = 4;
            numTime.Dock = DockStyle.Fill;
            numTime.Location = new Point(236, 191);
            numTime.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            numTime.Name = "numTime";
            numTime.Size = new Size(244, 23);
            numTime.TabIndex = 0;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPageStart);
            tabMain.Controls.Add(tabPageJoseph);
            tabMain.Controls.Add(tabPageFlece);
            tabMain.Controls.Add(tabPageRosalind);
            tabMain.Controls.Add(tabPageJekhar);
            tabMain.Controls.Add(tabPageOther);
            tabMain.Controls.Add(tabPageInventory);
            tabMain.Controls.Add(tabPageCamera);
            tabMain.Controls.Add(tabPageContainer);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 24);
            tabMain.Margin = new Padding(4, 3, 4, 3);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(981, 535);
            tabMain.TabIndex = 19;
            // 
            // tabPageContainer
            // 
            tabPageContainer.Controls.Add(tableLayoutPanel2);
            tabPageContainer.Location = new Point(4, 24);
            tabPageContainer.Name = "tabPageContainer";
            tabPageContainer.Padding = new Padding(3);
            tabPageContainer.Size = new Size(973, 507);
            tabPageContainer.TabIndex = 8;
            tabPageContainer.Text = "Containers";
            tabPageContainer.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel2.Controls.Add(lvContainerGameItems, 2, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 3);
            tableLayoutPanel2.Controls.Add(lblContainers, 0, 0);
            tableLayoutPanel2.Controls.Add(lblContainerContent, 0, 2);
            tableLayoutPanel2.Controls.Add(lvContainers, 0, 1);
            tableLayoutPanel2.Controls.Add(lvContainerContent, 0, 3);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 210F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 210F));
            tableLayoutPanel2.Size = new Size(967, 501);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnRemoveContainer, 0, 1);
            tableLayoutPanel3.Controls.Add(btnAddContainer, 0, 0);
            tableLayoutPanel3.Controls.Add(btnToggleContainerLock, 0, 6);
            tableLayoutPanel3.Controls.Add(numContainerPosZ, 1, 5);
            tableLayoutPanel3.Controls.Add(label22, 0, 5);
            tableLayoutPanel3.Controls.Add(numContainerPosY, 1, 4);
            tableLayoutPanel3.Controls.Add(label21, 0, 4);
            tableLayoutPanel3.Controls.Add(numContainerPosX, 1, 3);
            tableLayoutPanel3.Controls.Add(label20, 0, 3);
            tableLayoutPanel3.Controls.Add(btnModifyContainer, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(386, 29);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel3.Size = new Size(194, 204);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // btnRemoveContainer
            // 
            tableLayoutPanel3.SetColumnSpan(btnRemoveContainer, 2);
            btnRemoveContainer.Dock = DockStyle.Fill;
            btnRemoveContainer.Location = new Point(3, 32);
            btnRemoveContainer.Name = "btnRemoveContainer";
            btnRemoveContainer.Size = new Size(188, 23);
            btnRemoveContainer.TabIndex = 2;
            btnRemoveContainer.Text = "Remove Container";
            btnRemoveContainer.UseVisualStyleBackColor = true;
            btnRemoveContainer.Click += btnRemoveContainer_Click;
            // 
            // btnAddContainer
            // 
            tableLayoutPanel3.SetColumnSpan(btnAddContainer, 2);
            btnAddContainer.Dock = DockStyle.Fill;
            btnAddContainer.Location = new Point(3, 3);
            btnAddContainer.Name = "btnAddContainer";
            btnAddContainer.Size = new Size(188, 23);
            btnAddContainer.TabIndex = 2;
            btnAddContainer.Text = "Add Container";
            btnAddContainer.UseVisualStyleBackColor = true;
            btnAddContainer.Click += btnAddContainer_Click;
            // 
            // btnToggleContainerLock
            // 
            tableLayoutPanel3.SetColumnSpan(btnToggleContainerLock, 2);
            btnToggleContainerLock.Dock = DockStyle.Fill;
            btnToggleContainerLock.Location = new Point(3, 177);
            btnToggleContainerLock.Name = "btnToggleContainerLock";
            btnToggleContainerLock.Size = new Size(188, 24);
            btnToggleContainerLock.TabIndex = 1;
            btnToggleContainerLock.Text = "Toggle Lock";
            btnToggleContainerLock.UseVisualStyleBackColor = true;
            btnToggleContainerLock.Click += btnToggleContainerLock_Click;
            // 
            // numContainerPosZ
            // 
            numContainerPosZ.DecimalPlaces = 4;
            numContainerPosZ.Dock = DockStyle.Fill;
            numContainerPosZ.Location = new Point(100, 148);
            numContainerPosZ.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numContainerPosZ.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numContainerPosZ.Name = "numContainerPosZ";
            numContainerPosZ.Size = new Size(91, 23);
            numContainerPosZ.TabIndex = 3;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Dock = DockStyle.Fill;
            label22.Location = new Point(3, 145);
            label22.Name = "label22";
            label22.Size = new Size(91, 29);
            label22.TabIndex = 4;
            label22.Text = "Z";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numContainerPosY
            // 
            numContainerPosY.DecimalPlaces = 4;
            numContainerPosY.Dock = DockStyle.Fill;
            numContainerPosY.Location = new Point(100, 119);
            numContainerPosY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numContainerPosY.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numContainerPosY.Name = "numContainerPosY";
            numContainerPosY.Size = new Size(91, 23);
            numContainerPosY.TabIndex = 3;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Dock = DockStyle.Fill;
            label21.Location = new Point(3, 116);
            label21.Name = "label21";
            label21.Size = new Size(91, 29);
            label21.TabIndex = 4;
            label21.Text = "Y";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numContainerPosX
            // 
            numContainerPosX.DecimalPlaces = 4;
            numContainerPosX.Dock = DockStyle.Fill;
            numContainerPosX.Location = new Point(100, 90);
            numContainerPosX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numContainerPosX.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numContainerPosX.Name = "numContainerPosX";
            numContainerPosX.Size = new Size(91, 23);
            numContainerPosX.TabIndex = 3;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Dock = DockStyle.Fill;
            label20.Location = new Point(3, 87);
            label20.Name = "label20";
            label20.Size = new Size(91, 29);
            label20.TabIndex = 4;
            label20.Text = "X";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnModifyContainer
            // 
            tableLayoutPanel3.SetColumnSpan(btnModifyContainer, 2);
            btnModifyContainer.Dock = DockStyle.Fill;
            btnModifyContainer.Location = new Point(3, 61);
            btnModifyContainer.Name = "btnModifyContainer";
            btnModifyContainer.Size = new Size(188, 23);
            btnModifyContainer.TabIndex = 2;
            btnModifyContainer.Text = "Modify Container";
            btnModifyContainer.UseVisualStyleBackColor = true;
            btnModifyContainer.Click += btnModifyContainer_Click;
            // 
            // lvContainerGameItems
            // 
            lvContainerGameItems.Columns.AddRange(new ColumnHeader[] { columnHeader21 });
            lvContainerGameItems.Dock = DockStyle.Fill;
            lvContainerGameItems.Location = new Point(586, 29);
            lvContainerGameItems.Name = "lvContainerGameItems";
            tableLayoutPanel2.SetRowSpan(lvContainerGameItems, 3);
            lvContainerGameItems.Size = new Size(378, 469);
            lvContainerGameItems.TabIndex = 5;
            lvContainerGameItems.UseCompatibleStateImageBehavior = false;
            lvContainerGameItems.View = View.Details;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Item Name";
            columnHeader21.Width = 180;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(btnAddToContainer, 0, 0);
            tableLayoutPanel4.Controls.Add(btnRemoveFromContainer, 0, 1);
            tableLayoutPanel4.Controls.Add(btnApplyToContainerItems, 0, 2);
            tableLayoutPanel4.Controls.Add(numContainerItemQuantity, 1, 3);
            tableLayoutPanel4.Controls.Add(numContainerItemCharges, 1, 4);
            tableLayoutPanel4.Controls.Add(label23, 0, 3);
            tableLayoutPanel4.Controls.Add(label24, 0, 4);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(386, 265);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(194, 233);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // btnAddToContainer
            // 
            tableLayoutPanel4.SetColumnSpan(btnAddToContainer, 2);
            btnAddToContainer.Dock = DockStyle.Fill;
            btnAddToContainer.Location = new Point(3, 3);
            btnAddToContainer.Name = "btnAddToContainer";
            btnAddToContainer.Size = new Size(188, 23);
            btnAddToContainer.TabIndex = 1;
            btnAddToContainer.Text = "Add Item";
            btnAddToContainer.UseVisualStyleBackColor = true;
            btnAddToContainer.Click += btnAddToContainer_Click;
            // 
            // btnRemoveFromContainer
            // 
            tableLayoutPanel4.SetColumnSpan(btnRemoveFromContainer, 2);
            btnRemoveFromContainer.Dock = DockStyle.Fill;
            btnRemoveFromContainer.Location = new Point(3, 32);
            btnRemoveFromContainer.Name = "btnRemoveFromContainer";
            btnRemoveFromContainer.Size = new Size(188, 23);
            btnRemoveFromContainer.TabIndex = 1;
            btnRemoveFromContainer.Text = "Remove Item";
            btnRemoveFromContainer.UseVisualStyleBackColor = true;
            btnRemoveFromContainer.Click += btnRemoveFromContainer_Click;
            // 
            // btnApplyToContainerItems
            // 
            tableLayoutPanel4.SetColumnSpan(btnApplyToContainerItems, 2);
            btnApplyToContainerItems.Dock = DockStyle.Fill;
            btnApplyToContainerItems.Location = new Point(3, 61);
            btnApplyToContainerItems.Name = "btnApplyToContainerItems";
            btnApplyToContainerItems.Size = new Size(188, 23);
            btnApplyToContainerItems.TabIndex = 2;
            btnApplyToContainerItems.Text = "Apply to Selected";
            btnApplyToContainerItems.UseVisualStyleBackColor = true;
            btnApplyToContainerItems.Click += btnApplyToContainerItems_Click;
            // 
            // numContainerItemQuantity
            // 
            numContainerItemQuantity.Dock = DockStyle.Fill;
            numContainerItemQuantity.Location = new Point(100, 90);
            numContainerItemQuantity.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numContainerItemQuantity.Name = "numContainerItemQuantity";
            numContainerItemQuantity.Size = new Size(91, 23);
            numContainerItemQuantity.TabIndex = 3;
            // 
            // numContainerItemCharges
            // 
            numContainerItemCharges.Dock = DockStyle.Fill;
            numContainerItemCharges.Location = new Point(100, 119);
            numContainerItemCharges.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numContainerItemCharges.Name = "numContainerItemCharges";
            numContainerItemCharges.Size = new Size(91, 23);
            numContainerItemCharges.TabIndex = 3;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Dock = DockStyle.Fill;
            label23.Location = new Point(3, 87);
            label23.Name = "label23";
            label23.Size = new Size(91, 29);
            label23.TabIndex = 4;
            label23.Text = "Quantity";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Dock = DockStyle.Fill;
            label24.Location = new Point(3, 116);
            label24.Name = "label24";
            label24.Size = new Size(91, 29);
            label24.TabIndex = 5;
            label24.Text = "Charges";
            label24.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblContainers
            // 
            lblContainers.AutoSize = true;
            lblContainers.Dock = DockStyle.Fill;
            lblContainers.Location = new Point(3, 0);
            lblContainers.Name = "lblContainers";
            lblContainers.Size = new Size(377, 26);
            lblContainers.TabIndex = 6;
            lblContainers.Text = "Containers: 0 / 0";
            lblContainers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblContainerContent
            // 
            lblContainerContent.AutoSize = true;
            lblContainerContent.Dock = DockStyle.Fill;
            lblContainerContent.Location = new Point(3, 236);
            lblContainerContent.Name = "lblContainerContent";
            lblContainerContent.Size = new Size(377, 26);
            lblContainerContent.TabIndex = 6;
            lblContainerContent.Text = "Container Items: 0 / 16";
            lblContainerContent.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lvContainers
            // 
            lvContainers.Columns.AddRange(new ColumnHeader[] { columnHeader6, columnHeader20 });
            lvContainers.Dock = DockStyle.Fill;
            lvContainers.Location = new Point(3, 29);
            lvContainers.Name = "lvContainers";
            lvContainers.Size = new Size(377, 204);
            lvContainers.TabIndex = 0;
            lvContainers.UseCompatibleStateImageBehavior = false;
            lvContainers.View = View.Details;
            lvContainers.SelectedIndexChanged += lvContainers_SelectedIndexChanged;
            // 
            // columnHeader6
            // 
            columnHeader6.Text = "Container";
            columnHeader6.Width = 180;
            // 
            // columnHeader20
            // 
            columnHeader20.Text = "Locked";
            columnHeader20.Width = 100;
            // 
            // lvContainerContent
            // 
            lvContainerContent.Columns.AddRange(new ColumnHeader[] { columnHeader7, columnHeader18, columnHeader19 });
            lvContainerContent.Dock = DockStyle.Fill;
            lvContainerContent.Location = new Point(3, 265);
            lvContainerContent.Name = "lvContainerContent";
            lvContainerContent.Size = new Size(377, 233);
            lvContainerContent.TabIndex = 0;
            lvContainerContent.UseCompatibleStateImageBehavior = false;
            lvContainerContent.View = View.Details;
            // 
            // columnHeader7
            // 
            columnHeader7.Text = "Item";
            columnHeader7.Width = 180;
            // 
            // columnHeader18
            // 
            columnHeader18.Text = "Quantity";
            columnHeader18.Width = 80;
            // 
            // columnHeader19
            // 
            columnHeader19.Text = "Charges";
            columnHeader19.Width = 80;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, applyChangesToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "&File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(133, 22);
            openFileToolStripMenuItem.Text = "&Open File...";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // applyChangesToolStripMenuItem
            // 
            applyChangesToolStripMenuItem.Name = "applyChangesToolStripMenuItem";
            applyChangesToolStripMenuItem.Size = new Size(133, 22);
            applyChangesToolStripMenuItem.Text = "&Save";
            applyChangesToolStripMenuItem.Click += saveChangesToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(133, 22);
            exitToolStripMenuItem.Text = "E&xit";
            exitToolStripMenuItem.Click += ExitToolStripMenuItem_Click;
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new Size(52, 20);
            aboutToolStripMenuItem.Text = "&About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, aboutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.RenderMode = ToolStripRenderMode.System;
            menuStrip1.Size = new Size(981, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            // 
            // SummonerSaveFileEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(981, 559);
            Controls.Add(tabMain);
            Controls.Add(menuStrip1);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SummonerSaveFileEditor";
            Text = "Summoner Save File Editor";
            tabPageOther.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            tblCreatureEdit.ResumeLayout(false);
            tblCreatureEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCreatureLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCreatureBaseHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCreatureCurrentHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCreatureBaseAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCreatureCurrentAP).EndInit();
            tabPageCamera.ResumeLayout(false);
            tabPageCamera.PerformLayout();
            tbleCameraPanel.ResumeLayout(false);
            tbleCameraPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCameraMode).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCameraUnknown).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCameraPosZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCameraFoV).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCameraPosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCameraPitch).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCameraPosX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCameraYaw).EndInit();
            ((System.ComponentModel.ISupportInitialize)numCameraZoom).EndInit();
            tabPageInventory.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            pnlInventoryControls.ResumeLayout(false);
            gbGold.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numGold).EndInit();
            GBoxItemQuantity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numCharges).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            tabPageJekhar.ResumeLayout(false);
            tblJekhar.ResumeLayout(false);
            tblJekhar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numJeCurrentHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJeCurrentAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJeSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJeBaseAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJeBaseHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJeLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJeExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJeSkill).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numJeSkillValue).EndInit();
            tabPageRosalind.ResumeLayout(false);
            tblRosalind.ResumeLayout(false);
            tblRosalind.PerformLayout();
            tableLayoutPanel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numRoSkillValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoCurrentHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoCurrentAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoBaseAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoBaseHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoSkill).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoExperience).EndInit();
            tabPageFlece.ResumeLayout(false);
            tblFlece.ResumeLayout(false);
            tblFlece.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numFlSkillValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlBaseAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlBaseHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlSkill).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlCurrentHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlCurrentAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlSpeed).EndInit();
            tabPageJoseph.ResumeLayout(false);
            tblJoseph.ResumeLayout(false);
            tblJoseph.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numJoSkillValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoSkill).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoBaseHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoCurrentAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoCurrentHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoBaseAP).EndInit();
            tabPageStart.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imgPreview).EndInit();
            ((System.ComponentModel.ISupportInitialize)numTime).EndInit();
            tabMain.ResumeLayout(false);
            tabPageContainer.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numContainerPosZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)numContainerPosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numContainerPosX).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numContainerItemQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numContainerItemCharges).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion
        private Character currentlySelectedCharacter;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label10;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private TabPage tabPageOther;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tblCreatureEdit;
        private Label LabelOtherLevel;
        private NumericUpDown numCreatureLevel;
        private Button btnMaxOtherLevel;
        private Label LabelOtherMaxHP;
        private Button btnMaxOther;
        private NumericUpDown numCreatureBaseHP;
        private Button btnMaxOtherCurrentAP;
        private Button btnMaxOtherBaseHP;
        private Button btnMaxOtherBaseAP;
        private Label LabelOtherCurrHP;
        private NumericUpDown numCreatureCurrentAP;
        private NumericUpDown numCreatureCurrentHP;
        private Label LabelOtherCurrAP;
        private Button btnMaxOtherCurrentHP;
        private Label LabelOtherMaxAP;
        private NumericUpDown numCreatureBaseAP;
        private ListView lvCreatureList;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader15;
        private ColumnHeader columnHeader5;
        private ColumnHeader columnHeader8;
        private TabPage tabPageCamera;
        private NumericUpDown numCameraMode;
        private NumericUpDown numCameraPosZ;
        private NumericUpDown numCameraPosY;
        private NumericUpDown numCameraPosX;
        private NumericUpDown numCameraZoom;
        private NumericUpDown numCameraYaw;
        private NumericUpDown numCameraPitch;
        private NumericUpDown numCameraFoV;
        private NumericUpDown numCameraUnknown;
        private TableLayoutPanel tbleCameraPanel;
        private TabPage tabPageInventory;
        private Button btnToggleIdentified;
        private Label lblInventory;
        private ListView lvInventory;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private Label lblGameItems;
        private Button btnAddAllItems;
        private Button btnClearInventory;
        private Button btnAddItem;
        private Button btnRemoveItem;
        private GroupBox gbGold;
        private Button btnMaxGold;
        private NumericUpDown numGold;
        private GroupBox GBoxItemQuantity;
        private Button btnApplyToAll;
        private Button btnApplyToSelected;
        private NumericUpDown numQuantity;
        private Label lblQuantity;
        private TabPage tabPageJekhar;
        private TableLayoutPanel tblJekhar;
        private Label lblJeAmulet;
        private Label lblJeRing1;
        private Label lblJeRing2;
        private Label lblJeGauntlets;
        private Label lblJeWeapon;
        private Label lblJeShield;
        private Label lblJeBoots;
        private Label lblJeTorso;
        private Label lblJeCurrentHP;
        private ComboBox cbJeLeggings;
        private ComboBox cbJeTorso;
        private ComboBox cbJeBoots;
        private ComboBox cbJeShield;
        private ComboBox cbJeWeapon;
        private ComboBox cbJeGauntlets;
        private ComboBox cbJeRing2;
        private ComboBox cbJeRing1;
        private ComboBox cbJeAmulet;
        private NumericUpDown numJeCurrentHP;
        private Button btnJeMaxCurrentHP;
        private Label lblJeCurrentAP;
        private NumericUpDown numJeCurrentAP;
        private Button btnJeMaxCurrentAP;
        private Label lblJeSpeed;
        private NumericUpDown numJeSpeed;
        private Button btnJeMaxSpeed;
        private Label lblJeLeggings;
        private Button btnJeMaxAll;
        private Button btnJeMaxBaseAP;
        private NumericUpDown numJeBaseAP;
        private Button btnJeMaxBaseHP;
        private Label lblJeBaseAP;
        private NumericUpDown numJeBaseHP;
        private NumericUpDown numJeLevel;
        private Label lblJeBaseHP;
        private NumericUpDown numJeExperience;
        private Label lblJeSkillPoints;
        private Button btnJeMaxLevel;
        private Label lblJeLevel;
        private Label lblJeExperience;
        private Button btnJeMaxExp;
        private NumericUpDown numJeSkill;
        private Button btnJeMaxSkill;
        private ListView lvJekharSkills;
        private ColumnHeader columnSkillName;
        private ColumnHeader columnSkillValue;
        private TableLayoutPanel tableLayoutPanel7;
        private NumericUpDown numJeSkillValue;
        private Button btnJeUpdateSkill;
        private TabPage tabPageRosalind;
        private TableLayoutPanel tblRosalind;
        private TableLayoutPanel tableLayoutPanel10;
        private NumericUpDown numRoSkillValue;
        private Button btnRoUpdateSkill;
        private ListView lvRosalindSkills;
        private ColumnHeader columnHeader13;
        private ColumnHeader columnHeader14;
        private Label lblRoAmulet;
        private Label lblRoRing1;
        private Label lblRoRing2;
        private Label lblRoGauntlets;
        private Label lblRoWeapon;
        private Label lblRoShield;
        private Label lblRoBoots;
        private Label lblRoTorso;
        private Label lblRoCurrentHP;
        private ComboBox cbRoLeggings;
        private ComboBox cbRoTorso;
        private ComboBox cbRoBoots;
        private ComboBox cbRoShield;
        private ComboBox cbRoWeapon;
        private ComboBox cbRoGauntlets;
        private ComboBox cbRoRing2;
        private ComboBox cbRoRing1;
        private ComboBox cbRoAmulet;
        private NumericUpDown numRoCurrentHP;
        private Button btnRoMaxCurrentHP;
        private Label lblRoCurrentAP;
        private NumericUpDown numRoCurrentAP;
        private Button btnRoMaxCurrentAP;
        private Label lblRoSpeed;
        private NumericUpDown numRoSpeed;
        private Button btnRoMaxSpeed;
        private Label lblRoLeggings;
        private Button btnRoMaxAll;
        private Button btnRoMaxBaseAP;
        private NumericUpDown numRoBaseAP;
        private Button btnRoMaxBaseHP;
        private Label lblRoBaseAP;
        private NumericUpDown numRoBaseHP;
        private Label lblRoBaseHP;
        private Button btnRoMaxSkill;
        private NumericUpDown numRoSkill;
        private Button btnRoMaxExp;
        private Label lblRoSkillPoints;
        private NumericUpDown numRoLevel;
        private NumericUpDown numRoExperience;
        private Button btnRoMaxLevel;
        private Label lblRoLevel;
        private Label lblRoExperience;
        private TabPage tabPageFlece;
        private TableLayoutPanel tblFlece;
        private Label lblFlAmulet;
        private ListView lvFleceSkills;
        private ColumnHeader columnHeader11;
        private ColumnHeader columnHeader12;
        private TableLayoutPanel tableLayoutPanel8;
        private NumericUpDown numFlSkillValue;
        private Button btnFlUpdateSkill;
        private Label lblFlRing1;
        private Label lblFlRing2;
        private Label lblFlGauntlets;
        private Label lblFlWeapon;
        private Label lblFlShield;
        private Label lblFlBoots;
        private Label lblFlTorso;
        private Button btnFlMaxAll;
        private Button btnFlMaxBaseAP;
        private Label lblFlCurrentHP;
        private NumericUpDown numFlBaseAP;
        private Button btnFlMaxBaseHP;
        private Label lblFlBaseAP;
        private ComboBox cbFlLeggings;
        private ComboBox cbFlTorso;
        private ComboBox cbFlBoots;
        private NumericUpDown numFlBaseHP;
        private ComboBox cbFlShield;
        private Label lblFlBaseHP;
        private ComboBox cbFlWeapon;
        private Button btnFlMaxSkill;
        private ComboBox cbFlGauntlets;
        private NumericUpDown numFlSkill;
        private Button btnFlMaxExp;
        private Label lblFlSkillPoints;
        private NumericUpDown numFlLevel;
        private NumericUpDown numFlExperience;
        private Button btnFlMaxLevel;
        private Label lblFlLevel;
        private ComboBox cbFlRing2;
        private Label lblFlExperience;
        private ComboBox cbFlRing1;
        private ComboBox cbFlAmulet;
        private NumericUpDown numFlCurrentHP;
        private Button btnFlMaxCurrentHP;
        private Label lblFlCurrentAP;
        private NumericUpDown numFlCurrentAP;
        private Button btnFlMaxCurrentAP;
        private Label lblFlSpeed;
        private NumericUpDown numFlSpeed;
        private Button btnFlMaxSpeed;
        private Label lblFlLeggings;
        private TabPage tabPageJoseph;
        private TableLayoutPanel tblJoseph;
        private Label lblJoLevel;
        private ComboBox cbJoLeggings;
        private ListView lvJosephSkills;
        private ColumnHeader columnHeader9;
        private ColumnHeader columnHeader10;
        private TableLayoutPanel tableLayoutPanel9;
        private NumericUpDown numJoSkillValue;
        private Button btnJoUpdateSkill;
        private NumericUpDown numJoLevel;
        private ComboBox cbJoTorso;
        private ComboBox cbJoBoots;
        private ComboBox cbJoShield;
        private Button btnJoMaxLevel;
        private Label lblJoExperience;
        private ComboBox cbJoWeapon;
        private NumericUpDown numJoExperience;
        private ComboBox cbJoGauntlets;
        private Button btnJoMaxExperience;
        private Label lblJoSkillPoints;
        private ComboBox cbJoRing2;
        private NumericUpDown numJoSkill;
        private ComboBox cbJoRing1;
        private Button btnJoMaxSkillPoints;
        private ComboBox cbJoAmulet;
        private Label lblJoMaxHP;
        private Button btnJoMaxAll;
        private Button btnJoMaxSpeed;
        private NumericUpDown numJoBaseHP;
        private NumericUpDown numJoSpeed;
        private Button btnJoMaxCurrentAP;
        private Label lblJoSpeed;
        private Button btnJoMaxBaseHP;
        private Button btnJoMaxBaseAP;
        private Label lblJoCurrentHP;
        private NumericUpDown numJoCurrentAP;
        private NumericUpDown numJoCurrentHP;
        private Label lblJoCurrentAP;
        private Button btnJoMaxCurrentHP;
        private Label lblJoBaseAP;
        private NumericUpDown numJoBaseAP;
        private Label lblJoAmulet;
        private Label lblJoRing1;
        private Label lblJoRing2;
        private Label lblJoGauntlets;
        private Label lblJoWeapon;
        private Label lblJoShield;
        private Label lblJoBoots;
        private Label lblJoTorso;
        private Label lblJoLeggings;
        private TabPage tabPageStart;
        private TableLayoutPanel tableLayoutPanel11;
        private Button btnOpenFile;
        private PictureBox imgPreview;
        private NumericUpDown numTime;
        private Label lblTime;
        private TextBox txtDescription;
        private TabControl tabMain;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem applyChangesToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button button1;
        private ListView lvGameItems;
        private ColumnHeader columnHeader17;
        private ColumnHeader columnHeader16;
        private Button btnSaveFile;
        private Label lblCharges;
        private NumericUpDown numCharges;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label8;
        private Label label9;
        private Label label11;
        private Label label12;
        private Label label17;
        private Label label18;
        private Label label19;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel pnlInventoryControls;
        private TabPage tabPageContainer;
        private ListView lvContainerContent;
        private ColumnHeader columnHeader7;
        private ColumnHeader columnHeader18;
        private ColumnHeader columnHeader19;
        private ListView lvContainers;
        private ColumnHeader columnHeader6;
        private ColumnHeader columnHeader20;
        private Button btnAddToContainer;
        private Button btnToggleContainerLock;
        private Label label22;
        private Label label21;
        private Label label20;
        private NumericUpDown numContainerPosZ;
        private NumericUpDown numContainerPosY;
        private NumericUpDown numContainerPosX;
        private Button btnModifyContainer;
        private Button btnAddContainer;
        private ListView lvContainerGameItems;
        private ColumnHeader columnHeader21;
        private NumericUpDown numContainerItemCharges;
        private NumericUpDown numContainerItemQuantity;
        private Button btnApplyToContainerItems;
        private Label lblContainerContent;
        private Label lblContainers;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnRemoveFromContainer;
        private Button btnRemoveContainer;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label23;
        private Label label24;
    }
}