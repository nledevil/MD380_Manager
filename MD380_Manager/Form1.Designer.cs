using System.Collections.Generic;

namespace MD380_Manager
{
    partial class Form1
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewComboBoxColumn gridViewComboBoxColumn2 = new Telerik.WinControls.UI.GridViewComboBoxColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCheckBoxColumn gridViewCheckBoxColumn2 = new Telerik.WinControls.UI.GridViewCheckBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.TableViewDefinition tableViewDefinition2 = new Telerik.WinControls.UI.TableViewDefinition();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ddlBscFreqRange = new System.Windows.Forms.ComboBox();
            this.lblUniqueDeviceID = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblMCUVer = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblHardwareVer = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCPSVersion = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSerial = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblLastProgDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage8 = new System.Windows.Forms.TabPage();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.cmboGnIntroScreen = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtGnIntroLine2 = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtGnIntroLine1 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.chkGnDisableLEDs = new System.Windows.Forms.CheckBox();
            this.cmboGnKeypadLockTime = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.cmboGnBackltTime = new System.Windows.Forms.ComboBox();
            this.label32 = new System.Windows.Forms.Label();
            this.txtGnRadioPrgPassword = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.txtGnPCPrgPassword = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.numGnRXLowBatInt = new System.Windows.Forms.NumericUpDown();
            this.numGnTXPreambleDur = new System.Windows.Forms.NumericUpDown();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cmboGnVOXSnstvty = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cmboGnMonType = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtGnRadioID = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtGnRadioName = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.numGnPrvCallHngTime = new System.Windows.Forms.NumericUpDown();
            this.numGnGrpCallHngTime = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.txtGnPowerOnPassword = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkGnPasswordLockEnable = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.numLnWrkrRemTime = new System.Windows.Forms.NumericUpDown();
            this.numGnLnWrkrRespTime = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.numAnlgHngTime = new System.Windows.Forms.NumericUpDown();
            this.numGnDigHngTime = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.numericCallToneAlertDurationUpDown1 = new MD380_Manager.NumericCallToneAlertDurationUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.cmboGnTalkPermTone = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.chkGnDisableAllTone = new System.Windows.Forms.CheckBox();
            this.chkGnCHFreeIndTone = new System.Windows.Forms.CheckBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkGnSaveModeRec = new System.Windows.Forms.CheckBox();
            this.chkGnSavePreamble = new System.Windows.Forms.CheckBox();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.numericMenuHangTimeUpDown1 = new MD380_Manager.CustomControls.NumericMenuHangTimeUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkMnuEditList = new System.Windows.Forms.CheckBox();
            this.chkMnuScan = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkMnuPrgRadio = new System.Windows.Forms.CheckBox();
            this.chkMnuDisplayMode = new System.Windows.Forms.CheckBox();
            this.chkMnuVOX = new System.Windows.Forms.CheckBox();
            this.chkMnuPasswordLock = new System.Windows.Forms.CheckBox();
            this.chkMnuSquelch = new System.Windows.Forms.CheckBox();
            this.chkMnuLEDInd = new System.Windows.Forms.CheckBox();
            this.chkMnuKeyboardLock = new System.Windows.Forms.CheckBox();
            this.chkMnuIntroScreen = new System.Windows.Forms.CheckBox();
            this.chkMnuBacklight = new System.Windows.Forms.CheckBox();
            this.chkMnuPower = new System.Windows.Forms.CheckBox();
            this.chkMnuToneAlert = new System.Windows.Forms.CheckBox();
            this.chkMnuTalkaround = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.chkMnuAnswered = new System.Windows.Forms.CheckBox();
            this.chkMnuOutgoingRadio = new System.Windows.Forms.CheckBox();
            this.chkMnuMissed = new System.Windows.Forms.CheckBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkMnuRadioDisable = new System.Windows.Forms.CheckBox();
            this.chkMnuRadioEnable = new System.Windows.Forms.CheckBox();
            this.chkMnuPrgKey = new System.Windows.Forms.CheckBox();
            this.chkMnuRemMon = new System.Windows.Forms.CheckBox();
            this.chkMnuRadioCheck = new System.Windows.Forms.CheckBox();
            this.chkMnuManDial = new System.Windows.Forms.CheckBox();
            this.chkMnuEdit = new System.Windows.Forms.CheckBox();
            this.chkMnuCallAlert = new System.Windows.Forms.CheckBox();
            this.chkMnuTextMessage = new System.Windows.Forms.CheckBox();
            this.lblMenuHangTime = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radGridContacts = new Telerik.WinControls.UI.RadGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnGrpLstMoveDown = new System.Windows.Forms.Button();
            this.btnGrpLstMoveUp = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGrpLstRemove = new System.Windows.Forms.Button();
            this.txtGroupListName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGrpLstAdd = new System.Windows.Forms.Button();
            this.btnGrpAssnMoveDown = new System.Windows.Forms.Button();
            this.btnGrpAssnMoveUp = new System.Windows.Forms.Button();
            this.lstGrpAssn = new System.Windows.Forms.ListBox();
            this.lstGrpAvail = new System.Windows.Forms.ListBox();
            this.lstGroupList = new System.Windows.Forms.ListBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.btnZnRemove = new System.Windows.Forms.Button();
            this.txtZnName = new System.Windows.Forms.TextBox();
            this.label33 = new System.Windows.Forms.Label();
            this.btnZnAdd = new System.Windows.Forms.Button();
            this.btnZnAssnMvUp = new System.Windows.Forms.Button();
            this.btnZnAssnMvDwn = new System.Windows.Forms.Button();
            this.lstZnChanAssigned = new System.Windows.Forms.ListBox();
            this.lstZnChanAvail = new System.Windows.Forms.ListBox();
            this.btnZnMvDwn = new System.Windows.Forms.Button();
            this.btnZnMvUp = new System.Windows.Forms.Button();
            this.lstZones = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnScnMvDwn = new System.Windows.Forms.Button();
            this.btnScnMvUp = new System.Windows.Forms.Button();
            this.lstScanLists = new System.Windows.Forms.ListBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.cmboSLSampleTime = new System.Windows.Forms.ComboBox();
            this.label65 = new System.Windows.Forms.Label();
            this.cmboSLSignalingHoldTime = new System.Windows.Forms.ComboBox();
            this.label63 = new System.Windows.Forms.Label();
            this.cmboSLTXCH = new System.Windows.Forms.ComboBox();
            this.label64 = new System.Windows.Forms.Label();
            this.cmboSLPriorityB = new System.Windows.Forms.ComboBox();
            this.label61 = new System.Windows.Forms.Label();
            this.cmboSLPriorityA = new System.Windows.Forms.ComboBox();
            this.label62 = new System.Windows.Forms.Label();
            this.btnScnChanMvUp = new System.Windows.Forms.Button();
            this.btnScnChanMvDwn = new System.Windows.Forms.Button();
            this.btnScnRemove = new System.Windows.Forms.Button();
            this.txtScnName = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btnScnAdd = new System.Windows.Forms.Button();
            this.lstScnChanAssn = new System.Windows.Forms.ListBox();
            this.lstScnChanAvail = new System.Windows.Forms.ListBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox20 = new System.Windows.Forms.GroupBox();
            this.cmboCHPrivacyNo = new System.Windows.Forms.ComboBox();
            this.label54 = new System.Windows.Forms.Label();
            this.cmboCHPrivacy = new System.Windows.Forms.ComboBox();
            this.label55 = new System.Windows.Forms.Label();
            this.chkCHCompUDP = new System.Windows.Forms.CheckBox();
            this.cmboCHTS = new System.Windows.Forms.ComboBox();
            this.chkCHDataCallConf = new System.Windows.Forms.CheckBox();
            this.label56 = new System.Windows.Forms.Label();
            this.chkCHEmgcyAlrmAck = new System.Windows.Forms.CheckBox();
            this.cmboCHColorCode = new System.Windows.Forms.ComboBox();
            this.chkCHPrivCallConf = new System.Windows.Forms.CheckBox();
            this.label57 = new System.Windows.Forms.Label();
            this.cmboCHGroupList = new System.Windows.Forms.ComboBox();
            this.label58 = new System.Windows.Forms.Label();
            this.cmboCHContactName = new System.Windows.Forms.ComboBox();
            this.label59 = new System.Windows.Forms.Label();
            this.cmboCHEmgcySys = new System.Windows.Forms.ComboBox();
            this.label60 = new System.Windows.Forms.Label();
            this.groupBox19 = new System.Windows.Forms.GroupBox();
            this.chkCHDecode4 = new System.Windows.Forms.CheckBox();
            this.chkCHDecode3 = new System.Windows.Forms.CheckBox();
            this.chkCHDecode2 = new System.Windows.Forms.CheckBox();
            this.chkCHDecode1 = new System.Windows.Forms.CheckBox();
            this.chkCHDecode8 = new System.Windows.Forms.CheckBox();
            this.chkCHDecode7 = new System.Windows.Forms.CheckBox();
            this.chkCHDecode6 = new System.Windows.Forms.CheckBox();
            this.chkCHDecode5 = new System.Windows.Forms.CheckBox();
            this.chkCHReverseBurst = new System.Windows.Forms.CheckBox();
            this.label53 = new System.Windows.Forms.Label();
            this.chkCHDisablePTTID = new System.Windows.Forms.CheckBox();
            this.cmboCHTXSignaling = new System.Windows.Forms.ComboBox();
            this.label39 = new System.Windows.Forms.Label();
            this.cmboCHRXSignaling = new System.Windows.Forms.ComboBox();
            this.label49 = new System.Windows.Forms.Label();
            this.cmboCHQTReverse = new System.Windows.Forms.ComboBox();
            this.label50 = new System.Windows.Forms.Label();
            this.cmboCHCTCSSEnc = new System.Windows.Forms.ComboBox();
            this.label51 = new System.Windows.Forms.Label();
            this.cmboCHCTCSSDec = new System.Windows.Forms.ComboBox();
            this.label52 = new System.Windows.Forms.Label();
            this.groupBox18 = new System.Windows.Forms.GroupBox();
            this.txtCHTXFreq = new System.Windows.Forms.TextBox();
            this.txtCHRXFreq = new System.Windows.Forms.TextBox();
            this.txtCHChannelName = new System.Windows.Forms.TextBox();
            this.chkCHAlwTalkaround = new System.Windows.Forms.CheckBox();
            this.chkCHVOX = new System.Windows.Forms.CheckBox();
            this.chkCHLoneWorker = new System.Windows.Forms.CheckBox();
            this.chkCHRXOnly = new System.Windows.Forms.CheckBox();
            this.chkCHAutoScan = new System.Windows.Forms.CheckBox();
            this.cmboCHAdmitCriteria = new System.Windows.Forms.ComboBox();
            this.label48 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.cmboCHPower = new System.Windows.Forms.ComboBox();
            this.label46 = new System.Windows.Forms.Label();
            this.cmboCHTOTRekeyDelay = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.cmboCHTOT = new System.Windows.Forms.ComboBox();
            this.label40 = new System.Windows.Forms.Label();
            this.cmboCHTXRefFreq = new System.Windows.Forms.ComboBox();
            this.label41 = new System.Windows.Forms.Label();
            this.cmboCHRXRefFreq = new System.Windows.Forms.ComboBox();
            this.label42 = new System.Windows.Forms.Label();
            this.cmboCHSquelch = new System.Windows.Forms.ComboBox();
            this.label37 = new System.Windows.Forms.Label();
            this.cmboCHScanList = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.cmboCHBandwidth = new System.Windows.Forms.ComboBox();
            this.label36 = new System.Windows.Forms.Label();
            this.cmboCHChannelMode = new System.Windows.Forms.ComboBox();
            this.label35 = new System.Windows.Forms.Label();
            this.btnCHMvDwn = new System.Windows.Forms.Button();
            this.btnCHMvUp = new System.Windows.Forms.Button();
            this.lstChannels = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage8.SuspendLayout();
            this.groupBox15.SuspendLayout();
            this.groupBox14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGnRXLowBatInt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGnTXPreambleDur)).BeginInit();
            this.groupBox13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGnPrvCallHngTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGnGrpCallHngTime)).BeginInit();
            this.groupBox12.SuspendLayout();
            this.groupBox11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numLnWrkrRemTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGnLnWrkrRespTime)).BeginInit();
            this.groupBox10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnlgHngTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGnDigHngTime)).BeginInit();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericCallToneAlertDurationUpDown1)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.tabPage7.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMenuHangTimeUpDown1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radGridContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridContacts.MasterTemplate)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox16.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox17.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox20.SuspendLayout();
            this.groupBox19.SuspendLayout();
            this.groupBox18.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage8);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(812, 600);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.groupBox2);
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(804, 571);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Basic Info";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ddlBscFreqRange);
            this.groupBox2.Controls.Add(this.lblUniqueDeviceID);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblMCUVer);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblHardwareVer);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.lblCPSVersion);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.lblSerial);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblModel);
            this.groupBox2.Controls.Add(this.lblLastProgDate);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(3, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(351, 210);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Basic Info";
            // 
            // ddlBscFreqRange
            // 
            this.ddlBscFreqRange.FormattingEnabled = true;
            this.ddlBscFreqRange.Location = new System.Drawing.Point(145, 21);
            this.ddlBscFreqRange.Name = "ddlBscFreqRange";
            this.ddlBscFreqRange.Size = new System.Drawing.Size(192, 21);
            this.ddlBscFreqRange.TabIndex = 32;
            this.ddlBscFreqRange.SelectedIndexChanged += new System.EventHandler(this.ddlBscFreqRange_SelectedIndexChanged);
            // 
            // lblUniqueDeviceID
            // 
            this.lblUniqueDeviceID.Location = new System.Drawing.Point(144, 181);
            this.lblUniqueDeviceID.Name = "lblUniqueDeviceID";
            this.lblUniqueDeviceID.Size = new System.Drawing.Size(193, 23);
            this.lblUniqueDeviceID.TabIndex = 31;
            this.lblUniqueDeviceID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 181);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 23);
            this.label14.TabIndex = 30;
            this.label14.Text = "Unique Device ID:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMCUVer
            // 
            this.lblMCUVer.Location = new System.Drawing.Point(144, 158);
            this.lblMCUVer.Name = "lblMCUVer";
            this.lblMCUVer.Size = new System.Drawing.Size(193, 23);
            this.lblMCUVer.TabIndex = 29;
            this.lblMCUVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 158);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(132, 23);
            this.label12.TabIndex = 28;
            this.label12.Text = "MCU Version:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHardwareVer
            // 
            this.lblHardwareVer.Location = new System.Drawing.Point(144, 135);
            this.lblHardwareVer.Name = "lblHardwareVer";
            this.lblHardwareVer.Size = new System.Drawing.Size(193, 23);
            this.lblHardwareVer.TabIndex = 27;
            this.lblHardwareVer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 23);
            this.label10.TabIndex = 26;
            this.label10.Text = "Hardware Version:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCPSVersion
            // 
            this.lblCPSVersion.Location = new System.Drawing.Point(144, 112);
            this.lblCPSVersion.Name = "lblCPSVersion";
            this.lblCPSVersion.Size = new System.Drawing.Size(193, 23);
            this.lblCPSVersion.TabIndex = 25;
            this.lblCPSVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 23);
            this.label8.TabIndex = 24;
            this.label8.Text = "CPS Version:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSerial
            // 
            this.lblSerial.Location = new System.Drawing.Point(144, 89);
            this.lblSerial.Name = "lblSerial";
            this.lblSerial.Size = new System.Drawing.Size(193, 23);
            this.lblSerial.TabIndex = 23;
            this.lblSerial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Serial:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblModel
            // 
            this.lblModel.Location = new System.Drawing.Point(144, 66);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(193, 23);
            this.lblModel.TabIndex = 21;
            this.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastProgDate
            // 
            this.lblLastProgDate.Location = new System.Drawing.Point(144, 43);
            this.lblLastProgDate.Name = "lblLastProgDate";
            this.lblLastProgDate.Size = new System.Drawing.Size(193, 23);
            this.lblLastProgDate.TabIndex = 20;
            this.lblLastProgDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 23);
            this.label4.TabIndex = 18;
            this.label4.Text = "Model:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 17;
            this.label3.Text = "Last Programming Date:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 16;
            this.label2.Text = "Frequency Range:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage8
            // 
            this.tabPage8.Controls.Add(this.groupBox15);
            this.tabPage8.Controls.Add(this.groupBox14);
            this.tabPage8.Controls.Add(this.groupBox13);
            this.tabPage8.Controls.Add(this.groupBox12);
            this.tabPage8.Controls.Add(this.groupBox11);
            this.tabPage8.Controls.Add(this.groupBox10);
            this.tabPage8.Controls.Add(this.groupBox9);
            this.tabPage8.Controls.Add(this.groupBox8);
            this.tabPage8.Location = new System.Drawing.Point(4, 25);
            this.tabPage8.Name = "tabPage8";
            this.tabPage8.Size = new System.Drawing.Size(804, 571);
            this.tabPage8.TabIndex = 7;
            this.tabPage8.Text = "General Settings";
            this.tabPage8.UseVisualStyleBackColor = true;
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.cmboGnIntroScreen);
            this.groupBox15.Controls.Add(this.label22);
            this.groupBox15.Controls.Add(this.txtGnIntroLine2);
            this.groupBox15.Controls.Add(this.label21);
            this.groupBox15.Controls.Add(this.txtGnIntroLine1);
            this.groupBox15.Controls.Add(this.label20);
            this.groupBox15.Location = new System.Drawing.Point(362, 300);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(347, 114);
            this.groupBox15.TabIndex = 7;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Intro Screen";
            // 
            // cmboGnIntroScreen
            // 
            this.cmboGnIntroScreen.FormattingEnabled = true;
            this.cmboGnIntroScreen.Items.AddRange(new object[] {
            "Picture",
            "Characters"});
            this.cmboGnIntroScreen.Location = new System.Drawing.Point(206, 30);
            this.cmboGnIntroScreen.Name = "cmboGnIntroScreen";
            this.cmboGnIntroScreen.Size = new System.Drawing.Size(121, 21);
            this.cmboGnIntroScreen.TabIndex = 28;
            this.cmboGnIntroScreen.SelectedIndexChanged += new System.EventHandler(this.cmboGnIntroScreen_SelectedIndexChanged);
            // 
            // label22
            // 
            this.label22.Location = new System.Drawing.Point(6, 28);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(194, 23);
            this.label22.TabIndex = 27;
            this.label22.Text = "Intro Screen";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGnIntroLine2
            // 
            this.txtGnIntroLine2.Enabled = false;
            this.txtGnIntroLine2.Location = new System.Drawing.Point(206, 78);
            this.txtGnIntroLine2.Name = "txtGnIntroLine2";
            this.txtGnIntroLine2.Size = new System.Drawing.Size(121, 20);
            this.txtGnIntroLine2.TabIndex = 26;
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(6, 76);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(194, 23);
            this.label21.TabIndex = 25;
            this.label21.Text = "Intro Screen Line 2";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGnIntroLine1
            // 
            this.txtGnIntroLine1.Enabled = false;
            this.txtGnIntroLine1.Location = new System.Drawing.Point(206, 53);
            this.txtGnIntroLine1.Name = "txtGnIntroLine1";
            this.txtGnIntroLine1.Size = new System.Drawing.Size(121, 20);
            this.txtGnIntroLine1.TabIndex = 24;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(6, 51);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(194, 23);
            this.label20.TabIndex = 23;
            this.label20.Text = "Intro Screen Line 1";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.chkGnDisableLEDs);
            this.groupBox14.Controls.Add(this.cmboGnKeypadLockTime);
            this.groupBox14.Controls.Add(this.label31);
            this.groupBox14.Controls.Add(this.cmboGnBackltTime);
            this.groupBox14.Controls.Add(this.label32);
            this.groupBox14.Controls.Add(this.txtGnRadioPrgPassword);
            this.groupBox14.Controls.Add(this.label30);
            this.groupBox14.Controls.Add(this.txtGnPCPrgPassword);
            this.groupBox14.Controls.Add(this.label29);
            this.groupBox14.Controls.Add(this.numGnRXLowBatInt);
            this.groupBox14.Controls.Add(this.numGnTXPreambleDur);
            this.groupBox14.Controls.Add(this.label27);
            this.groupBox14.Controls.Add(this.label28);
            this.groupBox14.Controls.Add(this.cmboGnVOXSnstvty);
            this.groupBox14.Controls.Add(this.label26);
            this.groupBox14.Controls.Add(this.cmboGnMonType);
            this.groupBox14.Controls.Add(this.label25);
            this.groupBox14.Controls.Add(this.txtGnRadioID);
            this.groupBox14.Controls.Add(this.label23);
            this.groupBox14.Controls.Add(this.txtGnRadioName);
            this.groupBox14.Controls.Add(this.label24);
            this.groupBox14.Location = new System.Drawing.Point(362, 4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Size = new System.Drawing.Size(347, 290);
            this.groupBox14.TabIndex = 6;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "General";
            // 
            // chkGnDisableLEDs
            // 
            this.chkGnDisableLEDs.Location = new System.Drawing.Point(63, 260);
            this.chkGnDisableLEDs.Name = "chkGnDisableLEDs";
            this.chkGnDisableLEDs.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkGnDisableLEDs.Size = new System.Drawing.Size(156, 24);
            this.chkGnDisableLEDs.TabIndex = 47;
            this.chkGnDisableLEDs.Text = "Disable All LEDs";
            this.chkGnDisableLEDs.UseVisualStyleBackColor = true;
            // 
            // cmboGnKeypadLockTime
            // 
            this.cmboGnKeypadLockTime.FormattingEnabled = true;
            this.cmboGnKeypadLockTime.Items.AddRange(new object[] {
            "Manual",
            "5",
            "10",
            "15"});
            this.cmboGnKeypadLockTime.Location = new System.Drawing.Point(206, 233);
            this.cmboGnKeypadLockTime.Name = "cmboGnKeypadLockTime";
            this.cmboGnKeypadLockTime.Size = new System.Drawing.Size(121, 21);
            this.cmboGnKeypadLockTime.TabIndex = 46;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(6, 231);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(194, 23);
            this.label31.TabIndex = 45;
            this.label31.Text = "Set Keypad Lock Time(s)";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboGnBackltTime
            // 
            this.cmboGnBackltTime.FormattingEnabled = true;
            this.cmboGnBackltTime.Items.AddRange(new object[] {
            "Always",
            "5",
            "10",
            "15"});
            this.cmboGnBackltTime.Location = new System.Drawing.Point(206, 210);
            this.cmboGnBackltTime.Name = "cmboGnBackltTime";
            this.cmboGnBackltTime.Size = new System.Drawing.Size(121, 21);
            this.cmboGnBackltTime.TabIndex = 44;
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(6, 208);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(194, 23);
            this.label32.TabIndex = 43;
            this.label32.Text = "Backlight Time(s)";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGnRadioPrgPassword
            // 
            this.txtGnRadioPrgPassword.Location = new System.Drawing.Point(206, 187);
            this.txtGnRadioPrgPassword.Name = "txtGnRadioPrgPassword";
            this.txtGnRadioPrgPassword.Size = new System.Drawing.Size(121, 20);
            this.txtGnRadioPrgPassword.TabIndex = 42;
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(6, 185);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(194, 23);
            this.label30.TabIndex = 41;
            this.label30.Text = "Radio Program Password";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGnPCPrgPassword
            // 
            this.txtGnPCPrgPassword.Location = new System.Drawing.Point(206, 164);
            this.txtGnPCPrgPassword.Name = "txtGnPCPrgPassword";
            this.txtGnPCPrgPassword.Size = new System.Drawing.Size(121, 20);
            this.txtGnPCPrgPassword.TabIndex = 40;
            // 
            // label29
            // 
            this.label29.Location = new System.Drawing.Point(6, 162);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(194, 23);
            this.label29.TabIndex = 39;
            this.label29.Text = "PC Programming Password";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // numGnRXLowBatInt
            // 
            this.numGnRXLowBatInt.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numGnRXLowBatInt.Location = new System.Drawing.Point(206, 139);
            this.numGnRXLowBatInt.Maximum = new decimal(new int[] {
            635,
            0,
            0,
            0});
            this.numGnRXLowBatInt.Name = "numGnRXLowBatInt";
            this.numGnRXLowBatInt.Size = new System.Drawing.Size(121, 20);
            this.numGnRXLowBatInt.TabIndex = 38;
            this.numGnRXLowBatInt.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // numGnTXPreambleDur
            // 
            this.numGnTXPreambleDur.Increment = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numGnTXPreambleDur.Location = new System.Drawing.Point(206, 113);
            this.numGnTXPreambleDur.Maximum = new decimal(new int[] {
            86240,
            0,
            0,
            0});
            this.numGnTXPreambleDur.Name = "numGnTXPreambleDur";
            this.numGnTXPreambleDur.Size = new System.Drawing.Size(121, 20);
            this.numGnTXPreambleDur.TabIndex = 37;
            this.numGnTXPreambleDur.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            // 
            // label27
            // 
            this.label27.Location = new System.Drawing.Point(6, 134);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(194, 23);
            this.label27.TabIndex = 36;
            this.label27.Text = "RX Low Battery Intervals(s)";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label28
            // 
            this.label28.Location = new System.Drawing.Point(6, 111);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(194, 23);
            this.label28.TabIndex = 35;
            this.label28.Text = "TX Preamble Duration(ms)";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboGnVOXSnstvty
            // 
            this.cmboGnVOXSnstvty.FormattingEnabled = true;
            this.cmboGnVOXSnstvty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmboGnVOXSnstvty.Location = new System.Drawing.Point(206, 90);
            this.cmboGnVOXSnstvty.Name = "cmboGnVOXSnstvty";
            this.cmboGnVOXSnstvty.Size = new System.Drawing.Size(121, 21);
            this.cmboGnVOXSnstvty.TabIndex = 34;
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(6, 88);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(194, 23);
            this.label26.TabIndex = 33;
            this.label26.Text = "VOX Sensitivity";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboGnMonType
            // 
            this.cmboGnMonType.FormattingEnabled = true;
            this.cmboGnMonType.Items.AddRange(new object[] {
            "Silent",
            "Open Squelch"});
            this.cmboGnMonType.Location = new System.Drawing.Point(206, 67);
            this.cmboGnMonType.Name = "cmboGnMonType";
            this.cmboGnMonType.Size = new System.Drawing.Size(121, 21);
            this.cmboGnMonType.TabIndex = 32;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(6, 65);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(194, 23);
            this.label25.TabIndex = 31;
            this.label25.Text = "Monitor Type";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGnRadioID
            // 
            this.txtGnRadioID.Location = new System.Drawing.Point(206, 44);
            this.txtGnRadioID.Name = "txtGnRadioID";
            this.txtGnRadioID.Size = new System.Drawing.Size(121, 20);
            this.txtGnRadioID.TabIndex = 30;
            // 
            // label23
            // 
            this.label23.Location = new System.Drawing.Point(6, 42);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(194, 23);
            this.label23.TabIndex = 29;
            this.label23.Text = "Radio ID";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtGnRadioName
            // 
            this.txtGnRadioName.Location = new System.Drawing.Point(206, 19);
            this.txtGnRadioName.Name = "txtGnRadioName";
            this.txtGnRadioName.Size = new System.Drawing.Size(121, 20);
            this.txtGnRadioName.TabIndex = 28;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(6, 17);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(194, 23);
            this.label24.TabIndex = 27;
            this.label24.Text = "Radio Name";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.numGnPrvCallHngTime);
            this.groupBox13.Controls.Add(this.numGnGrpCallHngTime);
            this.groupBox13.Controls.Add(this.label18);
            this.groupBox13.Controls.Add(this.label19);
            this.groupBox13.Location = new System.Drawing.Point(9, 420);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Size = new System.Drawing.Size(346, 74);
            this.groupBox13.TabIndex = 5;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Talkaround";
            // 
            // numGnPrvCallHngTime
            // 
            this.numGnPrvCallHngTime.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numGnPrvCallHngTime.Location = new System.Drawing.Point(207, 42);
            this.numGnPrvCallHngTime.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.numGnPrvCallHngTime.Name = "numGnPrvCallHngTime";
            this.numGnPrvCallHngTime.Size = new System.Drawing.Size(121, 20);
            this.numGnPrvCallHngTime.TabIndex = 24;
            this.numGnPrvCallHngTime.Value = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            // 
            // numGnGrpCallHngTime
            // 
            this.numGnGrpCallHngTime.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numGnGrpCallHngTime.Location = new System.Drawing.Point(207, 19);
            this.numGnGrpCallHngTime.Maximum = new decimal(new int[] {
            7000,
            0,
            0,
            0});
            this.numGnGrpCallHngTime.Name = "numGnGrpCallHngTime";
            this.numGnGrpCallHngTime.Size = new System.Drawing.Size(121, 20);
            this.numGnGrpCallHngTime.TabIndex = 23;
            this.numGnGrpCallHngTime.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(6, 39);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(194, 23);
            this.label18.TabIndex = 20;
            this.label18.Text = "Private Call Hang Time(ms)";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(6, 16);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(195, 23);
            this.label19.TabIndex = 18;
            this.label19.Text = "Group Call Hang Time(ms)";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.txtGnPowerOnPassword);
            this.groupBox12.Controls.Add(this.label17);
            this.groupBox12.Controls.Add(this.chkGnPasswordLockEnable);
            this.groupBox12.Location = new System.Drawing.Point(9, 335);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(346, 79);
            this.groupBox12.TabIndex = 4;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Power On Password";
            // 
            // txtGnPowerOnPassword
            // 
            this.txtGnPowerOnPassword.Enabled = false;
            this.txtGnPowerOnPassword.Location = new System.Drawing.Point(206, 48);
            this.txtGnPowerOnPassword.Name = "txtGnPowerOnPassword";
            this.txtGnPowerOnPassword.Size = new System.Drawing.Size(121, 20);
            this.txtGnPowerOnPassword.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(6, 46);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(194, 23);
            this.label17.TabIndex = 21;
            this.label17.Text = "Power On Password";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkGnPasswordLockEnable
            // 
            this.chkGnPasswordLockEnable.Location = new System.Drawing.Point(9, 19);
            this.chkGnPasswordLockEnable.Name = "chkGnPasswordLockEnable";
            this.chkGnPasswordLockEnable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkGnPasswordLockEnable.Size = new System.Drawing.Size(208, 24);
            this.chkGnPasswordLockEnable.TabIndex = 16;
            this.chkGnPasswordLockEnable.Text = "Password and Lock Enable";
            this.chkGnPasswordLockEnable.UseVisualStyleBackColor = true;
            this.chkGnPasswordLockEnable.CheckedChanged += new System.EventHandler(this.chkGnPasswordLockEnable_CheckedChanged);
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.numLnWrkrRemTime);
            this.groupBox11.Controls.Add(this.numGnLnWrkrRespTime);
            this.groupBox11.Controls.Add(this.label15);
            this.groupBox11.Controls.Add(this.label16);
            this.groupBox11.Location = new System.Drawing.Point(9, 255);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(346, 74);
            this.groupBox11.TabIndex = 3;
            this.groupBox11.TabStop = false;
            this.groupBox11.Text = "Lone Worker";
            // 
            // numLnWrkrRemTime
            // 
            this.numLnWrkrRemTime.Location = new System.Drawing.Point(207, 45);
            this.numLnWrkrRemTime.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numLnWrkrRemTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numLnWrkrRemTime.Name = "numLnWrkrRemTime";
            this.numLnWrkrRemTime.Size = new System.Drawing.Size(121, 20);
            this.numLnWrkrRemTime.TabIndex = 24;
            this.numLnWrkrRemTime.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numGnLnWrkrRespTime
            // 
            this.numGnLnWrkrRespTime.Location = new System.Drawing.Point(207, 19);
            this.numGnLnWrkrRespTime.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.numGnLnWrkrRespTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numGnLnWrkrRespTime.Name = "numGnLnWrkrRespTime";
            this.numGnLnWrkrRespTime.Size = new System.Drawing.Size(121, 20);
            this.numGnLnWrkrRespTime.TabIndex = 23;
            this.numGnLnWrkrRespTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(6, 39);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(194, 23);
            this.label15.TabIndex = 20;
            this.label15.Text = "Lone Worker Reminder Time(s)";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(6, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(195, 23);
            this.label16.TabIndex = 18;
            this.label16.Text = "Lone Worker Response Time(min)";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.numAnlgHngTime);
            this.groupBox10.Controls.Add(this.numGnDigHngTime);
            this.groupBox10.Controls.Add(this.label11);
            this.groupBox10.Controls.Add(this.label13);
            this.groupBox10.Location = new System.Drawing.Point(9, 174);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(346, 75);
            this.groupBox10.TabIndex = 2;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Scan";
            // 
            // numAnlgHngTime
            // 
            this.numAnlgHngTime.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numAnlgHngTime.Location = new System.Drawing.Point(206, 44);
            this.numAnlgHngTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numAnlgHngTime.Name = "numAnlgHngTime";
            this.numAnlgHngTime.Size = new System.Drawing.Size(121, 20);
            this.numAnlgHngTime.TabIndex = 23;
            this.numAnlgHngTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numGnDigHngTime
            // 
            this.numGnDigHngTime.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numGnDigHngTime.Location = new System.Drawing.Point(206, 18);
            this.numGnDigHngTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numGnDigHngTime.Name = "numGnDigHngTime";
            this.numGnDigHngTime.Size = new System.Drawing.Size(121, 20);
            this.numGnDigHngTime.TabIndex = 22;
            this.numGnDigHngTime.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 39);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "Scan Analog Hang Time(ms)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(194, 23);
            this.label13.TabIndex = 18;
            this.label13.Text = "Scan Digital Hang Time(ms)";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.numericCallToneAlertDurationUpDown1);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.cmboGnTalkPermTone);
            this.groupBox9.Controls.Add(this.label7);
            this.groupBox9.Controls.Add(this.chkGnDisableAllTone);
            this.groupBox9.Controls.Add(this.chkGnCHFreeIndTone);
            this.groupBox9.Location = new System.Drawing.Point(9, 62);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(346, 106);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Alert Tone";
            // 
            // numericCallToneAlertDurationUpDown1
            // 
            this.numericCallToneAlertDurationUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericCallToneAlertDurationUpDown1.Location = new System.Drawing.Point(208, 69);
            this.numericCallToneAlertDurationUpDown1.Maximum = new decimal(new int[] {
            1200,
            0,
            0,
            0});
            this.numericCallToneAlertDurationUpDown1.Name = "numericCallToneAlertDurationUpDown1";
            this.numericCallToneAlertDurationUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericCallToneAlertDurationUpDown1.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 23);
            this.label9.TabIndex = 20;
            this.label9.Text = "Call Alert Tone Duration(s)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboGnTalkPermTone
            // 
            this.cmboGnTalkPermTone.FormattingEnabled = true;
            this.cmboGnTalkPermTone.Items.AddRange(new object[] {
            "None",
            "Digital",
            "Analog",
            "Digital and Analog"});
            this.cmboGnTalkPermTone.Location = new System.Drawing.Point(207, 48);
            this.cmboGnTalkPermTone.Name = "cmboGnTalkPermTone";
            this.cmboGnTalkPermTone.Size = new System.Drawing.Size(121, 21);
            this.cmboGnTalkPermTone.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(7, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(194, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Talk Permit Tone";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkGnDisableAllTone
            // 
            this.chkGnDisableAllTone.Location = new System.Drawing.Point(64, 19);
            this.chkGnDisableAllTone.Name = "chkGnDisableAllTone";
            this.chkGnDisableAllTone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkGnDisableAllTone.Size = new System.Drawing.Size(104, 24);
            this.chkGnDisableAllTone.TabIndex = 16;
            this.chkGnDisableAllTone.Text = "Disable All Tone";
            this.chkGnDisableAllTone.UseVisualStyleBackColor = true;
            // 
            // chkGnCHFreeIndTone
            // 
            this.chkGnCHFreeIndTone.Location = new System.Drawing.Point(171, 19);
            this.chkGnCHFreeIndTone.Name = "chkGnCHFreeIndTone";
            this.chkGnCHFreeIndTone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkGnCHFreeIndTone.Size = new System.Drawing.Size(156, 24);
            this.chkGnCHFreeIndTone.TabIndex = 17;
            this.chkGnCHFreeIndTone.Text = "CH Free Indication Tone";
            this.chkGnCHFreeIndTone.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chkGnSaveModeRec);
            this.groupBox8.Controls.Add(this.chkGnSavePreamble);
            this.groupBox8.Location = new System.Drawing.Point(9, 4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(346, 52);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Save";
            // 
            // chkGnSaveModeRec
            // 
            this.chkGnSaveModeRec.Checked = true;
            this.chkGnSaveModeRec.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGnSaveModeRec.Location = new System.Drawing.Point(189, 19);
            this.chkGnSaveModeRec.Name = "chkGnSaveModeRec";
            this.chkGnSaveModeRec.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkGnSaveModeRec.Size = new System.Drawing.Size(138, 24);
            this.chkGnSaveModeRec.TabIndex = 17;
            this.chkGnSaveModeRec.Text = "Save Mode Receive";
            this.chkGnSaveModeRec.UseVisualStyleBackColor = true;
            // 
            // chkGnSavePreamble
            // 
            this.chkGnSavePreamble.Checked = true;
            this.chkGnSavePreamble.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGnSavePreamble.Location = new System.Drawing.Point(64, 19);
            this.chkGnSavePreamble.Name = "chkGnSavePreamble";
            this.chkGnSavePreamble.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkGnSavePreamble.Size = new System.Drawing.Size(104, 24);
            this.chkGnSavePreamble.TabIndex = 16;
            this.chkGnSavePreamble.Text = "Save Preamble";
            this.chkGnSavePreamble.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Controls.Add(this.groupBox3);
            this.tabPage7.Location = new System.Drawing.Point(4, 25);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Size = new System.Drawing.Size(804, 571);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Menu Items";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.numericMenuHangTimeUpDown1);
            this.groupBox3.Controls.Add(this.groupBox7);
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.chkMnuTextMessage);
            this.groupBox3.Controls.Add(this.lblMenuHangTime);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(8, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 356);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Menu Items";
            // 
            // numericMenuHangTimeUpDown1
            // 
            this.numericMenuHangTimeUpDown1.Location = new System.Drawing.Point(135, 23);
            this.numericMenuHangTimeUpDown1.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericMenuHangTimeUpDown1.Name = "numericMenuHangTimeUpDown1";
            this.numericMenuHangTimeUpDown1.Size = new System.Drawing.Size(49, 20);
            this.numericMenuHangTimeUpDown1.TabIndex = 7;
            this.numericMenuHangTimeUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkMnuEditList);
            this.groupBox7.Controls.Add(this.chkMnuScan);
            this.groupBox7.Location = new System.Drawing.Point(296, 244);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(255, 97);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Scan";
            // 
            // chkMnuEditList
            // 
            this.chkMnuEditList.Checked = true;
            this.chkMnuEditList.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuEditList.Location = new System.Drawing.Point(132, 25);
            this.chkMnuEditList.Name = "chkMnuEditList";
            this.chkMnuEditList.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuEditList.Size = new System.Drawing.Size(104, 24);
            this.chkMnuEditList.TabIndex = 15;
            this.chkMnuEditList.Text = "Edit List";
            this.chkMnuEditList.UseVisualStyleBackColor = true;
            // 
            // chkMnuScan
            // 
            this.chkMnuScan.Checked = true;
            this.chkMnuScan.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuScan.Location = new System.Drawing.Point(18, 25);
            this.chkMnuScan.Name = "chkMnuScan";
            this.chkMnuScan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuScan.Size = new System.Drawing.Size(104, 24);
            this.chkMnuScan.TabIndex = 14;
            this.chkMnuScan.Text = "Scan";
            this.chkMnuScan.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkMnuPrgRadio);
            this.groupBox6.Controls.Add(this.chkMnuDisplayMode);
            this.groupBox6.Controls.Add(this.chkMnuVOX);
            this.groupBox6.Controls.Add(this.chkMnuPasswordLock);
            this.groupBox6.Controls.Add(this.chkMnuSquelch);
            this.groupBox6.Controls.Add(this.chkMnuLEDInd);
            this.groupBox6.Controls.Add(this.chkMnuKeyboardLock);
            this.groupBox6.Controls.Add(this.chkMnuIntroScreen);
            this.groupBox6.Controls.Add(this.chkMnuBacklight);
            this.groupBox6.Controls.Add(this.chkMnuPower);
            this.groupBox6.Controls.Add(this.chkMnuToneAlert);
            this.groupBox6.Controls.Add(this.chkMnuTalkaround);
            this.groupBox6.Location = new System.Drawing.Point(296, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(255, 218);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Utilities";
            // 
            // chkMnuPrgRadio
            // 
            this.chkMnuPrgRadio.Location = new System.Drawing.Point(132, 175);
            this.chkMnuPrgRadio.Name = "chkMnuPrgRadio";
            this.chkMnuPrgRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuPrgRadio.Size = new System.Drawing.Size(104, 24);
            this.chkMnuPrgRadio.TabIndex = 22;
            this.chkMnuPrgRadio.Text = "Program Radio";
            this.chkMnuPrgRadio.UseVisualStyleBackColor = true;
            // 
            // chkMnuDisplayMode
            // 
            this.chkMnuDisplayMode.Checked = true;
            this.chkMnuDisplayMode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuDisplayMode.Location = new System.Drawing.Point(18, 175);
            this.chkMnuDisplayMode.Name = "chkMnuDisplayMode";
            this.chkMnuDisplayMode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuDisplayMode.Size = new System.Drawing.Size(104, 24);
            this.chkMnuDisplayMode.TabIndex = 21;
            this.chkMnuDisplayMode.Text = "Display Mode";
            this.chkMnuDisplayMode.UseVisualStyleBackColor = true;
            // 
            // chkMnuVOX
            // 
            this.chkMnuVOX.Location = new System.Drawing.Point(132, 145);
            this.chkMnuVOX.Name = "chkMnuVOX";
            this.chkMnuVOX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuVOX.Size = new System.Drawing.Size(104, 24);
            this.chkMnuVOX.TabIndex = 20;
            this.chkMnuVOX.Text = "VOX";
            this.chkMnuVOX.UseVisualStyleBackColor = true;
            // 
            // chkMnuPasswordLock
            // 
            this.chkMnuPasswordLock.Checked = true;
            this.chkMnuPasswordLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuPasswordLock.Location = new System.Drawing.Point(18, 145);
            this.chkMnuPasswordLock.Name = "chkMnuPasswordLock";
            this.chkMnuPasswordLock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuPasswordLock.Size = new System.Drawing.Size(104, 24);
            this.chkMnuPasswordLock.TabIndex = 19;
            this.chkMnuPasswordLock.Text = "Password Lock";
            this.chkMnuPasswordLock.UseVisualStyleBackColor = true;
            // 
            // chkMnuSquelch
            // 
            this.chkMnuSquelch.Checked = true;
            this.chkMnuSquelch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuSquelch.Location = new System.Drawing.Point(132, 114);
            this.chkMnuSquelch.Name = "chkMnuSquelch";
            this.chkMnuSquelch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuSquelch.Size = new System.Drawing.Size(104, 24);
            this.chkMnuSquelch.TabIndex = 18;
            this.chkMnuSquelch.Text = "Squelch";
            this.chkMnuSquelch.UseVisualStyleBackColor = true;
            // 
            // chkMnuLEDInd
            // 
            this.chkMnuLEDInd.Checked = true;
            this.chkMnuLEDInd.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuLEDInd.Location = new System.Drawing.Point(18, 114);
            this.chkMnuLEDInd.Name = "chkMnuLEDInd";
            this.chkMnuLEDInd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuLEDInd.Size = new System.Drawing.Size(104, 24);
            this.chkMnuLEDInd.TabIndex = 17;
            this.chkMnuLEDInd.Text = "LED Indicator";
            this.chkMnuLEDInd.UseVisualStyleBackColor = true;
            // 
            // chkMnuKeyboardLock
            // 
            this.chkMnuKeyboardLock.Checked = true;
            this.chkMnuKeyboardLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuKeyboardLock.Location = new System.Drawing.Point(132, 84);
            this.chkMnuKeyboardLock.Name = "chkMnuKeyboardLock";
            this.chkMnuKeyboardLock.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuKeyboardLock.Size = new System.Drawing.Size(104, 24);
            this.chkMnuKeyboardLock.TabIndex = 16;
            this.chkMnuKeyboardLock.Text = "Keyboard Lock";
            this.chkMnuKeyboardLock.UseVisualStyleBackColor = true;
            // 
            // chkMnuIntroScreen
            // 
            this.chkMnuIntroScreen.Checked = true;
            this.chkMnuIntroScreen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuIntroScreen.Location = new System.Drawing.Point(18, 84);
            this.chkMnuIntroScreen.Name = "chkMnuIntroScreen";
            this.chkMnuIntroScreen.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuIntroScreen.Size = new System.Drawing.Size(104, 24);
            this.chkMnuIntroScreen.TabIndex = 15;
            this.chkMnuIntroScreen.Text = "Intro Screen";
            this.chkMnuIntroScreen.UseVisualStyleBackColor = true;
            // 
            // chkMnuBacklight
            // 
            this.chkMnuBacklight.Checked = true;
            this.chkMnuBacklight.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuBacklight.Location = new System.Drawing.Point(132, 54);
            this.chkMnuBacklight.Name = "chkMnuBacklight";
            this.chkMnuBacklight.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuBacklight.Size = new System.Drawing.Size(104, 24);
            this.chkMnuBacklight.TabIndex = 14;
            this.chkMnuBacklight.Text = "Backlight";
            this.chkMnuBacklight.UseVisualStyleBackColor = true;
            // 
            // chkMnuPower
            // 
            this.chkMnuPower.Checked = true;
            this.chkMnuPower.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuPower.Location = new System.Drawing.Point(18, 54);
            this.chkMnuPower.Name = "chkMnuPower";
            this.chkMnuPower.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuPower.Size = new System.Drawing.Size(104, 24);
            this.chkMnuPower.TabIndex = 13;
            this.chkMnuPower.Text = "Power";
            this.chkMnuPower.UseVisualStyleBackColor = true;
            // 
            // chkMnuToneAlert
            // 
            this.chkMnuToneAlert.Checked = true;
            this.chkMnuToneAlert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuToneAlert.Location = new System.Drawing.Point(132, 24);
            this.chkMnuToneAlert.Name = "chkMnuToneAlert";
            this.chkMnuToneAlert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuToneAlert.Size = new System.Drawing.Size(104, 24);
            this.chkMnuToneAlert.TabIndex = 12;
            this.chkMnuToneAlert.Text = "Tone or Alert";
            this.chkMnuToneAlert.UseVisualStyleBackColor = true;
            // 
            // chkMnuTalkaround
            // 
            this.chkMnuTalkaround.Checked = true;
            this.chkMnuTalkaround.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuTalkaround.Location = new System.Drawing.Point(18, 24);
            this.chkMnuTalkaround.Name = "chkMnuTalkaround";
            this.chkMnuTalkaround.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuTalkaround.Size = new System.Drawing.Size(104, 24);
            this.chkMnuTalkaround.TabIndex = 11;
            this.chkMnuTalkaround.Text = "Talkaround";
            this.chkMnuTalkaround.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.chkMnuAnswered);
            this.groupBox5.Controls.Add(this.chkMnuOutgoingRadio);
            this.groupBox5.Controls.Add(this.chkMnuMissed);
            this.groupBox5.Location = new System.Drawing.Point(10, 244);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(253, 97);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Call Log";
            // 
            // chkMnuAnswered
            // 
            this.chkMnuAnswered.Checked = true;
            this.chkMnuAnswered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuAnswered.Location = new System.Drawing.Point(129, 25);
            this.chkMnuAnswered.Name = "chkMnuAnswered";
            this.chkMnuAnswered.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuAnswered.Size = new System.Drawing.Size(104, 24);
            this.chkMnuAnswered.TabIndex = 13;
            this.chkMnuAnswered.Text = "Answered";
            this.chkMnuAnswered.UseVisualStyleBackColor = true;
            // 
            // chkMnuOutgoingRadio
            // 
            this.chkMnuOutgoingRadio.Checked = true;
            this.chkMnuOutgoingRadio.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuOutgoingRadio.Location = new System.Drawing.Point(15, 55);
            this.chkMnuOutgoingRadio.Name = "chkMnuOutgoingRadio";
            this.chkMnuOutgoingRadio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuOutgoingRadio.Size = new System.Drawing.Size(104, 24);
            this.chkMnuOutgoingRadio.TabIndex = 12;
            this.chkMnuOutgoingRadio.Text = "Outgoing Radio";
            this.chkMnuOutgoingRadio.UseVisualStyleBackColor = true;
            // 
            // chkMnuMissed
            // 
            this.chkMnuMissed.Checked = true;
            this.chkMnuMissed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuMissed.Location = new System.Drawing.Point(15, 25);
            this.chkMnuMissed.Name = "chkMnuMissed";
            this.chkMnuMissed.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuMissed.Size = new System.Drawing.Size(104, 24);
            this.chkMnuMissed.TabIndex = 11;
            this.chkMnuMissed.Text = "Missed";
            this.chkMnuMissed.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkMnuRadioDisable);
            this.groupBox4.Controls.Add(this.chkMnuRadioEnable);
            this.groupBox4.Controls.Add(this.chkMnuPrgKey);
            this.groupBox4.Controls.Add(this.chkMnuRemMon);
            this.groupBox4.Controls.Add(this.chkMnuRadioCheck);
            this.groupBox4.Controls.Add(this.chkMnuManDial);
            this.groupBox4.Controls.Add(this.chkMnuEdit);
            this.groupBox4.Controls.Add(this.chkMnuCallAlert);
            this.groupBox4.Location = new System.Drawing.Point(10, 86);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(253, 152);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Contacts";
            // 
            // chkMnuRadioDisable
            // 
            this.chkMnuRadioDisable.Location = new System.Drawing.Point(129, 109);
            this.chkMnuRadioDisable.Name = "chkMnuRadioDisable";
            this.chkMnuRadioDisable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuRadioDisable.Size = new System.Drawing.Size(104, 24);
            this.chkMnuRadioDisable.TabIndex = 10;
            this.chkMnuRadioDisable.Text = "Radio Disable";
            this.chkMnuRadioDisable.UseVisualStyleBackColor = true;
            // 
            // chkMnuRadioEnable
            // 
            this.chkMnuRadioEnable.Location = new System.Drawing.Point(15, 109);
            this.chkMnuRadioEnable.Name = "chkMnuRadioEnable";
            this.chkMnuRadioEnable.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuRadioEnable.Size = new System.Drawing.Size(104, 24);
            this.chkMnuRadioEnable.TabIndex = 9;
            this.chkMnuRadioEnable.Text = "Radio Enable";
            this.chkMnuRadioEnable.UseVisualStyleBackColor = true;
            // 
            // chkMnuPrgKey
            // 
            this.chkMnuPrgKey.Checked = true;
            this.chkMnuPrgKey.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuPrgKey.Location = new System.Drawing.Point(129, 79);
            this.chkMnuPrgKey.Name = "chkMnuPrgKey";
            this.chkMnuPrgKey.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuPrgKey.Size = new System.Drawing.Size(104, 24);
            this.chkMnuPrgKey.TabIndex = 8;
            this.chkMnuPrgKey.Text = "Program Key";
            this.chkMnuPrgKey.UseVisualStyleBackColor = true;
            // 
            // chkMnuRemMon
            // 
            this.chkMnuRemMon.Location = new System.Drawing.Point(15, 79);
            this.chkMnuRemMon.Name = "chkMnuRemMon";
            this.chkMnuRemMon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuRemMon.Size = new System.Drawing.Size(104, 24);
            this.chkMnuRemMon.TabIndex = 7;
            this.chkMnuRemMon.Text = "Remote Monitor";
            this.chkMnuRemMon.UseVisualStyleBackColor = true;
            // 
            // chkMnuRadioCheck
            // 
            this.chkMnuRadioCheck.Location = new System.Drawing.Point(129, 49);
            this.chkMnuRadioCheck.Name = "chkMnuRadioCheck";
            this.chkMnuRadioCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuRadioCheck.Size = new System.Drawing.Size(104, 24);
            this.chkMnuRadioCheck.TabIndex = 6;
            this.chkMnuRadioCheck.Text = "Radio Check";
            this.chkMnuRadioCheck.UseVisualStyleBackColor = true;
            // 
            // chkMnuManDial
            // 
            this.chkMnuManDial.Checked = true;
            this.chkMnuManDial.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuManDial.Location = new System.Drawing.Point(15, 49);
            this.chkMnuManDial.Name = "chkMnuManDial";
            this.chkMnuManDial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuManDial.Size = new System.Drawing.Size(104, 24);
            this.chkMnuManDial.TabIndex = 5;
            this.chkMnuManDial.Text = "Manual Dial";
            this.chkMnuManDial.UseVisualStyleBackColor = true;
            // 
            // chkMnuEdit
            // 
            this.chkMnuEdit.Checked = true;
            this.chkMnuEdit.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuEdit.Location = new System.Drawing.Point(129, 19);
            this.chkMnuEdit.Name = "chkMnuEdit";
            this.chkMnuEdit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuEdit.Size = new System.Drawing.Size(104, 24);
            this.chkMnuEdit.TabIndex = 4;
            this.chkMnuEdit.Text = "Edit";
            this.chkMnuEdit.UseVisualStyleBackColor = true;
            // 
            // chkMnuCallAlert
            // 
            this.chkMnuCallAlert.Checked = true;
            this.chkMnuCallAlert.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuCallAlert.Location = new System.Drawing.Point(15, 19);
            this.chkMnuCallAlert.Name = "chkMnuCallAlert";
            this.chkMnuCallAlert.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuCallAlert.Size = new System.Drawing.Size(104, 24);
            this.chkMnuCallAlert.TabIndex = 3;
            this.chkMnuCallAlert.Text = "Call Alert";
            this.chkMnuCallAlert.UseVisualStyleBackColor = true;
            // 
            // chkMnuTextMessage
            // 
            this.chkMnuTextMessage.Checked = true;
            this.chkMnuTextMessage.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMnuTextMessage.Location = new System.Drawing.Point(25, 56);
            this.chkMnuTextMessage.Name = "chkMnuTextMessage";
            this.chkMnuTextMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkMnuTextMessage.Size = new System.Drawing.Size(104, 24);
            this.chkMnuTextMessage.TabIndex = 2;
            this.chkMnuTextMessage.Text = "Text Message";
            this.chkMnuTextMessage.UseVisualStyleBackColor = true;
            // 
            // lblMenuHangTime
            // 
            this.lblMenuHangTime.AutoSize = true;
            this.lblMenuHangTime.Location = new System.Drawing.Point(136, 29);
            this.lblMenuHangTime.Name = "lblMenuHangTime";
            this.lblMenuHangTime.Size = new System.Drawing.Size(0, 13);
            this.lblMenuHangTime.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(7, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Menu Hang Time(s):";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radGridContacts);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(804, 571);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Contacts";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radGridContacts
            // 
            this.radGridContacts.BackColor = System.Drawing.SystemColors.Control;
            this.radGridContacts.Cursor = System.Windows.Forms.Cursors.Default;
            this.radGridContacts.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.radGridContacts.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radGridContacts.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.radGridContacts.Location = new System.Drawing.Point(7, 7);
            // 
            // 
            // 
            this.radGridContacts.MasterTemplate.AllowAddNewRow = false;
            this.radGridContacts.MasterTemplate.AllowColumnChooser = false;
            this.radGridContacts.MasterTemplate.AllowColumnReorder = false;
            this.radGridContacts.MasterTemplate.AllowDeleteRow = false;
            this.radGridContacts.MasterTemplate.AllowDragToGroup = false;
            this.radGridContacts.MasterTemplate.AutoGenerateColumns = false;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "Name";
            gridViewTextBoxColumn4.HeaderText = "Contact Name";
            gridViewTextBoxColumn4.Name = "colContactName";
            gridViewTextBoxColumn4.Width = 200;
            gridViewComboBoxColumn2.DataSource = ((object)(resources.GetObject("gridViewComboBoxColumn2.DataSource")));
            gridViewComboBoxColumn2.EnableExpressionEditor = false;
            gridViewComboBoxColumn2.FieldName = "CallType";
            gridViewComboBoxColumn2.HeaderText = "Call Type";
            gridViewComboBoxColumn2.Name = "colType";
            gridViewComboBoxColumn2.Width = 100;
            gridViewTextBoxColumn5.EnableExpressionEditor = false;
            gridViewTextBoxColumn5.FieldName = "CallID";
            gridViewTextBoxColumn5.HeaderText = "Call ID";
            gridViewTextBoxColumn5.Name = "colCallID";
            gridViewTextBoxColumn5.Width = 100;
            gridViewCheckBoxColumn2.EnableExpressionEditor = false;
            gridViewCheckBoxColumn2.FieldName = "receiveTone";
            gridViewCheckBoxColumn2.HeaderText = "Call Receive Tone";
            gridViewCheckBoxColumn2.MinWidth = 20;
            gridViewCheckBoxColumn2.Name = "colCT";
            gridViewCheckBoxColumn2.Width = 100;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "GUID";
            gridViewTextBoxColumn6.HeaderText = "GUID";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.Name = "colGUID";
            gridViewTextBoxColumn6.ReadOnly = true;
            this.radGridContacts.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewComboBoxColumn2,
            gridViewTextBoxColumn5,
            gridViewCheckBoxColumn2,
            gridViewTextBoxColumn6});
            this.radGridContacts.MasterTemplate.EnableGrouping = false;
            this.radGridContacts.MasterTemplate.EnableSorting = false;
            this.radGridContacts.MasterTemplate.ViewDefinition = tableViewDefinition2;
            this.radGridContacts.Name = "radGridContacts";
            this.radGridContacts.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.radGridContacts.Size = new System.Drawing.Size(789, 555);
            this.radGridContacts.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnGrpLstMoveDown);
            this.tabPage2.Controls.Add(this.btnGrpLstMoveUp);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.lstGroupList);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(804, 571);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "RX Group List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnGrpLstMoveDown
            // 
            this.btnGrpLstMoveDown.Location = new System.Drawing.Point(149, 524);
            this.btnGrpLstMoveDown.Name = "btnGrpLstMoveDown";
            this.btnGrpLstMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnGrpLstMoveDown.TabIndex = 3;
            this.btnGrpLstMoveDown.Text = "Move Down";
            this.btnGrpLstMoveDown.UseVisualStyleBackColor = true;
            this.btnGrpLstMoveDown.Click += new System.EventHandler(this.btnGrpLstMoveDown_Click);
            // 
            // btnGrpLstMoveUp
            // 
            this.btnGrpLstMoveUp.Location = new System.Drawing.Point(9, 525);
            this.btnGrpLstMoveUp.Name = "btnGrpLstMoveUp";
            this.btnGrpLstMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnGrpLstMoveUp.TabIndex = 2;
            this.btnGrpLstMoveUp.Text = "Move Up";
            this.btnGrpLstMoveUp.UseVisualStyleBackColor = true;
            this.btnGrpLstMoveUp.Click += new System.EventHandler(this.btnGrpLstMoveUp_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGrpLstRemove);
            this.groupBox1.Controls.Add(this.txtGroupListName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGrpLstAdd);
            this.groupBox1.Controls.Add(this.btnGrpAssnMoveDown);
            this.groupBox1.Controls.Add(this.btnGrpAssnMoveUp);
            this.groupBox1.Controls.Add(this.lstGrpAssn);
            this.groupBox1.Controls.Add(this.lstGrpAvail);
            this.groupBox1.Location = new System.Drawing.Point(232, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(564, 556);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btnGrpLstRemove
            // 
            this.btnGrpLstRemove.Location = new System.Drawing.Point(237, 267);
            this.btnGrpLstRemove.Name = "btnGrpLstRemove";
            this.btnGrpLstRemove.Size = new System.Drawing.Size(92, 23);
            this.btnGrpLstRemove.TabIndex = 7;
            this.btnGrpLstRemove.Text = "<== Remove";
            this.btnGrpLstRemove.UseVisualStyleBackColor = true;
            this.btnGrpLstRemove.Click += new System.EventHandler(this.btnGrpLstRemove_Click);
            // 
            // txtGroupListName
            // 
            this.txtGroupListName.Location = new System.Drawing.Point(237, 19);
            this.txtGroupListName.Name = "txtGroupListName";
            this.txtGroupListName.Size = new System.Drawing.Size(222, 20);
            this.txtGroupListName.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(139, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Group List Name: ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnGrpLstAdd
            // 
            this.btnGrpLstAdd.Location = new System.Drawing.Point(237, 238);
            this.btnGrpLstAdd.Name = "btnGrpLstAdd";
            this.btnGrpLstAdd.Size = new System.Drawing.Size(92, 23);
            this.btnGrpLstAdd.TabIndex = 4;
            this.btnGrpLstAdd.Text = "Add ==>";
            this.btnGrpLstAdd.UseVisualStyleBackColor = true;
            this.btnGrpLstAdd.Click += new System.EventHandler(this.btnGrpLstAdd_Click);
            // 
            // btnGrpAssnMoveDown
            // 
            this.btnGrpAssnMoveDown.Location = new System.Drawing.Point(484, 518);
            this.btnGrpAssnMoveDown.Name = "btnGrpAssnMoveDown";
            this.btnGrpAssnMoveDown.Size = new System.Drawing.Size(75, 23);
            this.btnGrpAssnMoveDown.TabIndex = 3;
            this.btnGrpAssnMoveDown.Text = "Move Down";
            this.btnGrpAssnMoveDown.UseVisualStyleBackColor = true;
            this.btnGrpAssnMoveDown.Click += new System.EventHandler(this.btnGrpAssnMoveDown_Click);
            // 
            // btnGrpAssnMoveUp
            // 
            this.btnGrpAssnMoveUp.Location = new System.Drawing.Point(335, 518);
            this.btnGrpAssnMoveUp.Name = "btnGrpAssnMoveUp";
            this.btnGrpAssnMoveUp.Size = new System.Drawing.Size(75, 23);
            this.btnGrpAssnMoveUp.TabIndex = 2;
            this.btnGrpAssnMoveUp.Text = "Move Up";
            this.btnGrpAssnMoveUp.UseVisualStyleBackColor = true;
            this.btnGrpAssnMoveUp.Click += new System.EventHandler(this.btnGrpAssnMoveUp_Click);
            // 
            // lstGrpAssn
            // 
            this.lstGrpAssn.FormattingEnabled = true;
            this.lstGrpAssn.Location = new System.Drawing.Point(335, 59);
            this.lstGrpAssn.Name = "lstGrpAssn";
            this.lstGrpAssn.Size = new System.Drawing.Size(224, 446);
            this.lstGrpAssn.TabIndex = 1;
            // 
            // lstGrpAvail
            // 
            this.lstGrpAvail.FormattingEnabled = true;
            this.lstGrpAvail.Location = new System.Drawing.Point(7, 59);
            this.lstGrpAvail.Name = "lstGrpAvail";
            this.lstGrpAvail.Size = new System.Drawing.Size(224, 446);
            this.lstGrpAvail.TabIndex = 0;
            // 
            // lstGroupList
            // 
            this.lstGroupList.FormattingEnabled = true;
            this.lstGroupList.Location = new System.Drawing.Point(9, 7);
            this.lstGroupList.Name = "lstGroupList";
            this.lstGroupList.Size = new System.Drawing.Size(216, 511);
            this.lstGroupList.TabIndex = 0;
            this.lstGroupList.SelectedIndexChanged += new System.EventHandler(this.lstGroupList_SelectedIndexChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox16);
            this.tabPage3.Controls.Add(this.btnZnMvDwn);
            this.tabPage3.Controls.Add(this.btnZnMvUp);
            this.tabPage3.Controls.Add(this.lstZones);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(804, 571);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Zones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.btnZnRemove);
            this.groupBox16.Controls.Add(this.txtZnName);
            this.groupBox16.Controls.Add(this.label33);
            this.groupBox16.Controls.Add(this.btnZnAdd);
            this.groupBox16.Controls.Add(this.btnZnAssnMvUp);
            this.groupBox16.Controls.Add(this.btnZnAssnMvDwn);
            this.groupBox16.Controls.Add(this.lstZnChanAssigned);
            this.groupBox16.Controls.Add(this.lstZnChanAvail);
            this.groupBox16.Location = new System.Drawing.Point(232, 7);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(564, 556);
            this.groupBox16.TabIndex = 7;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Zone List";
            // 
            // btnZnRemove
            // 
            this.btnZnRemove.Location = new System.Drawing.Point(237, 267);
            this.btnZnRemove.Name = "btnZnRemove";
            this.btnZnRemove.Size = new System.Drawing.Size(92, 23);
            this.btnZnRemove.TabIndex = 7;
            this.btnZnRemove.Text = "<== Remove";
            this.btnZnRemove.UseVisualStyleBackColor = true;
            this.btnZnRemove.Click += new System.EventHandler(this.btnZnRemove_Click);
            // 
            // txtZnName
            // 
            this.txtZnName.Location = new System.Drawing.Point(237, 19);
            this.txtZnName.Name = "txtZnName";
            this.txtZnName.Size = new System.Drawing.Size(222, 20);
            this.txtZnName.TabIndex = 6;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(139, 22);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(92, 13);
            this.label33.TabIndex = 5;
            this.label33.Text = "Zone Name: ";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnZnAdd
            // 
            this.btnZnAdd.Location = new System.Drawing.Point(237, 238);
            this.btnZnAdd.Name = "btnZnAdd";
            this.btnZnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnZnAdd.TabIndex = 4;
            this.btnZnAdd.Text = "Add ==>";
            this.btnZnAdd.UseVisualStyleBackColor = true;
            this.btnZnAdd.Click += new System.EventHandler(this.btnZnAdd_Click);
            // 
            // btnZnAssnMvUp
            // 
            this.btnZnAssnMvUp.Location = new System.Drawing.Point(335, 518);
            this.btnZnAssnMvUp.Name = "btnZnAssnMvUp";
            this.btnZnAssnMvUp.Size = new System.Drawing.Size(75, 23);
            this.btnZnAssnMvUp.TabIndex = 2;
            this.btnZnAssnMvUp.Text = "Move Up";
            this.btnZnAssnMvUp.UseVisualStyleBackColor = true;
            this.btnZnAssnMvUp.Click += new System.EventHandler(this.btnZnAssnMvUp_Click);
            // 
            // btnZnAssnMvDwn
            // 
            this.btnZnAssnMvDwn.Location = new System.Drawing.Point(484, 518);
            this.btnZnAssnMvDwn.Name = "btnZnAssnMvDwn";
            this.btnZnAssnMvDwn.Size = new System.Drawing.Size(75, 23);
            this.btnZnAssnMvDwn.TabIndex = 3;
            this.btnZnAssnMvDwn.Text = "Move Down";
            this.btnZnAssnMvDwn.UseVisualStyleBackColor = true;
            this.btnZnAssnMvDwn.Click += new System.EventHandler(this.btnZnAssnMvDwn_Click);
            // 
            // lstZnChanAssigned
            // 
            this.lstZnChanAssigned.FormattingEnabled = true;
            this.lstZnChanAssigned.Location = new System.Drawing.Point(335, 59);
            this.lstZnChanAssigned.Name = "lstZnChanAssigned";
            this.lstZnChanAssigned.Size = new System.Drawing.Size(224, 446);
            this.lstZnChanAssigned.TabIndex = 1;
            // 
            // lstZnChanAvail
            // 
            this.lstZnChanAvail.FormattingEnabled = true;
            this.lstZnChanAvail.Location = new System.Drawing.Point(7, 59);
            this.lstZnChanAvail.Name = "lstZnChanAvail";
            this.lstZnChanAvail.Size = new System.Drawing.Size(224, 446);
            this.lstZnChanAvail.TabIndex = 0;
            // 
            // btnZnMvDwn
            // 
            this.btnZnMvDwn.Location = new System.Drawing.Point(150, 524);
            this.btnZnMvDwn.Name = "btnZnMvDwn";
            this.btnZnMvDwn.Size = new System.Drawing.Size(75, 23);
            this.btnZnMvDwn.TabIndex = 6;
            this.btnZnMvDwn.Text = "Move Down";
            this.btnZnMvDwn.UseVisualStyleBackColor = true;
            this.btnZnMvDwn.Click += new System.EventHandler(this.btnZnMvDwn_Click);
            // 
            // btnZnMvUp
            // 
            this.btnZnMvUp.Location = new System.Drawing.Point(9, 524);
            this.btnZnMvUp.Name = "btnZnMvUp";
            this.btnZnMvUp.Size = new System.Drawing.Size(75, 23);
            this.btnZnMvUp.TabIndex = 5;
            this.btnZnMvUp.Text = "Move Up";
            this.btnZnMvUp.UseVisualStyleBackColor = true;
            this.btnZnMvUp.Click += new System.EventHandler(this.btnZnMvUp_Click);
            // 
            // lstZones
            // 
            this.lstZones.FormattingEnabled = true;
            this.lstZones.Location = new System.Drawing.Point(9, 7);
            this.lstZones.Name = "lstZones";
            this.lstZones.Size = new System.Drawing.Size(216, 511);
            this.lstZones.TabIndex = 4;
            this.lstZones.SelectedIndexChanged += new System.EventHandler(this.lstZones_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnScnMvDwn);
            this.tabPage4.Controls.Add(this.btnScnMvUp);
            this.tabPage4.Controls.Add(this.lstScanLists);
            this.tabPage4.Controls.Add(this.groupBox17);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(804, 571);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Scan Lists";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnScnMvDwn
            // 
            this.btnScnMvDwn.Location = new System.Drawing.Point(150, 524);
            this.btnScnMvDwn.Name = "btnScnMvDwn";
            this.btnScnMvDwn.Size = new System.Drawing.Size(75, 23);
            this.btnScnMvDwn.TabIndex = 10;
            this.btnScnMvDwn.Text = "Move Down";
            this.btnScnMvDwn.UseVisualStyleBackColor = true;
            this.btnScnMvDwn.Click += new System.EventHandler(this.btnScnMvDwn_Click);
            // 
            // btnScnMvUp
            // 
            this.btnScnMvUp.Location = new System.Drawing.Point(9, 524);
            this.btnScnMvUp.Name = "btnScnMvUp";
            this.btnScnMvUp.Size = new System.Drawing.Size(75, 23);
            this.btnScnMvUp.TabIndex = 9;
            this.btnScnMvUp.Text = "Move Up";
            this.btnScnMvUp.UseVisualStyleBackColor = true;
            this.btnScnMvUp.Click += new System.EventHandler(this.btnScnMvUp_Click);
            // 
            // lstScanLists
            // 
            this.lstScanLists.FormattingEnabled = true;
            this.lstScanLists.Location = new System.Drawing.Point(9, 7);
            this.lstScanLists.Name = "lstScanLists";
            this.lstScanLists.Size = new System.Drawing.Size(216, 511);
            this.lstScanLists.TabIndex = 8;
            this.lstScanLists.SelectedIndexChanged += new System.EventHandler(this.lstScanLists_SelectedIndexChanged);
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.cmboSLSampleTime);
            this.groupBox17.Controls.Add(this.label65);
            this.groupBox17.Controls.Add(this.cmboSLSignalingHoldTime);
            this.groupBox17.Controls.Add(this.label63);
            this.groupBox17.Controls.Add(this.cmboSLTXCH);
            this.groupBox17.Controls.Add(this.label64);
            this.groupBox17.Controls.Add(this.cmboSLPriorityB);
            this.groupBox17.Controls.Add(this.label61);
            this.groupBox17.Controls.Add(this.cmboSLPriorityA);
            this.groupBox17.Controls.Add(this.label62);
            this.groupBox17.Controls.Add(this.btnScnChanMvUp);
            this.groupBox17.Controls.Add(this.btnScnChanMvDwn);
            this.groupBox17.Controls.Add(this.btnScnRemove);
            this.groupBox17.Controls.Add(this.txtScnName);
            this.groupBox17.Controls.Add(this.label34);
            this.groupBox17.Controls.Add(this.btnScnAdd);
            this.groupBox17.Controls.Add(this.lstScnChanAssn);
            this.groupBox17.Controls.Add(this.lstScnChanAvail);
            this.groupBox17.Location = new System.Drawing.Point(232, 7);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(564, 556);
            this.groupBox17.TabIndex = 11;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Scan List";
            // 
            // cmboSLSampleTime
            // 
            this.cmboSLSampleTime.FormattingEnabled = true;
            this.cmboSLSampleTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmboSLSampleTime.Location = new System.Drawing.Point(142, 517);
            this.cmboSLSampleTime.Name = "cmboSLSampleTime";
            this.cmboSLSampleTime.Size = new System.Drawing.Size(140, 21);
            this.cmboSLSampleTime.TabIndex = 44;
            // 
            // label65
            // 
            this.label65.Location = new System.Drawing.Point(6, 517);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(130, 23);
            this.label65.TabIndex = 43;
            this.label65.Text = "Priority Sample Time(ms)";
            this.label65.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboSLSignalingHoldTime
            // 
            this.cmboSLSignalingHoldTime.FormattingEnabled = true;
            this.cmboSLSignalingHoldTime.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmboSLSignalingHoldTime.Location = new System.Drawing.Point(142, 494);
            this.cmboSLSignalingHoldTime.Name = "cmboSLSignalingHoldTime";
            this.cmboSLSignalingHoldTime.Size = new System.Drawing.Size(140, 21);
            this.cmboSLSignalingHoldTime.TabIndex = 42;
            // 
            // label63
            // 
            this.label63.Location = new System.Drawing.Point(6, 494);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(130, 23);
            this.label63.TabIndex = 41;
            this.label63.Text = "Signaling Hold Time(ms)";
            this.label63.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboSLTXCH
            // 
            this.cmboSLTXCH.FormattingEnabled = true;
            this.cmboSLTXCH.Items.AddRange(new object[] {
            "Silent",
            "Open Squelch"});
            this.cmboSLTXCH.Location = new System.Drawing.Point(142, 471);
            this.cmboSLTXCH.Name = "cmboSLTXCH";
            this.cmboSLTXCH.Size = new System.Drawing.Size(140, 21);
            this.cmboSLTXCH.TabIndex = 40;
            // 
            // label64
            // 
            this.label64.Location = new System.Drawing.Point(6, 471);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(130, 23);
            this.label64.TabIndex = 39;
            this.label64.Text = "TX Designated CH";
            this.label64.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboSLPriorityB
            // 
            this.cmboSLPriorityB.FormattingEnabled = true;
            this.cmboSLPriorityB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cmboSLPriorityB.Location = new System.Drawing.Point(142, 448);
            this.cmboSLPriorityB.Name = "cmboSLPriorityB";
            this.cmboSLPriorityB.Size = new System.Drawing.Size(140, 21);
            this.cmboSLPriorityB.TabIndex = 38;
            // 
            // label61
            // 
            this.label61.Location = new System.Drawing.Point(6, 448);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(130, 23);
            this.label61.TabIndex = 37;
            this.label61.Text = "Priority Channel 2";
            this.label61.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboSLPriorityA
            // 
            this.cmboSLPriorityA.FormattingEnabled = true;
            this.cmboSLPriorityA.Items.AddRange(new object[] {
            "Silent",
            "Open Squelch"});
            this.cmboSLPriorityA.Location = new System.Drawing.Point(142, 425);
            this.cmboSLPriorityA.Name = "cmboSLPriorityA";
            this.cmboSLPriorityA.Size = new System.Drawing.Size(140, 21);
            this.cmboSLPriorityA.TabIndex = 36;
            // 
            // label62
            // 
            this.label62.Location = new System.Drawing.Point(6, 425);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(130, 23);
            this.label62.TabIndex = 35;
            this.label62.Text = "Priority Channel 1";
            this.label62.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnScnChanMvUp
            // 
            this.btnScnChanMvUp.Location = new System.Drawing.Point(335, 517);
            this.btnScnChanMvUp.Name = "btnScnChanMvUp";
            this.btnScnChanMvUp.Size = new System.Drawing.Size(75, 23);
            this.btnScnChanMvUp.TabIndex = 8;
            this.btnScnChanMvUp.Text = "Move Up";
            this.btnScnChanMvUp.UseVisualStyleBackColor = true;
            // 
            // btnScnChanMvDwn
            // 
            this.btnScnChanMvDwn.Location = new System.Drawing.Point(484, 517);
            this.btnScnChanMvDwn.Name = "btnScnChanMvDwn";
            this.btnScnChanMvDwn.Size = new System.Drawing.Size(75, 23);
            this.btnScnChanMvDwn.TabIndex = 9;
            this.btnScnChanMvDwn.Text = "Move Down";
            this.btnScnChanMvDwn.UseVisualStyleBackColor = true;
            // 
            // btnScnRemove
            // 
            this.btnScnRemove.Location = new System.Drawing.Point(237, 267);
            this.btnScnRemove.Name = "btnScnRemove";
            this.btnScnRemove.Size = new System.Drawing.Size(92, 23);
            this.btnScnRemove.TabIndex = 7;
            this.btnScnRemove.Text = "<== Remove";
            this.btnScnRemove.UseVisualStyleBackColor = true;
            this.btnScnRemove.Click += new System.EventHandler(this.btnScnRemove_Click);
            // 
            // txtScnName
            // 
            this.txtScnName.Location = new System.Drawing.Point(237, 19);
            this.txtScnName.Name = "txtScnName";
            this.txtScnName.Size = new System.Drawing.Size(222, 20);
            this.txtScnName.TabIndex = 6;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(139, 22);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(92, 13);
            this.label34.TabIndex = 5;
            this.label34.Text = "Scan List Name:";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnScnAdd
            // 
            this.btnScnAdd.Location = new System.Drawing.Point(237, 238);
            this.btnScnAdd.Name = "btnScnAdd";
            this.btnScnAdd.Size = new System.Drawing.Size(92, 23);
            this.btnScnAdd.TabIndex = 4;
            this.btnScnAdd.Text = "Add ==>";
            this.btnScnAdd.UseVisualStyleBackColor = true;
            this.btnScnAdd.Click += new System.EventHandler(this.btnScnAdd_Click);
            // 
            // lstScnChanAssn
            // 
            this.lstScnChanAssn.FormattingEnabled = true;
            this.lstScnChanAssn.Location = new System.Drawing.Point(335, 59);
            this.lstScnChanAssn.Name = "lstScnChanAssn";
            this.lstScnChanAssn.Size = new System.Drawing.Size(224, 459);
            this.lstScnChanAssn.TabIndex = 1;
            // 
            // lstScnChanAvail
            // 
            this.lstScnChanAvail.FormattingEnabled = true;
            this.lstScnChanAvail.Location = new System.Drawing.Point(7, 59);
            this.lstScnChanAvail.Name = "lstScnChanAvail";
            this.lstScnChanAvail.Size = new System.Drawing.Size(224, 355);
            this.lstScnChanAvail.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.groupBox20);
            this.tabPage5.Controls.Add(this.groupBox19);
            this.tabPage5.Controls.Add(this.groupBox18);
            this.tabPage5.Controls.Add(this.btnCHMvDwn);
            this.tabPage5.Controls.Add(this.btnCHMvUp);
            this.tabPage5.Controls.Add(this.lstChannels);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(804, 571);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Channels";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox20
            // 
            this.groupBox20.Controls.Add(this.cmboCHPrivacyNo);
            this.groupBox20.Controls.Add(this.label54);
            this.groupBox20.Controls.Add(this.cmboCHPrivacy);
            this.groupBox20.Controls.Add(this.label55);
            this.groupBox20.Controls.Add(this.chkCHCompUDP);
            this.groupBox20.Controls.Add(this.cmboCHTS);
            this.groupBox20.Controls.Add(this.chkCHDataCallConf);
            this.groupBox20.Controls.Add(this.label56);
            this.groupBox20.Controls.Add(this.chkCHEmgcyAlrmAck);
            this.groupBox20.Controls.Add(this.cmboCHColorCode);
            this.groupBox20.Controls.Add(this.chkCHPrivCallConf);
            this.groupBox20.Controls.Add(this.label57);
            this.groupBox20.Controls.Add(this.cmboCHGroupList);
            this.groupBox20.Controls.Add(this.label58);
            this.groupBox20.Controls.Add(this.cmboCHContactName);
            this.groupBox20.Controls.Add(this.label59);
            this.groupBox20.Controls.Add(this.cmboCHEmgcySys);
            this.groupBox20.Controls.Add(this.label60);
            this.groupBox20.Location = new System.Drawing.Point(519, 201);
            this.groupBox20.Name = "groupBox20";
            this.groupBox20.Size = new System.Drawing.Size(282, 317);
            this.groupBox20.TabIndex = 16;
            this.groupBox20.TabStop = false;
            this.groupBox20.Text = "Digital";
            // 
            // cmboCHPrivacyNo
            // 
            this.cmboCHPrivacyNo.FormattingEnabled = true;
            this.cmboCHPrivacyNo.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16"});
            this.cmboCHPrivacyNo.Location = new System.Drawing.Point(154, 159);
            this.cmboCHPrivacyNo.Name = "cmboCHPrivacyNo";
            this.cmboCHPrivacyNo.Size = new System.Drawing.Size(88, 21);
            this.cmboCHPrivacyNo.TabIndex = 47;
            // 
            // label54
            // 
            this.label54.Location = new System.Drawing.Point(41, 157);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(107, 23);
            this.label54.TabIndex = 46;
            this.label54.Text = "Privacy No.";
            this.label54.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHPrivacy
            // 
            this.cmboCHPrivacy.FormattingEnabled = true;
            this.cmboCHPrivacy.Items.AddRange(new object[] {
            "None",
            "Basic",
            "Enhanced"});
            this.cmboCHPrivacy.Location = new System.Drawing.Point(154, 136);
            this.cmboCHPrivacy.Name = "cmboCHPrivacy";
            this.cmboCHPrivacy.Size = new System.Drawing.Size(88, 21);
            this.cmboCHPrivacy.TabIndex = 45;
            // 
            // label55
            // 
            this.label55.Location = new System.Drawing.Point(41, 134);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(107, 23);
            this.label55.TabIndex = 44;
            this.label55.Text = "Privacy";
            this.label55.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkCHCompUDP
            // 
            this.chkCHCompUDP.Location = new System.Drawing.Point(44, 287);
            this.chkCHCompUDP.Name = "chkCHCompUDP";
            this.chkCHCompUDP.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHCompUDP.Size = new System.Drawing.Size(187, 24);
            this.chkCHCompUDP.TabIndex = 54;
            this.chkCHCompUDP.Text = "Compressed UDP Data Header";
            this.chkCHCompUDP.UseVisualStyleBackColor = true;
            // 
            // cmboCHTS
            // 
            this.cmboCHTS.FormattingEnabled = true;
            this.cmboCHTS.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmboCHTS.Location = new System.Drawing.Point(154, 113);
            this.cmboCHTS.Name = "cmboCHTS";
            this.cmboCHTS.Size = new System.Drawing.Size(88, 21);
            this.cmboCHTS.TabIndex = 43;
            // 
            // chkCHDataCallConf
            // 
            this.chkCHDataCallConf.Location = new System.Drawing.Point(44, 258);
            this.chkCHDataCallConf.Name = "chkCHDataCallConf";
            this.chkCHDataCallConf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHDataCallConf.Size = new System.Drawing.Size(187, 24);
            this.chkCHDataCallConf.TabIndex = 53;
            this.chkCHDataCallConf.Text = "Data Call Confirmed";
            this.chkCHDataCallConf.UseVisualStyleBackColor = true;
            // 
            // label56
            // 
            this.label56.Location = new System.Drawing.Point(41, 111);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(107, 23);
            this.label56.TabIndex = 42;
            this.label56.Text = "Repeater Slot";
            this.label56.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkCHEmgcyAlrmAck
            // 
            this.chkCHEmgcyAlrmAck.Location = new System.Drawing.Point(44, 228);
            this.chkCHEmgcyAlrmAck.Name = "chkCHEmgcyAlrmAck";
            this.chkCHEmgcyAlrmAck.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHEmgcyAlrmAck.Size = new System.Drawing.Size(187, 24);
            this.chkCHEmgcyAlrmAck.TabIndex = 52;
            this.chkCHEmgcyAlrmAck.Text = "Emergency Alarm Ack";
            this.chkCHEmgcyAlrmAck.UseVisualStyleBackColor = true;
            // 
            // cmboCHColorCode
            // 
            this.cmboCHColorCode.FormattingEnabled = true;
            this.cmboCHColorCode.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmboCHColorCode.Location = new System.Drawing.Point(154, 90);
            this.cmboCHColorCode.Name = "cmboCHColorCode";
            this.cmboCHColorCode.Size = new System.Drawing.Size(88, 21);
            this.cmboCHColorCode.TabIndex = 41;
            // 
            // chkCHPrivCallConf
            // 
            this.chkCHPrivCallConf.Location = new System.Drawing.Point(44, 198);
            this.chkCHPrivCallConf.Name = "chkCHPrivCallConf";
            this.chkCHPrivCallConf.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHPrivCallConf.Size = new System.Drawing.Size(187, 24);
            this.chkCHPrivCallConf.TabIndex = 51;
            this.chkCHPrivCallConf.Text = "Private Call Confirmed";
            this.chkCHPrivCallConf.UseVisualStyleBackColor = true;
            // 
            // label57
            // 
            this.label57.Location = new System.Drawing.Point(41, 88);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(107, 23);
            this.label57.TabIndex = 40;
            this.label57.Text = "Color Code";
            this.label57.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHGroupList
            // 
            this.cmboCHGroupList.FormattingEnabled = true;
            this.cmboCHGroupList.Items.AddRange(new object[] {
            "None",
            "Digital",
            "Analog",
            "Digital and Analog"});
            this.cmboCHGroupList.Location = new System.Drawing.Point(154, 67);
            this.cmboCHGroupList.Name = "cmboCHGroupList";
            this.cmboCHGroupList.Size = new System.Drawing.Size(88, 21);
            this.cmboCHGroupList.TabIndex = 39;
            // 
            // label58
            // 
            this.label58.Location = new System.Drawing.Point(41, 65);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(107, 23);
            this.label58.TabIndex = 38;
            this.label58.Text = "Group List";
            this.label58.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHContactName
            // 
            this.cmboCHContactName.FormattingEnabled = true;
            this.cmboCHContactName.Items.AddRange(new object[] {
            "None",
            "Digital",
            "Analog",
            "Digital and Analog"});
            this.cmboCHContactName.Location = new System.Drawing.Point(154, 44);
            this.cmboCHContactName.Name = "cmboCHContactName";
            this.cmboCHContactName.Size = new System.Drawing.Size(88, 21);
            this.cmboCHContactName.TabIndex = 37;
            // 
            // label59
            // 
            this.label59.Location = new System.Drawing.Point(41, 42);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(107, 23);
            this.label59.TabIndex = 36;
            this.label59.Text = "Contact Name";
            this.label59.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHEmgcySys
            // 
            this.cmboCHEmgcySys.FormattingEnabled = true;
            this.cmboCHEmgcySys.Items.AddRange(new object[] {
            "None",
            "Digital",
            "Analog",
            "Digital and Analog"});
            this.cmboCHEmgcySys.Location = new System.Drawing.Point(154, 21);
            this.cmboCHEmgcySys.Name = "cmboCHEmgcySys";
            this.cmboCHEmgcySys.Size = new System.Drawing.Size(88, 21);
            this.cmboCHEmgcySys.TabIndex = 35;
            // 
            // label60
            // 
            this.label60.Location = new System.Drawing.Point(41, 19);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(107, 23);
            this.label60.TabIndex = 34;
            this.label60.Text = "Emergency System";
            this.label60.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox19
            // 
            this.groupBox19.Controls.Add(this.chkCHDecode4);
            this.groupBox19.Controls.Add(this.chkCHDecode3);
            this.groupBox19.Controls.Add(this.chkCHDecode2);
            this.groupBox19.Controls.Add(this.chkCHDecode1);
            this.groupBox19.Controls.Add(this.chkCHDecode8);
            this.groupBox19.Controls.Add(this.chkCHDecode7);
            this.groupBox19.Controls.Add(this.chkCHDecode6);
            this.groupBox19.Controls.Add(this.chkCHDecode5);
            this.groupBox19.Controls.Add(this.chkCHReverseBurst);
            this.groupBox19.Controls.Add(this.label53);
            this.groupBox19.Controls.Add(this.chkCHDisablePTTID);
            this.groupBox19.Controls.Add(this.cmboCHTXSignaling);
            this.groupBox19.Controls.Add(this.label39);
            this.groupBox19.Controls.Add(this.cmboCHRXSignaling);
            this.groupBox19.Controls.Add(this.label49);
            this.groupBox19.Controls.Add(this.cmboCHQTReverse);
            this.groupBox19.Controls.Add(this.label50);
            this.groupBox19.Controls.Add(this.cmboCHCTCSSEnc);
            this.groupBox19.Controls.Add(this.label51);
            this.groupBox19.Controls.Add(this.cmboCHCTCSSDec);
            this.groupBox19.Controls.Add(this.label52);
            this.groupBox19.Location = new System.Drawing.Point(232, 201);
            this.groupBox19.Name = "groupBox19";
            this.groupBox19.Size = new System.Drawing.Size(282, 317);
            this.groupBox19.TabIndex = 15;
            this.groupBox19.TabStop = false;
            this.groupBox19.Text = "Analog";
            // 
            // chkCHDecode4
            // 
            this.chkCHDecode4.Location = new System.Drawing.Point(42, 273);
            this.chkCHDecode4.Name = "chkCHDecode4";
            this.chkCHDecode4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHDecode4.Size = new System.Drawing.Size(82, 24);
            this.chkCHDecode4.TabIndex = 62;
            this.chkCHDecode4.Text = "Decode 4";
            this.chkCHDecode4.UseVisualStyleBackColor = true;
            // 
            // chkCHDecode3
            // 
            this.chkCHDecode3.Location = new System.Drawing.Point(42, 244);
            this.chkCHDecode3.Name = "chkCHDecode3";
            this.chkCHDecode3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHDecode3.Size = new System.Drawing.Size(82, 24);
            this.chkCHDecode3.TabIndex = 61;
            this.chkCHDecode3.Text = "Decode 3";
            this.chkCHDecode3.UseVisualStyleBackColor = true;
            // 
            // chkCHDecode2
            // 
            this.chkCHDecode2.Location = new System.Drawing.Point(42, 214);
            this.chkCHDecode2.Name = "chkCHDecode2";
            this.chkCHDecode2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHDecode2.Size = new System.Drawing.Size(82, 24);
            this.chkCHDecode2.TabIndex = 60;
            this.chkCHDecode2.Text = "Decode 2";
            this.chkCHDecode2.UseVisualStyleBackColor = true;
            // 
            // chkCHDecode1
            // 
            this.chkCHDecode1.Location = new System.Drawing.Point(42, 184);
            this.chkCHDecode1.Name = "chkCHDecode1";
            this.chkCHDecode1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHDecode1.Size = new System.Drawing.Size(82, 24);
            this.chkCHDecode1.TabIndex = 59;
            this.chkCHDecode1.Text = "Decode 1";
            this.chkCHDecode1.UseVisualStyleBackColor = true;
            // 
            // chkCHDecode8
            // 
            this.chkCHDecode8.Location = new System.Drawing.Point(130, 273);
            this.chkCHDecode8.Name = "chkCHDecode8";
            this.chkCHDecode8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHDecode8.Size = new System.Drawing.Size(82, 24);
            this.chkCHDecode8.TabIndex = 58;
            this.chkCHDecode8.Text = "Decode 8";
            this.chkCHDecode8.UseVisualStyleBackColor = true;
            // 
            // chkCHDecode7
            // 
            this.chkCHDecode7.Location = new System.Drawing.Point(130, 244);
            this.chkCHDecode7.Name = "chkCHDecode7";
            this.chkCHDecode7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHDecode7.Size = new System.Drawing.Size(82, 24);
            this.chkCHDecode7.TabIndex = 57;
            this.chkCHDecode7.Text = "Decode 7";
            this.chkCHDecode7.UseVisualStyleBackColor = true;
            // 
            // chkCHDecode6
            // 
            this.chkCHDecode6.Location = new System.Drawing.Point(130, 214);
            this.chkCHDecode6.Name = "chkCHDecode6";
            this.chkCHDecode6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHDecode6.Size = new System.Drawing.Size(82, 24);
            this.chkCHDecode6.TabIndex = 56;
            this.chkCHDecode6.Text = "Decode 6";
            this.chkCHDecode6.UseVisualStyleBackColor = true;
            // 
            // chkCHDecode5
            // 
            this.chkCHDecode5.Location = new System.Drawing.Point(130, 184);
            this.chkCHDecode5.Name = "chkCHDecode5";
            this.chkCHDecode5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHDecode5.Size = new System.Drawing.Size(82, 24);
            this.chkCHDecode5.TabIndex = 55;
            this.chkCHDecode5.Text = "Decode 5";
            this.chkCHDecode5.UseVisualStyleBackColor = true;
            // 
            // chkCHReverseBurst
            // 
            this.chkCHReverseBurst.Location = new System.Drawing.Point(42, 137);
            this.chkCHReverseBurst.Name = "chkCHReverseBurst";
            this.chkCHReverseBurst.Size = new System.Drawing.Size(208, 24);
            this.chkCHReverseBurst.TabIndex = 50;
            this.chkCHReverseBurst.Text = "Reverse Burst/Turn-off Code";
            this.chkCHReverseBurst.UseVisualStyleBackColor = true;
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(220, 44);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(47, 28);
            this.label53.TabIndex = 49;
            this.label53.Text = "Disable PTT ID";
            // 
            // chkCHDisablePTTID
            // 
            this.chkCHDisablePTTID.Location = new System.Drawing.Point(233, 19);
            this.chkCHDisablePTTID.Name = "chkCHDisablePTTID";
            this.chkCHDisablePTTID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHDisablePTTID.Size = new System.Drawing.Size(17, 22);
            this.chkCHDisablePTTID.TabIndex = 48;
            this.chkCHDisablePTTID.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkCHDisablePTTID.UseVisualStyleBackColor = true;
            // 
            // cmboCHTXSignaling
            // 
            this.cmboCHTXSignaling.FormattingEnabled = true;
            this.cmboCHTXSignaling.Items.AddRange(new object[] {
            "Off",
            "DTMF-1",
            "DTMF-2",
            "DTMF-3",
            "DTMF-4"});
            this.cmboCHTXSignaling.Location = new System.Drawing.Point(119, 110);
            this.cmboCHTXSignaling.Name = "cmboCHTXSignaling";
            this.cmboCHTXSignaling.Size = new System.Drawing.Size(88, 21);
            this.cmboCHTXSignaling.TabIndex = 39;
            // 
            // label39
            // 
            this.label39.Location = new System.Drawing.Point(6, 108);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(107, 23);
            this.label39.TabIndex = 38;
            this.label39.Text = "TX Signaling System";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHRXSignaling
            // 
            this.cmboCHRXSignaling.FormattingEnabled = true;
            this.cmboCHRXSignaling.Items.AddRange(new object[] {
            "Off",
            "DTMF-1",
            "DTMF-2",
            "DTMF-3",
            "DTMF-4"});
            this.cmboCHRXSignaling.Location = new System.Drawing.Point(119, 87);
            this.cmboCHRXSignaling.Name = "cmboCHRXSignaling";
            this.cmboCHRXSignaling.Size = new System.Drawing.Size(88, 21);
            this.cmboCHRXSignaling.TabIndex = 37;
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(6, 85);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(107, 23);
            this.label49.TabIndex = 36;
            this.label49.Text = "RX Signaling System";
            this.label49.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHQTReverse
            // 
            this.cmboCHQTReverse.FormattingEnabled = true;
            this.cmboCHQTReverse.Items.AddRange(new object[] {
            "180",
            "120"});
            this.cmboCHQTReverse.Location = new System.Drawing.Point(119, 64);
            this.cmboCHQTReverse.Name = "cmboCHQTReverse";
            this.cmboCHQTReverse.Size = new System.Drawing.Size(88, 21);
            this.cmboCHQTReverse.TabIndex = 35;
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(6, 62);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(107, 23);
            this.label50.TabIndex = 34;
            this.label50.Text = "QT Reverse";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHCTCSSEnc
            // 
            this.cmboCHCTCSSEnc.FormattingEnabled = true;
            this.cmboCHCTCSSEnc.Items.AddRange(new object[] {
            "None",
            "67.0",
            "69.3",
            "71.0",
            "71.9",
            "74.4",
            "77.0",
            "79.7",
            "82.5",
            "85.4",
            "88.5",
            "91.5",
            "94.8",
            "97.4",
            "100.0",
            "103.5",
            "107.2",
            "110.9",
            "114.8",
            "118.8",
            "123.0",
            "127.3",
            "131.8",
            "136.5",
            "141.3",
            "146.2",
            "151.4",
            "156.7",
            "159.8",
            "162.2",
            "165.5",
            "167.9",
            "171.3",
            "173.8",
            "177.3",
            "179.9",
            "183.5",
            "186.2",
            "189.9",
            "192.8",
            "196.6",
            "199.5",
            "203.5",
            "206.5",
            "210.7",
            "218.1",
            "225.7",
            "229.1",
            "233.6",
            "241.8",
            "250.3",
            "254.1",
            "D023N",
            "D025N",
            "D026N",
            "D031N",
            "D032N",
            "D036N",
            "D043N",
            "D047N",
            "D050N",
            "D051N",
            "D053N",
            "D054N",
            "D065N",
            "D071N",
            "D072N",
            "D073N",
            "D074N",
            "D114N",
            "D115N",
            "D116N",
            "D122N",
            "D125N",
            "D131N",
            "D132N",
            "D134N",
            "D141N",
            "D143N",
            "D145N",
            "D152N",
            "D155N",
            "D156N",
            "D162N",
            "D165N",
            "D172N",
            "D174N",
            "D205N",
            "D212N",
            "D214N",
            "D223N",
            "D225N",
            "D226N",
            "D243N",
            "D244N",
            "D245N",
            "D246N",
            "D251N",
            "D252N",
            "D255N",
            "D261N",
            "D263N",
            "D265N",
            "D266N",
            "D271N",
            "D274N",
            "D306N",
            "D311N",
            "D315N",
            "D325N",
            "D331N",
            "D332N",
            "D343N",
            "D346N",
            "D351N",
            "D356N",
            "D364N",
            "D365N",
            "D371N",
            "D411N",
            "D412N",
            "D413N",
            "D423N",
            "D431N",
            "D432N",
            "D445N",
            "D446N",
            "D452N",
            "D454N",
            "D455N",
            "D462N",
            "D464N",
            "D465N",
            "D466N",
            "D503N",
            "D506N",
            "D516N",
            "D523N",
            "D526N",
            "D532N",
            "D546N",
            "D565N",
            "D606N",
            "D612N",
            "D624N",
            "D627N",
            "D631N",
            "D632N",
            "D654N",
            "D662N",
            "D664N",
            "D703N",
            "D712N",
            "D723N",
            "D731N",
            "D732N",
            "D734N",
            "D743N",
            "D754N",
            "D023I",
            "D025I",
            "D026I",
            "D031I",
            "D032I",
            "D036I",
            "D043I",
            "D047I",
            "D050I",
            "D051I",
            "D053I",
            "D054I",
            "D065I",
            "D071I",
            "D072I",
            "D073I",
            "D074I",
            "D114I",
            "D115I",
            "D116I",
            "D122I",
            "D125I",
            "D131I",
            "D132I",
            "D134I",
            "D141I",
            "D143I",
            "D145I",
            "D152I",
            "D155I",
            "D156I",
            "D162I",
            "D165I",
            "D172I",
            "D174I",
            "D205I",
            "D212I",
            "D214I",
            "D223I",
            "D225I",
            "D226I",
            "D243I",
            "D244I",
            "D245I",
            "D246I",
            "D251I",
            "D252I",
            "D255I",
            "D261I",
            "D263I",
            "D265I",
            "D266I",
            "D271I",
            "D274I",
            "D306I",
            "D311I",
            "D315I",
            "D325I",
            "D331I",
            "D332I",
            "D343I",
            "D346I",
            "D351I",
            "D356I",
            "D364I",
            "D365I",
            "D371I",
            "D411I",
            "D412I",
            "D413I",
            "D423I",
            "D431I",
            "D432I",
            "D445I",
            "D446I",
            "D452I",
            "D454I",
            "D455I",
            "D462I",
            "D464I",
            "D465I",
            "D466I",
            "D503I",
            "D506I",
            "D516I",
            "D523I",
            "D526I",
            "D532I",
            "D546I",
            "D565I",
            "D606I",
            "D612I",
            "D624I",
            "D627I",
            "D631I",
            "D632I",
            "D654I",
            "D662I",
            "D664I",
            "D703I",
            "D712I",
            "D723I",
            "D731I",
            "D732I",
            "D734I",
            "D743I",
            "D754I"});
            this.cmboCHCTCSSEnc.Location = new System.Drawing.Point(119, 41);
            this.cmboCHCTCSSEnc.Name = "cmboCHCTCSSEnc";
            this.cmboCHCTCSSEnc.Size = new System.Drawing.Size(88, 21);
            this.cmboCHCTCSSEnc.TabIndex = 33;
            this.cmboCHCTCSSEnc.SelectedIndexChanged += new System.EventHandler(this.cmboCHCTCSSEnc_SelectedIndexChanged);
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(6, 39);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(107, 23);
            this.label51.TabIndex = 32;
            this.label51.Text = "CTCSS.DCS Enc";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHCTCSSDec
            // 
            this.cmboCHCTCSSDec.FormattingEnabled = true;
            this.cmboCHCTCSSDec.Items.AddRange(new object[] {
            "None",
            "67.0",
            "69.3",
            "71.0",
            "71.9",
            "74.4",
            "77.0",
            "79.7",
            "82.5",
            "85.4",
            "88.5",
            "91.5",
            "94.8",
            "97.4",
            "100.0",
            "103.5",
            "107.2",
            "110.9",
            "114.8",
            "118.8",
            "123.0",
            "127.3",
            "131.8",
            "136.5",
            "141.3",
            "146.2",
            "151.4",
            "156.7",
            "159.8",
            "162.2",
            "165.5",
            "167.9",
            "171.3",
            "173.8",
            "177.3",
            "179.9",
            "183.5",
            "186.2",
            "189.9",
            "192.8",
            "196.6",
            "199.5",
            "203.5",
            "206.5",
            "210.7",
            "218.1",
            "225.7",
            "229.1",
            "233.6",
            "241.8",
            "250.3",
            "254.1",
            "D023N",
            "D025N",
            "D026N",
            "D031N",
            "D032N",
            "D036N",
            "D043N",
            "D047N",
            "D050N",
            "D051N",
            "D053N",
            "D054N",
            "D065N",
            "D071N",
            "D072N",
            "D073N",
            "D074N",
            "D114N",
            "D115N",
            "D116N",
            "D122N",
            "D125N",
            "D131N",
            "D132N",
            "D134N",
            "D141N",
            "D143N",
            "D145N",
            "D152N",
            "D155N",
            "D156N",
            "D162N",
            "D165N",
            "D172N",
            "D174N",
            "D205N",
            "D212N",
            "D214N",
            "D223N",
            "D225N",
            "D226N",
            "D243N",
            "D244N",
            "D245N",
            "D246N",
            "D251N",
            "D252N",
            "D255N",
            "D261N",
            "D263N",
            "D265N",
            "D266N",
            "D271N",
            "D274N",
            "D306N",
            "D311N",
            "D315N",
            "D325N",
            "D331N",
            "D332N",
            "D343N",
            "D346N",
            "D351N",
            "D356N",
            "D364N",
            "D365N",
            "D371N",
            "D411N",
            "D412N",
            "D413N",
            "D423N",
            "D431N",
            "D432N",
            "D445N",
            "D446N",
            "D452N",
            "D454N",
            "D455N",
            "D462N",
            "D464N",
            "D465N",
            "D466N",
            "D503N",
            "D506N",
            "D516N",
            "D523N",
            "D526N",
            "D532N",
            "D546N",
            "D565N",
            "D606N",
            "D612N",
            "D624N",
            "D627N",
            "D631N",
            "D632N",
            "D654N",
            "D662N",
            "D664N",
            "D703N",
            "D712N",
            "D723N",
            "D731N",
            "D732N",
            "D734N",
            "D743N",
            "D754N",
            "D023I",
            "D025I",
            "D026I",
            "D031I",
            "D032I",
            "D036I",
            "D043I",
            "D047I",
            "D050I",
            "D051I",
            "D053I",
            "D054I",
            "D065I",
            "D071I",
            "D072I",
            "D073I",
            "D074I",
            "D114I",
            "D115I",
            "D116I",
            "D122I",
            "D125I",
            "D131I",
            "D132I",
            "D134I",
            "D141I",
            "D143I",
            "D145I",
            "D152I",
            "D155I",
            "D156I",
            "D162I",
            "D165I",
            "D172I",
            "D174I",
            "D205I",
            "D212I",
            "D214I",
            "D223I",
            "D225I",
            "D226I",
            "D243I",
            "D244I",
            "D245I",
            "D246I",
            "D251I",
            "D252I",
            "D255I",
            "D261I",
            "D263I",
            "D265I",
            "D266I",
            "D271I",
            "D274I",
            "D306I",
            "D311I",
            "D315I",
            "D325I",
            "D331I",
            "D332I",
            "D343I",
            "D346I",
            "D351I",
            "D356I",
            "D364I",
            "D365I",
            "D371I",
            "D411I",
            "D412I",
            "D413I",
            "D423I",
            "D431I",
            "D432I",
            "D445I",
            "D446I",
            "D452I",
            "D454I",
            "D455I",
            "D462I",
            "D464I",
            "D465I",
            "D466I",
            "D503I",
            "D506I",
            "D516I",
            "D523I",
            "D526I",
            "D532I",
            "D546I",
            "D565I",
            "D606I",
            "D612I",
            "D624I",
            "D627I",
            "D631I",
            "D632I",
            "D654I",
            "D662I",
            "D664I",
            "D703I",
            "D712I",
            "D723I",
            "D731I",
            "D732I",
            "D734I",
            "D743I",
            "D754I"});
            this.cmboCHCTCSSDec.Location = new System.Drawing.Point(119, 18);
            this.cmboCHCTCSSDec.Name = "cmboCHCTCSSDec";
            this.cmboCHCTCSSDec.Size = new System.Drawing.Size(88, 21);
            this.cmboCHCTCSSDec.TabIndex = 31;
            // 
            // label52
            // 
            this.label52.Location = new System.Drawing.Point(6, 16);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(107, 23);
            this.label52.TabIndex = 30;
            this.label52.Text = "CTCSS/DCS Dec";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox18
            // 
            this.groupBox18.Controls.Add(this.txtCHTXFreq);
            this.groupBox18.Controls.Add(this.txtCHRXFreq);
            this.groupBox18.Controls.Add(this.txtCHChannelName);
            this.groupBox18.Controls.Add(this.chkCHAlwTalkaround);
            this.groupBox18.Controls.Add(this.chkCHVOX);
            this.groupBox18.Controls.Add(this.chkCHLoneWorker);
            this.groupBox18.Controls.Add(this.chkCHRXOnly);
            this.groupBox18.Controls.Add(this.chkCHAutoScan);
            this.groupBox18.Controls.Add(this.cmboCHAdmitCriteria);
            this.groupBox18.Controls.Add(this.label48);
            this.groupBox18.Controls.Add(this.label43);
            this.groupBox18.Controls.Add(this.label44);
            this.groupBox18.Controls.Add(this.label45);
            this.groupBox18.Controls.Add(this.cmboCHPower);
            this.groupBox18.Controls.Add(this.label46);
            this.groupBox18.Controls.Add(this.cmboCHTOTRekeyDelay);
            this.groupBox18.Controls.Add(this.label47);
            this.groupBox18.Controls.Add(this.cmboCHTOT);
            this.groupBox18.Controls.Add(this.label40);
            this.groupBox18.Controls.Add(this.cmboCHTXRefFreq);
            this.groupBox18.Controls.Add(this.label41);
            this.groupBox18.Controls.Add(this.cmboCHRXRefFreq);
            this.groupBox18.Controls.Add(this.label42);
            this.groupBox18.Controls.Add(this.cmboCHSquelch);
            this.groupBox18.Controls.Add(this.label37);
            this.groupBox18.Controls.Add(this.cmboCHScanList);
            this.groupBox18.Controls.Add(this.label38);
            this.groupBox18.Controls.Add(this.cmboCHBandwidth);
            this.groupBox18.Controls.Add(this.label36);
            this.groupBox18.Controls.Add(this.cmboCHChannelMode);
            this.groupBox18.Controls.Add(this.label35);
            this.groupBox18.Location = new System.Drawing.Point(232, 7);
            this.groupBox18.Name = "groupBox18";
            this.groupBox18.Size = new System.Drawing.Size(569, 187);
            this.groupBox18.TabIndex = 14;
            this.groupBox18.TabStop = false;
            this.groupBox18.Text = "Channel Info";
            // 
            // txtCHTXFreq
            // 
            this.txtCHTXFreq.Location = new System.Drawing.Point(324, 111);
            this.txtCHTXFreq.Name = "txtCHTXFreq";
            this.txtCHTXFreq.Size = new System.Drawing.Size(111, 20);
            this.txtCHTXFreq.TabIndex = 71;
            // 
            // txtCHRXFreq
            // 
            this.txtCHRXFreq.Location = new System.Drawing.Point(324, 87);
            this.txtCHRXFreq.Name = "txtCHRXFreq";
            this.txtCHRXFreq.Size = new System.Drawing.Size(111, 20);
            this.txtCHRXFreq.TabIndex = 70;
            // 
            // txtCHChannelName
            // 
            this.txtCHChannelName.Location = new System.Drawing.Point(324, 64);
            this.txtCHChannelName.Name = "txtCHChannelName";
            this.txtCHChannelName.Size = new System.Drawing.Size(111, 20);
            this.txtCHChannelName.TabIndex = 69;
            // 
            // chkCHAlwTalkaround
            // 
            this.chkCHAlwTalkaround.Location = new System.Drawing.Point(441, 138);
            this.chkCHAlwTalkaround.Name = "chkCHAlwTalkaround";
            this.chkCHAlwTalkaround.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHAlwTalkaround.Size = new System.Drawing.Size(122, 24);
            this.chkCHAlwTalkaround.TabIndex = 68;
            this.chkCHAlwTalkaround.Text = "Allow Talkaround";
            this.chkCHAlwTalkaround.UseVisualStyleBackColor = true;
            // 
            // chkCHVOX
            // 
            this.chkCHVOX.Location = new System.Drawing.Point(441, 108);
            this.chkCHVOX.Name = "chkCHVOX";
            this.chkCHVOX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHVOX.Size = new System.Drawing.Size(122, 24);
            this.chkCHVOX.TabIndex = 67;
            this.chkCHVOX.Text = "VOX";
            this.chkCHVOX.UseVisualStyleBackColor = true;
            // 
            // chkCHLoneWorker
            // 
            this.chkCHLoneWorker.Location = new System.Drawing.Point(441, 78);
            this.chkCHLoneWorker.Name = "chkCHLoneWorker";
            this.chkCHLoneWorker.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHLoneWorker.Size = new System.Drawing.Size(122, 24);
            this.chkCHLoneWorker.TabIndex = 65;
            this.chkCHLoneWorker.Text = "Lone Worker";
            this.chkCHLoneWorker.UseVisualStyleBackColor = true;
            // 
            // chkCHRXOnly
            // 
            this.chkCHRXOnly.Location = new System.Drawing.Point(441, 48);
            this.chkCHRXOnly.Name = "chkCHRXOnly";
            this.chkCHRXOnly.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHRXOnly.Size = new System.Drawing.Size(122, 24);
            this.chkCHRXOnly.TabIndex = 64;
            this.chkCHRXOnly.Text = "RX Only";
            this.chkCHRXOnly.UseVisualStyleBackColor = true;
            // 
            // chkCHAutoScan
            // 
            this.chkCHAutoScan.Location = new System.Drawing.Point(441, 18);
            this.chkCHAutoScan.Name = "chkCHAutoScan";
            this.chkCHAutoScan.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkCHAutoScan.Size = new System.Drawing.Size(122, 24);
            this.chkCHAutoScan.TabIndex = 63;
            this.chkCHAutoScan.Text = "Auto Scan";
            this.chkCHAutoScan.UseVisualStyleBackColor = true;
            // 
            // cmboCHAdmitCriteria
            // 
            this.cmboCHAdmitCriteria.FormattingEnabled = true;
            this.cmboCHAdmitCriteria.Items.AddRange(new object[] {
            "Always",
            "Channel Free",
            "Color Code"});
            this.cmboCHAdmitCriteria.Location = new System.Drawing.Point(324, 135);
            this.cmboCHAdmitCriteria.Name = "cmboCHAdmitCriteria";
            this.cmboCHAdmitCriteria.Size = new System.Drawing.Size(111, 21);
            this.cmboCHAdmitCriteria.TabIndex = 47;
            // 
            // label48
            // 
            this.label48.Location = new System.Drawing.Point(213, 133);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(105, 23);
            this.label48.TabIndex = 46;
            this.label48.Text = "Admit Criteria";
            this.label48.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(213, 110);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(105, 23);
            this.label43.TabIndex = 44;
            this.label43.Text = "TX Frequency(Mhz)";
            this.label43.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label44
            // 
            this.label44.Location = new System.Drawing.Point(213, 87);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(105, 23);
            this.label44.TabIndex = 42;
            this.label44.Text = "RX Frequency(Mhz)";
            this.label44.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(213, 64);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(105, 23);
            this.label45.TabIndex = 40;
            this.label45.Text = "Channel Name";
            this.label45.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHPower
            // 
            this.cmboCHPower.FormattingEnabled = true;
            this.cmboCHPower.Items.AddRange(new object[] {
            "Low",
            "High"});
            this.cmboCHPower.Location = new System.Drawing.Point(324, 43);
            this.cmboCHPower.Name = "cmboCHPower";
            this.cmboCHPower.Size = new System.Drawing.Size(111, 21);
            this.cmboCHPower.TabIndex = 39;
            // 
            // label46
            // 
            this.label46.Location = new System.Drawing.Point(213, 41);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(105, 23);
            this.label46.TabIndex = 38;
            this.label46.Text = "Power";
            this.label46.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHTOTRekeyDelay
            // 
            this.cmboCHTOTRekeyDelay.FormattingEnabled = true;
            this.cmboCHTOTRekeyDelay.Items.AddRange(new object[] {
            "None",
            "Digital",
            "Analog",
            "Digital and Analog"});
            this.cmboCHTOTRekeyDelay.Location = new System.Drawing.Point(324, 20);
            this.cmboCHTOTRekeyDelay.Name = "cmboCHTOTRekeyDelay";
            this.cmboCHTOTRekeyDelay.Size = new System.Drawing.Size(111, 21);
            this.cmboCHTOTRekeyDelay.TabIndex = 37;
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(213, 18);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(105, 23);
            this.label47.TabIndex = 36;
            this.label47.Text = "TOT Rekey Delay(s)";
            this.label47.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHTOT
            // 
            this.cmboCHTOT.FormattingEnabled = true;
            this.cmboCHTOT.Items.AddRange(new object[] {
            "Infinite",
            "15",
            "30",
            "45",
            "60",
            "75",
            "90",
            "105",
            "120",
            "135",
            "150",
            "165",
            "180",
            "195",
            "210",
            "225",
            "240",
            "255",
            "270",
            "285",
            "300",
            "315",
            "330",
            "345",
            "360",
            "375",
            "390",
            "405",
            "420",
            "435",
            "450",
            "465",
            "480",
            "495",
            "510",
            "525",
            "540",
            "555"});
            this.cmboCHTOT.Location = new System.Drawing.Point(119, 156);
            this.cmboCHTOT.Name = "cmboCHTOT";
            this.cmboCHTOT.Size = new System.Drawing.Size(88, 21);
            this.cmboCHTOT.TabIndex = 33;
            // 
            // label40
            // 
            this.label40.Location = new System.Drawing.Point(6, 154);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(107, 23);
            this.label40.TabIndex = 32;
            this.label40.Text = "TOT(s)";
            this.label40.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHTXRefFreq
            // 
            this.cmboCHTXRefFreq.FormattingEnabled = true;
            this.cmboCHTXRefFreq.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmboCHTXRefFreq.Location = new System.Drawing.Point(119, 133);
            this.cmboCHTXRefFreq.Name = "cmboCHTXRefFreq";
            this.cmboCHTXRefFreq.Size = new System.Drawing.Size(88, 21);
            this.cmboCHTXRefFreq.TabIndex = 31;
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(6, 131);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(107, 23);
            this.label41.TabIndex = 30;
            this.label41.Text = "TX Ref Frequency";
            this.label41.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHRXRefFreq
            // 
            this.cmboCHRXRefFreq.FormattingEnabled = true;
            this.cmboCHRXRefFreq.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.cmboCHRXRefFreq.Location = new System.Drawing.Point(119, 110);
            this.cmboCHRXRefFreq.Name = "cmboCHRXRefFreq";
            this.cmboCHRXRefFreq.Size = new System.Drawing.Size(88, 21);
            this.cmboCHRXRefFreq.TabIndex = 29;
            // 
            // label42
            // 
            this.label42.Location = new System.Drawing.Point(6, 108);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(107, 23);
            this.label42.TabIndex = 28;
            this.label42.Text = "RX Ref Frequency";
            this.label42.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHSquelch
            // 
            this.cmboCHSquelch.FormattingEnabled = true;
            this.cmboCHSquelch.Items.AddRange(new object[] {
            "Tight",
            "Normal"});
            this.cmboCHSquelch.Location = new System.Drawing.Point(119, 87);
            this.cmboCHSquelch.Name = "cmboCHSquelch";
            this.cmboCHSquelch.Size = new System.Drawing.Size(88, 21);
            this.cmboCHSquelch.TabIndex = 27;
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(6, 85);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(107, 23);
            this.label37.TabIndex = 26;
            this.label37.Text = "Squelch";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHScanList
            // 
            this.cmboCHScanList.FormattingEnabled = true;
            this.cmboCHScanList.Items.AddRange(new object[] {
            "None"});
            this.cmboCHScanList.Location = new System.Drawing.Point(119, 64);
            this.cmboCHScanList.Name = "cmboCHScanList";
            this.cmboCHScanList.Size = new System.Drawing.Size(88, 21);
            this.cmboCHScanList.TabIndex = 25;
            // 
            // label38
            // 
            this.label38.Location = new System.Drawing.Point(6, 62);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(107, 23);
            this.label38.TabIndex = 24;
            this.label38.Text = "Scan List";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHBandwidth
            // 
            this.cmboCHBandwidth.FormattingEnabled = true;
            this.cmboCHBandwidth.Items.AddRange(new object[] {
            "12.5Khz",
            "25Khz"});
            this.cmboCHBandwidth.Location = new System.Drawing.Point(119, 41);
            this.cmboCHBandwidth.Name = "cmboCHBandwidth";
            this.cmboCHBandwidth.Size = new System.Drawing.Size(88, 21);
            this.cmboCHBandwidth.TabIndex = 23;
            // 
            // label36
            // 
            this.label36.Location = new System.Drawing.Point(6, 39);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(107, 23);
            this.label36.TabIndex = 22;
            this.label36.Text = "Band Width";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmboCHChannelMode
            // 
            this.cmboCHChannelMode.FormattingEnabled = true;
            this.cmboCHChannelMode.Items.AddRange(new object[] {
            "Analog",
            "Digital"});
            this.cmboCHChannelMode.Location = new System.Drawing.Point(119, 18);
            this.cmboCHChannelMode.Name = "cmboCHChannelMode";
            this.cmboCHChannelMode.Size = new System.Drawing.Size(88, 21);
            this.cmboCHChannelMode.TabIndex = 21;
            this.cmboCHChannelMode.SelectedIndexChanged += new System.EventHandler(this.cmboCHChannelMode_SelectedIndexChanged);
            // 
            // label35
            // 
            this.label35.Location = new System.Drawing.Point(6, 16);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(107, 23);
            this.label35.TabIndex = 20;
            this.label35.Text = "Channel Mode";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCHMvDwn
            // 
            this.btnCHMvDwn.Location = new System.Drawing.Point(150, 524);
            this.btnCHMvDwn.Name = "btnCHMvDwn";
            this.btnCHMvDwn.Size = new System.Drawing.Size(75, 23);
            this.btnCHMvDwn.TabIndex = 13;
            this.btnCHMvDwn.Text = "Move Down";
            this.btnCHMvDwn.UseVisualStyleBackColor = true;
            this.btnCHMvDwn.Click += new System.EventHandler(this.btnCHMvDwn_Click);
            // 
            // btnCHMvUp
            // 
            this.btnCHMvUp.Location = new System.Drawing.Point(9, 524);
            this.btnCHMvUp.Name = "btnCHMvUp";
            this.btnCHMvUp.Size = new System.Drawing.Size(75, 23);
            this.btnCHMvUp.TabIndex = 12;
            this.btnCHMvUp.Text = "Move Up";
            this.btnCHMvUp.UseVisualStyleBackColor = true;
            this.btnCHMvUp.Click += new System.EventHandler(this.btnCHMvUp_Click);
            // 
            // lstChannels
            // 
            this.lstChannels.FormattingEnabled = true;
            this.lstChannels.Location = new System.Drawing.Point(9, 7);
            this.lstChannels.Name = "lstChannels";
            this.lstChannels.Size = new System.Drawing.Size(216, 511);
            this.lstChannels.TabIndex = 11;
            this.lstChannels.SelectedIndexChanged += new System.EventHandler(this.lstChannels_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 627);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "W9UEY MD-380 Code Plug Reorganizer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage8.ResumeLayout(false);
            this.groupBox15.ResumeLayout(false);
            this.groupBox15.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numGnRXLowBatInt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGnTXPreambleDur)).EndInit();
            this.groupBox13.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numGnPrvCallHngTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGnGrpCallHngTime)).EndInit();
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numLnWrkrRemTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGnLnWrkrRespTime)).EndInit();
            this.groupBox10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAnlgHngTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numGnDigHngTime)).EndInit();
            this.groupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericCallToneAlertDurationUpDown1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.tabPage7.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMenuHangTimeUpDown1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radGridContacts.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radGridContacts)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox20.ResumeLayout(false);
            this.groupBox19.ResumeLayout(false);
            this.groupBox18.ResumeLayout(false);
            this.groupBox18.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private Telerik.WinControls.UI.RadGridView radGridContacts;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnGrpLstMoveDown;
        private System.Windows.Forms.Button btnGrpLstMoveUp;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGrpLstRemove;
        private System.Windows.Forms.TextBox txtGroupListName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGrpLstAdd;
        private System.Windows.Forms.Button btnGrpAssnMoveDown;
        private System.Windows.Forms.Button btnGrpAssnMoveUp;
        private System.Windows.Forms.ListBox lstGrpAssn;
        private System.Windows.Forms.ListBox lstGrpAvail;
        private System.Windows.Forms.ListBox lstGroupList;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblUniqueDeviceID;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblMCUVer;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblHardwareVer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCPSVersion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSerial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblLastProgDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ddlBscFreqRange;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.CheckBox chkMnuEditList;
        private System.Windows.Forms.CheckBox chkMnuScan;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkMnuPrgRadio;
        private System.Windows.Forms.CheckBox chkMnuDisplayMode;
        private System.Windows.Forms.CheckBox chkMnuVOX;
        private System.Windows.Forms.CheckBox chkMnuPasswordLock;
        private System.Windows.Forms.CheckBox chkMnuSquelch;
        private System.Windows.Forms.CheckBox chkMnuLEDInd;
        private System.Windows.Forms.CheckBox chkMnuKeyboardLock;
        private System.Windows.Forms.CheckBox chkMnuIntroScreen;
        private System.Windows.Forms.CheckBox chkMnuBacklight;
        private System.Windows.Forms.CheckBox chkMnuPower;
        private System.Windows.Forms.CheckBox chkMnuToneAlert;
        private System.Windows.Forms.CheckBox chkMnuTalkaround;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.CheckBox chkMnuAnswered;
        private System.Windows.Forms.CheckBox chkMnuOutgoingRadio;
        private System.Windows.Forms.CheckBox chkMnuMissed;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkMnuRadioDisable;
        private System.Windows.Forms.CheckBox chkMnuRadioEnable;
        private System.Windows.Forms.CheckBox chkMnuPrgKey;
        private System.Windows.Forms.CheckBox chkMnuRemMon;
        private System.Windows.Forms.CheckBox chkMnuRadioCheck;
        private System.Windows.Forms.CheckBox chkMnuManDial;
        private System.Windows.Forms.CheckBox chkMnuEdit;
        private System.Windows.Forms.CheckBox chkMnuCallAlert;
        private System.Windows.Forms.CheckBox chkMnuTextMessage;
        private System.Windows.Forms.Label lblMenuHangTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.ComboBox cmboGnIntroScreen;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtGnIntroLine2;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtGnIntroLine1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBox14;
        private System.Windows.Forms.CheckBox chkGnDisableLEDs;
        private System.Windows.Forms.ComboBox cmboGnKeypadLockTime;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cmboGnBackltTime;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.TextBox txtGnRadioPrgPassword;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox txtGnPCPrgPassword;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.NumericUpDown numGnRXLowBatInt;
        private System.Windows.Forms.NumericUpDown numGnTXPreambleDur;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmboGnVOXSnstvty;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmboGnMonType;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtGnRadioID;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtGnRadioName;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.GroupBox groupBox13;
        private System.Windows.Forms.NumericUpDown numGnPrvCallHngTime;
        private System.Windows.Forms.NumericUpDown numGnGrpCallHngTime;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TextBox txtGnPowerOnPassword;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox chkGnPasswordLockEnable;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.NumericUpDown numLnWrkrRemTime;
        private System.Windows.Forms.NumericUpDown numGnLnWrkrRespTime;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.NumericUpDown numAnlgHngTime;
        private System.Windows.Forms.NumericUpDown numGnDigHngTime;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmboGnTalkPermTone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkGnDisableAllTone;
        private System.Windows.Forms.CheckBox chkGnCHFreeIndTone;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chkGnSaveModeRec;
        private System.Windows.Forms.CheckBox chkGnSavePreamble;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.Button btnZnRemove;
        private System.Windows.Forms.TextBox txtZnName;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Button btnZnAdd;
        private System.Windows.Forms.Button btnZnAssnMvDwn;
        private System.Windows.Forms.Button btnZnAssnMvUp;
        private System.Windows.Forms.ListBox lstZnChanAssigned;
        private System.Windows.Forms.ListBox lstZnChanAvail;
        private System.Windows.Forms.Button btnZnMvDwn;
        private System.Windows.Forms.Button btnZnMvUp;
        private System.Windows.Forms.ListBox lstZones;
        private System.Windows.Forms.Button btnScnMvDwn;
        private System.Windows.Forms.Button btnScnMvUp;
        private System.Windows.Forms.ListBox lstScanLists;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.Button btnScnRemove;
        private System.Windows.Forms.TextBox txtScnName;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Button btnScnAdd;
        private System.Windows.Forms.ListBox lstScnChanAssn;
        private System.Windows.Forms.ListBox lstScnChanAvail;
        private System.Windows.Forms.Button btnScnChanMvUp;
        private System.Windows.Forms.Button btnScnChanMvDwn;
        private NumericCallToneAlertDurationUpDown numericCallToneAlertDurationUpDown1;
        private CustomControls.NumericMenuHangTimeUpDown numericMenuHangTimeUpDown1;
        private System.Windows.Forms.Button btnCHMvDwn;
        private System.Windows.Forms.Button btnCHMvUp;
        private System.Windows.Forms.ListBox lstChannels;
        private System.Windows.Forms.GroupBox groupBox20;
        private System.Windows.Forms.ComboBox cmboCHPrivacyNo;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.ComboBox cmboCHPrivacy;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.CheckBox chkCHCompUDP;
        private System.Windows.Forms.ComboBox cmboCHTS;
        private System.Windows.Forms.CheckBox chkCHDataCallConf;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.CheckBox chkCHEmgcyAlrmAck;
        private System.Windows.Forms.ComboBox cmboCHColorCode;
        private System.Windows.Forms.CheckBox chkCHPrivCallConf;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.ComboBox cmboCHGroupList;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.ComboBox cmboCHContactName;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.ComboBox cmboCHEmgcySys;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.GroupBox groupBox19;
        private System.Windows.Forms.CheckBox chkCHDecode4;
        private System.Windows.Forms.CheckBox chkCHDecode3;
        private System.Windows.Forms.CheckBox chkCHDecode2;
        private System.Windows.Forms.CheckBox chkCHDecode1;
        private System.Windows.Forms.CheckBox chkCHDecode8;
        private System.Windows.Forms.CheckBox chkCHDecode7;
        private System.Windows.Forms.CheckBox chkCHDecode6;
        private System.Windows.Forms.CheckBox chkCHDecode5;
        private System.Windows.Forms.CheckBox chkCHReverseBurst;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.CheckBox chkCHDisablePTTID;
        private System.Windows.Forms.ComboBox cmboCHTXSignaling;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.ComboBox cmboCHRXSignaling;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.ComboBox cmboCHQTReverse;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.ComboBox cmboCHCTCSSEnc;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.ComboBox cmboCHCTCSSDec;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.GroupBox groupBox18;
        private System.Windows.Forms.TextBox txtCHTXFreq;
        private System.Windows.Forms.TextBox txtCHRXFreq;
        private System.Windows.Forms.TextBox txtCHChannelName;
        private System.Windows.Forms.CheckBox chkCHAlwTalkaround;
        private System.Windows.Forms.CheckBox chkCHVOX;
        private System.Windows.Forms.CheckBox chkCHLoneWorker;
        private System.Windows.Forms.CheckBox chkCHRXOnly;
        private System.Windows.Forms.CheckBox chkCHAutoScan;
        private System.Windows.Forms.ComboBox cmboCHAdmitCriteria;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.ComboBox cmboCHPower;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.ComboBox cmboCHTOTRekeyDelay;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox cmboCHTOT;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.ComboBox cmboCHTXRefFreq;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.ComboBox cmboCHRXRefFreq;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.ComboBox cmboCHSquelch;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cmboCHScanList;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.ComboBox cmboCHBandwidth;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.ComboBox cmboCHChannelMode;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.ComboBox cmboSLSampleTime;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.ComboBox cmboSLSignalingHoldTime;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.ComboBox cmboSLTXCH;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.ComboBox cmboSLPriorityB;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.ComboBox cmboSLPriorityA;
        private System.Windows.Forms.Label label62;
    }
}

