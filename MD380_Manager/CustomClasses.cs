using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MD380_Manager
{
    public class Contact
    {
        public Guid GUID {get;set;}
        public string Name { get; set; }
        public string CallType { get; set; }
        public int CallID { get; set; }
        public bool receiveTone { get; set; }
    }

    public class GroupList
    {
        public Guid GUID { get; set; }
        public string GroupListName { get; set; }
        public List<Guid> ContactMembers { get; set; }
    }

    public class ZoneList
    {
        public Guid GUID { get; set; }
        public string ZoneName { get; set; }
        public List<Guid> ChannelMembers { get; set; }
    }

    public class ScanList
    {
        public Guid GUID { get; set; }
        public string ScanListName { get; set; }
        public List<Guid> ChannelMembers { get; set; }
        public string PriorityChannelA { get; set; }
        public string PriorityChannelB { get; set; }
        public int SignalingHoldTime { get; set; }
        public int PrioritySampleTime { get; set; }
        public string TxDesignatedChannel { get; set; }
    }

    public class EmergencySystem
    {
        public Guid GUID { get; set; }
        public int RemoteMonitorDuration { get; set; }
        public int TXSyncWakeupTOT { get; set; }
        public int TXWakeupMessageLimit { get; set; }
        public bool RadioDisableDecode { get; set; }
        public bool RemoteMonitorDecode { get; set; }
        public bool EmergencyRemoteMonitorDecode { get; set; }
        public string SystemName { get; set; }
        public string AlarmType { get; set; }
        public string AlarmMode { get; set; }
        public Guid RevertChannel { get; set; }
        public int ImpoliteRetries { get; set; }
        public int PoliteRetries { get; set; }
        public int HotMicDuration { get; set; }
    }

    public class Channel
    {
        public Guid GUID { get; set; }
        public string ChannelName { get; set; }
        public string ChannelMode { get; set; }
        public string Bandwidth { get; set; }
        public Guid ScanListGuid { get; set; }
        public string RXFreq { get; set; }
        public string TXFreq { get; set; }
        public string AdmitCriteria { get; set; }
        public string Squelch { get; set; }
        public string RXRef { get; set; }
        public string TXRef { get; set; }
        public int TOT { get; set; }
        public int TOTDelay { get; set; }
        public string Power { get; set; }
        public bool AutoScan { get; set; }
        public bool RXOnly { get; set; }
        public bool LoneWorker { get; set; }
        public bool VOX { get; set; }
        public bool AllowTalkaround { get; set; }
        public AnalogData analog { get; set; }
        public DigitalData digital { get; set; }
    }

    public class AnalogData
    {
        public string CTCSSDecode { get; set; }
        public string CTCSSEncode { get; set; }
        public int QTReverse { get; set; }
        public string TXSignaling { get; set; }
        public string RXSignaling { get; set; }
        public RXSignalingDecode decodes { get; set; }
        public bool ReverseBurst { get; set; }
        public bool DisplayPTTID { get; set; }
    }

    public class RXSignalingDecode
    {
        public bool decode1 { get; set; }
        public bool decode2 { get; set; }
        public bool decode3 { get; set; }
        public bool decode4 { get; set; }
        public bool decode5 { get; set; }
        public bool decode6 { get; set; }
        public bool decode7 { get; set; }
        public bool decode8 { get; set; }
    }
    public class DigitalData
    {
        public bool PrivateCallConf { get; set; }
        public bool EmergencyAlarmAck { get; set; }
        public bool DataCallConf { get; set; }
        public bool CompressedUDPDataHeader { get; set; }
        public Guid EmergencySystemGuid { get; set; }
        public Guid ContactGuid { get; set; }
        public Guid GroupListGuid { get; set; }
        public int ColorCode { get; set; }
        public int RepeaterSlot { get; set; }
        public string Privacy { get; set; }
        public int PrivacyNo { get; set; }
    }
    public class BasicInfo
    {
        public string FrequencyRange { get; set; }
        public string LastProgramDate { get; set; }
        public string ModelName { get; set; }
        public string SerialNumber { get; set; }
        public string CPSVersion { get; set; }
        public string HardwareVersion { get; set; }
        public string MCUVersion { get; set; }
        public string UniqueDeviceID { get; set; }
    }
    public class GeneralSetting
    {
        public bool SavePreamble { get; set; }
        public bool SaveModeReceive { get; set; }
        public bool DisableAllTone { get; set; }
        public bool CHFreeIndTone { get; set; }
        public string TalkPermitTone { get; set; }
        public int CallAlertToneDuration { get; set; }
        public int ScanDigitalHangTime { get; set; }
        public int ScanAnalogHangTime { get; set; }
        public int LoneWorkerRespTime { get; set; }
        public int LoneWorkerReminderTime { get; set; }
        public bool PasswordLockEnable { get; set; }
        public string PowerOnPassword { get; set; }
        public string RadioName { get; set; }
        public string RadioID { get; set; }
        public string MonitorType { get; set; }
        public int VOXSensitivity { get; set; }
        public int TXPreambleDuration { get; set; }
        public int RXLowBatInterval { get; set; }
        public string PCProgPassword { get; set; }
        public string RadioProgPassword { get; set; }
        public string BackLightTime { get; set; }
        public string SetKeypadLockTime { get; set; }
        public bool DisableAllLEDS { get; set; }
        public int GroupCallHangTime { get; set; }
        public int PrivateCallHangTime { get; set; }
        public string IntroScreen { get; set; }
        public string IntroScreenLine1 { get; set; }
        public string IntroScreenLine2 { get; set; }
    }
    public class MenuItems
    {
        public int MenuHangTime { get; set; }
        public bool TextMessage { get; set; }
        public bool CallAlert { get; set; }
        public bool Edit { get; set; }
        public bool ManualDial { get; set; }
        public bool RadioCheck { get; set; }
        public bool RemoteMonitor { get; set; }
        public bool ProgramKey { get; set; }
        public bool RadioEnable { get; set; }
        public bool RadioDisable { get; set; }
        public bool Missed { get; set; }
        public bool Answered { get; set; }
        public bool OutgoingRadio { get; set; }
        public bool Talkaround { get; set; }
        public bool ToneOrAlert { get; set; }
        public bool Power { get; set; }
        public bool IntroScreen { get; set; }
        public bool KeyboardLock { get; set; }
        public bool LEDIndicator { get; set; }
        public bool Squelch { get; set; }
        public bool PasswordLock { get; set; }
        public bool VOX { get; set; }
        public bool Backlight { get; set; }
        public bool DisplayMode { get; set; }
        public bool ProgramRadio { get; set; }
        public bool Scan { get; set; }
        public bool EditList { get; set; }
    }



    #region Extensions
    /*public partial class NumericCallAlertToneDuration : NumericUpDown
    {
        public NumericCallAlertToneDuration()
        {
        }

        protected override void UpdateEditText()
        {
            if (Value == 0)
                Text = "Continue";
            else
                base.UpdateEditText();
        }
    }*/
    #endregion
}
