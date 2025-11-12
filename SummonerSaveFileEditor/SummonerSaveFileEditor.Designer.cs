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
            numEntityLevel = new NumericUpDown();
            btnMaxOtherLevel = new Button();
            LabelOtherMaxHP = new Label();
            numEntityBaseHP = new NumericUpDown();
            btnMaxOtherBaseHP = new Button();
            LabelOtherCurrHP = new Label();
            numEntityCurrentHP = new NumericUpDown();
            btnMaxOtherCurrentHP = new Button();
            LabelOtherMaxAP = new Label();
            numEntityBaseAP = new NumericUpDown();
            btnMaxOtherBaseAP = new Button();
            LabelOtherCurrAP = new Label();
            numEntityCurrentAP = new NumericUpDown();
            btnMaxOtherCurrentAP = new Button();
            btnMaxOther = new Button();
            lblCreatureStatus = new Label();
            numEntityPosZ = new NumericUpDown();
            numEntityPosY = new NumericUpDown();
            numEntityPosX = new NumericUpDown();
            lblOtherPosZ = new Label();
            lblOtherPosY = new Label();
            lblOtherPosX = new Label();
            label30 = new Label();
            lvCreatureList = new ListView();
            columnHeader4 = new ColumnHeader();
            columnHeader15 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            columnHeader8 = new ColumnHeader();
            columnHeader26 = new ColumnHeader();
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
            numJeSkillPoints = new NumericUpDown();
            btnJeMaxSkill = new Button();
            lvJekharSkills = new ListView();
            columnSkillName = new ColumnHeader();
            columnSkillValue = new ColumnHeader();
            tableLayoutPanel7 = new TableLayoutPanel();
            numJeSkillValue = new NumericUpDown();
            btnJeUpdateSkill = new Button();
            numJePosX = new NumericUpDown();
            numJePosY = new NumericUpDown();
            numJePosZ = new NumericUpDown();
            lblJePosition = new Label();
            lblJePosX = new Label();
            lblJePosY = new Label();
            lblJePosZ = new Label();
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
            numRoSkillPoints = new NumericUpDown();
            btnRoMaxExp = new Button();
            lblRoSkillPoints = new Label();
            numRoLevel = new NumericUpDown();
            numRoExperience = new NumericUpDown();
            btnRoMaxLevel = new Button();
            lblRoLevel = new Label();
            lblRoExperience = new Label();
            numRoPosX = new NumericUpDown();
            numRoPosY = new NumericUpDown();
            numRoPosZ = new NumericUpDown();
            lblRoPosition = new Label();
            lblRoPosX = new Label();
            lblRoPosY = new Label();
            lblRoPosZ = new Label();
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
            numFlSkillPoints = new NumericUpDown();
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
            numFlPosX = new NumericUpDown();
            numFlPosY = new NumericUpDown();
            numFlPosZ = new NumericUpDown();
            label32 = new Label();
            lblFlPosX = new Label();
            lblFlPosY = new Label();
            lblFlPosZ = new Label();
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
            numJoSkillPoints = new NumericUpDown();
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
            label31 = new Label();
            lblJoPosX = new Label();
            lblJoPosY = new Label();
            lblJoPosZ = new Label();
            numJoPosX = new NumericUpDown();
            numJoPosY = new NumericUpDown();
            numJoPosZ = new NumericUpDown();
            tabPageStart = new TabPage();
            tableLayoutPanel11 = new TableLayoutPanel();
            btnSaveFile = new Button();
            btnOpenFile = new Button();
            numTime = new NumericUpDown();
            lblTime = new Label();
            imgPreview = new PictureBox();
            txtDescription = new TextBox();
            tabMain = new TabControl();
            tabPageSummon = new TabPage();
            tblSummon = new TableLayoutPanel();
            lblSuAmulet = new Label();
            lblSuRing1 = new Label();
            lblSuRing2 = new Label();
            lblSuGauntlets = new Label();
            lblSuWeapon = new Label();
            lblSuShield = new Label();
            lblSuBoots = new Label();
            lblSuTorso = new Label();
            lblSuCurrentHP = new Label();
            cbSuLeggings = new ComboBox();
            cbSuTorso = new ComboBox();
            cbSuBoots = new ComboBox();
            cbSuShield = new ComboBox();
            cbSuWeapon = new ComboBox();
            cbSuGauntlets = new ComboBox();
            cbSuRing2 = new ComboBox();
            cbSuRing1 = new ComboBox();
            cbSuAmulet = new ComboBox();
            numSuCurrentHP = new NumericUpDown();
            btnSuMaxCurrentHP = new Button();
            lblSuCurrentAP = new Label();
            numSuCurrentAP = new NumericUpDown();
            btnSuMaxCurrentAP = new Button();
            lblSuSpeed = new Label();
            numSuSpeed = new NumericUpDown();
            btnSuMaxSpeed = new Button();
            lblSuLeggings = new Label();
            btnSuMaxAll = new Button();
            btnSuMaxBaseAP = new Button();
            numSuBaseAP = new NumericUpDown();
            btnSuMaxBaseHP = new Button();
            lblSuBaseAP = new Label();
            numSuBaseHP = new NumericUpDown();
            numSuLevel = new NumericUpDown();
            lblSuBaseHP = new Label();
            numSuExperience = new NumericUpDown();
            lblSuSkillPoints = new Label();
            btnSuMaxLevel = new Button();
            lblSuLevel = new Label();
            lblSuExperience = new Label();
            btnSuMaxExp = new Button();
            numSuSkillPoints = new NumericUpDown();
            btnSuMaxSkill = new Button();
            lvSummonSkills = new ListView();
            columnHeader24 = new ColumnHeader();
            columnHeader25 = new ColumnHeader();
            tableLayoutPanel19 = new TableLayoutPanel();
            numSuSkillValue = new NumericUpDown();
            btnSuUpdateSkill = new Button();
            label29 = new Label();
            lblSuPosition = new Label();
            lblSuPosX = new Label();
            lblSuPosY = new Label();
            lblSuPosZ = new Label();
            numSuPosX = new NumericUpDown();
            numSuPosY = new NumericUpDown();
            numSuPosZ = new NumericUpDown();
            tabPageContainer = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnModifyGoldPile = new Button();
            btnRemoveGoldPile = new Button();
            btnAddGoldPile = new Button();
            btnRemoveContainer = new Button();
            btnAddContainer = new Button();
            btnToggleContainerLock = new Button();
            tableLayoutPanel12 = new TableLayoutPanel();
            label21 = new Label();
            numContainerPosY = new NumericUpDown();
            tableLayoutPanel17 = new TableLayoutPanel();
            label28 = new Label();
            numGoldPileAmount = new NumericUpDown();
            tableLayoutPanel16 = new TableLayoutPanel();
            label27 = new Label();
            numGoldPilePosZ = new NumericUpDown();
            tableLayoutPanel15 = new TableLayoutPanel();
            label26 = new Label();
            numGoldPilePosY = new NumericUpDown();
            tableLayoutPanel14 = new TableLayoutPanel();
            label25 = new Label();
            numGoldPilePosX = new NumericUpDown();
            tableLayoutPanel13 = new TableLayoutPanel();
            label22 = new Label();
            numContainerPosZ = new NumericUpDown();
            tableLayoutPanel6 = new TableLayoutPanel();
            label20 = new Label();
            numContainerPosX = new NumericUpDown();
            btnModifyContainer = new Button();
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
            lvContainerGameItems = new ListView();
            columnHeader21 = new ColumnHeader();
            lvGoldPiles = new ListView();
            columnHeader22 = new ColumnHeader();
            columnHeader23 = new ColumnHeader();
            lblGoldPiles = new Label();
            lblContainerGameItems = new Label();
            tabPageQuests = new TabPage();
            label33 = new Label();
            lvQuestList = new ListView();
            columnHeader27 = new ColumnHeader();
            tabPageLevelItems = new TabPage();
            lvLevelItems = new ListView();
            columnHeader28 = new ColumnHeader();
            columnHeader29 = new ColumnHeader();
            columnHeader30 = new ColumnHeader();
            columnHeader31 = new ColumnHeader();
            columnHeader32 = new ColumnHeader();
            columnHeader33 = new ColumnHeader();
            tabPageConversations = new TabPage();
            tvConversations = new TreeView();
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
            ((System.ComponentModel.ISupportInitialize)numEntityLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntityBaseHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntityCurrentHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntityBaseAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntityCurrentAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntityPosZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntityPosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEntityPosX).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)numJeSkillPoints).BeginInit();
            tableLayoutPanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJeSkillValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJePosX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJePosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJePosZ).BeginInit();
            tabPageRosalind.SuspendLayout();
            tblRosalind.SuspendLayout();
            tableLayoutPanel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numRoSkillValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoCurrentHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoCurrentAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoBaseAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoBaseHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoSkillPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoPosX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoPosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRoPosZ).BeginInit();
            tabPageFlece.SuspendLayout();
            tblFlece.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numFlSkillValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlBaseAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlBaseHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlSkillPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlCurrentHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlCurrentAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlPosX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlPosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFlPosZ).BeginInit();
            tabPageJoseph.SuspendLayout();
            tblJoseph.SuspendLayout();
            tableLayoutPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numJoSkillValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoSkillPoints).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoBaseHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoCurrentAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoCurrentHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoBaseAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoPosX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoPosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numJoPosZ).BeginInit();
            tabPageStart.SuspendLayout();
            tableLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgPreview).BeginInit();
            tabMain.SuspendLayout();
            tabPageSummon.SuspendLayout();
            tblSummon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSuCurrentHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSuCurrentAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSuSpeed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSuBaseAP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSuBaseHP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSuLevel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSuExperience).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSuSkillPoints).BeginInit();
            tableLayoutPanel19.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numSuSkillValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSuPosX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSuPosY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSuPosZ).BeginInit();
            tabPageContainer.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel12.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numContainerPosY).BeginInit();
            tableLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGoldPileAmount).BeginInit();
            tableLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGoldPilePosZ).BeginInit();
            tableLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGoldPilePosY).BeginInit();
            tableLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numGoldPilePosX).BeginInit();
            tableLayoutPanel13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numContainerPosZ).BeginInit();
            tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numContainerPosX).BeginInit();
            tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numContainerItemQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numContainerItemCharges).BeginInit();
            tabPageQuests.SuspendLayout();
            tabPageLevelItems.SuspendLayout();
            tabPageConversations.SuspendLayout();
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
            tabPageOther.BackColor = Color.Transparent;
            tabPageOther.Controls.Add(tableLayoutPanel5);
            tabPageOther.Location = new Point(4, 24);
            tabPageOther.Name = "tabPageOther";
            tabPageOther.Size = new Size(974, 507);
            tabPageOther.TabIndex = 4;
            tabPageOther.Text = "Other";
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.9067364F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 74.09326F));
            tableLayoutPanel5.Controls.Add(tblCreatureEdit, 0, 0);
            tableLayoutPanel5.Controls.Add(lvCreatureList, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Margin = new Padding(0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(974, 507);
            tableLayoutPanel5.TabIndex = 0;
            // 
            // tblCreatureEdit
            // 
            tblCreatureEdit.ColumnCount = 3;
            tblCreatureEdit.ColumnStyles.Add(new ColumnStyle());
            tblCreatureEdit.ColumnStyles.Add(new ColumnStyle());
            tblCreatureEdit.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tblCreatureEdit.Controls.Add(LabelOtherLevel, 0, 0);
            tblCreatureEdit.Controls.Add(numEntityLevel, 1, 0);
            tblCreatureEdit.Controls.Add(btnMaxOtherLevel, 2, 0);
            tblCreatureEdit.Controls.Add(LabelOtherMaxHP, 0, 1);
            tblCreatureEdit.Controls.Add(numEntityBaseHP, 1, 1);
            tblCreatureEdit.Controls.Add(btnMaxOtherBaseHP, 2, 1);
            tblCreatureEdit.Controls.Add(LabelOtherCurrHP, 0, 2);
            tblCreatureEdit.Controls.Add(numEntityCurrentHP, 1, 2);
            tblCreatureEdit.Controls.Add(btnMaxOtherCurrentHP, 2, 2);
            tblCreatureEdit.Controls.Add(LabelOtherMaxAP, 0, 3);
            tblCreatureEdit.Controls.Add(numEntityBaseAP, 1, 3);
            tblCreatureEdit.Controls.Add(btnMaxOtherBaseAP, 2, 3);
            tblCreatureEdit.Controls.Add(LabelOtherCurrAP, 0, 4);
            tblCreatureEdit.Controls.Add(numEntityCurrentAP, 1, 4);
            tblCreatureEdit.Controls.Add(btnMaxOtherCurrentAP, 2, 4);
            tblCreatureEdit.Controls.Add(btnMaxOther, 1, 5);
            tblCreatureEdit.Controls.Add(lblCreatureStatus, 0, 7);
            tblCreatureEdit.Controls.Add(numEntityPosZ, 1, 12);
            tblCreatureEdit.Controls.Add(numEntityPosY, 1, 11);
            tblCreatureEdit.Controls.Add(numEntityPosX, 1, 10);
            tblCreatureEdit.Controls.Add(lblOtherPosZ, 0, 12);
            tblCreatureEdit.Controls.Add(lblOtherPosY, 0, 11);
            tblCreatureEdit.Controls.Add(lblOtherPosX, 0, 10);
            tblCreatureEdit.Controls.Add(label30, 0, 9);
            tblCreatureEdit.Dock = DockStyle.Fill;
            tblCreatureEdit.Location = new Point(0, 0);
            tblCreatureEdit.Margin = new Padding(0);
            tblCreatureEdit.Name = "tblCreatureEdit";
            tblCreatureEdit.RowCount = 14;
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblCreatureEdit.Size = new Size(252, 507);
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
            // numEntityLevel
            // 
            numEntityLevel.Location = new Point(81, 3);
            numEntityLevel.Margin = new Padding(4, 3, 4, 3);
            numEntityLevel.Maximum = new decimal(new int[] { 16752, 0, 0, 0 });
            numEntityLevel.Minimum = new decimal(new int[] { 1, 0, 0, int.MinValue });
            numEntityLevel.Name = "numEntityLevel";
            numEntityLevel.Size = new Size(107, 23);
            numEntityLevel.TabIndex = 1;
            numEntityLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numEntityLevel.ValueChanged += CreaturePropertyChanged;
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
            // numEntityBaseHP
            // 
            numEntityBaseHP.Location = new Point(81, 32);
            numEntityBaseHP.Margin = new Padding(4, 3, 4, 3);
            numEntityBaseHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numEntityBaseHP.Name = "numEntityBaseHP";
            numEntityBaseHP.Size = new Size(107, 23);
            numEntityBaseHP.TabIndex = 18;
            numEntityBaseHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            numEntityBaseHP.ValueChanged += CreaturePropertyChanged;
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
            // numEntityCurrentHP
            // 
            numEntityCurrentHP.Location = new Point(81, 61);
            numEntityCurrentHP.Margin = new Padding(4, 3, 4, 3);
            numEntityCurrentHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numEntityCurrentHP.Name = "numEntityCurrentHP";
            numEntityCurrentHP.Size = new Size(107, 23);
            numEntityCurrentHP.TabIndex = 18;
            numEntityCurrentHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            numEntityCurrentHP.ValueChanged += CreaturePropertyChanged;
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
            // numEntityBaseAP
            // 
            numEntityBaseAP.Location = new Point(81, 90);
            numEntityBaseAP.Margin = new Padding(4, 3, 4, 3);
            numEntityBaseAP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numEntityBaseAP.Name = "numEntityBaseAP";
            numEntityBaseAP.Size = new Size(107, 23);
            numEntityBaseAP.TabIndex = 21;
            numEntityBaseAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numEntityBaseAP.ValueChanged += CreaturePropertyChanged;
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
            // numEntityCurrentAP
            // 
            numEntityCurrentAP.Location = new Point(81, 119);
            numEntityCurrentAP.Margin = new Padding(4, 3, 4, 3);
            numEntityCurrentAP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numEntityCurrentAP.Name = "numEntityCurrentAP";
            numEntityCurrentAP.Size = new Size(107, 23);
            numEntityCurrentAP.TabIndex = 21;
            numEntityCurrentAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            numEntityCurrentAP.ValueChanged += CreaturePropertyChanged;
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
            // lblCreatureStatus
            // 
            tblCreatureEdit.SetColumnSpan(lblCreatureStatus, 3);
            lblCreatureStatus.Dock = DockStyle.Top;
            lblCreatureStatus.Location = new Point(3, 203);
            lblCreatureStatus.Name = "lblCreatureStatus";
            lblCreatureStatus.Size = new Size(246, 29);
            lblCreatureStatus.TabIndex = 23;
            lblCreatureStatus.Text = "      ";
            // 
            // numEntityPosZ
            // 
            numEntityPosZ.DecimalPlaces = 4;
            numEntityPosZ.Dock = DockStyle.Fill;
            numEntityPosZ.Location = new Point(81, 351);
            numEntityPosZ.Margin = new Padding(4, 3, 4, 3);
            numEntityPosZ.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numEntityPosZ.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numEntityPosZ.Name = "numEntityPosZ";
            numEntityPosZ.Size = new Size(107, 23);
            numEntityPosZ.TabIndex = 1;
            numEntityPosZ.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numEntityPosZ.ValueChanged += CreaturePropertyChanged;
            // 
            // numEntityPosY
            // 
            numEntityPosY.DecimalPlaces = 4;
            numEntityPosY.Dock = DockStyle.Fill;
            numEntityPosY.Location = new Point(81, 322);
            numEntityPosY.Margin = new Padding(4, 3, 4, 3);
            numEntityPosY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numEntityPosY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numEntityPosY.Name = "numEntityPosY";
            numEntityPosY.Size = new Size(107, 23);
            numEntityPosY.TabIndex = 1;
            numEntityPosY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numEntityPosY.ValueChanged += CreaturePropertyChanged;
            // 
            // numEntityPosX
            // 
            numEntityPosX.DecimalPlaces = 4;
            numEntityPosX.Dock = DockStyle.Fill;
            numEntityPosX.Location = new Point(81, 293);
            numEntityPosX.Margin = new Padding(4, 3, 4, 3);
            numEntityPosX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numEntityPosX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numEntityPosX.Name = "numEntityPosX";
            numEntityPosX.Size = new Size(107, 23);
            numEntityPosX.TabIndex = 1;
            numEntityPosX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            numEntityPosX.ValueChanged += CreaturePropertyChanged;
            // 
            // lblOtherPosZ
            // 
            lblOtherPosZ.AutoSize = true;
            lblOtherPosZ.Dock = DockStyle.Fill;
            lblOtherPosZ.Location = new Point(4, 348);
            lblOtherPosZ.Margin = new Padding(4, 0, 4, 0);
            lblOtherPosZ.Name = "lblOtherPosZ";
            lblOtherPosZ.Size = new Size(69, 29);
            lblOtherPosZ.TabIndex = 0;
            lblOtherPosZ.Text = "Z";
            lblOtherPosZ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOtherPosY
            // 
            lblOtherPosY.AutoSize = true;
            lblOtherPosY.Dock = DockStyle.Fill;
            lblOtherPosY.Location = new Point(4, 319);
            lblOtherPosY.Margin = new Padding(4, 0, 4, 0);
            lblOtherPosY.Name = "lblOtherPosY";
            lblOtherPosY.Size = new Size(69, 29);
            lblOtherPosY.TabIndex = 0;
            lblOtherPosY.Text = "Y";
            lblOtherPosY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblOtherPosX
            // 
            lblOtherPosX.AutoSize = true;
            lblOtherPosX.Dock = DockStyle.Fill;
            lblOtherPosX.Location = new Point(4, 290);
            lblOtherPosX.Margin = new Padding(4, 0, 4, 0);
            lblOtherPosX.Name = "lblOtherPosX";
            lblOtherPosX.Size = new Size(69, 29);
            lblOtherPosX.TabIndex = 0;
            lblOtherPosX.Text = "X";
            lblOtherPosX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Dock = DockStyle.Fill;
            label30.Location = new Point(3, 261);
            label30.Name = "label30";
            label30.Size = new Size(71, 29);
            label30.TabIndex = 24;
            label30.Text = "Position";
            label30.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lvCreatureList
            // 
            lvCreatureList.Columns.AddRange(new ColumnHeader[] { columnHeader4, columnHeader15, columnHeader5, columnHeader8, columnHeader26 });
            lvCreatureList.Dock = DockStyle.Fill;
            lvCreatureList.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvCreatureList.FullRowSelect = true;
            lvCreatureList.Location = new Point(256, 3);
            lvCreatureList.Margin = new Padding(4, 3, 4, 3);
            lvCreatureList.Name = "lvCreatureList";
            lvCreatureList.Size = new Size(714, 501);
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
            // columnHeader26
            // 
            columnHeader26.Text = "Status";
            columnHeader26.Width = 80;
            // 
            // tabPageCamera
            // 
            tabPageCamera.BackColor = Color.Transparent;
            tabPageCamera.Controls.Add(label19);
            tabPageCamera.Controls.Add(tbleCameraPanel);
            tabPageCamera.Location = new Point(4, 24);
            tabPageCamera.Name = "tabPageCamera";
            tabPageCamera.Size = new Size(974, 507);
            tabPageCamera.TabIndex = 7;
            tabPageCamera.Text = "Camera";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(307, 33);
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
            tabPageInventory.BackColor = Color.Transparent;
            tabPageInventory.Controls.Add(tableLayoutPanel1);
            tabPageInventory.Location = new Point(4, 24);
            tabPageInventory.Name = "tabPageInventory";
            tabPageInventory.Size = new Size(974, 507);
            tabPageInventory.TabIndex = 5;
            tabPageInventory.Text = "Inventory";
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
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(974, 507);
            tableLayoutPanel1.TabIndex = 24;
            // 
            // lblGameItems
            // 
            lblGameItems.AutoSize = true;
            lblGameItems.Dock = DockStyle.Fill;
            lblGameItems.Location = new Point(4, 0);
            lblGameItems.Margin = new Padding(4, 0, 4, 0);
            lblGameItems.Name = "lblGameItems";
            lblGameItems.Size = new Size(327, 29);
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
            pnlInventoryControls.Location = new Point(335, 29);
            pnlInventoryControls.Margin = new Padding(0);
            pnlInventoryControls.Name = "pnlInventoryControls";
            pnlInventoryControls.Size = new Size(252, 478);
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
            lvGameItems.Size = new Size(329, 472);
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
            lvInventory.Location = new Point(591, 32);
            lvInventory.Margin = new Padding(4, 3, 4, 3);
            lvInventory.Name = "lvInventory";
            lvInventory.Size = new Size(379, 472);
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
            lblInventory.Location = new Point(591, 0);
            lblInventory.Margin = new Padding(4, 0, 4, 0);
            lblInventory.Name = "lblInventory";
            lblInventory.Size = new Size(379, 29);
            lblInventory.TabIndex = 9;
            lblInventory.Text = "Inventory";
            lblInventory.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPageJekhar
            // 
            tabPageJekhar.BackColor = Color.Transparent;
            tabPageJekhar.Controls.Add(tblJekhar);
            tabPageJekhar.Location = new Point(4, 24);
            tabPageJekhar.Name = "tabPageJekhar";
            tabPageJekhar.Size = new Size(974, 507);
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
            tblJekhar.Controls.Add(numJeSkillPoints, 1, 2);
            tblJekhar.Controls.Add(btnJeMaxSkill, 2, 2);
            tblJekhar.Controls.Add(lvJekharSkills, 5, 0);
            tblJekhar.Controls.Add(tableLayoutPanel7, 5, 8);
            tblJekhar.Controls.Add(numJePosX, 1, 11);
            tblJekhar.Controls.Add(numJePosY, 1, 12);
            tblJekhar.Controls.Add(numJePosZ, 1, 13);
            tblJekhar.Controls.Add(lblJePosition, 0, 10);
            tblJekhar.Controls.Add(lblJePosX, 0, 11);
            tblJekhar.Controls.Add(lblJePosY, 0, 12);
            tblJekhar.Controls.Add(lblJePosZ, 0, 13);
            tblJekhar.Dock = DockStyle.Fill;
            tblJekhar.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblJekhar.Location = new Point(0, 0);
            tblJekhar.Margin = new Padding(4, 3, 4, 3);
            tblJekhar.Name = "tblJekhar";
            tblJekhar.RowCount = 15;
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
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJekhar.Size = new Size(974, 507);
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
            lblJeBaseAP.Text = "Base AP:";
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
            lblJeBaseHP.Text = "Base HP:";
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
            // numJeSkillPoints
            // 
            numJeSkillPoints.Dock = DockStyle.Fill;
            numJeSkillPoints.Location = new Point(81, 61);
            numJeSkillPoints.Margin = new Padding(4, 3, 4, 3);
            numJeSkillPoints.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
            numJeSkillPoints.Name = "numJeSkillPoints";
            numJeSkillPoints.Size = new Size(107, 23);
            numJeSkillPoints.TabIndex = 2;
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
            lvJekharSkills.Size = new Size(384, 226);
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
            tableLayoutPanel7.Size = new Size(392, 29);
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
            numJeSkillValue.Size = new Size(188, 23);
            numJeSkillValue.TabIndex = 3;
            // 
            // btnJeUpdateSkill
            // 
            btnJeUpdateSkill.Dock = DockStyle.Fill;
            btnJeUpdateSkill.Location = new Point(200, 3);
            btnJeUpdateSkill.Margin = new Padding(4, 3, 4, 3);
            btnJeUpdateSkill.Name = "btnJeUpdateSkill";
            btnJeUpdateSkill.Size = new Size(188, 23);
            btnJeUpdateSkill.TabIndex = 4;
            btnJeUpdateSkill.Text = "Update Skill";
            btnJeUpdateSkill.UseVisualStyleBackColor = true;
            btnJeUpdateSkill.Click += btnJeUpdateSkill_Click;
            // 
            // numJePosX
            // 
            numJePosX.DecimalPlaces = 4;
            numJePosX.Dock = DockStyle.Fill;
            numJePosX.Location = new Point(81, 322);
            numJePosX.Margin = new Padding(4, 3, 4, 3);
            numJePosX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numJePosX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numJePosX.Name = "numJePosX";
            numJePosX.Size = new Size(107, 23);
            numJePosX.TabIndex = 41;
            numJePosX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numJePosY
            // 
            numJePosY.DecimalPlaces = 4;
            numJePosY.Dock = DockStyle.Fill;
            numJePosY.Location = new Point(81, 351);
            numJePosY.Margin = new Padding(4, 3, 4, 3);
            numJePosY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numJePosY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numJePosY.Name = "numJePosY";
            numJePosY.Size = new Size(107, 23);
            numJePosY.TabIndex = 41;
            numJePosY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numJePosZ
            // 
            numJePosZ.DecimalPlaces = 4;
            numJePosZ.Dock = DockStyle.Fill;
            numJePosZ.Location = new Point(81, 380);
            numJePosZ.Margin = new Padding(4, 3, 4, 3);
            numJePosZ.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numJePosZ.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numJePosZ.Name = "numJePosZ";
            numJePosZ.Size = new Size(107, 23);
            numJePosZ.TabIndex = 41;
            numJePosZ.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblJePosition
            // 
            lblJePosition.AutoSize = true;
            lblJePosition.Dock = DockStyle.Fill;
            lblJePosition.Location = new Point(3, 290);
            lblJePosition.Name = "lblJePosition";
            lblJePosition.Size = new Size(71, 29);
            lblJePosition.TabIndex = 42;
            lblJePosition.Text = "Position";
            lblJePosition.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJePosX
            // 
            lblJePosX.AutoSize = true;
            lblJePosX.Dock = DockStyle.Fill;
            lblJePosX.Location = new Point(3, 319);
            lblJePosX.Name = "lblJePosX";
            lblJePosX.Size = new Size(71, 29);
            lblJePosX.TabIndex = 43;
            lblJePosX.Text = "X";
            lblJePosX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJePosY
            // 
            lblJePosY.AutoSize = true;
            lblJePosY.Dock = DockStyle.Fill;
            lblJePosY.Location = new Point(3, 348);
            lblJePosY.Name = "lblJePosY";
            lblJePosY.Size = new Size(71, 29);
            lblJePosY.TabIndex = 43;
            lblJePosY.Text = "Y";
            lblJePosY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJePosZ
            // 
            lblJePosZ.AutoSize = true;
            lblJePosZ.Dock = DockStyle.Fill;
            lblJePosZ.Location = new Point(3, 377);
            lblJePosZ.Name = "lblJePosZ";
            lblJePosZ.Size = new Size(71, 29);
            lblJePosZ.TabIndex = 43;
            lblJePosZ.Text = "Z";
            lblJePosZ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPageRosalind
            // 
            tabPageRosalind.BackColor = Color.Transparent;
            tabPageRosalind.Controls.Add(tblRosalind);
            tabPageRosalind.Location = new Point(4, 24);
            tabPageRosalind.Name = "tabPageRosalind";
            tabPageRosalind.Size = new Size(974, 507);
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
            tblRosalind.Controls.Add(numRoSkillPoints, 1, 2);
            tblRosalind.Controls.Add(btnRoMaxExp, 2, 1);
            tblRosalind.Controls.Add(lblRoSkillPoints, 0, 2);
            tblRosalind.Controls.Add(numRoLevel, 1, 0);
            tblRosalind.Controls.Add(numRoExperience, 1, 1);
            tblRosalind.Controls.Add(btnRoMaxLevel, 2, 0);
            tblRosalind.Controls.Add(lblRoLevel, 0, 0);
            tblRosalind.Controls.Add(lblRoExperience, 0, 1);
            tblRosalind.Controls.Add(numRoPosX, 1, 11);
            tblRosalind.Controls.Add(numRoPosY, 1, 12);
            tblRosalind.Controls.Add(numRoPosZ, 1, 13);
            tblRosalind.Controls.Add(lblRoPosition, 0, 10);
            tblRosalind.Controls.Add(lblRoPosX, 0, 11);
            tblRosalind.Controls.Add(lblRoPosY, 0, 12);
            tblRosalind.Controls.Add(lblRoPosZ, 0, 13);
            tblRosalind.Dock = DockStyle.Fill;
            tblRosalind.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblRosalind.Location = new Point(0, 0);
            tblRosalind.Margin = new Padding(4, 3, 4, 3);
            tblRosalind.Name = "tblRosalind";
            tblRosalind.RowCount = 15;
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
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblRosalind.Size = new Size(974, 507);
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
            tableLayoutPanel10.Size = new Size(392, 29);
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
            numRoSkillValue.Size = new Size(188, 23);
            numRoSkillValue.TabIndex = 3;
            // 
            // btnRoUpdateSkill
            // 
            btnRoUpdateSkill.Dock = DockStyle.Fill;
            btnRoUpdateSkill.Location = new Point(200, 3);
            btnRoUpdateSkill.Margin = new Padding(4, 3, 4, 3);
            btnRoUpdateSkill.Name = "btnRoUpdateSkill";
            btnRoUpdateSkill.Size = new Size(188, 23);
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
            lvRosalindSkills.Size = new Size(384, 226);
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
            lblRoBaseAP.Text = "Base AP:";
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
            lblRoBaseHP.Text = "Base HP:";
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
            // numRoSkillPoints
            // 
            numRoSkillPoints.Dock = DockStyle.Fill;
            numRoSkillPoints.Location = new Point(81, 61);
            numRoSkillPoints.Margin = new Padding(4, 3, 4, 3);
            numRoSkillPoints.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
            numRoSkillPoints.Name = "numRoSkillPoints";
            numRoSkillPoints.Size = new Size(107, 23);
            numRoSkillPoints.TabIndex = 2;
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
            // numRoPosX
            // 
            numRoPosX.DecimalPlaces = 4;
            numRoPosX.Dock = DockStyle.Fill;
            numRoPosX.Location = new Point(81, 322);
            numRoPosX.Margin = new Padding(4, 3, 4, 3);
            numRoPosX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numRoPosX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numRoPosX.Name = "numRoPosX";
            numRoPosX.Size = new Size(107, 23);
            numRoPosX.TabIndex = 38;
            numRoPosX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numRoPosY
            // 
            numRoPosY.DecimalPlaces = 4;
            numRoPosY.Dock = DockStyle.Fill;
            numRoPosY.Location = new Point(81, 351);
            numRoPosY.Margin = new Padding(4, 3, 4, 3);
            numRoPosY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numRoPosY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numRoPosY.Name = "numRoPosY";
            numRoPosY.Size = new Size(107, 23);
            numRoPosY.TabIndex = 38;
            numRoPosY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numRoPosZ
            // 
            numRoPosZ.DecimalPlaces = 4;
            numRoPosZ.Dock = DockStyle.Fill;
            numRoPosZ.Location = new Point(81, 380);
            numRoPosZ.Margin = new Padding(4, 3, 4, 3);
            numRoPosZ.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numRoPosZ.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numRoPosZ.Name = "numRoPosZ";
            numRoPosZ.Size = new Size(107, 23);
            numRoPosZ.TabIndex = 38;
            numRoPosZ.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblRoPosition
            // 
            lblRoPosition.AutoSize = true;
            lblRoPosition.Dock = DockStyle.Fill;
            lblRoPosition.Location = new Point(3, 290);
            lblRoPosition.Name = "lblRoPosition";
            lblRoPosition.Size = new Size(71, 29);
            lblRoPosition.TabIndex = 40;
            lblRoPosition.Text = "Position";
            lblRoPosition.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblRoPosX
            // 
            lblRoPosX.AutoSize = true;
            lblRoPosX.Dock = DockStyle.Fill;
            lblRoPosX.Location = new Point(3, 319);
            lblRoPosX.Name = "lblRoPosX";
            lblRoPosX.Size = new Size(71, 29);
            lblRoPosX.TabIndex = 41;
            lblRoPosX.Text = "X";
            lblRoPosX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoPosY
            // 
            lblRoPosY.AutoSize = true;
            lblRoPosY.Dock = DockStyle.Fill;
            lblRoPosY.Location = new Point(3, 348);
            lblRoPosY.Name = "lblRoPosY";
            lblRoPosY.Size = new Size(71, 29);
            lblRoPosY.TabIndex = 41;
            lblRoPosY.Text = "Y";
            lblRoPosY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblRoPosZ
            // 
            lblRoPosZ.AutoSize = true;
            lblRoPosZ.Dock = DockStyle.Fill;
            lblRoPosZ.Location = new Point(3, 377);
            lblRoPosZ.Name = "lblRoPosZ";
            lblRoPosZ.Size = new Size(71, 29);
            lblRoPosZ.TabIndex = 41;
            lblRoPosZ.Text = "Z";
            lblRoPosZ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPageFlece
            // 
            tabPageFlece.BackColor = Color.Transparent;
            tabPageFlece.BackgroundImageLayout = ImageLayout.Stretch;
            tabPageFlece.Controls.Add(tblFlece);
            tabPageFlece.Location = new Point(4, 24);
            tabPageFlece.Name = "tabPageFlece";
            tabPageFlece.Size = new Size(974, 507);
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
            tblFlece.Controls.Add(numFlSkillPoints, 1, 2);
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
            tblFlece.Controls.Add(numFlPosX, 1, 11);
            tblFlece.Controls.Add(numFlPosY, 1, 12);
            tblFlece.Controls.Add(numFlPosZ, 1, 13);
            tblFlece.Controls.Add(label32, 0, 10);
            tblFlece.Controls.Add(lblFlPosX, 0, 11);
            tblFlece.Controls.Add(lblFlPosY, 0, 12);
            tblFlece.Controls.Add(lblFlPosZ, 0, 13);
            tblFlece.Dock = DockStyle.Fill;
            tblFlece.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblFlece.Location = new Point(0, 0);
            tblFlece.Margin = new Padding(4, 3, 4, 3);
            tblFlece.Name = "tblFlece";
            tblFlece.RowCount = 15;
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
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblFlece.Size = new Size(974, 507);
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
            lvFleceSkills.Size = new Size(384, 226);
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
            tableLayoutPanel8.Size = new Size(392, 29);
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
            numFlSkillValue.Size = new Size(188, 23);
            numFlSkillValue.TabIndex = 3;
            // 
            // btnFlUpdateSkill
            // 
            btnFlUpdateSkill.Dock = DockStyle.Fill;
            btnFlUpdateSkill.Location = new Point(200, 3);
            btnFlUpdateSkill.Margin = new Padding(4, 3, 4, 3);
            btnFlUpdateSkill.Name = "btnFlUpdateSkill";
            btnFlUpdateSkill.Size = new Size(188, 23);
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
            lblFlBaseAP.Text = "Base AP:";
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
            lblFlBaseHP.Text = "Base HP:";
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
            // numFlSkillPoints
            // 
            numFlSkillPoints.Dock = DockStyle.Fill;
            numFlSkillPoints.Location = new Point(81, 61);
            numFlSkillPoints.Margin = new Padding(4, 3, 4, 3);
            numFlSkillPoints.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
            numFlSkillPoints.Name = "numFlSkillPoints";
            numFlSkillPoints.Size = new Size(107, 23);
            numFlSkillPoints.TabIndex = 2;
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
            // numFlPosX
            // 
            numFlPosX.DecimalPlaces = 4;
            numFlPosX.Dock = DockStyle.Fill;
            numFlPosX.Location = new Point(81, 322);
            numFlPosX.Margin = new Padding(4, 3, 4, 3);
            numFlPosX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numFlPosX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numFlPosX.Name = "numFlPosX";
            numFlPosX.Size = new Size(107, 23);
            numFlPosX.TabIndex = 38;
            numFlPosX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numFlPosY
            // 
            numFlPosY.DecimalPlaces = 4;
            numFlPosY.Dock = DockStyle.Fill;
            numFlPosY.Location = new Point(81, 351);
            numFlPosY.Margin = new Padding(4, 3, 4, 3);
            numFlPosY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numFlPosY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numFlPosY.Name = "numFlPosY";
            numFlPosY.Size = new Size(107, 23);
            numFlPosY.TabIndex = 38;
            numFlPosY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numFlPosZ
            // 
            numFlPosZ.DecimalPlaces = 4;
            numFlPosZ.Dock = DockStyle.Fill;
            numFlPosZ.Location = new Point(81, 380);
            numFlPosZ.Margin = new Padding(4, 3, 4, 3);
            numFlPosZ.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numFlPosZ.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numFlPosZ.Name = "numFlPosZ";
            numFlPosZ.Size = new Size(107, 23);
            numFlPosZ.TabIndex = 38;
            numFlPosZ.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Dock = DockStyle.Fill;
            label32.Location = new Point(3, 290);
            label32.Name = "label32";
            label32.Size = new Size(71, 29);
            label32.TabIndex = 39;
            label32.Text = "Position";
            label32.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblFlPosX
            // 
            lblFlPosX.AutoSize = true;
            lblFlPosX.Dock = DockStyle.Fill;
            lblFlPosX.Location = new Point(3, 319);
            lblFlPosX.Name = "lblFlPosX";
            lblFlPosX.Size = new Size(71, 29);
            lblFlPosX.TabIndex = 40;
            lblFlPosX.Text = "X";
            lblFlPosX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFlPosY
            // 
            lblFlPosY.AutoSize = true;
            lblFlPosY.Dock = DockStyle.Fill;
            lblFlPosY.Location = new Point(3, 348);
            lblFlPosY.Name = "lblFlPosY";
            lblFlPosY.Size = new Size(71, 29);
            lblFlPosY.TabIndex = 40;
            lblFlPosY.Text = "Y";
            lblFlPosY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFlPosZ
            // 
            lblFlPosZ.AutoSize = true;
            lblFlPosZ.Dock = DockStyle.Fill;
            lblFlPosZ.Location = new Point(3, 377);
            lblFlPosZ.Name = "lblFlPosZ";
            lblFlPosZ.Size = new Size(71, 29);
            lblFlPosZ.TabIndex = 40;
            lblFlPosZ.Text = "Z";
            lblFlPosZ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tabPageJoseph
            // 
            tabPageJoseph.BackColor = Color.Transparent;
            tabPageJoseph.Controls.Add(tblJoseph);
            tabPageJoseph.Location = new Point(4, 24);
            tabPageJoseph.Name = "tabPageJoseph";
            tabPageJoseph.Size = new Size(974, 507);
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
            tblJoseph.Controls.Add(numJoSkillPoints, 1, 2);
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
            tblJoseph.Controls.Add(label31, 0, 10);
            tblJoseph.Controls.Add(lblJoPosX, 0, 11);
            tblJoseph.Controls.Add(lblJoPosY, 0, 12);
            tblJoseph.Controls.Add(lblJoPosZ, 0, 13);
            tblJoseph.Controls.Add(numJoPosX, 1, 11);
            tblJoseph.Controls.Add(numJoPosY, 1, 12);
            tblJoseph.Controls.Add(numJoPosZ, 1, 13);
            tblJoseph.Dock = DockStyle.Fill;
            tblJoseph.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblJoseph.Location = new Point(0, 0);
            tblJoseph.Name = "tblJoseph";
            tblJoseph.RowCount = 15;
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
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblJoseph.Size = new Size(974, 507);
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
            lvJosephSkills.Size = new Size(384, 226);
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
            tableLayoutPanel9.Size = new Size(392, 29);
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
            numJoSkillValue.Size = new Size(188, 23);
            numJoSkillValue.TabIndex = 3;
            // 
            // btnJoUpdateSkill
            // 
            btnJoUpdateSkill.Dock = DockStyle.Fill;
            btnJoUpdateSkill.Location = new Point(200, 3);
            btnJoUpdateSkill.Margin = new Padding(4, 3, 4, 3);
            btnJoUpdateSkill.Name = "btnJoUpdateSkill";
            btnJoUpdateSkill.Size = new Size(188, 23);
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
            // numJoSkillPoints
            // 
            numJoSkillPoints.Dock = DockStyle.Fill;
            numJoSkillPoints.Location = new Point(81, 61);
            numJoSkillPoints.Margin = new Padding(4, 3, 4, 3);
            numJoSkillPoints.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
            numJoSkillPoints.Name = "numJoSkillPoints";
            numJoSkillPoints.Size = new Size(107, 23);
            numJoSkillPoints.TabIndex = 2;
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
            lblJoMaxHP.Text = "Base HP:";
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
            lblJoBaseAP.Text = "Base AP:";
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
            // label31
            // 
            label31.AutoSize = true;
            label31.Dock = DockStyle.Fill;
            label31.Location = new Point(3, 290);
            label31.Name = "label31";
            label31.Size = new Size(71, 29);
            label31.TabIndex = 28;
            label31.Text = "Position";
            label31.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblJoPosX
            // 
            lblJoPosX.AutoSize = true;
            lblJoPosX.Dock = DockStyle.Fill;
            lblJoPosX.Location = new Point(3, 319);
            lblJoPosX.Name = "lblJoPosX";
            lblJoPosX.Size = new Size(71, 29);
            lblJoPosX.TabIndex = 29;
            lblJoPosX.Text = "X";
            lblJoPosX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJoPosY
            // 
            lblJoPosY.AutoSize = true;
            lblJoPosY.Dock = DockStyle.Fill;
            lblJoPosY.Location = new Point(3, 348);
            lblJoPosY.Name = "lblJoPosY";
            lblJoPosY.Size = new Size(71, 29);
            lblJoPosY.TabIndex = 30;
            lblJoPosY.Text = "Y";
            lblJoPosY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblJoPosZ
            // 
            lblJoPosZ.AutoSize = true;
            lblJoPosZ.Dock = DockStyle.Fill;
            lblJoPosZ.Location = new Point(3, 377);
            lblJoPosZ.Name = "lblJoPosZ";
            lblJoPosZ.Size = new Size(71, 29);
            lblJoPosZ.TabIndex = 31;
            lblJoPosZ.Text = "Z";
            lblJoPosZ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numJoPosX
            // 
            numJoPosX.DecimalPlaces = 4;
            numJoPosX.Dock = DockStyle.Fill;
            numJoPosX.Location = new Point(81, 322);
            numJoPosX.Margin = new Padding(4, 3, 4, 3);
            numJoPosX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numJoPosX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numJoPosX.Name = "numJoPosX";
            numJoPosX.Size = new Size(107, 23);
            numJoPosX.TabIndex = 32;
            numJoPosX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numJoPosY
            // 
            numJoPosY.DecimalPlaces = 4;
            numJoPosY.Dock = DockStyle.Fill;
            numJoPosY.Location = new Point(81, 351);
            numJoPosY.Margin = new Padding(4, 3, 4, 3);
            numJoPosY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numJoPosY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numJoPosY.Name = "numJoPosY";
            numJoPosY.Size = new Size(107, 23);
            numJoPosY.TabIndex = 32;
            numJoPosY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numJoPosZ
            // 
            numJoPosZ.DecimalPlaces = 4;
            numJoPosZ.Dock = DockStyle.Fill;
            numJoPosZ.Location = new Point(81, 380);
            numJoPosZ.Margin = new Padding(4, 3, 4, 3);
            numJoPosZ.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numJoPosZ.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numJoPosZ.Name = "numJoPosZ";
            numJoPosZ.Size = new Size(107, 23);
            numJoPosZ.TabIndex = 32;
            numJoPosZ.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tabPageStart
            // 
            tabPageStart.BackColor = Color.Transparent;
            tabPageStart.Controls.Add(tableLayoutPanel11);
            tabPageStart.Location = new Point(4, 24);
            tabPageStart.Name = "tabPageStart";
            tabPageStart.Size = new Size(974, 507);
            tabPageStart.TabIndex = 6;
            tabPageStart.Text = "Start";
            // 
            // tableLayoutPanel11
            // 
            tableLayoutPanel11.ColumnCount = 4;
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F));
            tableLayoutPanel11.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel11.Controls.Add(btnSaveFile, 2, 4);
            tableLayoutPanel11.Controls.Add(btnOpenFile, 1, 4);
            tableLayoutPanel11.Controls.Add(numTime, 1, 2);
            tableLayoutPanel11.Controls.Add(lblTime, 2, 2);
            tableLayoutPanel11.Controls.Add(imgPreview, 2, 1);
            tableLayoutPanel11.Controls.Add(txtDescription, 1, 1);
            tableLayoutPanel11.Dock = DockStyle.Fill;
            tableLayoutPanel11.Location = new Point(0, 0);
            tableLayoutPanel11.Name = "tableLayoutPanel11";
            tableLayoutPanel11.RowCount = 6;
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 188F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));
            tableLayoutPanel11.RowStyles.Add(new RowStyle(SizeType.Percent, 66.6666641F));
            tableLayoutPanel11.Size = new Size(974, 507);
            tableLayoutPanel11.TabIndex = 0;
            // 
            // btnSaveFile
            // 
            btnSaveFile.Dock = DockStyle.Fill;
            btnSaveFile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveFile.Location = new Point(491, 311);
            btnSaveFile.Margin = new Padding(4, 3, 4, 3);
            btnSaveFile.Name = "btnSaveFile";
            btnSaveFile.Size = new Size(242, 49);
            btnSaveFile.TabIndex = 24;
            btnSaveFile.Text = "Save";
            btnSaveFile.UseVisualStyleBackColor = true;
            btnSaveFile.Click += saveChangesToolStripMenuItem_Click;
            // 
            // btnOpenFile
            // 
            btnOpenFile.Dock = DockStyle.Fill;
            btnOpenFile.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOpenFile.Location = new Point(241, 311);
            btnOpenFile.Margin = new Padding(4, 3, 4, 3);
            btnOpenFile.Name = "btnOpenFile";
            btnOpenFile.Size = new Size(242, 49);
            btnOpenFile.TabIndex = 23;
            btnOpenFile.Text = "Open";
            btnOpenFile.UseVisualStyleBackColor = true;
            btnOpenFile.Click += openFileToolStripMenuItem_Click;
            // 
            // numTime
            // 
            numTime.DecimalPlaces = 4;
            numTime.Dock = DockStyle.Fill;
            numTime.Location = new Point(240, 262);
            numTime.Maximum = new decimal(new int[] { -1, -1, -1, 0 });
            numTime.Name = "numTime";
            numTime.Size = new Size(244, 23);
            numTime.TabIndex = 0;
            // 
            // lblTime
            // 
            lblTime.AutoSize = true;
            lblTime.Dock = DockStyle.Fill;
            lblTime.Location = new Point(490, 259);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(244, 29);
            lblTime.TabIndex = 1;
            lblTime.Text = "Time: 00:00";
            lblTime.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // imgPreview
            // 
            imgPreview.BorderStyle = BorderStyle.FixedSingle;
            imgPreview.Dock = DockStyle.Fill;
            imgPreview.Location = new Point(487, 71);
            imgPreview.Margin = new Padding(0);
            imgPreview.Name = "imgPreview";
            imgPreview.Size = new Size(250, 188);
            imgPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            imgPreview.TabIndex = 22;
            imgPreview.TabStop = false;
            // 
            // txtDescription
            // 
            txtDescription.BorderStyle = BorderStyle.FixedSingle;
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Location = new Point(237, 71);
            txtDescription.Margin = new Padding(0);
            txtDescription.MaxLength = 255;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(250, 188);
            txtDescription.TabIndex = 25;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabPageStart);
            tabMain.Controls.Add(tabPageJoseph);
            tabMain.Controls.Add(tabPageFlece);
            tabMain.Controls.Add(tabPageRosalind);
            tabMain.Controls.Add(tabPageJekhar);
            tabMain.Controls.Add(tabPageSummon);
            tabMain.Controls.Add(tabPageOther);
            tabMain.Controls.Add(tabPageInventory);
            tabMain.Controls.Add(tabPageCamera);
            tabMain.Controls.Add(tabPageContainer);
            tabMain.Controls.Add(tabPageQuests);
            tabMain.Controls.Add(tabPageLevelItems);
            tabMain.Controls.Add(tabPageConversations);
            tabMain.Dock = DockStyle.Fill;
            tabMain.Location = new Point(0, 24);
            tabMain.Margin = new Padding(4, 3, 4, 3);
            tabMain.Name = "tabMain";
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(982, 535);
            tabMain.TabIndex = 19;
            // 
            // tabPageSummon
            // 
            tabPageSummon.BackColor = Color.Transparent;
            tabPageSummon.Controls.Add(tblSummon);
            tabPageSummon.Location = new Point(4, 24);
            tabPageSummon.Name = "tabPageSummon";
            tabPageSummon.Size = new Size(974, 507);
            tabPageSummon.TabIndex = 9;
            tabPageSummon.Text = "Summon";
            // 
            // tblSummon
            // 
            tblSummon.ColumnCount = 6;
            tblSummon.ColumnStyles.Add(new ColumnStyle());
            tblSummon.ColumnStyles.Add(new ColumnStyle());
            tblSummon.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 60F));
            tblSummon.ColumnStyles.Add(new ColumnStyle());
            tblSummon.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            tblSummon.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 282F));
            tblSummon.Controls.Add(lblSuAmulet, 3, 0);
            tblSummon.Controls.Add(lblSuRing1, 3, 1);
            tblSummon.Controls.Add(lblSuRing2, 3, 2);
            tblSummon.Controls.Add(lblSuGauntlets, 3, 3);
            tblSummon.Controls.Add(lblSuWeapon, 3, 4);
            tblSummon.Controls.Add(lblSuShield, 3, 5);
            tblSummon.Controls.Add(lblSuBoots, 3, 6);
            tblSummon.Controls.Add(lblSuTorso, 3, 7);
            tblSummon.Controls.Add(lblSuCurrentHP, 0, 4);
            tblSummon.Controls.Add(cbSuLeggings, 4, 8);
            tblSummon.Controls.Add(cbSuTorso, 4, 7);
            tblSummon.Controls.Add(cbSuBoots, 4, 6);
            tblSummon.Controls.Add(cbSuShield, 4, 5);
            tblSummon.Controls.Add(cbSuWeapon, 4, 4);
            tblSummon.Controls.Add(cbSuGauntlets, 4, 3);
            tblSummon.Controls.Add(cbSuRing2, 4, 2);
            tblSummon.Controls.Add(cbSuRing1, 4, 1);
            tblSummon.Controls.Add(cbSuAmulet, 4, 0);
            tblSummon.Controls.Add(numSuCurrentHP, 1, 4);
            tblSummon.Controls.Add(btnSuMaxCurrentHP, 2, 4);
            tblSummon.Controls.Add(lblSuCurrentAP, 0, 6);
            tblSummon.Controls.Add(numSuCurrentAP, 1, 6);
            tblSummon.Controls.Add(btnSuMaxCurrentAP, 2, 6);
            tblSummon.Controls.Add(lblSuSpeed, 0, 7);
            tblSummon.Controls.Add(numSuSpeed, 1, 7);
            tblSummon.Controls.Add(btnSuMaxSpeed, 2, 7);
            tblSummon.Controls.Add(lblSuLeggings, 3, 8);
            tblSummon.Controls.Add(btnSuMaxAll, 1, 8);
            tblSummon.Controls.Add(btnSuMaxBaseAP, 2, 5);
            tblSummon.Controls.Add(numSuBaseAP, 1, 5);
            tblSummon.Controls.Add(btnSuMaxBaseHP, 2, 3);
            tblSummon.Controls.Add(lblSuBaseAP, 0, 5);
            tblSummon.Controls.Add(numSuBaseHP, 1, 3);
            tblSummon.Controls.Add(numSuLevel, 1, 0);
            tblSummon.Controls.Add(lblSuBaseHP, 0, 3);
            tblSummon.Controls.Add(numSuExperience, 1, 1);
            tblSummon.Controls.Add(lblSuSkillPoints, 0, 2);
            tblSummon.Controls.Add(btnSuMaxLevel, 2, 0);
            tblSummon.Controls.Add(lblSuLevel, 0, 0);
            tblSummon.Controls.Add(lblSuExperience, 0, 1);
            tblSummon.Controls.Add(btnSuMaxExp, 2, 1);
            tblSummon.Controls.Add(numSuSkillPoints, 1, 2);
            tblSummon.Controls.Add(btnSuMaxSkill, 2, 2);
            tblSummon.Controls.Add(lvSummonSkills, 5, 0);
            tblSummon.Controls.Add(tableLayoutPanel19, 5, 8);
            tblSummon.Controls.Add(label29, 5, 14);
            tblSummon.Controls.Add(lblSuPosition, 0, 10);
            tblSummon.Controls.Add(lblSuPosX, 0, 11);
            tblSummon.Controls.Add(lblSuPosY, 0, 12);
            tblSummon.Controls.Add(lblSuPosZ, 0, 13);
            tblSummon.Controls.Add(numSuPosX, 1, 11);
            tblSummon.Controls.Add(numSuPosY, 1, 12);
            tblSummon.Controls.Add(numSuPosZ, 1, 13);
            tblSummon.Dock = DockStyle.Fill;
            tblSummon.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            tblSummon.Location = new Point(0, 0);
            tblSummon.Margin = new Padding(4, 3, 4, 3);
            tblSummon.Name = "tblSummon";
            tblSummon.RowCount = 15;
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.RowStyles.Add(new RowStyle(SizeType.Absolute, 29F));
            tblSummon.Size = new Size(974, 507);
            tblSummon.TabIndex = 28;
            // 
            // lblSuAmulet
            // 
            lblSuAmulet.AutoSize = true;
            lblSuAmulet.Dock = DockStyle.Fill;
            lblSuAmulet.Location = new Point(256, 0);
            lblSuAmulet.Margin = new Padding(4, 0, 4, 0);
            lblSuAmulet.Name = "lblSuAmulet";
            lblSuAmulet.Size = new Size(62, 29);
            lblSuAmulet.TabIndex = 32;
            lblSuAmulet.Text = "Amulet";
            lblSuAmulet.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSuRing1
            // 
            lblSuRing1.AutoSize = true;
            lblSuRing1.Dock = DockStyle.Fill;
            lblSuRing1.Location = new Point(256, 29);
            lblSuRing1.Margin = new Padding(4, 0, 4, 0);
            lblSuRing1.Name = "lblSuRing1";
            lblSuRing1.Size = new Size(62, 29);
            lblSuRing1.TabIndex = 33;
            lblSuRing1.Text = "Left Right";
            lblSuRing1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSuRing2
            // 
            lblSuRing2.AutoSize = true;
            lblSuRing2.Dock = DockStyle.Fill;
            lblSuRing2.Location = new Point(256, 58);
            lblSuRing2.Margin = new Padding(4, 0, 4, 0);
            lblSuRing2.Name = "lblSuRing2";
            lblSuRing2.Size = new Size(62, 29);
            lblSuRing2.TabIndex = 34;
            lblSuRing2.Text = "Right Ring";
            lblSuRing2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSuGauntlets
            // 
            lblSuGauntlets.AutoSize = true;
            lblSuGauntlets.Dock = DockStyle.Fill;
            lblSuGauntlets.Location = new Point(256, 87);
            lblSuGauntlets.Margin = new Padding(4, 0, 4, 0);
            lblSuGauntlets.Name = "lblSuGauntlets";
            lblSuGauntlets.Size = new Size(62, 29);
            lblSuGauntlets.TabIndex = 35;
            lblSuGauntlets.Text = "Gauntlets";
            lblSuGauntlets.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSuWeapon
            // 
            lblSuWeapon.AutoSize = true;
            lblSuWeapon.Dock = DockStyle.Fill;
            lblSuWeapon.Location = new Point(256, 116);
            lblSuWeapon.Margin = new Padding(4, 0, 4, 0);
            lblSuWeapon.Name = "lblSuWeapon";
            lblSuWeapon.Size = new Size(62, 29);
            lblSuWeapon.TabIndex = 36;
            lblSuWeapon.Text = "Weapon";
            lblSuWeapon.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSuShield
            // 
            lblSuShield.AutoSize = true;
            lblSuShield.Dock = DockStyle.Fill;
            lblSuShield.Location = new Point(256, 145);
            lblSuShield.Margin = new Padding(4, 0, 4, 0);
            lblSuShield.Name = "lblSuShield";
            lblSuShield.Size = new Size(62, 29);
            lblSuShield.TabIndex = 37;
            lblSuShield.Text = "Shield";
            lblSuShield.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSuBoots
            // 
            lblSuBoots.AutoSize = true;
            lblSuBoots.Dock = DockStyle.Fill;
            lblSuBoots.Location = new Point(256, 174);
            lblSuBoots.Margin = new Padding(4, 0, 4, 0);
            lblSuBoots.Name = "lblSuBoots";
            lblSuBoots.Size = new Size(62, 29);
            lblSuBoots.TabIndex = 38;
            lblSuBoots.Text = "Boots";
            lblSuBoots.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSuTorso
            // 
            lblSuTorso.AutoSize = true;
            lblSuTorso.Dock = DockStyle.Fill;
            lblSuTorso.Location = new Point(256, 203);
            lblSuTorso.Margin = new Padding(4, 0, 4, 0);
            lblSuTorso.Name = "lblSuTorso";
            lblSuTorso.Size = new Size(62, 29);
            lblSuTorso.TabIndex = 39;
            lblSuTorso.Text = "Torso";
            lblSuTorso.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSuCurrentHP
            // 
            lblSuCurrentHP.AutoSize = true;
            lblSuCurrentHP.Dock = DockStyle.Fill;
            lblSuCurrentHP.Location = new Point(4, 116);
            lblSuCurrentHP.Margin = new Padding(4, 0, 4, 0);
            lblSuCurrentHP.Name = "lblSuCurrentHP";
            lblSuCurrentHP.Size = new Size(69, 29);
            lblSuCurrentHP.TabIndex = 26;
            lblSuCurrentHP.Text = "Current HP:";
            lblSuCurrentHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbSuLeggings
            // 
            cbSuLeggings.Dock = DockStyle.Fill;
            cbSuLeggings.DropDownHeight = 300;
            cbSuLeggings.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuLeggings.FormattingEnabled = true;
            cbSuLeggings.IntegralHeight = false;
            cbSuLeggings.Location = new Point(326, 235);
            cbSuLeggings.Margin = new Padding(4, 3, 4, 3);
            cbSuLeggings.Name = "cbSuLeggings";
            cbSuLeggings.Size = new Size(252, 23);
            cbSuLeggings.TabIndex = 23;
            // 
            // cbSuTorso
            // 
            cbSuTorso.Dock = DockStyle.Fill;
            cbSuTorso.DropDownHeight = 300;
            cbSuTorso.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuTorso.FormattingEnabled = true;
            cbSuTorso.IntegralHeight = false;
            cbSuTorso.Location = new Point(326, 206);
            cbSuTorso.Margin = new Padding(4, 3, 4, 3);
            cbSuTorso.Name = "cbSuTorso";
            cbSuTorso.Size = new Size(252, 23);
            cbSuTorso.TabIndex = 23;
            // 
            // cbSuBoots
            // 
            cbSuBoots.Dock = DockStyle.Fill;
            cbSuBoots.DropDownHeight = 300;
            cbSuBoots.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuBoots.FormattingEnabled = true;
            cbSuBoots.IntegralHeight = false;
            cbSuBoots.Location = new Point(326, 177);
            cbSuBoots.Margin = new Padding(4, 3, 4, 3);
            cbSuBoots.Name = "cbSuBoots";
            cbSuBoots.Size = new Size(252, 23);
            cbSuBoots.TabIndex = 23;
            // 
            // cbSuShield
            // 
            cbSuShield.Dock = DockStyle.Fill;
            cbSuShield.DropDownHeight = 300;
            cbSuShield.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuShield.FormattingEnabled = true;
            cbSuShield.IntegralHeight = false;
            cbSuShield.Location = new Point(326, 148);
            cbSuShield.Margin = new Padding(4, 3, 4, 3);
            cbSuShield.Name = "cbSuShield";
            cbSuShield.Size = new Size(252, 23);
            cbSuShield.TabIndex = 23;
            // 
            // cbSuWeapon
            // 
            cbSuWeapon.Dock = DockStyle.Fill;
            cbSuWeapon.DropDownHeight = 300;
            cbSuWeapon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuWeapon.FormattingEnabled = true;
            cbSuWeapon.IntegralHeight = false;
            cbSuWeapon.Location = new Point(326, 119);
            cbSuWeapon.Margin = new Padding(4, 3, 4, 3);
            cbSuWeapon.Name = "cbSuWeapon";
            cbSuWeapon.Size = new Size(252, 23);
            cbSuWeapon.TabIndex = 23;
            // 
            // cbSuGauntlets
            // 
            cbSuGauntlets.Dock = DockStyle.Fill;
            cbSuGauntlets.DropDownHeight = 300;
            cbSuGauntlets.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuGauntlets.FormattingEnabled = true;
            cbSuGauntlets.IntegralHeight = false;
            cbSuGauntlets.Location = new Point(326, 90);
            cbSuGauntlets.Margin = new Padding(4, 3, 4, 3);
            cbSuGauntlets.Name = "cbSuGauntlets";
            cbSuGauntlets.Size = new Size(252, 23);
            cbSuGauntlets.TabIndex = 23;
            // 
            // cbSuRing2
            // 
            cbSuRing2.Dock = DockStyle.Fill;
            cbSuRing2.DropDownHeight = 300;
            cbSuRing2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuRing2.FormattingEnabled = true;
            cbSuRing2.IntegralHeight = false;
            cbSuRing2.Location = new Point(326, 61);
            cbSuRing2.Margin = new Padding(4, 3, 4, 3);
            cbSuRing2.Name = "cbSuRing2";
            cbSuRing2.Size = new Size(252, 23);
            cbSuRing2.TabIndex = 23;
            // 
            // cbSuRing1
            // 
            cbSuRing1.Dock = DockStyle.Fill;
            cbSuRing1.DropDownHeight = 300;
            cbSuRing1.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuRing1.FormattingEnabled = true;
            cbSuRing1.IntegralHeight = false;
            cbSuRing1.Location = new Point(326, 32);
            cbSuRing1.Margin = new Padding(4, 3, 4, 3);
            cbSuRing1.Name = "cbSuRing1";
            cbSuRing1.Size = new Size(252, 23);
            cbSuRing1.TabIndex = 23;
            // 
            // cbSuAmulet
            // 
            cbSuAmulet.Dock = DockStyle.Fill;
            cbSuAmulet.DropDownHeight = 300;
            cbSuAmulet.DropDownStyle = ComboBoxStyle.DropDownList;
            cbSuAmulet.FormattingEnabled = true;
            cbSuAmulet.IntegralHeight = false;
            cbSuAmulet.Location = new Point(326, 3);
            cbSuAmulet.Margin = new Padding(4, 3, 4, 3);
            cbSuAmulet.Name = "cbSuAmulet";
            cbSuAmulet.Size = new Size(252, 23);
            cbSuAmulet.TabIndex = 23;
            // 
            // numSuCurrentHP
            // 
            numSuCurrentHP.Dock = DockStyle.Fill;
            numSuCurrentHP.Location = new Point(81, 119);
            numSuCurrentHP.Margin = new Padding(4, 3, 4, 3);
            numSuCurrentHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSuCurrentHP.Name = "numSuCurrentHP";
            numSuCurrentHP.Size = new Size(107, 23);
            numSuCurrentHP.TabIndex = 24;
            numSuCurrentHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            // 
            // btnSuMaxCurrentHP
            // 
            btnSuMaxCurrentHP.Dock = DockStyle.Fill;
            btnSuMaxCurrentHP.Location = new Point(196, 119);
            btnSuMaxCurrentHP.Margin = new Padding(4, 3, 4, 3);
            btnSuMaxCurrentHP.Name = "btnSuMaxCurrentHP";
            btnSuMaxCurrentHP.Size = new Size(52, 23);
            btnSuMaxCurrentHP.TabIndex = 25;
            btnSuMaxCurrentHP.Text = "Max";
            btnSuMaxCurrentHP.UseVisualStyleBackColor = true;
            // 
            // lblSuCurrentAP
            // 
            lblSuCurrentAP.AutoSize = true;
            lblSuCurrentAP.Dock = DockStyle.Fill;
            lblSuCurrentAP.Location = new Point(4, 174);
            lblSuCurrentAP.Margin = new Padding(4, 0, 4, 0);
            lblSuCurrentAP.Name = "lblSuCurrentAP";
            lblSuCurrentAP.Size = new Size(69, 29);
            lblSuCurrentAP.TabIndex = 23;
            lblSuCurrentAP.Text = "Current AP:";
            lblSuCurrentAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numSuCurrentAP
            // 
            numSuCurrentAP.Dock = DockStyle.Fill;
            numSuCurrentAP.Location = new Point(81, 177);
            numSuCurrentAP.Margin = new Padding(4, 3, 4, 3);
            numSuCurrentAP.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numSuCurrentAP.Name = "numSuCurrentAP";
            numSuCurrentAP.Size = new Size(107, 23);
            numSuCurrentAP.TabIndex = 24;
            numSuCurrentAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnSuMaxCurrentAP
            // 
            btnSuMaxCurrentAP.Dock = DockStyle.Fill;
            btnSuMaxCurrentAP.Location = new Point(196, 177);
            btnSuMaxCurrentAP.Margin = new Padding(4, 3, 4, 3);
            btnSuMaxCurrentAP.Name = "btnSuMaxCurrentAP";
            btnSuMaxCurrentAP.Size = new Size(52, 23);
            btnSuMaxCurrentAP.TabIndex = 25;
            btnSuMaxCurrentAP.Text = "Max";
            btnSuMaxCurrentAP.UseVisualStyleBackColor = true;
            // 
            // lblSuSpeed
            // 
            lblSuSpeed.AutoSize = true;
            lblSuSpeed.Dock = DockStyle.Fill;
            lblSuSpeed.Location = new Point(4, 203);
            lblSuSpeed.Margin = new Padding(4, 0, 4, 0);
            lblSuSpeed.Name = "lblSuSpeed";
            lblSuSpeed.Size = new Size(69, 29);
            lblSuSpeed.TabIndex = 23;
            lblSuSpeed.Text = "Speed:";
            lblSuSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numSuSpeed
            // 
            numSuSpeed.Dock = DockStyle.Fill;
            numSuSpeed.Location = new Point(81, 206);
            numSuSpeed.Margin = new Padding(4, 3, 4, 3);
            numSuSpeed.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            numSuSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSuSpeed.Name = "numSuSpeed";
            numSuSpeed.Size = new Size(107, 23);
            numSuSpeed.TabIndex = 24;
            numSuSpeed.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // btnSuMaxSpeed
            // 
            btnSuMaxSpeed.Dock = DockStyle.Fill;
            btnSuMaxSpeed.Location = new Point(196, 206);
            btnSuMaxSpeed.Margin = new Padding(4, 3, 4, 3);
            btnSuMaxSpeed.Name = "btnSuMaxSpeed";
            btnSuMaxSpeed.Size = new Size(52, 23);
            btnSuMaxSpeed.TabIndex = 25;
            btnSuMaxSpeed.Text = "Max";
            btnSuMaxSpeed.UseVisualStyleBackColor = true;
            // 
            // lblSuLeggings
            // 
            lblSuLeggings.AutoSize = true;
            lblSuLeggings.Dock = DockStyle.Fill;
            lblSuLeggings.Location = new Point(256, 232);
            lblSuLeggings.Margin = new Padding(4, 0, 4, 0);
            lblSuLeggings.Name = "lblSuLeggings";
            lblSuLeggings.Size = new Size(62, 29);
            lblSuLeggings.TabIndex = 40;
            lblSuLeggings.Text = "Leggings";
            lblSuLeggings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSuMaxAll
            // 
            btnSuMaxAll.Dock = DockStyle.Fill;
            btnSuMaxAll.Location = new Point(81, 235);
            btnSuMaxAll.Margin = new Padding(4, 3, 4, 3);
            btnSuMaxAll.Name = "btnSuMaxAll";
            btnSuMaxAll.Size = new Size(107, 23);
            btnSuMaxAll.TabIndex = 19;
            btnSuMaxAll.Text = "Max All";
            btnSuMaxAll.UseVisualStyleBackColor = true;
            // 
            // btnSuMaxBaseAP
            // 
            btnSuMaxBaseAP.Dock = DockStyle.Fill;
            btnSuMaxBaseAP.Location = new Point(196, 148);
            btnSuMaxBaseAP.Margin = new Padding(4, 3, 4, 3);
            btnSuMaxBaseAP.Name = "btnSuMaxBaseAP";
            btnSuMaxBaseAP.Size = new Size(52, 23);
            btnSuMaxBaseAP.TabIndex = 28;
            btnSuMaxBaseAP.Text = "Max";
            btnSuMaxBaseAP.UseVisualStyleBackColor = true;
            // 
            // numSuBaseAP
            // 
            numSuBaseAP.Dock = DockStyle.Fill;
            numSuBaseAP.Location = new Point(81, 148);
            numSuBaseAP.Margin = new Padding(4, 3, 4, 3);
            numSuBaseAP.Maximum = new decimal(new int[] { 20000, 0, 0, 0 });
            numSuBaseAP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSuBaseAP.Name = "numSuBaseAP";
            numSuBaseAP.Size = new Size(107, 23);
            numSuBaseAP.TabIndex = 27;
            numSuBaseAP.Value = new decimal(new int[] { 20, 0, 0, 0 });
            // 
            // btnSuMaxBaseHP
            // 
            btnSuMaxBaseHP.Dock = DockStyle.Fill;
            btnSuMaxBaseHP.Location = new Point(196, 90);
            btnSuMaxBaseHP.Margin = new Padding(4, 3, 4, 3);
            btnSuMaxBaseHP.Name = "btnSuMaxBaseHP";
            btnSuMaxBaseHP.Size = new Size(52, 23);
            btnSuMaxBaseHP.TabIndex = 31;
            btnSuMaxBaseHP.Text = "Max";
            btnSuMaxBaseHP.UseVisualStyleBackColor = true;
            // 
            // lblSuBaseAP
            // 
            lblSuBaseAP.AutoSize = true;
            lblSuBaseAP.Dock = DockStyle.Fill;
            lblSuBaseAP.Location = new Point(4, 145);
            lblSuBaseAP.Margin = new Padding(4, 0, 4, 0);
            lblSuBaseAP.Name = "lblSuBaseAP";
            lblSuBaseAP.Size = new Size(69, 29);
            lblSuBaseAP.TabIndex = 26;
            lblSuBaseAP.Text = "Base AP:";
            lblSuBaseAP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numSuBaseHP
            // 
            numSuBaseHP.Dock = DockStyle.Fill;
            numSuBaseHP.Location = new Point(81, 90);
            numSuBaseHP.Margin = new Padding(4, 3, 4, 3);
            numSuBaseHP.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numSuBaseHP.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSuBaseHP.Name = "numSuBaseHP";
            numSuBaseHP.Size = new Size(107, 23);
            numSuBaseHP.TabIndex = 30;
            numSuBaseHP.Value = new decimal(new int[] { 64, 0, 0, 0 });
            // 
            // numSuLevel
            // 
            numSuLevel.Dock = DockStyle.Fill;
            numSuLevel.Location = new Point(81, 3);
            numSuLevel.Margin = new Padding(4, 3, 4, 3);
            numSuLevel.Maximum = new decimal(new int[] { 50, 0, 0, 0 });
            numSuLevel.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numSuLevel.Name = "numSuLevel";
            numSuLevel.Size = new Size(107, 23);
            numSuLevel.TabIndex = 1;
            numSuLevel.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblSuBaseHP
            // 
            lblSuBaseHP.AutoSize = true;
            lblSuBaseHP.Dock = DockStyle.Fill;
            lblSuBaseHP.Location = new Point(4, 87);
            lblSuBaseHP.Margin = new Padding(4, 0, 4, 0);
            lblSuBaseHP.Name = "lblSuBaseHP";
            lblSuBaseHP.Size = new Size(69, 29);
            lblSuBaseHP.TabIndex = 29;
            lblSuBaseHP.Text = "Base HP:";
            lblSuBaseHP.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numSuExperience
            // 
            numSuExperience.Dock = DockStyle.Fill;
            numSuExperience.Location = new Point(81, 32);
            numSuExperience.Margin = new Padding(4, 3, 4, 3);
            numSuExperience.Maximum = new decimal(new int[] { 6327001, 0, 0, 0 });
            numSuExperience.Name = "numSuExperience";
            numSuExperience.Size = new Size(107, 23);
            numSuExperience.TabIndex = 2;
            // 
            // lblSuSkillPoints
            // 
            lblSuSkillPoints.AutoSize = true;
            lblSuSkillPoints.Dock = DockStyle.Fill;
            lblSuSkillPoints.Location = new Point(4, 58);
            lblSuSkillPoints.Margin = new Padding(4, 0, 4, 0);
            lblSuSkillPoints.Name = "lblSuSkillPoints";
            lblSuSkillPoints.Size = new Size(69, 29);
            lblSuSkillPoints.TabIndex = 3;
            lblSuSkillPoints.Text = "Skill Points:";
            lblSuSkillPoints.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSuMaxLevel
            // 
            btnSuMaxLevel.Dock = DockStyle.Fill;
            btnSuMaxLevel.Location = new Point(196, 3);
            btnSuMaxLevel.Margin = new Padding(4, 3, 4, 3);
            btnSuMaxLevel.Name = "btnSuMaxLevel";
            btnSuMaxLevel.Size = new Size(52, 23);
            btnSuMaxLevel.TabIndex = 19;
            btnSuMaxLevel.Text = "Max";
            btnSuMaxLevel.UseVisualStyleBackColor = true;
            // 
            // lblSuLevel
            // 
            lblSuLevel.AutoSize = true;
            lblSuLevel.Dock = DockStyle.Fill;
            lblSuLevel.Location = new Point(4, 0);
            lblSuLevel.Margin = new Padding(4, 0, 4, 0);
            lblSuLevel.Name = "lblSuLevel";
            lblSuLevel.Size = new Size(69, 29);
            lblSuLevel.TabIndex = 0;
            lblSuLevel.Text = "Level:";
            lblSuLevel.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSuExperience
            // 
            lblSuExperience.AutoSize = true;
            lblSuExperience.Dock = DockStyle.Fill;
            lblSuExperience.Location = new Point(4, 29);
            lblSuExperience.Margin = new Padding(4, 0, 4, 0);
            lblSuExperience.Name = "lblSuExperience";
            lblSuExperience.Size = new Size(69, 29);
            lblSuExperience.TabIndex = 2;
            lblSuExperience.Text = "Experience:";
            lblSuExperience.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSuMaxExp
            // 
            btnSuMaxExp.Dock = DockStyle.Fill;
            btnSuMaxExp.Location = new Point(196, 32);
            btnSuMaxExp.Margin = new Padding(4, 3, 4, 3);
            btnSuMaxExp.Name = "btnSuMaxExp";
            btnSuMaxExp.Size = new Size(52, 23);
            btnSuMaxExp.TabIndex = 19;
            btnSuMaxExp.Text = "Max";
            btnSuMaxExp.UseVisualStyleBackColor = true;
            // 
            // numSuSkillPoints
            // 
            numSuSkillPoints.Dock = DockStyle.Fill;
            numSuSkillPoints.Location = new Point(81, 61);
            numSuSkillPoints.Margin = new Padding(4, 3, 4, 3);
            numSuSkillPoints.Maximum = new decimal(new int[] { 160, 0, 0, 0 });
            numSuSkillPoints.Name = "numSuSkillPoints";
            numSuSkillPoints.Size = new Size(107, 23);
            numSuSkillPoints.TabIndex = 2;
            // 
            // btnSuMaxSkill
            // 
            btnSuMaxSkill.Dock = DockStyle.Fill;
            btnSuMaxSkill.Location = new Point(196, 61);
            btnSuMaxSkill.Margin = new Padding(4, 3, 4, 3);
            btnSuMaxSkill.Name = "btnSuMaxSkill";
            btnSuMaxSkill.Size = new Size(52, 23);
            btnSuMaxSkill.TabIndex = 19;
            btnSuMaxSkill.Text = "Max";
            btnSuMaxSkill.UseVisualStyleBackColor = true;
            // 
            // lvSummonSkills
            // 
            lvSummonSkills.Columns.AddRange(new ColumnHeader[] { columnHeader24, columnHeader25 });
            lvSummonSkills.Dock = DockStyle.Fill;
            lvSummonSkills.FullRowSelect = true;
            lvSummonSkills.Location = new Point(586, 3);
            lvSummonSkills.Margin = new Padding(4, 3, 4, 3);
            lvSummonSkills.Name = "lvSummonSkills";
            tblSummon.SetRowSpan(lvSummonSkills, 8);
            lvSummonSkills.Size = new Size(384, 226);
            lvSummonSkills.TabIndex = 0;
            lvSummonSkills.UseCompatibleStateImageBehavior = false;
            lvSummonSkills.View = View.Details;
            lvSummonSkills.SelectedIndexChanged += lvSummonSkills_SelectedIndexChanged;
            // 
            // columnHeader24
            // 
            columnHeader24.Text = "Skill Name";
            columnHeader24.Width = 216;
            // 
            // columnHeader25
            // 
            columnHeader25.Text = "Value";
            columnHeader25.Width = 63;
            // 
            // tableLayoutPanel19
            // 
            tableLayoutPanel19.ColumnCount = 2;
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel19.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel19.Controls.Add(numSuSkillValue, 0, 0);
            tableLayoutPanel19.Controls.Add(btnSuUpdateSkill, 1, 0);
            tableLayoutPanel19.Dock = DockStyle.Fill;
            tableLayoutPanel19.Location = new Point(582, 232);
            tableLayoutPanel19.Margin = new Padding(0);
            tableLayoutPanel19.Name = "tableLayoutPanel19";
            tableLayoutPanel19.RowCount = 1;
            tableLayoutPanel19.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel19.Size = new Size(392, 29);
            tableLayoutPanel19.TabIndex = 23;
            // 
            // numSuSkillValue
            // 
            numSuSkillValue.Dock = DockStyle.Fill;
            numSuSkillValue.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            numSuSkillValue.Location = new Point(4, 3);
            numSuSkillValue.Margin = new Padding(4, 3, 4, 3);
            numSuSkillValue.Maximum = new decimal(new int[] { 25, 0, 0, 0 });
            numSuSkillValue.Name = "numSuSkillValue";
            numSuSkillValue.Size = new Size(188, 23);
            numSuSkillValue.TabIndex = 3;
            // 
            // btnSuUpdateSkill
            // 
            btnSuUpdateSkill.Dock = DockStyle.Fill;
            btnSuUpdateSkill.Location = new Point(200, 3);
            btnSuUpdateSkill.Margin = new Padding(4, 3, 4, 3);
            btnSuUpdateSkill.Name = "btnSuUpdateSkill";
            btnSuUpdateSkill.Size = new Size(188, 23);
            btnSuUpdateSkill.TabIndex = 4;
            btnSuUpdateSkill.Text = "Update Skill";
            btnSuUpdateSkill.UseVisualStyleBackColor = true;
            btnSuUpdateSkill.Click += btnSuUpdateSkill_Click;
            // 
            // label29
            // 
            label29.Dock = DockStyle.Fill;
            label29.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label29.Location = new Point(585, 406);
            label29.Name = "label29";
            label29.Size = new Size(386, 101);
            label29.TabIndex = 41;
            label29.Text = "Note: Summon stats are temporary and will reset on next summon. Changes made here will only be reflected in the current summon.";
            label29.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSuPosition
            // 
            lblSuPosition.AutoSize = true;
            lblSuPosition.Dock = DockStyle.Fill;
            lblSuPosition.Location = new Point(3, 290);
            lblSuPosition.Name = "lblSuPosition";
            lblSuPosition.Size = new Size(71, 29);
            lblSuPosition.TabIndex = 47;
            lblSuPosition.Text = "Position";
            lblSuPosition.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblSuPosX
            // 
            lblSuPosX.AutoSize = true;
            lblSuPosX.Dock = DockStyle.Fill;
            lblSuPosX.Location = new Point(3, 319);
            lblSuPosX.Name = "lblSuPosX";
            lblSuPosX.Size = new Size(71, 29);
            lblSuPosX.TabIndex = 48;
            lblSuPosX.Text = "X";
            lblSuPosX.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSuPosY
            // 
            lblSuPosY.AutoSize = true;
            lblSuPosY.Dock = DockStyle.Fill;
            lblSuPosY.Location = new Point(3, 348);
            lblSuPosY.Name = "lblSuPosY";
            lblSuPosY.Size = new Size(71, 29);
            lblSuPosY.TabIndex = 49;
            lblSuPosY.Text = "Y";
            lblSuPosY.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblSuPosZ
            // 
            lblSuPosZ.AutoSize = true;
            lblSuPosZ.Dock = DockStyle.Fill;
            lblSuPosZ.Location = new Point(3, 377);
            lblSuPosZ.Name = "lblSuPosZ";
            lblSuPosZ.Size = new Size(71, 29);
            lblSuPosZ.TabIndex = 50;
            lblSuPosZ.Text = "Z";
            lblSuPosZ.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numSuPosX
            // 
            numSuPosX.DecimalPlaces = 4;
            numSuPosX.Dock = DockStyle.Fill;
            numSuPosX.Location = new Point(81, 322);
            numSuPosX.Margin = new Padding(4, 3, 4, 3);
            numSuPosX.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSuPosX.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numSuPosX.Name = "numSuPosX";
            numSuPosX.Size = new Size(107, 23);
            numSuPosX.TabIndex = 44;
            numSuPosX.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numSuPosY
            // 
            numSuPosY.DecimalPlaces = 4;
            numSuPosY.Dock = DockStyle.Fill;
            numSuPosY.Location = new Point(81, 351);
            numSuPosY.Margin = new Padding(4, 3, 4, 3);
            numSuPosY.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSuPosY.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numSuPosY.Name = "numSuPosY";
            numSuPosY.Size = new Size(107, 23);
            numSuPosY.TabIndex = 45;
            numSuPosY.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numSuPosZ
            // 
            numSuPosZ.DecimalPlaces = 4;
            numSuPosZ.Dock = DockStyle.Fill;
            numSuPosZ.Location = new Point(81, 380);
            numSuPosZ.Margin = new Padding(4, 3, 4, 3);
            numSuPosZ.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numSuPosZ.Minimum = new decimal(new int[] { 10000, 0, 0, int.MinValue });
            numSuPosZ.Name = "numSuPosZ";
            numSuPosZ.Size = new Size(107, 23);
            numSuPosZ.TabIndex = 46;
            numSuPosZ.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // tabPageContainer
            // 
            tabPageContainer.BackColor = Color.Transparent;
            tabPageContainer.Controls.Add(tableLayoutPanel2);
            tabPageContainer.Location = new Point(4, 24);
            tabPageContainer.Name = "tabPageContainer";
            tabPageContainer.Size = new Size(974, 507);
            tabPageContainer.TabIndex = 8;
            tabPageContainer.Text = "Containers";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 265F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 1, 3);
            tableLayoutPanel2.Controls.Add(lblContainers, 0, 0);
            tableLayoutPanel2.Controls.Add(lblContainerContent, 0, 2);
            tableLayoutPanel2.Controls.Add(lvContainers, 0, 1);
            tableLayoutPanel2.Controls.Add(lvContainerContent, 0, 3);
            tableLayoutPanel2.Controls.Add(lvContainerGameItems, 2, 3);
            tableLayoutPanel2.Controls.Add(lvGoldPiles, 2, 1);
            tableLayoutPanel2.Controls.Add(lblGoldPiles, 2, 0);
            tableLayoutPanel2.Controls.Add(lblContainerGameItems, 2, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 210F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 210F));
            tableLayoutPanel2.Size = new Size(974, 507);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(btnModifyGoldPile, 1, 2);
            tableLayoutPanel3.Controls.Add(btnRemoveGoldPile, 1, 1);
            tableLayoutPanel3.Controls.Add(btnAddGoldPile, 1, 0);
            tableLayoutPanel3.Controls.Add(btnRemoveContainer, 0, 1);
            tableLayoutPanel3.Controls.Add(btnAddContainer, 0, 0);
            tableLayoutPanel3.Controls.Add(btnToggleContainerLock, 0, 6);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel12, 0, 4);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel17, 1, 6);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel16, 1, 5);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel15, 1, 4);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel14, 1, 3);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel13, 0, 5);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 3);
            tableLayoutPanel3.Controls.Add(btnModifyContainer, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(354, 26);
            tableLayoutPanel3.Margin = new Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel3.Size = new Size(265, 210);
            tableLayoutPanel3.TabIndex = 8;
            // 
            // btnModifyGoldPile
            // 
            btnModifyGoldPile.Dock = DockStyle.Fill;
            btnModifyGoldPile.Location = new Point(135, 63);
            btnModifyGoldPile.Name = "btnModifyGoldPile";
            btnModifyGoldPile.Size = new Size(127, 24);
            btnModifyGoldPile.TabIndex = 7;
            btnModifyGoldPile.Text = "Modify Gold Pile";
            btnModifyGoldPile.UseVisualStyleBackColor = true;
            btnModifyGoldPile.Click += btnModifyGoldPile_Click;
            // 
            // btnRemoveGoldPile
            // 
            btnRemoveGoldPile.Dock = DockStyle.Fill;
            btnRemoveGoldPile.Location = new Point(135, 33);
            btnRemoveGoldPile.Name = "btnRemoveGoldPile";
            btnRemoveGoldPile.Size = new Size(127, 24);
            btnRemoveGoldPile.TabIndex = 6;
            btnRemoveGoldPile.Text = "Remove Gold Pile";
            btnRemoveGoldPile.UseVisualStyleBackColor = true;
            btnRemoveGoldPile.Click += btnRemoveGoldPile_Click;
            // 
            // btnAddGoldPile
            // 
            btnAddGoldPile.Dock = DockStyle.Fill;
            btnAddGoldPile.Location = new Point(135, 3);
            btnAddGoldPile.Name = "btnAddGoldPile";
            btnAddGoldPile.Size = new Size(127, 24);
            btnAddGoldPile.TabIndex = 5;
            btnAddGoldPile.Text = "Add Gold Pile";
            btnAddGoldPile.UseVisualStyleBackColor = true;
            btnAddGoldPile.Click += btnAddGoldPile_Click;
            // 
            // btnRemoveContainer
            // 
            btnRemoveContainer.Dock = DockStyle.Fill;
            btnRemoveContainer.Location = new Point(3, 33);
            btnRemoveContainer.Name = "btnRemoveContainer";
            btnRemoveContainer.Size = new Size(126, 24);
            btnRemoveContainer.TabIndex = 2;
            btnRemoveContainer.Text = "Remove Container";
            btnRemoveContainer.UseVisualStyleBackColor = true;
            btnRemoveContainer.Click += btnRemoveContainer_Click;
            // 
            // btnAddContainer
            // 
            btnAddContainer.Dock = DockStyle.Fill;
            btnAddContainer.Location = new Point(3, 3);
            btnAddContainer.Name = "btnAddContainer";
            btnAddContainer.Size = new Size(126, 24);
            btnAddContainer.TabIndex = 2;
            btnAddContainer.Text = "Add Container";
            btnAddContainer.UseVisualStyleBackColor = true;
            btnAddContainer.Click += btnAddContainer_Click;
            // 
            // btnToggleContainerLock
            // 
            btnToggleContainerLock.Dock = DockStyle.Fill;
            btnToggleContainerLock.Location = new Point(3, 183);
            btnToggleContainerLock.Name = "btnToggleContainerLock";
            btnToggleContainerLock.Size = new Size(126, 24);
            btnToggleContainerLock.TabIndex = 1;
            btnToggleContainerLock.Text = "Toggle Lock";
            btnToggleContainerLock.UseVisualStyleBackColor = true;
            btnToggleContainerLock.Click += btnToggleContainerLock_Click;
            // 
            // tableLayoutPanel12
            // 
            tableLayoutPanel12.ColumnCount = 2;
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel12.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Controls.Add(label21, 0, 0);
            tableLayoutPanel12.Controls.Add(numContainerPosY, 1, 0);
            tableLayoutPanel12.Dock = DockStyle.Fill;
            tableLayoutPanel12.Location = new Point(0, 120);
            tableLayoutPanel12.Margin = new Padding(0);
            tableLayoutPanel12.Name = "tableLayoutPanel12";
            tableLayoutPanel12.RowCount = 1;
            tableLayoutPanel12.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel12.Size = new Size(132, 30);
            tableLayoutPanel12.TabIndex = 8;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Dock = DockStyle.Fill;
            label21.Location = new Point(3, 0);
            label21.Name = "label21";
            label21.Size = new Size(30, 30);
            label21.TabIndex = 4;
            label21.Text = "Y";
            label21.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numContainerPosY
            // 
            numContainerPosY.DecimalPlaces = 4;
            numContainerPosY.Dock = DockStyle.Fill;
            numContainerPosY.Location = new Point(39, 3);
            numContainerPosY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numContainerPosY.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numContainerPosY.Name = "numContainerPosY";
            numContainerPosY.Size = new Size(90, 23);
            numContainerPosY.TabIndex = 3;
            // 
            // tableLayoutPanel17
            // 
            tableLayoutPanel17.ColumnCount = 2;
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel17.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel17.Controls.Add(label28, 0, 0);
            tableLayoutPanel17.Controls.Add(numGoldPileAmount, 1, 0);
            tableLayoutPanel17.Dock = DockStyle.Fill;
            tableLayoutPanel17.Location = new Point(132, 180);
            tableLayoutPanel17.Margin = new Padding(0);
            tableLayoutPanel17.Name = "tableLayoutPanel17";
            tableLayoutPanel17.RowCount = 1;
            tableLayoutPanel17.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel17.Size = new Size(133, 30);
            tableLayoutPanel17.TabIndex = 8;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Dock = DockStyle.Fill;
            label28.Location = new Point(3, 0);
            label28.Name = "label28";
            label28.Size = new Size(30, 30);
            label28.TabIndex = 4;
            label28.Text = "Qty.";
            label28.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numGoldPileAmount
            // 
            numGoldPileAmount.Dock = DockStyle.Fill;
            numGoldPileAmount.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numGoldPileAmount.Location = new Point(39, 3);
            numGoldPileAmount.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            numGoldPileAmount.Name = "numGoldPileAmount";
            numGoldPileAmount.Size = new Size(91, 23);
            numGoldPileAmount.TabIndex = 3;
            // 
            // tableLayoutPanel16
            // 
            tableLayoutPanel16.ColumnCount = 2;
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel16.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Controls.Add(label27, 0, 0);
            tableLayoutPanel16.Controls.Add(numGoldPilePosZ, 1, 0);
            tableLayoutPanel16.Dock = DockStyle.Fill;
            tableLayoutPanel16.Location = new Point(132, 150);
            tableLayoutPanel16.Margin = new Padding(0);
            tableLayoutPanel16.Name = "tableLayoutPanel16";
            tableLayoutPanel16.RowCount = 1;
            tableLayoutPanel16.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel16.Size = new Size(133, 30);
            tableLayoutPanel16.TabIndex = 8;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Dock = DockStyle.Fill;
            label27.Location = new Point(3, 0);
            label27.Name = "label27";
            label27.Size = new Size(30, 30);
            label27.TabIndex = 4;
            label27.Text = "Z";
            label27.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numGoldPilePosZ
            // 
            numGoldPilePosZ.DecimalPlaces = 4;
            numGoldPilePosZ.Dock = DockStyle.Fill;
            numGoldPilePosZ.Location = new Point(39, 3);
            numGoldPilePosZ.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numGoldPilePosZ.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numGoldPilePosZ.Name = "numGoldPilePosZ";
            numGoldPilePosZ.Size = new Size(91, 23);
            numGoldPilePosZ.TabIndex = 3;
            // 
            // tableLayoutPanel15
            // 
            tableLayoutPanel15.ColumnCount = 2;
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel15.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel15.Controls.Add(label26, 0, 0);
            tableLayoutPanel15.Controls.Add(numGoldPilePosY, 1, 0);
            tableLayoutPanel15.Dock = DockStyle.Fill;
            tableLayoutPanel15.Location = new Point(132, 120);
            tableLayoutPanel15.Margin = new Padding(0);
            tableLayoutPanel15.Name = "tableLayoutPanel15";
            tableLayoutPanel15.RowCount = 1;
            tableLayoutPanel15.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel15.Size = new Size(133, 30);
            tableLayoutPanel15.TabIndex = 8;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Dock = DockStyle.Fill;
            label26.Location = new Point(3, 0);
            label26.Name = "label26";
            label26.Size = new Size(30, 30);
            label26.TabIndex = 4;
            label26.Text = "Y";
            label26.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numGoldPilePosY
            // 
            numGoldPilePosY.DecimalPlaces = 4;
            numGoldPilePosY.Dock = DockStyle.Fill;
            numGoldPilePosY.Location = new Point(39, 3);
            numGoldPilePosY.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numGoldPilePosY.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numGoldPilePosY.Name = "numGoldPilePosY";
            numGoldPilePosY.Size = new Size(91, 23);
            numGoldPilePosY.TabIndex = 3;
            // 
            // tableLayoutPanel14
            // 
            tableLayoutPanel14.ColumnCount = 2;
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel14.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Controls.Add(label25, 0, 0);
            tableLayoutPanel14.Controls.Add(numGoldPilePosX, 1, 0);
            tableLayoutPanel14.Dock = DockStyle.Fill;
            tableLayoutPanel14.Location = new Point(132, 90);
            tableLayoutPanel14.Margin = new Padding(0);
            tableLayoutPanel14.Name = "tableLayoutPanel14";
            tableLayoutPanel14.RowCount = 1;
            tableLayoutPanel14.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel14.Size = new Size(133, 30);
            tableLayoutPanel14.TabIndex = 8;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Dock = DockStyle.Fill;
            label25.Location = new Point(3, 0);
            label25.Name = "label25";
            label25.Size = new Size(30, 30);
            label25.TabIndex = 4;
            label25.Text = "X";
            label25.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numGoldPilePosX
            // 
            numGoldPilePosX.DecimalPlaces = 4;
            numGoldPilePosX.Dock = DockStyle.Fill;
            numGoldPilePosX.Location = new Point(39, 3);
            numGoldPilePosX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numGoldPilePosX.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numGoldPilePosX.Name = "numGoldPilePosX";
            numGoldPilePosX.Size = new Size(91, 23);
            numGoldPilePosX.TabIndex = 3;
            // 
            // tableLayoutPanel13
            // 
            tableLayoutPanel13.ColumnCount = 2;
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel13.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Controls.Add(label22, 0, 0);
            tableLayoutPanel13.Controls.Add(numContainerPosZ, 1, 0);
            tableLayoutPanel13.Dock = DockStyle.Fill;
            tableLayoutPanel13.Location = new Point(0, 150);
            tableLayoutPanel13.Margin = new Padding(0);
            tableLayoutPanel13.Name = "tableLayoutPanel13";
            tableLayoutPanel13.RowCount = 1;
            tableLayoutPanel13.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel13.Size = new Size(132, 30);
            tableLayoutPanel13.TabIndex = 8;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Dock = DockStyle.Fill;
            label22.Location = new Point(3, 0);
            label22.Name = "label22";
            label22.Size = new Size(30, 30);
            label22.TabIndex = 4;
            label22.Text = "Z";
            label22.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numContainerPosZ
            // 
            numContainerPosZ.DecimalPlaces = 4;
            numContainerPosZ.Dock = DockStyle.Fill;
            numContainerPosZ.Location = new Point(39, 3);
            numContainerPosZ.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numContainerPosZ.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numContainerPosZ.Name = "numContainerPosZ";
            numContainerPosZ.Size = new Size(90, 23);
            numContainerPosZ.TabIndex = 3;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 36F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label20, 0, 0);
            tableLayoutPanel6.Controls.Add(numContainerPosX, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(0, 90);
            tableLayoutPanel6.Margin = new Padding(0);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Size = new Size(132, 30);
            tableLayoutPanel6.TabIndex = 8;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Dock = DockStyle.Fill;
            label20.Location = new Point(3, 0);
            label20.Name = "label20";
            label20.Size = new Size(30, 30);
            label20.TabIndex = 4;
            label20.Text = "X";
            label20.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // numContainerPosX
            // 
            numContainerPosX.DecimalPlaces = 4;
            numContainerPosX.Dock = DockStyle.Fill;
            numContainerPosX.Location = new Point(39, 3);
            numContainerPosX.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numContainerPosX.Minimum = new decimal(new int[] { 1000, 0, 0, int.MinValue });
            numContainerPosX.Name = "numContainerPosX";
            numContainerPosX.Size = new Size(90, 23);
            numContainerPosX.TabIndex = 3;
            // 
            // btnModifyContainer
            // 
            btnModifyContainer.Dock = DockStyle.Fill;
            btnModifyContainer.Location = new Point(3, 63);
            btnModifyContainer.Name = "btnModifyContainer";
            btnModifyContainer.Size = new Size(126, 24);
            btnModifyContainer.TabIndex = 2;
            btnModifyContainer.Text = "Modify Container";
            btnModifyContainer.UseVisualStyleBackColor = true;
            btnModifyContainer.Click += btnModifyContainer_Click;
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
            tableLayoutPanel4.Location = new Point(354, 262);
            tableLayoutPanel4.Margin = new Padding(0);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 6;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            tableLayoutPanel4.Size = new Size(265, 245);
            tableLayoutPanel4.TabIndex = 8;
            // 
            // btnAddToContainer
            // 
            tableLayoutPanel4.SetColumnSpan(btnAddToContainer, 2);
            btnAddToContainer.Dock = DockStyle.Fill;
            btnAddToContainer.Location = new Point(3, 3);
            btnAddToContainer.Name = "btnAddToContainer";
            btnAddToContainer.Size = new Size(259, 24);
            btnAddToContainer.TabIndex = 1;
            btnAddToContainer.Text = "Add Item";
            btnAddToContainer.UseVisualStyleBackColor = true;
            btnAddToContainer.Click += btnAddToContainer_Click;
            // 
            // btnRemoveFromContainer
            // 
            tableLayoutPanel4.SetColumnSpan(btnRemoveFromContainer, 2);
            btnRemoveFromContainer.Dock = DockStyle.Fill;
            btnRemoveFromContainer.Location = new Point(3, 33);
            btnRemoveFromContainer.Name = "btnRemoveFromContainer";
            btnRemoveFromContainer.Size = new Size(259, 24);
            btnRemoveFromContainer.TabIndex = 1;
            btnRemoveFromContainer.Text = "Remove Item";
            btnRemoveFromContainer.UseVisualStyleBackColor = true;
            btnRemoveFromContainer.Click += btnRemoveFromContainer_Click;
            // 
            // btnApplyToContainerItems
            // 
            tableLayoutPanel4.SetColumnSpan(btnApplyToContainerItems, 2);
            btnApplyToContainerItems.Dock = DockStyle.Fill;
            btnApplyToContainerItems.Location = new Point(3, 63);
            btnApplyToContainerItems.Name = "btnApplyToContainerItems";
            btnApplyToContainerItems.Size = new Size(259, 24);
            btnApplyToContainerItems.TabIndex = 2;
            btnApplyToContainerItems.Text = "Apply to Selected";
            btnApplyToContainerItems.UseVisualStyleBackColor = true;
            btnApplyToContainerItems.Click += btnApplyToContainerItems_Click;
            // 
            // numContainerItemQuantity
            // 
            numContainerItemQuantity.Dock = DockStyle.Fill;
            numContainerItemQuantity.Location = new Point(135, 93);
            numContainerItemQuantity.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numContainerItemQuantity.Name = "numContainerItemQuantity";
            numContainerItemQuantity.Size = new Size(127, 23);
            numContainerItemQuantity.TabIndex = 3;
            // 
            // numContainerItemCharges
            // 
            numContainerItemCharges.Dock = DockStyle.Fill;
            numContainerItemCharges.Location = new Point(135, 123);
            numContainerItemCharges.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            numContainerItemCharges.Name = "numContainerItemCharges";
            numContainerItemCharges.Size = new Size(127, 23);
            numContainerItemCharges.TabIndex = 3;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Dock = DockStyle.Fill;
            label23.Location = new Point(3, 90);
            label23.Name = "label23";
            label23.Size = new Size(126, 30);
            label23.TabIndex = 4;
            label23.Text = "Quantity";
            label23.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Dock = DockStyle.Fill;
            label24.Location = new Point(3, 120);
            label24.Name = "label24";
            label24.Size = new Size(126, 30);
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
            lblContainers.Size = new Size(348, 26);
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
            lblContainerContent.Size = new Size(348, 26);
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
            lvContainers.Size = new Size(348, 204);
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
            lvContainerContent.Size = new Size(348, 239);
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
            // lvContainerGameItems
            // 
            lvContainerGameItems.Columns.AddRange(new ColumnHeader[] { columnHeader21 });
            lvContainerGameItems.Dock = DockStyle.Fill;
            lvContainerGameItems.Location = new Point(622, 265);
            lvContainerGameItems.Name = "lvContainerGameItems";
            lvContainerGameItems.Size = new Size(349, 239);
            lvContainerGameItems.TabIndex = 5;
            lvContainerGameItems.UseCompatibleStateImageBehavior = false;
            lvContainerGameItems.View = View.Details;
            // 
            // columnHeader21
            // 
            columnHeader21.Text = "Item Name";
            columnHeader21.Width = 180;
            // 
            // lvGoldPiles
            // 
            lvGoldPiles.Columns.AddRange(new ColumnHeader[] { columnHeader22, columnHeader23 });
            lvGoldPiles.Dock = DockStyle.Fill;
            lvGoldPiles.Location = new Point(622, 29);
            lvGoldPiles.Name = "lvGoldPiles";
            lvGoldPiles.Size = new Size(349, 204);
            lvGoldPiles.TabIndex = 9;
            lvGoldPiles.UseCompatibleStateImageBehavior = false;
            lvGoldPiles.View = View.Details;
            lvGoldPiles.SelectedIndexChanged += lvGoldPiles_SelectedIndexChanged;
            // 
            // columnHeader22
            // 
            columnHeader22.Text = "Gold Pile";
            columnHeader22.Width = 180;
            // 
            // columnHeader23
            // 
            columnHeader23.Text = "Quantity";
            columnHeader23.Width = 100;
            // 
            // lblGoldPiles
            // 
            lblGoldPiles.AutoSize = true;
            lblGoldPiles.Dock = DockStyle.Fill;
            lblGoldPiles.Location = new Point(622, 0);
            lblGoldPiles.Name = "lblGoldPiles";
            lblGoldPiles.Size = new Size(349, 26);
            lblGoldPiles.TabIndex = 10;
            lblGoldPiles.Text = "Gold Piles: 0 / 0";
            lblGoldPiles.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblContainerGameItems
            // 
            lblContainerGameItems.AutoSize = true;
            lblContainerGameItems.Dock = DockStyle.Fill;
            lblContainerGameItems.Location = new Point(622, 236);
            lblContainerGameItems.Name = "lblContainerGameItems";
            lblContainerGameItems.Size = new Size(349, 26);
            lblContainerGameItems.TabIndex = 11;
            lblContainerGameItems.Text = "Game Items";
            lblContainerGameItems.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tabPageQuests
            // 
            tabPageQuests.Controls.Add(label33);
            tabPageQuests.Controls.Add(lvQuestList);
            tabPageQuests.Location = new Point(4, 24);
            tabPageQuests.Name = "tabPageQuests";
            tabPageQuests.Padding = new Padding(3);
            tabPageQuests.Size = new Size(974, 507);
            tabPageQuests.TabIndex = 10;
            tabPageQuests.Text = "Quests";
            tabPageQuests.UseVisualStyleBackColor = true;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(441, 20);
            label33.Name = "label33";
            label33.Size = new Size(293, 15);
            label33.TabIndex = 1;
            label33.Text = "Note: this list only affects visibility, not quest progress.";
            // 
            // lvQuestList
            // 
            lvQuestList.CheckBoxes = true;
            lvQuestList.Columns.AddRange(new ColumnHeader[] { columnHeader27 });
            lvQuestList.Location = new Point(6, 6);
            lvQuestList.Name = "lvQuestList";
            lvQuestList.Size = new Size(416, 493);
            lvQuestList.TabIndex = 0;
            lvQuestList.UseCompatibleStateImageBehavior = false;
            lvQuestList.View = View.Details;
            // 
            // columnHeader27
            // 
            columnHeader27.Text = "Quests";
            columnHeader27.Width = 300;
            // 
            // tabPageLevelItems
            // 
            tabPageLevelItems.Controls.Add(lvLevelItems);
            tabPageLevelItems.Location = new Point(4, 24);
            tabPageLevelItems.Name = "tabPageLevelItems";
            tabPageLevelItems.Padding = new Padding(3);
            tabPageLevelItems.Size = new Size(974, 507);
            tabPageLevelItems.TabIndex = 11;
            tabPageLevelItems.Text = "Level Items";
            tabPageLevelItems.UseVisualStyleBackColor = true;
            // 
            // lvLevelItems
            // 
            lvLevelItems.CheckBoxes = true;
            lvLevelItems.Columns.AddRange(new ColumnHeader[] { columnHeader28, columnHeader29, columnHeader30, columnHeader31, columnHeader32, columnHeader33 });
            lvLevelItems.Dock = DockStyle.Fill;
            lvLevelItems.FullRowSelect = true;
            lvLevelItems.Location = new Point(3, 3);
            lvLevelItems.Name = "lvLevelItems";
            lvLevelItems.Size = new Size(968, 501);
            lvLevelItems.TabIndex = 0;
            lvLevelItems.UseCompatibleStateImageBehavior = false;
            lvLevelItems.View = View.Details;
            // 
            // columnHeader28
            // 
            columnHeader28.Text = "Exists";
            columnHeader28.Width = 40;
            // 
            // columnHeader29
            // 
            columnHeader29.Text = "Name";
            columnHeader29.Width = 200;
            // 
            // columnHeader30
            // 
            columnHeader30.Text = "Item";
            columnHeader30.Width = 200;
            // 
            // columnHeader31
            // 
            columnHeader31.Text = "Level";
            columnHeader31.Width = 200;
            // 
            // columnHeader32
            // 
            columnHeader32.Text = "Count";
            // 
            // columnHeader33
            // 
            columnHeader33.Text = "Navpoint";
            columnHeader33.Width = 200;
            // 
            // tabPageConversations
            // 
            tabPageConversations.Controls.Add(tvConversations);
            tabPageConversations.Location = new Point(4, 24);
            tabPageConversations.Name = "tabPageConversations";
            tabPageConversations.Padding = new Padding(3);
            tabPageConversations.Size = new Size(974, 507);
            tabPageConversations.TabIndex = 12;
            tabPageConversations.Text = "Conversations";
            tabPageConversations.UseVisualStyleBackColor = true;
            // 
            // tvConversations
            // 
            tvConversations.Location = new Point(6, 6);
            tvConversations.Name = "tvConversations";
            tvConversations.Size = new Size(467, 493);
            tvConversations.TabIndex = 0;
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
            menuStrip1.Size = new Size(982, 24);
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
            ClientSize = new Size(982, 559);
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
            ((System.ComponentModel.ISupportInitialize)numEntityLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntityBaseHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntityCurrentHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntityBaseAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntityCurrentAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntityPosZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntityPosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEntityPosX).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)numJeSkillPoints).EndInit();
            tableLayoutPanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numJeSkillValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJePosX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJePosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJePosZ).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)numRoSkillPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoPosX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoPosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRoPosZ).EndInit();
            tabPageFlece.ResumeLayout(false);
            tblFlece.ResumeLayout(false);
            tblFlece.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numFlSkillValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlBaseAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlBaseHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlSkillPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlCurrentHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlCurrentAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlPosX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlPosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFlPosZ).EndInit();
            tabPageJoseph.ResumeLayout(false);
            tblJoseph.ResumeLayout(false);
            tblJoseph.PerformLayout();
            tableLayoutPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numJoSkillValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoSkillPoints).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoBaseHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoCurrentAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoCurrentHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoBaseAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoPosX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoPosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numJoPosZ).EndInit();
            tabPageStart.ResumeLayout(false);
            tableLayoutPanel11.ResumeLayout(false);
            tableLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgPreview).EndInit();
            tabMain.ResumeLayout(false);
            tabPageSummon.ResumeLayout(false);
            tblSummon.ResumeLayout(false);
            tblSummon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numSuCurrentHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSuCurrentAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSuSpeed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSuBaseAP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSuBaseHP).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSuLevel).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSuExperience).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSuSkillPoints).EndInit();
            tableLayoutPanel19.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numSuSkillValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSuPosX).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSuPosY).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSuPosZ).EndInit();
            tabPageContainer.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel12.ResumeLayout(false);
            tableLayoutPanel12.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numContainerPosY).EndInit();
            tableLayoutPanel17.ResumeLayout(false);
            tableLayoutPanel17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGoldPileAmount).EndInit();
            tableLayoutPanel16.ResumeLayout(false);
            tableLayoutPanel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGoldPilePosZ).EndInit();
            tableLayoutPanel15.ResumeLayout(false);
            tableLayoutPanel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGoldPilePosY).EndInit();
            tableLayoutPanel14.ResumeLayout(false);
            tableLayoutPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numGoldPilePosX).EndInit();
            tableLayoutPanel13.ResumeLayout(false);
            tableLayoutPanel13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numContainerPosZ).EndInit();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numContainerPosX).EndInit();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numContainerItemQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)numContainerItemCharges).EndInit();
            tabPageQuests.ResumeLayout(false);
            tabPageQuests.PerformLayout();
            tabPageLevelItems.ResumeLayout(false);
            tabPageConversations.ResumeLayout(false);
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
        private NumericUpDown numEntityLevel;
        private Button btnMaxOtherLevel;
        private Label LabelOtherMaxHP;
        private Button btnMaxOther;
        private NumericUpDown numEntityBaseHP;
        private Button btnMaxOtherCurrentAP;
        private Button btnMaxOtherBaseHP;
        private Button btnMaxOtherBaseAP;
        private Label LabelOtherCurrHP;
        private NumericUpDown numEntityCurrentAP;
        private NumericUpDown numEntityCurrentHP;
        private Label LabelOtherCurrAP;
        private Button btnMaxOtherCurrentHP;
        private Label LabelOtherMaxAP;
        private NumericUpDown numEntityBaseAP;
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
        private NumericUpDown numJeSkillPoints;
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
        private NumericUpDown numRoSkillPoints;
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
        private NumericUpDown numFlSkillPoints;
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
        private NumericUpDown numJoSkillPoints;
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
        private ListView lvGoldPiles;
        private ColumnHeader columnHeader22;
        private ColumnHeader columnHeader23;
        private Button btnModifyGoldPile;
        private Button btnRemoveGoldPile;
        private Button btnAddGoldPile;
        private TableLayoutPanel tableLayoutPanel6;
        private Label lblGoldPiles;
        private TableLayoutPanel tableLayoutPanel12;
        private TableLayoutPanel tableLayoutPanel16;
        private Label label27;
        private NumericUpDown numGoldPilePosZ;
        private TableLayoutPanel tableLayoutPanel15;
        private Label label26;
        private NumericUpDown numGoldPilePosY;
        private TableLayoutPanel tableLayoutPanel14;
        private Label label25;
        private NumericUpDown numGoldPilePosX;
        private TableLayoutPanel tableLayoutPanel13;
        private TableLayoutPanel tableLayoutPanel17;
        private Label label28;
        private NumericUpDown numGoldPileAmount;
        private Label lblContainerGameItems;
        private TabPage tabPageSummon;
        private TableLayoutPanel tblSummon;
        private Label lblSuAmulet;
        private Label lblSuRing1;
        private Label lblSuRing2;
        private Label lblSuGauntlets;
        private Label lblSuWeapon;
        private Label lblSuShield;
        private Label lblSuBoots;
        private Label lblSuTorso;
        private Label lblSuCurrentHP;
        private ComboBox cbSuLeggings;
        private ComboBox cbSuTorso;
        private ComboBox cbSuBoots;
        private ComboBox cbSuShield;
        private ComboBox cbSuWeapon;
        private ComboBox cbSuGauntlets;
        private ComboBox cbSuRing2;
        private ComboBox cbSuRing1;
        private ComboBox cbSuAmulet;
        private NumericUpDown numSuCurrentHP;
        private Button btnSuMaxCurrentHP;
        private Label lblSuCurrentAP;
        private NumericUpDown numSuCurrentAP;
        private Button btnSuMaxCurrentAP;
        private Label lblSuSpeed;
        private NumericUpDown numSuSpeed;
        private Button btnSuMaxSpeed;
        private Label lblSuLeggings;
        private Button btnSuMaxAll;
        private Button btnSuMaxBaseAP;
        private NumericUpDown numSuBaseAP;
        private Button btnSuMaxBaseHP;
        private Label lblSuBaseAP;
        private NumericUpDown numSuBaseHP;
        private NumericUpDown numSuLevel;
        private Label lblSuBaseHP;
        private NumericUpDown numSuExperience;
        private Label lblSuSkillPoints;
        private Button btnSuMaxLevel;
        private Label lblSuLevel;
        private Label lblSuExperience;
        private Button btnSuMaxExp;
        private NumericUpDown numSuSkillPoints;
        private Button btnSuMaxSkill;
        private ListView lvSummonSkills;
        private ColumnHeader columnHeader24;
        private ColumnHeader columnHeader25;
        private TableLayoutPanel tableLayoutPanel19;
        private NumericUpDown numSuSkillValue;
        private Button btnSuUpdateSkill;
        private Label label29;
        private Label lblCreatureStatus;
        private ColumnHeader columnHeader26;
        private TabPage tabPageQuests;
        private ListView lvQuestList;
        private ColumnHeader columnHeader27;
        private Label lblOtherPosX;
        private NumericUpDown numEntityPosX;
        private Label lblOtherPosY;
        private NumericUpDown numEntityPosY;
        private NumericUpDown numEntityPosZ;
        private Label lblOtherPosZ;
        private Label label30;
        private Label label31;
        private Label lblJoPosX;
        private Label lblJoPosY;
        private Label lblJoPosZ;
        private NumericUpDown numJoPosX;
        private NumericUpDown numJoPosY;
        private NumericUpDown numJoPosZ;
        private NumericUpDown numJePosX;
        private NumericUpDown numJePosY;
        private NumericUpDown numJePosZ;
        private Label lblJePosition;
        private Label lblJePosX;
        private Label lblJePosY;
        private Label lblJePosZ;
        private NumericUpDown numRoPosX;
        private NumericUpDown numRoPosY;
        private NumericUpDown numRoPosZ;
        private Label lblRoPosition;
        private Label lblRoPosX;
        private Label lblRoPosY;
        private Label lblRoPosZ;
        private NumericUpDown numFlPosX;
        private NumericUpDown numFlPosY;
        private NumericUpDown numFlPosZ;
        private Label label32;
        private Label lblFlPosX;
        private Label lblFlPosY;
        private Label lblFlPosZ;
        private NumericUpDown numSuPosY;
        private NumericUpDown numSuPosZ;
        private Label lblSuPosition;
        private Label lblSuPosX;
        private Label lblSuPosY;
        private Label lblSuPosZ;
        private NumericUpDown numSuPosX;
        private TabPage tabPageLevelItems;
        private ListView lvLevelItems;
        private ColumnHeader columnHeader28;
        private ColumnHeader columnHeader29;
        private ColumnHeader columnHeader30;
        private ColumnHeader columnHeader31;
        private ColumnHeader columnHeader32;
        private ColumnHeader columnHeader33;
        private TabPage tabPageConversations;
        private TreeView tvConversations;
        private Label label33;
    }
}