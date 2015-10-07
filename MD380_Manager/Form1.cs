﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Exchange.WebServices.Data;
using Telerik.WinControls.UI;

namespace MD380_Manager
{
    public partial class Form1 : Form
    {
        private byte[] _F;
        private RadContextMenu cntContextMenu;
        public Form1()
        {
            InitializeComponent();
            radGridContacts.ContextMenuOpening += radGridContacts_ContextMenuOpening;
            txtGroupListName.Leave += txtGroupListName_TextChanged;
            initControls();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public void initControls()
        {
            // Basic Info Tab
            List<string> freqChoices = new List<string>();
            freqChoices.Add("136-174Mhz");
            freqChoices.Add("350-400Mhz");
            freqChoices.Add("400-480Mhz");
            freqChoices.Add("450-520Mhz");
            ddlBscFreqRange.DataSource = freqChoices;

            // General Settings
            cmboGnTalkPermTone.SelectedItem = "None";
            cmboGnMonType.SelectedItem = "Open Squelch";
            cmboGnVOXSnstvty.SelectedItem = "3";
            cmboGnBackltTime.SelectedItem = "Always";
            cmboGnKeypadLockTime.SelectedItem = "Manual";
            cmboGnIntroScreen.SelectedItem = "Picture";

            // Contacts Tab
            cntContextMenu = new RadContextMenu();
            RadMenuItem mvUp = new RadMenuItem();
            mvUp.Text = "Move Up";
            mvUp.Click += new EventHandler(cntMoveUp);
            cntContextMenu.Items.Add(mvUp);
            RadMenuItem mvDwn = new RadMenuItem();
            mvDwn.Text = "Move Down";
            mvDwn.Click += new EventHandler(cntMoveDown);
            cntContextMenu.Items.Add(mvDwn);

            // Channels Tab
            cmboCHTOTRekeyDelay.Items.Clear();
            for (int i = 0; i < 256; i++)
                cmboCHTOTRekeyDelay.Items.Add(i.ToString());

                initChannels();
        }
        private void refreshScreens()
        {
            initScanLists();

            loadBasicInfo();
            loadGeneralSettings();
            loadMenuItems();
            loadContacts();
            loadGroups(-1);
            loadZones(-1);
            loadScanLists(-1);
            loadChannels(-1);
        }
        #region Basic Info
        private void loadBasicInfo()
        {
            ddlBscFreqRange.SelectedItem = MD380Data.Basic_Info.FrequencyRange;
            lblLastProgDate.Text = MD380Data.Basic_Info.LastProgramDate;
            lblModel.Text = MD380Data.Basic_Info.ModelName;
            lblSerial.Text = MD380Data.Basic_Info.SerialNumber;
            lblCPSVersion.Text = MD380Data.Basic_Info.CPSVersion;
            lblHardwareVer.Text = MD380Data.Basic_Info.HardwareVersion;
            lblMCUVer.Text = MD380Data.Basic_Info.MCUVersion;
            lblUniqueDeviceID.Text = MD380Data.Basic_Info.UniqueDeviceID;
        }
        #endregion

        #region General Settings

        private void loadGeneralSettings()
        {
            // Save Preamble
            chkGnSavePreamble.Checked = MD380Data.GeneralSettings.SavePreamble;

            // Save Mode Receive
            chkGnSaveModeRec.Checked = MD380Data.GeneralSettings.SaveModeReceive;

            // Disable All Tone
            chkGnDisableAllTone.Checked = MD380Data.GeneralSettings.DisableAllTone;

            // CH Free Indicator
            chkGnCHFreeIndTone.Checked = MD380Data.GeneralSettings.CHFreeIndTone;

            // Password Lock Enable
            chkGnPasswordLockEnable.Checked = MD380Data.GeneralSettings.PasswordLockEnable;

            // Disable All LEDs
            chkGnDisableLEDs.Checked = MD380Data.GeneralSettings.DisableAllLEDS;

            // Talk Permit Tone
            cmboGnTalkPermTone.SelectedItem = MD380Data.GeneralSettings.TalkPermitTone;

            // Monitor Type
            cmboGnMonType.SelectedItem = MD380Data.GeneralSettings.MonitorType;

            // VOX
            cmboGnVOXSnstvty.SelectedItem = MD380Data.GeneralSettings.VOXSensitivity;

            // Backlight Time
            cmboGnBackltTime.SelectedItem = MD380Data.GeneralSettings.BackLightTime;

            // Set Keypad Lock
            cmboGnKeypadLockTime.SelectedItem = MD380Data.GeneralSettings.SetKeypadLockTime;

            // Intro Screen
            cmboGnIntroScreen.SelectedItem = MD380Data.GeneralSettings.IntroScreen;

            // NumericUpDown
            // Call Alert Tone Duration
            numericCallToneAlertDurationUpDown1.Value = MD380Data.GeneralSettings.CallAlertToneDuration;

            // Dig Scan Time
            numGnDigHngTime.Value = MD380Data.GeneralSettings.ScanDigitalHangTime;

            // Anl Scan Time
            numAnlgHngTime.Value = MD380Data.GeneralSettings.ScanAnalogHangTime;

            // Lone Worker 1
            numGnLnWrkrRespTime.Value = MD380Data.GeneralSettings.LoneWorkerRespTime;

            // Lone Worker 2
            numLnWrkrRemTime.Value = MD380Data.GeneralSettings.LoneWorkerReminderTime;

            // TX Preamble
            numGnTXPreambleDur.Value = MD380Data.GeneralSettings.TXPreambleDuration;

            // RX Low Bat
            numGnRXLowBatInt.Value = MD380Data.GeneralSettings.RXLowBatInterval;

            // Grp Call Hang Time
            numGnGrpCallHngTime.Value = MD380Data.GeneralSettings.GroupCallHangTime;

            // Prv Call Hang Time
            numGnPrvCallHngTime.Value = MD380Data.GeneralSettings.PrivateCallHangTime;
            
            // Textboxes
            // Radio Name
            txtGnRadioName.Text = MD380Data.GeneralSettings.RadioName;

            // Radio ID
            txtGnRadioID.Text = MD380Data.GeneralSettings.RadioID;

            // PC Prog Password
            txtGnPCPrgPassword.Text = MD380Data.GeneralSettings.PCProgPassword;

            // Radio Password
            txtGnRadioPrgPassword.Text = MD380Data.GeneralSettings.RadioProgPassword;

            // Power On Password
            txtGnPowerOnPassword.Text = MD380Data.GeneralSettings.PowerOnPassword;
            txtGnPowerOnPassword.Enabled = chkGnPasswordLockEnable.Checked;

            // Intro Line 1
            txtGnIntroLine1.Text = MD380Data.GeneralSettings.IntroScreenLine1;

            // Intro Line 2
            txtGnIntroLine2.Text = MD380Data.GeneralSettings.IntroScreenLine2;
        }
        private void chkGnPasswordLockEnable_CheckedChanged(object sender, EventArgs e)
        {
            txtGnPowerOnPassword.Enabled = chkGnPasswordLockEnable.Checked;
        }
        private void cmboGnIntroScreen_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboGnIntroScreen.SelectedItem == "Characters")
            {
                txtGnIntroLine1.Enabled = true;
                txtGnIntroLine2.Enabled = true;
            }
            else
            {
                txtGnIntroLine1.Enabled = false;
                txtGnIntroLine2.Enabled = false;
            }
        }

        #endregion

        #region Menu Items

        private void loadMenuItems()
        {
            // Menu Hang Time
            numericMenuHangTimeUpDown1.Value = MD380Data.MenuItem.MenuHangTime;

            // Text Message
            chkMnuTextMessage.Checked = MD380Data.MenuItem.TextMessage;

            // Call Alert
            chkMnuCallAlert.Checked = MD380Data.MenuItem.CallAlert;

            // Edit
            chkMnuEdit.Checked = MD380Data.MenuItem.Edit;

            // Manual Dial
            chkMnuManDial.Checked = MD380Data.MenuItem.ManualDial;

            // Radio Check
            chkMnuRadioCheck.Checked = MD380Data.MenuItem.RadioCheck;

            // Remote Monitor
            chkMnuRemMon.Checked = MD380Data.MenuItem.RemoteMonitor;

            // Program Key
            chkMnuPrgKey.Checked = MD380Data.MenuItem.ProgramKey;

            // Radio Enable
            chkMnuRadioEnable.Checked = MD380Data.MenuItem.RadioEnable;

            // Radio Disable
            chkMnuRadioDisable.Checked = MD380Data.MenuItem.RadioDisable;

            // Missed
            chkMnuMissed.Checked = MD380Data.MenuItem.Missed;

            // Answered
            chkMnuAnswered.Checked = MD380Data.MenuItem.Answered;

            // Outgoing Radio
            chkMnuOutgoingRadio.Checked = MD380Data.MenuItem.OutgoingRadio;

            // Scan
            chkMnuScan.Checked = MD380Data.MenuItem.Scan;

            // Edit List
            chkMnuEditList.Checked = MD380Data.MenuItem.EditList;

            // Talkaround
            chkMnuTalkaround.Checked = MD380Data.MenuItem.Talkaround;

            // Tone or Alert
            

            // Power

            // Backlight

            // Intro

            // Keyboard Lock

            // LED Indicator

            // Squelch

            // Password and Lock

            // VOX

            // Display Mode

            // Program Radio
        }

        #endregion

        #region Contacts
        private void loadContacts()
        {
            radGridContacts.DataSource = MD380Data.Contacts.Where(a =>a.CallType != "BLANK");
        }
        void radGridContacts_DataBindingComplete(object sender, Telerik.WinControls.UI.GridViewBindingCompleteEventArgs e)
        {
            foreach (GridViewRowInfo row in radGridContacts.Rows)
            {
                if (row.Cells[1].Value == "ALL CALL")
                {
                    // 16777215
                    row.Cells[2].ReadOnly = true;
                }
            }
        }
        void radGridContacts_ContextMenuOpening(object sender, Telerik.WinControls.UI.ContextMenuOpeningEventArgs e)
        {
            if (radGridContacts.CurrentRow.Index <= 0)
                cntContextMenu.Items[0].Enabled = false;
            else
                cntContextMenu.Items[0].Enabled = true;

            if (radGridContacts.CurrentRow.Index == (radGridContacts.Rows.Count - 1) || radGridContacts.CurrentRow.Index == -1)
                cntContextMenu.Items[1].Enabled = false;
            else
                cntContextMenu.Items[1].Enabled = true;

            e.ContextMenu = cntContextMenu.DropDown;
        }
        void radGridContacts_CellValidating(object sender, Telerik.WinControls.UI.CellValidatingEventArgs e)
        {
            switch (e.ColumnIndex)
            {
                case 0:
                    // Contact Name
                    break;
                case 1:
                    // Contact Type
                    break;
                case 2:
                    // Contact ID
                    string oldVal = !object.Equals(e.OldValue, null) ? e.OldValue.ToString() : "";
                    string newVal = !object.Equals(e.Value, null) ? e.Value.ToString() : "";
                    string callType = !object.Equals(e.Row.Cells[1].Value, null) ? e.Row.Cells[1].Value.ToString() : "";
                    foreach (Contact cnt in MD380Data.Contacts.Where(a => a.CallID.ToString() != oldVal))
                    {
                        
                        if (cnt.CallID.ToString() == newVal && cnt.CallType == callType)
                        {
                            e.Cancel = true;
                            MessageBox.Show("ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
                case 3:
                    // Contact Receive Tone
                    break;
            }
            
        }
        void cntMoveUp(object sender, EventArgs e)
        {
            int idx = radGridContacts.CurrentRow.Index;
            if (idx > 0)
            {
                Contact cnt = MD380Data.Contacts[idx];
                MD380Data.Contacts.RemoveAt(idx);
                MD380Data.Contacts.Insert(idx - 1, cnt);
                loadContacts();
                radGridContacts.Rows[idx - 1].IsSelected = true;
                radGridContacts.Rows[idx - 1].IsCurrent = true;
                GridTableElement tblEl = this.radGridContacts.CurrentView as GridTableElement;
                if (tblEl != null && radGridContacts.CurrentRow != null)
                {
                    tblEl.ScrollToRow(radGridContacts.CurrentRow);
                }
            }
        }
        void cntMoveDown(object sender, EventArgs e)
        {
            int idx = radGridContacts.CurrentRow.Index;
            if (idx < (radGridContacts.Rows.Count - 1))
            {
                Contact cnt = MD380Data.Contacts[idx];
                MD380Data.Contacts.RemoveAt(idx);
                MD380Data.Contacts.Insert(idx + 1, cnt);
                loadContacts();
                radGridContacts.Rows[idx + 1].IsSelected = true;
                radGridContacts.Rows[idx + 1].IsCurrent = true;
                GridTableElement tblEl = this.radGridContacts.CurrentView as GridTableElement;
                if (tblEl != null && radGridContacts.CurrentRow != null)
                {
                    tblEl.ScrollToRow(radGridContacts.CurrentRow);
                }
            }
        }
        #endregion

        #region Group Lists
        private void loadGroups(int idx)
        {
            lstGroupList.DataSource = null;
            lstGroupList.DisplayMember = "GroupListName";
            lstGroupList.ValueMember = "GUID";
            lstGroupList.DataSource = MD380Data.Groups;
            if (idx != -1)
                lstGroupList.SelectedIndex = idx;
        }
        private void lstGroupList_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshGroups(-1,-1);
        }
        void txtGroupListName_TextChanged(object sender, EventArgs e)
        {
            if (object.Equals(MD380Data.Groups.Where(g => g.GroupListName == txtGroupListName.Text).FirstOrDefault(), null))
            {
                if (lstGroupList.SelectedItem.ToString() != txtGroupListName.Text)
                {
                    GroupList list = MD380Data.Groups.Where(g => g.GroupListName == lstGroupList.SelectedItem.ToString()).FirstOrDefault();
                    list.GroupListName = txtGroupListName.Text;
                }
                loadGroups(lstGroupList.SelectedIndex);
            }
            else
            {
                MessageBox.Show("Group List Name Already Exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtGroupListName.Text = lstGroupList.SelectedItem.ToString();
            }
        }
        private string getContactNameFromGuid(Guid inguid)
        {
            string name = "";
            foreach (Contact ct in MD380Data.Contacts)
            {
                if (ct.GUID == inguid)
                {
                    name = ct.Name;
                }
            }
            return name;
        }
        private void refreshGroups(int adx, int udx)
        {
            if (lstGroupList.SelectedIndex > -1)
            {
                List<Guid> assignedGuids = ((GroupList)lstGroupList.Items[lstGroupList.SelectedIndex]).ContactMembers;

                List<Contact> assignedContacts = new List<Contact>();
                foreach (Guid cguid in assignedGuids)
                    foreach (Contact ct in MD380Data.Contacts)
                        if (ct.GUID == cguid)
                            assignedContacts.Add(ct);

                List<Contact> unassignedContacts = MD380Data.Contacts.Where(a => a.Name != "").Except(assignedContacts).ToList();

                lstGrpAssn.DisplayMember = "Name";
                lstGrpAssn.ValueMember = "GUID";
                lstGrpAssn.DataSource = assignedContacts;
                lstGrpAvail.DisplayMember = "Name";
                lstGrpAvail.ValueMember = "GUID";
                lstGrpAvail.DataSource = unassignedContacts;
                txtGroupListName.Text = ((GroupList)lstGroupList.SelectedItem).GroupListName;
                if (adx > -1)
                    lstGrpAssn.SelectedIndex = (adx > (lstGrpAssn.Items.Count - 1) ? lstGrpAssn.Items.Count - 1 : adx);
                if (udx > -1)
                    lstGrpAvail.SelectedIndex = (udx > (lstGrpAvail.Items.Count - 1) ? lstGrpAvail.Items.Count - 1 : udx);
            }
        }
        private void btnGrpLstMoveUp_Click(object sender, EventArgs e)
        {
            if (lstGroupList.SelectedIndex > 0)
            {
                GroupList gList = (GroupList)lstGroupList.SelectedItem;
                MD380Data.Groups.RemoveAt(lstGroupList.SelectedIndex);
                MD380Data.Groups.Insert((lstGroupList.SelectedIndex - 1), gList);
                loadGroups(lstGroupList.SelectedIndex - 1);
            }
        }
        private void btnGrpLstMoveDown_Click(object sender, EventArgs e)
        {
            if (lstGroupList.SelectedIndex < (lstGroupList.Items.Count - 1))
            {
                GroupList gList = (GroupList)lstGroupList.SelectedItem;
                MD380Data.Groups.RemoveAt(lstGroupList.SelectedIndex);
                MD380Data.Groups.Insert((lstGroupList.SelectedIndex + 1), gList);
                loadGroups(lstGroupList.SelectedIndex + 1);
            }
        }
        private void btnGrpLstAdd_Click(object sender, EventArgs e)
        {
            if (lstGrpAvail.Items.Count > 0)
            {
                Guid cntGuid = (Guid)lstGrpAvail.SelectedValue;
                MD380Data.Groups.Where(b => b.GUID == (Guid)lstGroupList.SelectedValue).FirstOrDefault().ContactMembers.Add(cntGuid);
                int udx = lstGrpAvail.SelectedIndex;
                int adx = lstGrpAssn.SelectedIndex;
                refreshGroups(adx, udx);
            }
        }
        private void btnGrpLstRemove_Click(object sender, EventArgs e)
        {
            if (lstGrpAssn.Items.Count > 0)
            {
                Guid cntGuid = (Guid)lstGrpAssn.SelectedValue;
                MD380Data.Groups.Where(b => b.GUID == (Guid)lstGroupList.SelectedValue).FirstOrDefault().ContactMembers.Remove(cntGuid);
                int udx = lstGrpAvail.SelectedIndex;
                int adx = lstGrpAssn.SelectedIndex;
                refreshGroups(adx, udx);
            }
        }
        private void btnGrpAssnMoveUp_Click(object sender, EventArgs e)
        {
            if (lstGrpAssn.SelectedIndex > 0)
            {
                Guid cntGuid = (Guid)lstGrpAssn.SelectedValue;
                MD380Data.Groups.Where(b => b.GUID == (Guid)lstGroupList.SelectedValue).FirstOrDefault().ContactMembers.RemoveAt(lstGrpAssn.SelectedIndex);
                MD380Data.Groups.Where(b => b.GUID == (Guid)lstGroupList.SelectedValue).FirstOrDefault().ContactMembers.Insert((lstGrpAssn.SelectedIndex - 1), cntGuid);
                refreshGroups(lstGrpAssn.SelectedIndex - 1, -1);
            }
        }
        private void btnGrpAssnMoveDown_Click(object sender, EventArgs e)
        {
            if (lstGrpAssn.SelectedIndex < (lstGrpAssn.Items.Count - 1))
            {
                Guid cntGuid = (Guid)lstGrpAssn.SelectedValue;
                MD380Data.Groups.Where(b => b.GUID == (Guid)lstGroupList.SelectedValue).FirstOrDefault().ContactMembers.RemoveAt(lstGrpAssn.SelectedIndex);
                MD380Data.Groups.Where(b => b.GUID == (Guid)lstGroupList.SelectedValue).FirstOrDefault().ContactMembers.Insert((lstGrpAssn.SelectedIndex + 1), cntGuid);
                refreshGroups(lstGrpAssn.SelectedIndex + 1, -1);
            }
        }
        #endregion

        #region Zones
        private void loadZones(int idx)
        {
            lstZones.DataSource = null;
            lstZones.DisplayMember = "ZoneName";
            lstZones.ValueMember = "GUID";
            lstZones.DataSource = MD380Data.Zones;

            if (idx != -1)
                lstZones.SelectedIndex = idx;
        }
        private void refreshZones(int adx, int udx)
        {
            if (lstZones.SelectedIndex > -1)
            {
                List<Guid> assignedGuids = ((ZoneList)lstZones.Items[lstZones.SelectedIndex]).ChannelMembers;
                List<Channel> assignedChannels = new List<Channel>();
                foreach (Guid cguid in assignedGuids)
                    foreach (Channel ch in MD380Data.Channels)
                        if (ch.GUID == cguid)
                            assignedChannels.Add(ch);

                List<Channel> unassignedChannels = MD380Data.Channels.Where(a => a.ChannelName != "BLANK").Except(assignedChannels).ToList();

                lstZnChanAssigned.DisplayMember = "ChannelName";
                lstZnChanAssigned.ValueMember = "GUID";
                lstZnChanAssigned.DataSource = assignedChannels;
                lstZnChanAvail.DisplayMember = "ChannelName";
                lstZnChanAvail.ValueMember = "GUID";
                lstZnChanAvail.DataSource = unassignedChannels;
                txtZnName.Text = ((ZoneList)lstZones.SelectedItem).ZoneName;

                if (adx > -1)
                    lstZnChanAssigned.SelectedIndex = (adx > (lstZnChanAssigned.Items.Count - 1) ? lstZnChanAssigned.Items.Count - 1 : adx);
                if (udx > -1)
                    lstZnChanAvail.SelectedIndex = (udx > (lstZnChanAvail.Items.Count - 1) ? lstZnChanAvail.Items.Count - 1 : udx);
            }
        }
        private void btnZnMvUp_Click(object sender, EventArgs e)
        {
            if (lstZones.SelectedIndex > 0)
            {
                ZoneList zone = MD380Data.Zones.Where(a => a.GUID == (Guid)lstZones.SelectedValue).FirstOrDefault();
                MD380Data.Zones.RemoveAt(lstZones.SelectedIndex);
                MD380Data.Zones.Insert(lstZones.SelectedIndex - 1, zone);
                loadZones(lstZones.SelectedIndex - 1);
            }
        }
        private void btnZnMvDwn_Click(object sender, EventArgs e)
        {
            if (lstZones.SelectedIndex < (lstZones.Items.Count - 1))
            {
                ZoneList zone = MD380Data.Zones.Where(a => a.GUID == (Guid)lstZones.SelectedValue).FirstOrDefault();
                MD380Data.Zones.RemoveAt(lstZones.SelectedIndex);
                MD380Data.Zones.Insert(lstZones.SelectedIndex + 1, zone);
                loadZones(lstZones.SelectedIndex + 1);
            }
        }
        private void btnZnAdd_Click(object sender, EventArgs e)
        {
            if (lstZnChanAvail.Items.Count > 0)
            {
                Guid chGuid = (Guid)lstZnChanAvail.SelectedValue;
                MD380Data.Zones.Where(z => z.GUID == (Guid)lstZones.SelectedValue).FirstOrDefault().ChannelMembers.Add(chGuid);
                int udx = lstZnChanAvail.SelectedIndex;
                int adx = lstZnChanAssigned.SelectedIndex;
                refreshZones(adx, udx);
            }
        }
        private void btnZnRemove_Click(object sender, EventArgs e)
        {
            if (lstZnChanAssigned.Items.Count > 0)
            {
                Guid chGuid = (Guid)lstZnChanAvail.SelectedValue;
                MD380Data.Zones.Where(z => z.GUID == (Guid)lstZones.SelectedValue).FirstOrDefault().ChannelMembers.Remove(chGuid);
                int udx = lstZnChanAvail.SelectedIndex;
                int adx = lstZnChanAssigned.SelectedIndex;
                refreshZones(adx, udx);
            }
        }
        private void btnZnAssnMvUp_Click(object sender, EventArgs e)
        {
            if (lstZnChanAssigned.SelectedIndex > 0)
            {
                Guid chGuid = (Guid)lstZnChanAssigned.SelectedValue;
                MD380Data.Zones.Where(b => b.GUID == (Guid)lstZones.SelectedValue).FirstOrDefault().ChannelMembers.RemoveAt(lstZnChanAssigned.SelectedIndex);
                MD380Data.Zones.Where(b => b.GUID == (Guid)lstZones.SelectedValue).FirstOrDefault().ChannelMembers.Insert((lstZnChanAssigned.SelectedIndex - 1), chGuid);
                refreshZones(lstZnChanAssigned.SelectedIndex - 1, -1);
            }
        }
        private void btnZnAssnMvDwn_Click(object sender, EventArgs e)
        {
            if (lstZnChanAssigned.SelectedIndex < (lstZnChanAssigned.Items.Count-1))
            {
                Guid chGuid = (Guid)lstZnChanAssigned.SelectedValue;
                MD380Data.Zones.Where(b => b.GUID == (Guid)lstZones.SelectedValue).FirstOrDefault().ChannelMembers.RemoveAt(lstZnChanAssigned.SelectedIndex);
                MD380Data.Zones.Where(b => b.GUID == (Guid)lstZones.SelectedValue).FirstOrDefault().ChannelMembers.Insert((lstZnChanAssigned.SelectedIndex + 1), chGuid);
                refreshZones(lstZnChanAssigned.SelectedIndex + 1, -1);
            }
        }
        private void lstZones_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshZones(-1, -1);
        }
        #endregion

        #region Scan Lists
        private void initScanLists()
        {
            _F = new byte[16];
            for (int i = 0; i < 16; i++)
                _F[i] = byte.Parse("FF", NumberStyles.HexNumber);

            List<String> sht = new List<string>();
            for (int i = 50; i <= 6375; i += 25)
                sht.Add(i.ToString());

            cmboSLSignalingHoldTime.DataSource = sht;

            List<string> sst = new List<string>();
            for (int i = 750; i <= 7750; i += 250)
                sst.Add(i.ToString());

            cmboSLSampleTime.DataSource = sst;
        }
        private void initCmboSLPriorityA(List<Channel> list)
        {
            List<Channel> newList = new List<Channel>(list);
            cmboSLPriorityA.DataSource = null;
            Channel selected = new Channel();
            selected.GUID = Guid.Empty;
            selected.ChannelName = "Selected";
            newList.Insert(0, selected);

            Channel none = new Channel();
            none.GUID = new Guid(_F);
            none.ChannelName = "None";
            newList.Add(none);

            cmboSLPriorityA.DisplayMember = "ChannelName";
            cmboSLPriorityA.ValueMember = "GUID";
            cmboSLPriorityA.DataSource = newList;
            cmboSLPriorityA.SelectedValue = (Guid)((ScanList)lstScanLists.SelectedItem).PriorityChannelA;
        }
        private void initCmboSLPriorityB(List<Channel> list)
        {
            List<Channel> newList = new List<Channel>(list);
            cmboSLPriorityB.DataSource = null;
            Channel selected = new Channel();
            selected.GUID = Guid.Empty;
            selected.ChannelName = "Selected";
            newList.Insert(0, selected);

            Channel none = new Channel();
            none.GUID = new Guid(_F);
            none.ChannelName = "None";
            newList.Add(none);

            cmboSLPriorityB.DisplayMember = "ChannelName";
            cmboSLPriorityB.ValueMember = "GUID";
            cmboSLPriorityB.DataSource = newList;
            cmboSLPriorityB.SelectedValue = (Guid)((ScanList)lstScanLists.SelectedItem).PriorityChannelB;
        }
        private void initCmboSLTXCH(List<Channel> list)
        {
            List<Channel> newList = new List<Channel>(list);
            cmboSLTXCH.DataSource = null;
            Channel selected = new Channel();
            selected.GUID = Guid.Empty;
            selected.ChannelName = "Selected";
            newList.Insert(0, selected);

            Channel none = new Channel();
            none.GUID = new Guid(_F);
            none.ChannelName = "Last Active";
            newList.Add(none);

            cmboSLTXCH.DisplayMember = "ChannelName";
            cmboSLTXCH.ValueMember = "GUID";
            cmboSLTXCH.DataSource = newList;
            cmboSLTXCH.SelectedValue = (Guid)((ScanList)lstScanLists.SelectedItem).TxDesignatedChannel;
        }
        private void loadScanLists(int idx)
        {
            lstScanLists.DataSource = null;
            lstScanLists.DisplayMember = "ScanListName";
            lstScanLists.ValueMember = "GUID";
            lstScanLists.DataSource = MD380Data.ScanLists.Where(a => a.ScanListName != "").ToList();

            if (idx != -1)
                lstScanLists.SelectedIndex = idx;
        }
        private void refreshScanLists(int adx, int udx)
        {
            if (lstScanLists.SelectedIndex > -1)
            {
                List<Guid> assignedGuids = ((ScanList)lstScanLists.Items[lstScanLists.SelectedIndex]).ChannelMembers;

                List<Channel> assignedChannels = new List<Channel>();
                foreach (Guid cguid in assignedGuids)
                    foreach (Channel ch in MD380Data.Channels)
                        if (ch.GUID == cguid)
                            assignedChannels.Add(ch);

                List<Channel> unassignedChannels = MD380Data.Channels.Where(a => a.ChannelName != "BLANK").Except(assignedChannels).ToList();

                lstScnChanAssn.DisplayMember = "ChannelName";
                lstScnChanAssn.ValueMember = "GUID";
                lstScnChanAssn.DataSource = assignedChannels;
                lstScnChanAvail.DisplayMember = "ChannelName";
                lstScnChanAvail.ValueMember = "GUID";
                lstScnChanAvail.DataSource = unassignedChannels;
                txtScnName.Text = ((ScanList)lstScanLists.SelectedItem).ScanListName;

                initCmboSLPriorityA(assignedChannels);
                initCmboSLPriorityB(assignedChannels);
                initCmboSLTXCH(assignedChannels);
                
                
                cmboSLSampleTime.SelectedItem = ((ScanList)lstScanLists.SelectedItem).PrioritySampleTime.ToString();
                cmboSLSignalingHoldTime.SelectedItem = ((ScanList)lstScanLists.SelectedItem).SignalingHoldTime.ToString();

                if (adx > -1)
                    lstScnChanAssn.SelectedIndex = (adx > (lstScnChanAssn.Items.Count - 1) ? lstScnChanAssn.Items.Count - 1 : adx);
                if (udx > -1)
                    lstScnChanAvail.SelectedIndex = (udx > (lstScnChanAvail.Items.Count - 1) ? lstScnChanAvail.Items.Count - 1 : udx);
            }
        }
        private void btnScnMvUp_Click(object sender, EventArgs e)
        {
            if (lstScanLists.SelectedIndex > 0)
            {
                ScanList slist = MD380Data.ScanLists.Where(a => a.GUID == (Guid)lstScanLists.SelectedValue).FirstOrDefault();
                MD380Data.ScanLists.RemoveAt(lstScanLists.SelectedIndex);
                MD380Data.ScanLists.Insert(lstScanLists.SelectedIndex - 1, slist);
                loadScanLists(lstScanLists.SelectedIndex - 1);
            }
        }
        private void btnScnMvDwn_Click(object sender, EventArgs e)
        {
            if (lstScanLists.SelectedIndex < (lstScanLists.Items.Count - 1))
            {
                ScanList slist = MD380Data.ScanLists.Where(a => a.GUID == (Guid)lstScanLists.SelectedValue).FirstOrDefault();
                MD380Data.ScanLists.RemoveAt(lstScanLists.SelectedIndex);
                MD380Data.ScanLists.Insert(lstScanLists.SelectedIndex + 1, slist);
                loadScanLists(lstScanLists.SelectedIndex + 1);
            }
        }
        private void btnScnAdd_Click(object sender, EventArgs e)
        {
            if (lstScnChanAvail.Items.Count > 0)
            {
                Guid chGuid = (Guid)lstScnChanAvail.SelectedValue;
                MD380Data.ScanLists.Where(z => z.GUID == (Guid)lstScanLists.SelectedValue).FirstOrDefault().ChannelMembers.Add(chGuid);
                int udx = lstScnChanAvail.SelectedIndex;
                int adx = lstScnChanAssn.SelectedIndex;
                refreshScanLists(adx, udx);
            }
        }
        private void btnScnRemove_Click(object sender, EventArgs e)
        {
            if (lstScnChanAssn.Items.Count > 0)
            {
                Guid chGuid = (Guid)lstScnChanAssn.SelectedValue;
                MD380Data.ScanLists.Where(z => z.GUID == (Guid)lstScanLists.SelectedValue).FirstOrDefault().ChannelMembers.Remove(chGuid);
                int udx = lstScnChanAvail.SelectedIndex;
                int adx = lstScnChanAssn.SelectedIndex;
                refreshScanLists(adx, udx);
            }
        }
        private void btnScnChanMvUp_Click_1(object sender, EventArgs e)
        {
            if (lstScnChanAssn.SelectedIndex > 0)
            {
                Guid chGuid = (Guid)lstScnChanAssn.SelectedValue;
                MD380Data.ScanLists.Where(b => b.GUID == (Guid)lstScanLists.SelectedValue).FirstOrDefault().ChannelMembers.RemoveAt(lstScnChanAssn.SelectedIndex);
                MD380Data.ScanLists.Where(b => b.GUID == (Guid)lstScanLists.SelectedValue).FirstOrDefault().ChannelMembers.Insert((lstScnChanAssn.SelectedIndex - 1), chGuid);
                refreshScanLists(lstScnChanAssn.SelectedIndex - 1, -1);
            }
        }
        private void btnScnChanMvDwn_Click_1(object sender, EventArgs e)
        {
            if (lstScnChanAssn.SelectedIndex < (lstScnChanAssn.Items.Count-1))
            {
                Guid chGuid = (Guid)lstScnChanAssn.SelectedValue;
                MD380Data.ScanLists.Where(b => b.GUID == (Guid)lstScanLists.SelectedValue).FirstOrDefault().ChannelMembers.RemoveAt(lstScnChanAssn.SelectedIndex);
                MD380Data.ScanLists.Where(b => b.GUID == (Guid)lstScanLists.SelectedValue).FirstOrDefault().ChannelMembers.Insert((lstScnChanAssn.SelectedIndex + 1), chGuid);
                refreshScanLists(lstScnChanAssn.SelectedIndex + 1, -1);
            }
        }
        private void lstScanLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshScanLists(-1, -1);
        }
        #endregion

        #region Channels

        private void initChannels()
        {
            // TOT Rekey Delay
            cmboCHTOTRekeyDelay.Items.Clear();
            for (int i = 0; i < 256; i++)
                cmboCHTOTRekeyDelay.Items.Add(i.ToString());

            // Defaults
            cmboCHChannelMode.SelectedItem = "Digital";
            cmboCHScanList.SelectedItem = "None";
            cmboCHRXRefFreq.SelectedItem = "Low";
            cmboCHTXRefFreq.SelectedItem = "Low";
            cmboCHSquelch.SelectedItem = "Normal";
            cmboCHTOT.SelectedItem = "60";
            cmboCHTOTRekeyDelay.SelectedItem = "0";
            cmboCHPower.SelectedItem = "High";
            cmboCHCTCSSDec.SelectedItem = "None";
            cmboCHCTCSSEnc.SelectedItem = "None";
            cmboCHQTReverse.SelectedItem = "180";
            chkCHReverseBurst.Checked = true;
            cmboCHRXSignaling.SelectedItem = "Off";
            cmboCHTXSignaling.SelectedItem = "Off";
        }
        private void loadChannels(int idx)
        {
            lstChannels.DataSource = null;
            lstChannels.DisplayMember = "ChannelName";
            lstChannels.ValueMember = "GUID";
            lstChannels.DataSource = MD380Data.Channels.Where(a => a.ChannelName != "BLANK").ToList();

            if (idx != -1)
                lstChannels.SelectedIndex = idx;
        }
        private void refreshChannels()
        {
            if (lstChannels.SelectedIndex > -1)
            {
                // Contact Name
                cmboCHContactName.DataSource = null;
                cmboCHContactName.DisplayMember = "Name";
                cmboCHContactName.ValueMember = "GUID";
                cmboCHContactName.DataSource = MD380Data.Contacts;

                // Group List
                cmboCHGroupList.DataSource = null;
                cmboCHGroupList.DisplayMember = "GroupListName";
                cmboCHGroupList.ValueMember = "GUID";
                cmboCHGroupList.DataSource = MD380Data.Groups;

                Channel chan = (Channel)lstChannels.Items[lstChannels.SelectedIndex];

                //// GENERAL SETTINGS

                // Channel Mode
                cmboCHChannelMode.SelectedItem = chan.ChannelMode;

                // Bandwidth
                cmboCHBandwidth.SelectedItem = chan.Bandwidth;
                
                // Scan List

                // Squelch
                cmboCHSquelch.SelectedItem = chan.Squelch;

                // RX Ref
                cmboCHRXRefFreq.SelectedItem = chan.RXRef;

                // TX Ref
                cmboCHTXRefFreq.SelectedItem = chan.TXRef;

                // TOT
                cmboCHTOT.SelectedItem = (chan.TOT == 0 ? "Infinite" : chan.TOT.ToString());

                // TOT Rekey
                cmboCHTOTRekeyDelay.SelectedItem = chan.TOTDelay.ToString();

                // Power
                cmboCHPower.SelectedItem = chan.Power;

                // Channel Name
                txtCHChannelName.Text = chan.ChannelName;

                // RX Freq
                txtCHRXFreq.Text = chan.RXFreq;

                // TX Freq
                txtCHTXFreq.Text = chan.TXFreq;

                // Admit Criteria
                cmboCHAdmitCriteria.SelectedItem = chan.AdmitCriteria;

                // Auto Scan Checkbox
                chkCHAutoScan.Checked = chan.AutoScan;

                // RX Only Checkbox
                chkCHRXOnly.Checked = chan.RXOnly;
                
                // Lone Worker Checkbox
                chkCHLoneWorker.Checked = chan.LoneWorker;

                // VOX Checkbox
                chkCHVOX.Checked = chan.VOX;

                // Allow Talkaround Checkbox
                chkCHAlwTalkaround.Checked = chan.AllowTalkaround;

                //// ANALOG

                // CTCSS Decode
                cmboCHCTCSSDec.SelectedItem = chan.analog.CTCSSDecode;

                // CTCSS Encode
                cmboCHCTCSSEnc.SelectedItem = chan.analog.CTCSSEncode;

                // QT Revers
                cmboCHQTReverse.SelectedItem = chan.analog.QTReverse;

                // RX Signaling
                cmboCHRXSignaling.SelectedItem = chan.analog.RXSignaling;

                // TX Signaling
                cmboCHTXSignaling.SelectedItem = chan.analog.TXSignaling;

                // Disable PTT ID Checkbox
                chkCHDisablePTTID.Checked = chan.analog.DisplayPTTID;

                // Reverse Burst Checkbox
                chkCHReverseBurst.Checked = chan.analog.ReverseBurst;

                // Decode 1-8 Checkboxes
                chkCHDecode1.Checked = chan.analog.decodes.decode1;
                chkCHDecode2.Checked = chan.analog.decodes.decode2;
                chkCHDecode3.Checked = chan.analog.decodes.decode3;
                chkCHDecode4.Checked = chan.analog.decodes.decode4;
                chkCHDecode5.Checked = chan.analog.decodes.decode5;
                chkCHDecode6.Checked = chan.analog.decodes.decode6;
                chkCHDecode7.Checked = chan.analog.decodes.decode7;
                chkCHDecode8.Checked = chan.analog.decodes.decode8;

                //// DIGITAL

                // Emergency System

                // Contact Name
                cmboCHContactName.SelectedValue = chan.digital.ContactGuid;

                // Group List
                cmboCHGroupList.SelectedValue = chan.digital.GroupListGuid;

                // Color Code
                cmboCHColorCode.SelectedItem = chan.digital.ColorCode.ToString();

                // Repeater Slot
                cmboCHTS.SelectedItem = chan.digital.RepeaterSlot.ToString();

                // Privacy
                cmboCHPrivacy.SelectedItem = chan.digital.Privacy;

                // Privacy No
                cmboCHPrivacyNo.SelectedItem = chan.digital.PrivacyNo.ToString();

                // Private Call Conf Checkbox
                chkCHPrivCallConf.Checked = chan.digital.PrivateCallConf;

                // Emergency Ack Checkbox
                chkCHEmgcyAlrmAck.Checked = chan.digital.EmergencyAlarmAck;

                // Data Call Conf Checkbox
                chkCHDataCallConf.Checked = chan.digital.DataCallConf;

                // Compressed UDP Header Checkbox
                chkCHCompUDP.Checked = chan.digital.CompressedUDPDataHeader;
            }
        }
        private void btnCHMvUp_Click(object sender, EventArgs e)
        {

        }
        private void btnCHMvDwn_Click(object sender, EventArgs e)
        {

        }
        private void lstChannels_SelectedIndexChanged(object sender, EventArgs e)
        {
            refreshChannels();
        }
        private void cmboCHChannelMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboCHChannelMode.SelectedItem == "Analog")
            {
                groupBox20.Enabled = false;
                groupBox19.Enabled = true;
                cmboCHBandwidth.Items.Clear();
                cmboCHBandwidth.Items.Add("12.5Khz");
                cmboCHBandwidth.Items.Add("25Khz");
                cmboCHAdmitCriteria.Items.Clear();
                cmboCHAdmitCriteria.Items.Add("Always");
                cmboCHAdmitCriteria.Items.Add("Channel Free");
                cmboCHAdmitCriteria.Items.Add("CTCSS/DCS");
            }
            else
            {
                groupBox20.Enabled = true;
                groupBox19.Enabled = false;
                cmboCHBandwidth.Items.Clear();
                cmboCHBandwidth.Items.Add("12.5Khz");
                cmboCHAdmitCriteria.Items.Clear();
                cmboCHAdmitCriteria.Items.Add("Always");
                cmboCHAdmitCriteria.Items.Add("Channel Free");
                cmboCHAdmitCriteria.Items.Add("Color Code");
            }
            //cmboCHBandwidth.SelectedItem = "12.5Khz";
            cmboCHAdmitCriteria.SelectedItem = "Always";
            if (lstChannels.SelectedIndex != -1)
                MD380Data.Channels[lstChannels.SelectedIndex].ChannelMode = cmboCHChannelMode.SelectedItem.ToString();
        }
        private void cmboCHCTCSSEnc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboCHCTCSSEnc.SelectedItem != "None")
            {
                cmboCHQTReverse.Enabled = true;
                chkCHReverseBurst.Enabled = true;
            }
            else
            {
                cmboCHQTReverse.Enabled = false;
                chkCHReverseBurst.Enabled = false;
            }
        }
        private void cmboCHBandwidth_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstChannels.SelectedIndex != -1)
                MD380Data.Channels[lstChannels.SelectedIndex].Bandwidth = cmboCHBandwidth.SelectedItem.ToString();
        }
        #endregion

        #region Misc
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Displays an OpenFileDialog so the user can select a Cursor.
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "MD380 Files|*.rdt";
            openFileDialog1.Title = "Select a MD380 File";

            // Show the Dialog.
            // If the user clicked OK in the dialog and
            // a .rdt file was selected, open it.
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MD380Data.initData(openFileDialog1.OpenFile());
                refreshScreens();
            }
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "MD380 Codeplug|*.rdt|CS700 Codeplug|*.rdt";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            saveFileDialog1.Title = "Save MD380 Codeplug";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();

                MD380Data.saveData(fs, saveFileDialog1.FilterIndex);
                
                fs.Close();
            }
            */
            CheckFiles();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }
        #endregion

        private void CheckFiles()
        {
            MessageBox.Show("Result: "+MD380Data.checkData().ToString(), "Check Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void ddlBscFreqRange_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!object.Equals(MD380Data.Basic_Info, null))
            {
                if (ddlBscFreqRange.Items.Count > 0)
                {
                    MD380Data.Basic_Info.FrequencyRange = ddlBscFreqRange.SelectedItem.ToString();
                }
            }
        }
    }
}
