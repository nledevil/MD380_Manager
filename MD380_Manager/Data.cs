using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace MD380_Manager
{
    public static class MD380Data
    {
        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int memcmp(byte[] b1, byte[] b2, long count);

        #region Mappings
        // Contacts
        private static int _cn_start = htoi("061A5");
        private static int _cn_end = htoi("0EE44");
        private static int _cn_len = 36;
        
        // RX Groups
        private static int _rx_start = htoi("0EE45");
        private static int _rx_end = htoi("14C04");
        private static int _rx_len = 96;

        // Zones
        private static int _zn_start = htoi("14C05");
        private static int _zn_end = htoi("18A84");
        private static int _zn_len = 64;

        // Scan Lists
        private static int _sc_start = htoi("18A85");
        private static int _sc_end = htoi("1F015");
        private static int _sc_len = 104;

        //// Privacy
        private static int _pv_start = htoi("1F015");
        private static int _pv_end = htoi("1F024");
        private static int _pv_len = 16;

        //// Channels
        private static int _ch_start = htoi("1F025");
        private static int _ch_end = htoi("2EA24");
        private static int _ch_len = 64;

        // Emergency
        // ??

        // Basic Info
        // ??

        // General Settings
        // ??

        // Menu Items
        // ??

        // Button Definitions
        // ??

        // Text Messages
        // ??

        // DTMF Signaling
        // ??
        #endregion
        private static List<int> _channelScanLists;
        private static byte[] _inputFile;
        private static byte[] _outputFile;
        #region BasicInfo
        public static BasicInfo Basic_Info;
        private static void initBasicInfo()
        {
            Basic_Info = new BasicInfo();

            #region Frequency Range
            byte fRng = _inputFile[htoi("136")];
            Basic_Info.FrequencyRange = fRng.ToString("X2") == "00" ? "136-174Mhz" : (fRng.ToString("X2") == "01" ? "350-400Mhz" : (fRng.ToString("X2") == "02" ? "400-480Mhz" : (fRng.ToString("X2") == "03" ? "450-520Mhz" : "")));
            #endregion

            #region Last Programmed Date
            byte[] prgDate = _inputFile.Slice(htoi("2226"), 7);
            string pDate = btoh(prgDate[0]) + btoh(prgDate[1]) + "-" + btoh(prgDate[2]) + "-" + btoh(prgDate[3]);
            string pTime = btoh(prgDate[4]) + ":" + btoh(prgDate[5]) + ":" + btoh(prgDate[6]);
            Basic_Info.LastProgramDate = pDate + " " + pTime;
            #endregion

            #region Model Name
            byte[] mdb = _inputFile.Slice(htoi("125"), 5);
            string md = batoa(mdb);
            Basic_Info.ModelName = md == "DR780" ? "MD_380" : (md == "D680" ? "CS700" : "");
            #endregion

            #region Serial Number
            // 145+14
            Basic_Info.SerialNumber = batoa(_inputFile.Slice(htoi("145"), 14));
            #endregion

            #region CPS Version
            // 222D-2230

            byte[] bcpsVer = _inputFile.Slice(htoi("222D"), 4);
            Basic_Info.CPSVersion = "V" + htoi(btoh(bcpsVer[0])).ToString() + htoi(btoh(bcpsVer[1])).ToString();
            Basic_Info.CPSVersion += "." + htoi(btoh(bcpsVer[2])).ToString() + htoi(btoh(bcpsVer[3])).ToString();
            #endregion

            #region Hardware Version
            // 15A,15C
            string hTest = btoh(_inputFile[htoi("15A")]);
            if (hTest != "FF")
            {
                Basic_Info.HardwareVersion = "V" + btoh(_inputFile[htoi("15A")]) + "." + btoh(_inputFile[htoi("15C")]);
            }
            #endregion

            #region MCU Version
            byte[] mcuVer = _inputFile.Slice(htoi("165"),4);
            string mcuVer_str = btoh(mcuVer[1]);
            if (mcuVer_str != "FF")
            {
                mcuVer_str += btoh(mcuVer[2]) + btoh(mcuVer[3]);
                mcuVer_str = mcuVer_str.Substring(0, 3) + "." + mcuVer_str.Substring(3, 3);
                Basic_Info.MCUVersion = Convert.ToChar(mcuVer[0]).ToString() + mcuVer_str;
            }
            #endregion

            #region Unique Device ID
            int uStart = htoi("16D");
            int uEnd = htoi("178") - uStart + 1;
            byte[] uId = _inputFile.Slice(uStart, uEnd);            
            if (btoh(uId[11]) != "FF")
            {
                string unId = batoa(uId.Slice(5, 7).Reverse().ToArray());
                string unIdint = btoh(uId[4]) + btoh(uId[3]) + btoh(uId[2]) + btoh(uId[1]) + btoh(uId[0]);
                Int64 uIdint = Convert.ToInt64(unIdint, 16);
                Basic_Info.UniqueDeviceID = unId + uIdint.ToString().PadLeft(13, '0');
            }
            #endregion
        }
        private static void saveBasicInfo()
        {
            #region Frequency Range
            string frqRng = Basic_Info.FrequencyRange == "136-174Mhz" ? "00" : (Basic_Info.FrequencyRange == "350-400Mhz" ? "01" : (Basic_Info.FrequencyRange == "400-480Mhz" ? "02" : (Basic_Info.FrequencyRange == "450-520Mhz" ? "03" : "FF")));
            _outputFile[htoi("136")] = byte.Parse(frqRng);
            #endregion

            #region Last Programmed Date
            string[] dateTime = Basic_Info.LastProgramDate.Split(new char[] { ' ' });
            string[] dateArr = dateTime[0].Split(new char[] { '-' });
            string[] timeArr = dateTime[1].Split(new char[] { ':' });
            int dtStart = htoi("2226");
            _outputFile[dtStart] = htob(dateArr[0].Substring(0, 2));
            _outputFile[dtStart + 1] = htob(dateArr[0].Substring(2, 2));
            _outputFile[dtStart + 2] = htob(dateArr[1]);
            _outputFile[dtStart + 3] = htob(dateArr[2]);
            _outputFile[dtStart + 4] = htob(timeArr[0]);
            _outputFile[dtStart + 5] = htob(timeArr[1]);
            _outputFile[dtStart + 6] = htob(timeArr[2]);
            #endregion

            #region Model Name
            copySliceToOutput(htoi("125"), 5, atoba(Basic_Info.ModelName == "MD_380" ? "DR780" : "D680\0"));
            #endregion

            #region Serial Number
            // 145+14
            copySliceToOutput(htoi("145"), 14, atoba(Basic_Info.SerialNumber));
            #endregion

            #region CPS Version
            copySliceToOutput(htoi("222D"),4,itoba(Basic_Info.CPSVersion.Replace(".", "").Replace("V", "")));
            #endregion

            #region Hardware Version
            if (!string.IsNullOrEmpty(Basic_Info.HardwareVersion))
            {
                int i15a = htoi("15A");
                int i15c = htoi("15C");
                _outputFile[i15a] = htob(Basic_Info.HardwareVersion.Substring(1, 2));
                _outputFile[i15c] = htob(Basic_Info.HardwareVersion.Substring(4, 2));
            }
            #endregion

            #region MCU Version
            if (!string.IsNullOrEmpty(Basic_Info.MCUVersion))
            {
                string mcuHex = btoh(Convert.ToByte(Convert.ToChar(Basic_Info.MCUVersion.Substring(0, 1)))) + Basic_Info.MCUVersion.Substring(1).Replace(".","");
                byte[] newArr = htoba(mcuHex);
                byte[] mcuVer = _inputFile.Slice(htoi("165"), 4);
                copySliceToOutput(htoi("165"), 4, newArr);
            }
            #endregion

            #region Unique Device ID
            if (!string.IsNullOrEmpty(Basic_Info.UniqueDeviceID))
            {
                int uStart = htoi("16D");
                int uLen = htoi("178") - uStart + 1;
                byte[] partB = htoba(Convert.ToInt64(Basic_Info.UniqueDeviceID.Substring(Basic_Info.UniqueDeviceID.Length - 13)).ToString("X10")).Reverse().ToArray();
                byte[] unID = partB.Concat(atoba(reverseString(Basic_Info.UniqueDeviceID.Substring(0, Basic_Info.UniqueDeviceID.Length - 13)))).ToArray();
                copySliceToOutput(uStart, uLen, unID);
            }
            #endregion
        }
        #endregion
        #region General Settings
        public static GeneralSetting GeneralSettings;
        private static void initGeneralSettings()
        {
            try
            {
                GeneralSettings = new GeneralSetting();

                byte b22A6 = _inputFile[htoi("22A6")];
                byte b22B4 = _inputFile[htoi("22B4")];
                byte b22B5 = _inputFile[htoi("22B5")];
                byte b22B6 = _inputFile[htoi("22B6")];
                byte b22B8 = _inputFile[htoi("22B8")];
                byte b22B9 = _inputFile[htoi("22B9")];
                byte b22A7 = _inputFile[htoi("22A7")];
                // 22A6-0
                string s22A60 = btoh(b22A6).Substring(0, 1);
                // 22A6-1
                string s22A61 = btoh(b22A6).Substring(1, 1);

                // Password and Lock 22A6-D0 : 0,1,4,5,8,9,C,D
                GeneralSettings.PasswordLockEnable = cCheck(s22A60, "0124589CD");
                
                // None 22A6-D0: 0,1,2,3, Digital 22A6-D0: 4,5,6,7, Analog 22A6-D0: 8,9,A,B, Digital and Analog 22A6-D0: C,D,E,F
                GeneralSettings.TalkPermitTone = cCheck(s22A60, "0123") ? "None" : (cCheck(s22A60, "4567") ? "Digital" : (cCheck(s22A60, "89AB") ? "Analog" : (cCheck(s22A60, "CDEF") ? "Digital and Analog" : "")));

                // Disable All Tone 22A6-D1: 8,9,A,B
                GeneralSettings.DisableAllTone = cCheck(s22A61, "89AB");

                // CHFreeIndTone 22A6-D0: 0,2,4,6,8,A,C,E
                GeneralSettings.CHFreeIndTone = cCheck(s22A60, "02468ACE");

                // SavePreamble 22A6-D1: 9,B,D,F
                GeneralSettings.SavePreamble = cCheck(s22A61, "9BDF");

                // Save Mode Receive 22A6-D1: A,B,E,F
                GeneralSettings.SaveModeReceive = cCheck(s22A61, "ABEF");

                // Call Alert Tone Duration 22B4
                // 00: Continue, 01:5, F0: 1200 (Dec 240 * 5)
                GeneralSettings.CallAlertToneDuration = (btoi(b22B4) * 5);
                
                // Scan Digital Hang Time: 22B8 : 1000 Default
                // 05: 500, 0A: 1000, 0F: 1500, 64: 10000, (Dec * 100)
                GeneralSettings.ScanDigitalHangTime = (btoi(b22B8) * 100);

                // Scan Analog Hang Time(ms): 22B9 : 1000 Default
                // Same as Digital Above (Dec * 100)
                GeneralSettings.ScanAnalogHangTime = (btoi(b22B9) * 100);

                // Lone Worker Reminder Time(min): 22B5 : 10 Default
                // Convert to decimal, 1-255
                GeneralSettings.LoneWorkerRespTime = btoi(b22B5);

                // Lone Worker Reminder Time(s):22B6 : 1 Default
                // Convert to Decimal, 1-255
                GeneralSettings.LoneWorkerReminderTime = btoi(b22B6);

                // Power On Password: 22BD + 4 (max 8 numbers) : (00000000: Default)
                // 00 00 01 11 = 00000111 ,00 01 00 11 = 00010011
                byte[] bPOP = _inputFile.Slice(htoi("22BD"), 4);
                GeneralSettings.PowerOnPassword = btoh(bPOP[0]) + btoh(bPOP[1]) + btoh(bPOP[2]) + btoh(bPOP[3]);

                // Radio Name: 22D5+32
                GeneralSettings.RadioName = batoa(_inputFile.Slice(htoi("22D5"), 32));

                // Radio ID: 22A9 + 4 : 1234 Default
                // Hex in reverse then Converted to Decimal
                GeneralSettings.RadioID = htoi(batoh(_inputFile.Slice(htoi("22A9"), 4).Reverse().ToArray())).ToString();

                // Monitor Type: 22A5 : Open Squelch Default
                string mt = btoh(_inputFile[htoi("22A5")]);
                // EE: Silent
                // EA: Silent, DisableAllLEDs
                // FE: Open Squelch
                // FA: Open, DisableAllLEDs
                GeneralSettings.MonitorType = (mt == "EE" || mt == "EA") ? "Silent" : ((mt == "FE" || mt == "FA") ? "Open Squelch" : "");

                // Disable LEDs
                GeneralSettings.DisableAllLEDS = (mt == "EA" || mt == "FA") ? true : false;

                // VOX Sensitivity: 22B0 : 3 Default
                // 01: 1 min, 0A: 10 max
                GeneralSettings.VOXSensitivity = btoi(_inputFile[htoi("22B0")]);

                // TX Preamble Duration(ms):22AD : 300 Default
                // Convert(dec) * 60: 144 * 60 max, 0 min
                GeneralSettings.TXPreambleDuration = (btoi(_inputFile[htoi("22AD")]) * 60);

                // RX Low Batt Interval(s): 22B3 : 120 Default
                // Convert(dec) * 5, 0 min, 127 * 5 max
                GeneralSettings.RXLowBatInterval = (btoi(_inputFile[htoi("22B3")]) * 5);

                // PC Prog Password: 22C5 + 8 (Max 8 characters) (Blank Default)
                // Convert(ascii)
                GeneralSettings.PCProgPassword = batoa(_inputFile.Slice(htoi("22C5"), 8));

                // Radio Prog Password: 22C1 + 4 (Max 8 characters) (00000000 Default)
                // 12 34 56 78 = 12345678
                GeneralSettings.RadioProgPassword = batoh(_inputFile.Slice(htoi("22C1"), 4));

                // Back Light Time(s): 22BA : Always Default
                // 00: Always, 01: 5, 02: 10, 03: 15
                string bcklt = (btoi(_inputFile[htoi("22BA")]) * 5).ToString();
                GeneralSettings.BackLightTime = (bcklt == "0") ? "Always" : bcklt;

                // Set Keypad Lock Time(s): 22BB : Manual Default
                // FF: Manual, 01: 5, 02: 10, 03: 15
                string keyLck = (btoi(_inputFile[htoi("22BB")]) * 5).ToString();
                GeneralSettings.SetKeypadLockTime = (keyLck == "0") ? "Manual" : keyLck;

                // Group Call Hang Time(ms): 22AE : 3000 Default
                // Convert(dec) * 10, 0 * 10 min, 70 * 10 max
                GeneralSettings.GroupCallHangTime = (btoi(_inputFile[htoi("22AE")]) * 10);

                // Private Call Hang Time(ms): 22AF : 4000 Default
                // Convert(dec) * 10, 0 * 10 min, 70 * 10 max
                GeneralSettings.PrivateCallHangTime = (btoi(_inputFile[htoi("22AF")]) * 10);

                // Intro Screen: 22A7

                // EA: Picture, FA: Characters
                string inScr = btoh(b22A7);
                GeneralSettings.IntroScreen = (inScr == "EA") ? "Picture" : ((inScr == "FA") ? "Characters" : "");

                // Intro Screen Line 1: 2265+20
                // Convert to Ascii
                GeneralSettings.IntroScreenLine1 = batoa(_inputFile.Slice(htoi("2265"), 20));

                // Intro Screen Line 2: 2279+20
                // Convert to Ascii
                GeneralSettings.IntroScreenLine2 = batoa(_inputFile.Slice(htoi("2279"), 20));
            }
            catch (Exception ex) { throw ex; }
        }  
        private static void saveGeneralSettings()
        {
            // 22A60
            List<string> s22A60 = createList("0123456789ABCDEF");

            if (GeneralSettings.PasswordLockEnable)
                s22A60 = filterList(s22A60, "014589CD");
            else
                s22A60 = filterList(s22A60, "2367ABEF");

            if (GeneralSettings.TalkPermitTone == "None")
                s22A60 = filterList(s22A60, "0123");
            else if (GeneralSettings.TalkPermitTone == "Digital")
                s22A60 = filterList(s22A60, "4567");
            else if (GeneralSettings.TalkPermitTone == "Analog")
                s22A60 = filterList(s22A60, "89AB");
            else
                s22A60 = filterList(s22A60, "CDEF");

            if (GeneralSettings.CHFreeIndTone)
                s22A60 = filterList(s22A60, "02468ACE");
            else
                s22A60 = filterList(s22A60, "13579BDF");

            // 22A61
            List<string> s22A61 = createList("89ABCDEF");

            if (GeneralSettings.DisableAllTone)
                s22A61 = filterList(s22A61, "89AB");
            else
                s22A61 = filterList(s22A61,"CDEF");
            
            if (GeneralSettings.SavePreamble)
                s22A61 = filterList(s22A61, "9BDF");
            else
                s22A61 = filterList(s22A61, "8ACE");

            if (GeneralSettings.SaveModeReceive)
                s22A61 = filterList(s22A61, "ABEF");
            else
                s22A61 = filterList(s22A61, "89CD");

            if (s22A60.Count == 1 && s22A61.Count == 1)
            {
                _outputFile[htoi("22A6")] = htoba(s22A60[0] + s22A61[0])[0];
            }
            else
            {
                throw new Exception("SOMETHING WRONG WITH GENERAL SETTINGS:s22A6");
            }

            
            // 22B4 - Call Alert Tone Duration
            _outputFile[htoi("22B4")] = Convert.ToByte(GeneralSettings.CallAlertToneDuration > 0 ? GeneralSettings.CallAlertToneDuration / 5 : 0);

            // 22B8 - Scan Digital Hang Time
            _outputFile[htoi("22B8")] = Convert.ToByte(GeneralSettings.ScanDigitalHangTime > 0 ? GeneralSettings.ScanDigitalHangTime / 100 : 0);
            
            // 22B9 - Scan Analog Hang Time
            _outputFile[htoi("22B9")] = Convert.ToByte(GeneralSettings.ScanAnalogHangTime > 0 ? GeneralSettings.ScanAnalogHangTime / 100 : 0);

            // 22B5 - Lone Worker Response Time
            _outputFile[htoi("22B5")] = Convert.ToByte(GeneralSettings.LoneWorkerRespTime);

            // 22B6 - Lone Worker Reminder Time
            _outputFile[htoi("22B6")] = Convert.ToByte(GeneralSettings.LoneWorkerReminderTime);
            
            // 22BD - Power On Password
            copySliceToOutput(htoi("22BD"), 4, htoba(GeneralSettings.PowerOnPassword));
            
            // 22D5 - Radio Name
            copySliceToOutput(htoi("22D5"), 32, atoba(GeneralSettings.RadioName, htob("00"), 16, true));
            
            // 22A9 - Radio ID
            copySliceToOutput(htoi("22A9"), 4, atoba(reverseString(GeneralSettings.RadioID)));
            
            // 22A5 - Monitor Type & Disable All LEDs
            _outputFile[htoi("22A5")] = byte.Parse((GeneralSettings.MonitorType == "Silent" ? "E" : "F") + (GeneralSettings.DisableAllLEDS ? "A" : "E"),NumberStyles.HexNumber);
            
            // 22B0 - VOX Sensitivity
            _outputFile[htoi("22B0")] = itob(GeneralSettings.VOXSensitivity);

            // 22AD - TX Preamble
            _outputFile[htoi("22AD")] = itob((GeneralSettings.TXPreambleDuration != 0 ? GeneralSettings.TXPreambleDuration / 60 : 0));
            
            // 22B3 - RX Low Batt
            _outputFile[htoi("22B3")] = itob((GeneralSettings.RXLowBatInterval != 0 ? GeneralSettings.RXLowBatInterval / 5 : 0));
            
            // 22C5 - PC Prog Password
            copySliceToOutput(htoi("22C5"), 8, atoba(GeneralSettings.PCProgPassword, htob("FF"), 8, false));
            
            // 22C1 - Radio Prog Password
            copySliceToOutput(htoi("22C1"), 4, htoba(GeneralSettings.RadioProgPassword));

            // 22BA - Backlight Time
            _outputFile[htoi("22BA")] = itob(GeneralSettings.BackLightTime == "Always" ? 0 : Convert.ToInt16(GeneralSettings.BackLightTime) / 5);

            // 22BB - Keypad Lock Time
            _outputFile[htoi("22BB")] = itob(GeneralSettings.SetKeypadLockTime == "Manual" ? 0 : Convert.ToInt16(GeneralSettings.SetKeypadLockTime) / 5);

            // 22AE - Group Call Hang Time
            _outputFile[htoi("22AE")] = itob(GeneralSettings.GroupCallHangTime == 0 ? 0 : GeneralSettings.GroupCallHangTime / 10);

            // 22AF - Private Call Hang Time
            _outputFile[htoi("22AF")] = itob(GeneralSettings.PrivateCallHangTime == 0 ? 0 : GeneralSettings.PrivateCallHangTime / 10);

            // 22A7 - Intro Screen
            _outputFile[htoi("22A7")] = htob(GeneralSettings.IntroScreen == "Picture" ? "EA" : "FA");

            // 2265 - Intro Screen Line 1
            copySliceToOutput(htoi("2265"), 20, atoba(GeneralSettings.IntroScreenLine1, htob("00"), 10, true));

            // 2279 - Intro Screen Line 2
            copySliceToOutput(htoi("2279"), 20, atoba(GeneralSettings.IntroScreenLine2, htob("00"), 10, true));
        }
        #endregion
        #region Menu Items
        public static MenuItems MenuItem;
        private static void initMenuItems()
        {
            try
            {
                MenuItem = new MenuItems();

                string s2315 = btoh(_inputFile[htoi("2315")]);
                string s2316 = btoh(_inputFile[htoi("2316")]);
                string s2317 = btoh(_inputFile[htoi("2317")]);
                string s2318 = btoh(_inputFile[htoi("2318")]);
                string s2319 = btoh(_inputFile[htoi("2319")]);
                
                // Menu Hang Time(s): 2315 : 10 Default
                // 00: Hang, 1E: 30 max
                MenuItem.MenuHangTime = htoi(s2315);

                // 2316
                string s23160 = s2316.Substring(0,1);
                string s23161 = s2316.Substring(1,1);

                // Radio Check: 0: 1,3,5,7,9,B,D,F
                MenuItem.RadioCheck = cCheck(s23160, "13579BDF");

                // Remote Monitor: 0: 2,3,6,7,A,B,E,F
                MenuItem.RemoteMonitor = cCheck(s23160, "2367ABEF");

                // Radio Enable: 0: 4,5,6,7,C,D,E,F
                MenuItem.RadioEnable = cCheck(s23160, "4567CDEF");

                // Radio Disable: 0: 8,9,A,B,C,D,E,F
                MenuItem.RadioDisable = cCheck(s23160, "89ABCDEF");

                // Text Message: 1: 1,3,5,7,9,B,D,F
                MenuItem.TextMessage = cCheck(s23161, "13579BDF");

                // Call Alert: 1: 2,3,6,7,A,B,E,F
                MenuItem.CallAlert = cCheck(s23161, "2367ABEF");

                // Edit: 1: 4,5,6,7,C,D,E,F
                MenuItem.Edit = cCheck(s23161, "4567CDEF");

                // Manual Dial: 1: 8,9,A,B,C,D,E,F
                MenuItem.ManualDial = cCheck(s23161, "89ABCDEF");

                // 2317
                string s23170 = s2317.Substring(0, 1);
                string s23171 = s2317.Substring(1, 1);

                // Answered: 0: 1,3,5,7,9,B,D,F
                MenuItem.Answered = cCheck(s23170, "13579BDF");

                // Outgoing Radio: 0: 2,3,6,7,A,B,E,F
                MenuItem.OutgoingRadio = cCheck(s23170, "2367ABEF");

                // Talkaround: 0: 4,5,6,7,C,D,E,F
                MenuItem.Talkaround = cCheck(s23170, "4567CDEF");

                // Tone/Alert: 0: 8,9,A,B,C,D,E,F
                MenuItem.ToneOrAlert = cCheck(s23170, "89ABCDEF");

                // Program Key: 1: 1,3,5,7,9,B,D,F
                MenuItem.ProgramKey = cCheck(s23171, "13579BDF");

                // Scan: 1: 2,3,6,7,A,B,E,F
                MenuItem.Scan = cCheck(s23171, "2367ABEF");

                // Edit List: 1: 4,5,6,7,C,D,E,F
                MenuItem.EditList = cCheck(s23171, "4567CDEF");

                // Missed: 1: 8,9,A,B,C,D,E,F
                MenuItem.Missed = cCheck(s23171, "89ABCDEF");

                // 2318
                string s23180 = s2318.Substring(0, 1);
                string s23181 = s2318.Substring(1, 1);

                // LED Indicator: 0: 1,3,9,B
                MenuItem.LEDIndicator = cCheck(s23180, "139B");

                // Squelch: 0: 2,3,A,B
                MenuItem.Squelch = cCheck(s23180, "23AB");

                // VOX: 0: 8,9,A,B
                MenuItem.VOX = cCheck(s23180, "89AB");

                // Power: 1: 1,3,5,7,9,B,D,F
                MenuItem.Power = cCheck(s23181, "13579BDF");

                // Backlight: 1: 2,3,6,7,A,B,E,F
                MenuItem.Backlight = cCheck(s23181, "2367ABEF");

                // Intro Screen: 1: 4,5,6,7,C,D,E,F
                MenuItem.IntroScreen = cCheck(s23181, "4567CDEF");

                // Keyboard Lock: 1: 8,9,A,B,C,D,E,F
                MenuItem.KeyboardLock = cCheck(s23181, "89ABCDEF");

                // 2319
                string s23191 = s2319.Substring(1, 1);

                // Program Radio, 2nd Digit 8,9,A,B
                MenuItem.ProgramRadio = cCheck(s23191, "89AB");

                // Password Lock, 2nd Digit 9,B,D,F
                MenuItem.PasswordLock = cCheck(s23191, "9BDF");

                // Display Mode, 2nd Digit A,B,E,F
                MenuItem.DisplayMode = cCheck(s23191, "ABEF");
            }
            catch (Exception ex) { throw ex; }
        }
        private static void saveMenuItems()
        {
            // 2315 - Menu Hang Time
            _outputFile[htoi("2315")] = itob(MenuItem.MenuHangTime);
            
            // 2316
            List<string> s23160 = createList("0123456789ABCDEF");
            List<string> s23161 = createList("0123456789ABCDEF");

            if (MenuItem.RadioCheck)
                s23160 = filterList(s23160, "13579BDF");
            else
                s23160 = filterList(s23160, "02468ACE");

            if (MenuItem.RemoteMonitor)
                s23160 = filterList(s23160, "2367ABEF");
            else
                s23160 = filterList(s23160, "014589CD");

            if (MenuItem.RadioEnable)
                s23160 = filterList(s23160, "4567CDEF");
            else
                s23160 = filterList(s23160, "012389AB");

            if (MenuItem.RadioDisable)
                s23160 = filterList(s23160, "89ABCDEF");
            else
                s23160 = filterList(s23160, "01234567");

            if (MenuItem.TextMessage)
                s23161 = filterList(s23161, "13579BDF");
            else
                s23161 = filterList(s23161, "02468ACE");

            if (MenuItem.CallAlert)
                s23161 = filterList(s23161, "2367ABEF");
            else
                s23161 = filterList(s23161, "014589CD");

            if (MenuItem.Edit)
                s23161 = filterList(s23161, "4567CDEF");
            else
                s23161 = filterList(s23161, "012389AB");

            if (MenuItem.ManualDial)
                s23161 = filterList(s23161, "89ABCDEF");
            else
                s23161 = filterList(s23161, "01234567");

            _outputFile[htoi("2316")] = htob(s23160[0] + s23161[0]);
            
            // 2317
            //string s23170 = s2317.Substring(0, 1);
            //string s23171 = s2317.Substring(1, 1);

            // Answered: 0: 1,3,5,7,9,B,D,F
            //MenuItem.Answered = cCheck(s23170, "13579BDF");

            // Outgoing Radio: 0: 2,3,6,7,A,B,E,F
            //MenuItem.OutgoingRadio = cCheck(s23170, "2367ABEF");

            // Talkaround: 0: 4,5,6,7,C,D,E,F
            //MenuItem.Talkaround = cCheck(s23170, "4567CDEF");

            // Tone/Alert: 0: 8,9,A,B,C,D,E,F
            //MenuItem.ToneOrAlert = cCheck(s23170, "89ABCDEF");

            // Program Key: 1: 1,3,5,7,9,B,D,F
            //MenuItem.ProgramKey = cCheck(s23171, "13579BDF");

            // Scan: 1: 2,3,6,7,A,B,E,F
            //MenuItem.Scan = cCheck(s23171, "2367ABEF");

            // Edit List: 1: 4,5,6,7,C,D,E,F
            //MenuItem.EditList = cCheck(s23171, "4567CDEF");

            // Missed: 1: 8,9,A,B,C,D,E,F
            //MenuItem.Missed = cCheck(s23171, "89ABCDEF");

            // 2318
            //string s23180 = s2318.Substring(0, 1);
            //string s23181 = s2318.Substring(1, 1);

            // LED Indicator: 0: 1,3,9,B
            //MenuItem.LEDIndicator = cCheck(s23180, "139B");

            // Squelch: 0: 2,3,A,B
            //MenuItem.Squelch = cCheck(s23180, "23AB");

            // VOX: 0: 8,9,A,B
            //MenuItem.VOX = cCheck(s23180, "89AB");

            // Power: 1: 1,3,5,7,9,B,D,F
            //MenuItem.Power = cCheck(s23181, "13579BDF");

            // Backlight: 1: 2,3,6,7,A,B,E,F
            //MenuItem.Backlight = cCheck(s23181, "2367ABEF");

            // Intro Screen: 1: 4,5,6,7,C,D,E,F
            //MenuItem.IntroScreen = cCheck(s23181, "4567CDEF");

            // Keyboard Lock: 1: 8,9,A,B,C,D,E,F
            //MenuItem.KeyboardLock = cCheck(s23181, "89ABCDEF");

            // 2319
            //string s23191 = s2319.Substring(1, 1);

            // Program Radio, 2nd Digit 8,9,A,B
            //MenuItem.ProgramRadio = cCheck(s23191, "89AB");

            // Password Lock, 2nd Digit 9,B,D,F
            //MenuItem.PasswordLock = cCheck(s23191, "9BDF");

            // Display Mode, 2nd Digit A,B,E,F
            //MenuItem.DisplayMode = cCheck(s23191, "ABEF");
        }
        #endregion
        #region Contacts
        public static List<Contact> Contacts;
        private static void initContacts()
        {
            Contacts = new List<Contact>();
            try
            {
                // Chop the part of the file for Contacts
                byte[] contacts = _inputFile.Slice(_cn_start, (_cn_end - _cn_start) + 1);

                // Create new list of Contacts
                List<byte[]> con_list = new List<byte[]>();

                // Fill the con_list
                for (int i = 0; i < contacts.Length; i += _cn_len)
                    con_list.Add(contacts.Slice(i, _cn_len));

                foreach (byte[] cn in con_list)
                {
                    // Lets create some actual contacts
                    Contact con = new Contact();

                    // Generate Guid
                    con.GUID = Guid.NewGuid();

                    // ID Number
                    string id_str = btoh(cn[2]) + btoh(cn[1]) + btoh(cn[0]);
                    con.CallID = htoi(id_str);

                    // Call Tone and Call Type
                    string ct = btoh(cn[3]);
                    con.receiveTone = ct.Substring(0, 1) == "C" ? false : true;
                    con.CallType = (ct.Substring(1, 1) == "1" ? "GROUP" : (ct.Substring(1, 1) == "2" ? "PRIVATE" : (ct.Substring(1, 1) == "3" ? "ALL CALL" : "BLANK")));

                    // Contact Name
                    con.Name = batoa(cn.Slice(4, _cn_len - 4));

                    Contacts.Add(con);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static void saveContacts()
        {

        }
        #endregion
        #region Channels
        public static List<Channel> Channels;
        private static void initChannels()
        {
            Channels = new List<Channel>();
            try
            {
                byte[] channels = _inputFile.Slice(_ch_start, (_ch_end - _ch_start) + 1);

                List<byte[]> ch_list = new List<byte[]>();

                for (int i = 0; i < channels.Length; i += _ch_len)
                    ch_list.Add(channels.Slice(i, _ch_len));

                _channelScanLists = new List<int>();

                foreach (byte[] ch in ch_list)
                {
                    try
                    {
                        Channel channel = new Channel();

                        AnalogData aData = new AnalogData();
                        DigitalData dData = new DigitalData();

                        channel.GUID = Guid.NewGuid();

                        #region Channel Byte 0
                        // Channel Mode (Analog/Digital)
                        string cMode = btoh(ch[0]).Substring(1, 1);
                        channel.ChannelMode = (cMode == "9" || cMode == "1") ? "Analog" : (cMode == "2" ? "Digital" : "BLANK" + cMode);
                        channel.Bandwidth = (cMode == "1" || cMode == "2") ? "12.5Khz" : (cMode == "9" ? "25Khz" : "BLANK");

                        // Squelch, Auto Scan, Lone Worker
                        string sal = btoh(ch[0]).Substring(0, 1);
                        // 4,5,C,D = Tight ; 6,7,E,F = Normal ; Everything Else Blank
                        channel.Squelch = (cCheck(sal, "45CD") ? "Tight" : (cCheck(sal, "67EF") ? "Normal" : "BLANK"));
                        // Auto Scan: 5,7,D,F Checked, else false
                        channel.AutoScan = cCheck(sal, "57DE");
                        // Lone Worker C,D,E,F
                        channel.LoneWorker = cCheck(sal, "CDEF");
                        #endregion

                        #region Channel Byte 1
                        // Color Code
                        dData.ColorCode = htoi(btoh(ch[1]).Substring(0, 1));

                        // TS, RX Only, Talk Around
                        string trt = btoh(ch[1]).Substring(1, 1);
                        // TS
                        dData.RepeaterSlot = cCheck(trt, "4567") ? 1 : (cCheck(trt, "89AB") ? 2 : 0);
                        // RX Only - 6,7,A,B
                        channel.RXOnly = cCheck(trt, "67AB");
                        // Talk Around - 5,7,9,B
                        channel.AllowTalkaround = cCheck(trt, "579B");
                        #endregion

                        #region Channel Byte 2
                        //Encryption,Private Call,Data Call
                        string epd = btoh(ch[2]).Substring(0, 1);
                        // Encryption - None: 0,4,8,C ; Basic: 1,5,9,D ; Enhanced: 2,6,A,E
                        dData.Privacy = cCheck(epd, "04BC") ? "None" : (cCheck(epd, "159D") ? "Basic" : (cCheck(epd, "26AE") ? "Enhanced" : ""));
                        // Private Call Checked - 4,5,6,C,D,E
                        dData.PrivateCallConf = cCheck(epd, "456CDE");
                        // Data Call Checked - 8,9,A,C,D,E
                        dData.DataCallConf = cCheck(epd, "89ACDE");
                        // Privacy No
                        dData.PrivacyNo = htoi(btoh(ch[2]).Substring(1, 1));
                        #endregion

                        #region Channel Byte 3
                        // Display PTT ID
                        aData.DisplayPTTID = cCheck(btoh(ch[3]).Substring(0, 1), "6");
                        // RX Reference
                        string rxRef = btoh(ch[3]).Substring(1, 1);
                        channel.RXRef = cCheck(rxRef, "08") ? "Low" : (cCheck(rxRef, "19") ? "Medium" : (cCheck(rxRef, "2A") ? "High" : ""));
                        // Emergency Alarm Ack
                        dData.EmergencyAlarmAck = cCheck(rxRef, "89A");
                        #endregion

                        #region Channel Byte 4
                        // Power, TX Ref, VOX, Admit Criteria
                        string ptv = btoh(ch[4]).Substring(0, 1);
                        string txRef = btoh(ch[4]).Substring(1, 1);
                        // Power - Low: 0,1,4,5,8,9,C,D ; High: 2,3,6,7,A,B,E,F
                        channel.Power = cCheck(ptv, "014589CD") ? "Low" : (cCheck(ptv, "2367ABEF") ? "High" : "");
                        // TX Ref - Low: 0,4,8,C ; Med: 1,5,9,D ; High: 2,6,A,E
                        channel.TXRef = cCheck(txRef, "048C") ? "Low" : (cCheck(txRef, "159D") ? "Medium" : (cCheck(txRef, "26AE") ? "High" : ""));
                        // VOX - 1,3,5,7,9,B,D,F
                        channel.VOX = cCheck(ptv, "13579BDF");
                        // Admit Criteria - Always:0123 ; Channel:4567 ; CTCSS:89AB ; Color Code:CDEF
                        channel.AdmitCriteria = cCheck(ptv, "0123") ? "Always" : (cCheck(ptv, "4567") ? "Channel" : (cCheck(ptv, "89AB") ? "CTCSS/DCS" : (cCheck(ptv, "CDEF") ? "Color Code" : "")));
                        // QT Reverse
                        aData.QTReverse = cCheck(txRef, "012456") ? 180 : (cCheck(txRef, "89ACDE") ? 120 : 0);
                        // Reverse Burst
                        aData.ReverseBurst = cCheck(txRef, "01289A");
                        #endregion

                        #region Channel Byte 6-7
                        int cntID = htoi(btoh(ch[7]) + btoh(ch[6]));
                        if (cntID > 0 && cntID < 65535)
                        {
                            if (cntID <= Contacts.Count)
                            {
                                dData.ContactGuid = Contacts.ToArray()[cntID - 1].GUID;
                            }
                        }
                        #endregion

                        #region Channel Byte 8
                        channel.TOT = (btoi(ch[8]) * 15);
                        #endregion

                        #region Channel Byte 9
                        channel.TOTDelay = btoi(ch[9]);
                        #endregion

                        // TODO
                        #region Channel Byte 10
                        int eSys = btoi(ch[10]);
                        if (eSys > 0)
                        {
                            //Get Emgcy System Guid

                        }
                        #endregion

                        #region Channel Byte 11
                        int sLID = btoi(ch[11]);
                        _channelScanLists.Add(sLID);
                        #endregion
                        // END TODO

                        #region Channel Byte 12
                        int gChn = btoi(ch[12]);
                        if (gChn > 0 && gChn < 65535)
                        {
                            if (gChn <= Groups.Count)
                            {
                                dData.GroupListGuid = Groups.ToArray()[gChn - 1].GUID;
                            }
                        }
                        #endregion

                        #region Channel Byte 14
                        int dcs = btoi(ch[14]);
                        RXSignalingDecode decodes = new RXSignalingDecode();
                        // Decode 8
                        if (dcs >= 128)
                        {
                            decodes.decode8 = true;
                            dcs -= 128;
                        }
                        // Decode 7
                        if (dcs >= 64)
                        {
                            decodes.decode7 = true;
                            dcs -= 64;
                        }
                        // Decode 6
                        if (dcs >= 32)
                        {
                            decodes.decode6 = true;
                            dcs -= 32;
                        }
                        // Decode 5
                        if (dcs >= 16)
                        {
                            decodes.decode5 = true;
                            dcs -= 16;
                        }
                        // Decode 4
                        if (dcs >= 8)
                        {
                            decodes.decode4 = true;
                            dcs -= 8;
                        }
                        // Decode 3
                        if (dcs >= 4)
                        {
                            decodes.decode3 = true;
                            dcs -= 4;
                        }
                        // Decode 2
                        if (dcs >= 2)
                        {
                            decodes.decode2 = true;
                            dcs -= 2;
                        }
                        // Decode 1
                        if (dcs >= 1)
                        {
                            decodes.decode1 = true;
                            dcs--;
                        }
                        aData.decodes = decodes;
                        #endregion

                        #region Channel Byte 16-19
                        string rxfrq = btoh(ch[19]) + btoh(ch[18]) + btoh(ch[17]) + btoh(ch[16]);
                        if (rxfrq != "FFFFFFFF")
                            channel.RXFreq = rxfrq.Substring(0, 3) + "." + rxfrq.Substring(3);
                        #endregion

                        #region Channel Byte 20-23
                        string txfrq = btoh(ch[23]) + btoh(ch[22]) + btoh(ch[21]) + btoh(ch[20]);
                        if (txfrq != "FFFFFFFF")
                            channel.TXFreq = txfrq.Substring(0, 3) + "." + txfrq.Substring(3);
                        #endregion

                        #region Channel Byte 24-25
                        string dcsDec = btoh(ch[25]) + btoh(ch[24]);
                        if (dcsDec != "FFFF")
                        {
                            if (cCheck(dcsDec.Substring(0, 1), "8C"))
                            {
                                aData.CTCSSDecode = "D" + dcsDec.Substring(1, 3) + (dcsDec.Substring(0, 1) == "8" ? "N" : "I");
                            }
                            else
                            {
                                aData.CTCSSDecode = dcsDec.Substring(0, 3) + "." + dcsDec.Substring(3, 1);
                            }
                        }
                        #endregion

                        #region Channel Byte 26-27
                        string dcsEnc = btoh(ch[27]) + btoh(ch[26]);
                        if (dcsEnc != "FFFF")
                        {
                            if (cCheck(dcsEnc.Substring(0, 1), "8C"))
                            {
                                aData.CTCSSEncode = "D" + dcsEnc.Substring(1, 3) + (dcsEnc.Substring(0, 1) == "8" ? "N" : "I");
                            }
                            else
                            {
                                aData.CTCSSEncode = dcsEnc.Substring(0, 3) + "." + dcsEnc.Substring(3, 1);
                            }
                        }
                        #endregion

                        #region Channel Byte 28-29
                        int rxsig = btoi(ch[28]);
                        if (rxsig > 0)
                        {
                            aData.RXSignaling = "DTMF" + rxsig.ToString();
                        }
                        else
                        {
                            aData.RXSignaling = "Off";
                        }

                        int txsig = btoi(ch[29]);
                        if (txsig > 0)
                        {
                            aData.TXSignaling = "DTMF" + txsig.ToString();
                        }
                        else
                        {
                            aData.TXSignaling = "Off";
                        }
                        #endregion

                        #region Channel Bytes 32-63
                        channel.ChannelName = (!string.IsNullOrEmpty(batoa(ch.Slice(32, 32))) ? batoa(ch.Slice(32, 32)) : "BLANK");
                        #endregion

                        channel.digital = dData;
                        channel.analog = aData;

                        Channels.Add(channel);
                    }
                    catch (Exception eex)
                    {
                        throw eex;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
        private static void updateChannelScanLists()
        {
            Channel[] chArr = Channels.ToArray();

            for (int i = 0; i < chArr.Length; i++)
            {
                Channel ch = chArr[i];
                int chID = _channelScanLists[i];
                if (chID < ScanLists.Count)
                {
                    ch.ScanListGuid = (ScanLists.ToArray())[_channelScanLists[i]].GUID;
                }
            }
        }
        private static void saveChannels()
        {
            for (int ch = 0; ch < Channels.Count; ch++)
            {
                Channel channel = Channels[ch];
                int bt = _ch_start + (ch * _ch_len);

                #region Byte 0
                // b00 - Squelch, Auto Scan, Lone Worker
                List<string> s00 = createList("4567CDEF");
                s00 = channel.Squelch == "Tight" ? filterList(s00, "45CD") : filterList(s00, "67EF");
                s00 = channel.AutoScan ? filterList(s00, "57DE") : filterList(s00, "46CF");
                s00 = channel.LoneWorker ? filterList(s00, "CDEF") : filterList(s00, "4567");
                // b01 - Channel Mode/Bandwidth
                string s01 = (channel.ChannelMode == "Analog" && channel.Bandwidth == "12.5Khz" ? "1" : (channel.ChannelMode == "Analog" ? "9" : channel.ChannelMode == "Digital" ? "2" : channel.ChannelMode.Replace("BLANK", "")));
                string ohex = _inputFile[bt].ToString("X2");
                _outputFile[bt] = htob(s00[0] + s01);
                #endregion

                #region Byte 1
                string s10 = channel.digital.ColorCode.ToString("X1");
                List<string> s11 = createList("456789AB");
                s11 = channel.digital.RepeaterSlot == 1 ? filterList(s11, "4567") : filterList(s11, "89AB");
                s11 = channel.RXOnly ? filterList(s11, "67AB") : filterList(s11, "4589");
                s11 = channel.AllowTalkaround ? filterList(s11, "579B") : filterList(s11, "468A");
                string ns1 = (s10 + s11[0]) == "F8" ? "FF" : s10 + s11[0];
                _outputFile[_ch_start + (ch * _ch_len) + 1] = htob(ns1);
                #endregion

                #region Byte 2
                List<string> s20 = createList("01245689ACDE");
                s20 = channel.digital.Privacy == "Enhanced" ? filterList(s20, "26AE") : (channel.digital.Privacy == "Basic" ? filterList(s20, "159D") : filterList(s20, "04BC"));
                s20 = channel.digital.PrivateCallConf ? filterList(s20, "456CDE") : filterList(s20, "01289A");
                s20 = channel.digital.DataCallConf ? filterList(s20, "89ACDE") : filterList(s20, "012456");
                string s21 = channel.digital.PrivacyNo.ToString("X1");
                string ns2 = (s20[0] + s21) == "0F" ? "FF" : s20[0] + s21;
                _outputFile[_ch_start + (ch * _ch_len) + 2] = htob(ns2);
                #endregion

                #region Byte 3
                string s30 = channel.analog.DisplayPTTID ? "6" : "E";
                List<string> s31 = createList("01289AF");
                s31 = channel.digital.EmergencyAlarmAck ? filterList(s31, "89A") : filterList(s31, "012F");
                s31 = channel.RXRef == "Low" ? filterList(s31, "08") : (channel.RXRef == "Medium" ? filterList(s31, "19") : (channel.RXRef == "High" ? filterList(s31, "2A") : filterList(s31, "F")));
                string ns3 = (s30 + s31[0]) == "EF" ? "FF" : s30 + s31[0];
                _outputFile[_ch_start + (ch * _ch_len) + 3] = htob(ns3);
                #endregion

                #region Byte 4
                List<string> s40 = createList("0123456789ABCDEF");
                s40 = channel.Power == "Low" ? filterList(s40, "014589CD") : filterList(s40, "2367ABEF");
                s40 = channel.VOX ? filterList(s40, "13579BDF") : filterList(s40, "02468ACE");
                s40 = channel.AdmitCriteria == "Always" ? filterList(s40,"0123") : (channel.AdmitCriteria == "Channel" ? filterList(s40,"4567") : (channel.AdmitCriteria == "CTCSS/DCS" ? filterList(s40,"89AB") : filterList(s40,"CDEF")));

                List<string> s41 = createList("01245689ACDEF");
                s41 = channel.TXRef == "Low" ? filterList(s41,"048C") : (channel.TXRef == "Medium" ? filterList(s41,"159D") : (channel.TXRef == "High" ? filterList(s41,"26AE") : filterList(s41,"F")));
                s41 = channel.analog.QTReverse == 180 ? filterList(s41, "012456") : (channel.analog.QTReverse == 120 ? filterList(s41, "89ACDE") : filterList(s41, "F"));
                s41 = channel.analog.ReverseBurst ? filterList(s41, "01289A") : filterList(s41, "456CDEF");
                string ns4 = s40[0] + s41[0];
                _outputFile[_ch_start + (ch * _ch_len) + 4] = htob(ns4);
                #endregion

                #region Byte 6-7

                #endregion
            }
            /*
                        #region Channel Byte 6-7
                        int cntID = htoi(btoh(ch[7]) + btoh(ch[6]));
                        if (cntID > 0 && cntID < 65535)
                        {
                            if (cntID <= Contacts.Count)
                            {
                                dData.ContactGuid = Contacts.ToArray()[cntID - 1].GUID;
                            }
                        }
                        #endregion

                        #region Channel Byte 8
                        channel.TOT = (btoi(ch[8]) * 15);
                        #endregion

                        #region Channel Byte 9
                        channel.TOTDelay = btoi(ch[9]);
                        #endregion

                        // TODO
                        #region Channel Byte 10
                        int eSys = btoi(ch[10]);
                        if (eSys > 0)
                        {
                            //Get Emgcy System Guid

                        }
                        #endregion

                        #region Channel Byte 11
                        int sLID = btoi(ch[11]);
                        _channelScanLists.Add(sLID);
                        #endregion
                        // END TODO

                        #region Channel Byte 12
                        int gChn = btoi(ch[12]);
                        if (gChn > 0 && gChn < 65535)
                        {
                            if (gChn <= Groups.Count)
                            {
                                dData.GroupListGuid = Groups.ToArray()[gChn - 1].GUID;
                            }
                        }
                        #endregion

                        #region Channel Byte 14
                        int dcs = btoi(ch[14]);
                        RXSignalingDecode decodes = new RXSignalingDecode();
                        // Decode 8
                        if (dcs >= 128)
                        {
                            decodes.decode8 = true;
                            dcs -= 128;
                        }
                        // Decode 7
                        if (dcs >= 64)
                        {
                            decodes.decode7 = true;
                            dcs -= 64;
                        }
                        // Decode 6
                        if (dcs >= 32)
                        {
                            decodes.decode6 = true;
                            dcs -= 32;
                        }
                        // Decode 5
                        if (dcs >= 16)
                        {
                            decodes.decode5 = true;
                            dcs -= 16;
                        }
                        // Decode 4
                        if (dcs >= 8)
                        {
                            decodes.decode4 = true;
                            dcs -= 8;
                        }
                        // Decode 3
                        if (dcs >= 4)
                        {
                            decodes.decode3 = true;
                            dcs -= 4;
                        }
                        // Decode 2
                        if (dcs >= 2)
                        {
                            decodes.decode2 = true;
                            dcs -= 2;
                        }
                        // Decode 1
                        if (dcs >= 1)
                        {
                            decodes.decode1 = true;
                            dcs--;
                        }
                        aData.decodes = decodes;
                        #endregion

                        #region Channel Byte 16-19
                        string rxfrq = btoh(ch[19]) + btoh(ch[18]) + btoh(ch[17]) + btoh(ch[16]);
                        if (rxfrq != "FFFFFFFF")
                            channel.RXFreq = rxfrq.Substring(0, 3) + "." + rxfrq.Substring(3);
                        #endregion

                        #region Channel Byte 20-23
                        string txfrq = btoh(ch[23]) + btoh(ch[22]) + btoh(ch[21]) + btoh(ch[20]);
                        if (txfrq != "FFFFFFFF")
                            channel.TXFreq = txfrq.Substring(0, 3) + "." + txfrq.Substring(3);
                        #endregion

                        #region Channel Byte 24-25
                        string dcsDec = btoh(ch[25]) + btoh(ch[24]);
                        if (dcsDec != "FFFF")
                        {
                            if (cCheck(dcsDec.Substring(0, 1), "8C"))
                            {
                                aData.CTCSSDecode = "D" + dcsDec.Substring(1, 3) + (dcsDec.Substring(0, 1) == "8" ? "N" : "I");
                            }
                            else
                            {
                                aData.CTCSSDecode = dcsDec.Substring(0, 3) + "." + dcsDec.Substring(3, 1);
                            }
                        }
                        #endregion

                        #region Channel Byte 26-27
                        string dcsEnc = btoh(ch[27]) + btoh(ch[26]);
                        if (dcsEnc != "FFFF")
                        {
                            if (cCheck(dcsEnc.Substring(0, 1), "8C"))
                            {
                                aData.CTCSSEncode = "D" + dcsEnc.Substring(1, 3) + (dcsEnc.Substring(0, 1) == "8" ? "N" : "I");
                            }
                            else
                            {
                                aData.CTCSSEncode = dcsEnc.Substring(0, 3) + "." + dcsEnc.Substring(3, 1);
                            }
                        }
                        #endregion

                        #region Channel Byte 28-29
                        int rxsig = btoi(ch[28]);
                        if (rxsig > 0)
                        {
                            aData.RXSignaling = "DTMF" + rxsig.ToString();
                        }
                        else
                        {
                            aData.RXSignaling = "Off";
                        }

                        int txsig = btoi(ch[29]);
                        if (txsig > 0)
                        {
                            aData.TXSignaling = "DTMF" + txsig.ToString();
                        }
                        else
                        {
                            aData.TXSignaling = "Off";
                        }
                        #endregion

                        #region Channel Bytes 32-63
                        channel.ChannelName = (!string.IsNullOrEmpty(batoa(ch.Slice(32, 32))) ? batoa(ch.Slice(32, 32)) : "BLANK");
                        #endregion

                        channel.digital = dData;
                        channel.analog = aData;

                        Channels.Add(channel);*/
        }
        #endregion
        #region Groups
        public static List<GroupList> Groups;
        private static void initRXGroups()
        {
            Groups = new List<GroupList>();
            try
            {
                byte[] groups = _inputFile.Slice(_rx_start, (_rx_end - _rx_start) + 1);

                List<byte[]> rx_list = new List<byte[]>();

                for (int i = 0; i < groups.Length; i += _rx_len)
                    rx_list.Add(groups.Slice(i, _rx_len));

                foreach (byte[] gp in rx_list)
                {
                    GroupList group = new GroupList();

                    group.GUID = Guid.NewGuid();

                    group.GroupListName = batoa(gp.Slice(0, 32));
                    
                    group.ContactMembers = new List<Guid>();

                    for (int i = 32; i < gp.Length; i += 2)
                    {
                        int indx = htoi(btoh(gp[i + 1]) + btoh(gp[i]));
                        if (indx > 0)
                        {
                            group.ContactMembers.Add((Contacts.ToArray())[indx - 1].GUID);
                        }
                    }

                    Groups.Add(group);
                }
            }
            catch (Exception ex)
            {

            }
        }
        private static void saveRXGroups()
        {

        }
        #endregion
        #region Zones
        public static List<ZoneList> Zones;
        private static void initZones()
        {
            Zones = new List<ZoneList>();

            try
            {
                byte[] zones = _inputFile.Slice(_zn_start, (_zn_end - _zn_start) + 1);

                List<byte[]> zn_list = new List<byte[]>();

                for (int i = 0; i < zones.Length; i += _zn_len)
                    zn_list.Add(zones.Slice(i, _zn_len));

                foreach (byte[] zn in zn_list)
                {
                    ZoneList zone = new ZoneList();

                    zone.GUID = Guid.NewGuid();

                    zone.ZoneName = batoa(zn.Slice(0, 32));

                    zone.ChannelMembers = new List<Guid>();

                    // Need to add Channels first
                    for (int i = 32; i < zn.Length; i += 2)
                    {
                        int indx = htoi(btoh(zn[i + 1]) + btoh(zn[i]));
                        if (indx > 0)
                        {
                            Guid newGuid = (Channels.ToArray())[indx - 1].GUID;
                            zone.ChannelMembers.Add((Channels.ToArray())[indx - 1].GUID);
                        }
                    }

                    Zones.Add(zone);
                }
            }
            catch (Exception ex)
            {

            }
        }
        private static void saveZones()
        {

        }
        #endregion
        #region ScanLists
        public static List<ScanList> ScanLists;
        private static void initScanLists()
        {
            ScanLists = new List<ScanList>();
            try
            {
                byte[] scanlists = _inputFile.Slice(_sc_start, (_sc_end - _sc_start));

                List<byte[]> sc_list = new List<byte[]>();

                for (int i = 0; i < scanlists.Length; i += _sc_len)
                    sc_list.Add(scanlists.Slice(i, _sc_len));

                foreach (byte[] sc in sc_list)
                {
                    byte[] f = new byte[16];

                    for (int i = 0; i < 16; i++)
                        f[i] = byte.Parse("FF", NumberStyles.HexNumber);

                    ScanList slist = new ScanList();
                    
                    slist.GUID = Guid.NewGuid();

                    slist.ScanListName = batoa(sc.Slice(0, 32));
                    
                    // slist.PriorityChannelA
                    int iPChanA = htoi(batoh(sc.Slice(32, 2).Reverse().ToArray()));
                    if (iPChanA == 0) 
                        slist.PriorityChannelA = Guid.Empty;
                    else if (iPChanA == 65535)
                        slist.PriorityChannelA = new Guid(f);
                    else
                        slist.PriorityChannelA = (Channels.ToArray())[iPChanA-1].GUID;
                    
                    // slist.PriorityChannelB
                    int iPChanB = htoi(batoh(sc.Slice(34, 2).Reverse().ToArray()));
                    if (iPChanB == 0)
                        slist.PriorityChannelB = Guid.Empty;
                    else if (iPChanB == 65535)
                        slist.PriorityChannelB = new Guid(f);
                    else
                        slist.PriorityChannelB = (Channels.ToArray())[iPChanB-1].GUID;
                    
                    // slist.TxDesignatedChannel
                    int desChan = htoi(batoh(sc.Slice(36, 2).Reverse().ToArray()));
                    if (desChan == 0)
                        slist.TxDesignatedChannel = Guid.Empty;
                    else if (desChan == 65535)
                        slist.TxDesignatedChannel = new Guid(f);
                    else
                        slist.TxDesignatedChannel = (Channels.ToArray())[desChan - 1].GUID;

                    // slist.PrioritySampleTime
                    slist.PrioritySampleTime = (btoi(sc[40]) * 250);

                    // slist.SignalingHoldTime
                    slist.SignalingHoldTime = (btoi(sc[39]) * 25);
                                                            
                    slist.ChannelMembers = new List<Guid>();

                    // Need to add Channels first
                    for (int i = 42; i < sc.Length; i += 2)
                    {
                        int indx = htoi((btoh(sc[i + 1]) + btoh(sc[i])));
                        if (indx > 0)
                        {
                            slist.ChannelMembers.Add((Channels.ToArray())[indx - 1].GUID);
                        }
                    }

                    ScanLists.Add(slist);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private static void saveScanLists()
        {

        }
        #endregion
        #region Main Functions
        public static void initData(Stream inputStream)
        {
            _inputFile = ReadFully(inputStream);
            _outputFile = new byte[_inputFile.Length];
            Array.Copy(_inputFile, _outputFile, _inputFile.Length);
            
            initBasicInfo();
            initGeneralSettings();
            initMenuItems();
            initContacts();
            initRXGroups();
            // initEmergencySystems();
            initChannels();
            initScanLists();
            updateChannelScanLists();
            initZones();
        }
        public static void saveData(FileStream fs, int type)
        {
            // Save Custom Class Changes Back to _inputFile
            updateInputFile();
            Write(fs, _inputFile);
            /*switch (type)
            {
                case 1:
                    // MD380

                    break;
                case 2:
                    // CS700
                    break;
            }*/
        }
        public static bool checkData()
        {
            updateInputFile();
            return _inputFile.Length == _outputFile.Length && memcmp(_inputFile, _outputFile, _inputFile.Length) == 0;
        }
        private static void updateInputFile()
        {
            saveBasicInfo();
            saveGeneralSettings();
            saveMenuItems();
            saveContacts();
            saveRXGroups();
            // initEmergencySystems();
            saveChannels();
            saveScanLists();
            saveZones();
        }
        #endregion
        #region Misc Functions
        private static byte[] ReadFully(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }
        private static List<string> createList(string start)
        {
            List<string> str = new List<string>();
            for (int i = 0; i < start.Length; i++)
            {
                str.Add(start.Substring(i, 1));
            }
            return str;
        }
        private static List<string> filterList(List<string> list, string filter)
        {
            List<string> newList = new List<string>(list);
            foreach (string str in list)
            {
                bool remove = true;
                for (int l = 0; l < filter.Length; l++)
                {
                    if (str == filter.Substring(l, 1))
                    {
                        remove = false;
                    }
                }
                if (remove)
                {
                    newList.Remove(str);
                }
            }

            return newList;
        }
        private static bool copySliceToOutput(int start, int length, byte[] data)
        {
            if (data.Length == length)
            {
                int cntr = 0;
                for (int i = start; i < (start + length); i++)
                {
                    _outputFile[i] = data[cntr];
                    cntr++;
                }
                return true;
            }
            return false;
        }
        private static bool cCheck(string in_str, string chars)
        {
            return in_str.IndexOfAny(chars.ToCharArray()) != -1 ? true : false;
        }
        private static void Write(Stream s, Byte[] bytes)
        {
            using (var writer = new BinaryWriter(s))
            {
                writer.Write(bytes);
            }
        }
        
        #endregion
        #region Conversion Functions
        private static string reverseString(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
        private static int htoi(string hex) 
        {
            return int.Parse(hex, NumberStyles.HexNumber);
        }
        private static int btoi(byte bt)
        {
            return Convert.ToInt32(bt);
        }
        private static string itoh(int inInt)
        {
            return inInt.ToString("X2");
        }
        private static string btoh(byte bt)
        {
            return bt.ToString("X2");
        }
        private static string batoh(byte[] btArr)
        {
            return BitConverter.ToString(btArr).Replace("-", "");
        }
        private static byte itob(int inInt)
        {
            return Convert.ToByte(inInt);
        }
        private static byte htob(string hex)
        {
            return byte.Parse(hex, NumberStyles.HexNumber);
        }
        private static byte[] htoba(string hex)
        {
            List<byte> bList = new List<byte>();
            if ((hex.Length % 2) == 0)
            {
                for (int i = 0; i < hex.Length; i += 2)
                {
                    bList.Add(htob(hex.Substring(i, 2)));
                }
            }
            return bList.ToArray();
        }
        private static byte[] atoba(string input)
        {
            return Encoding.ASCII.GetBytes(input);
        }
        private static byte[] atoba(string input, byte pad, int ascLen, bool skipBytes)
        {
            List<byte> ascArr = Encoding.ASCII.GetBytes(input).ToList();
            while (ascArr.Count < ascLen)
                ascArr.Add(pad);

            List<byte> retArr = new List<byte>();

            if (skipBytes)
            {
                for (int i = 0; i < ascLen; i++)
                {
                    retArr.Add(ascArr[i]);
                    retArr.Add(pad);
                }
            }
            else
            {
                retArr = new List<byte>(ascArr);
            }

            return retArr.ToArray();
        }
        private static string batoa(byte[] in_arr)
        {
            string retStr = "";

            for (int i = 0; i < in_arr.Length; i++)
            {
                if (in_arr[i].ToString("X2") != "FF")
                {
                    retStr = retStr + Convert.ToChar(in_arr[i]).ToString().Replace("\0", string.Empty);
                }
            }

            return retStr.Trim();
        }
        private static byte[] itoba(string ints)
        {
            List<byte> bRet = new List<byte>();
            for (int i = 0; i < ints.Length; i++)
            {
                bRet.Add(Convert.ToByte(ints.Substring(i, 1)));
            }
            return bRet.ToArray();
        }
        #endregion
    }

    public static class Extensions
    {
        public static T[] Slice<T>(this T[] source, int index, int length)
        {
            T[] slice = new T[length];
            Array.Copy(source, index, slice, 0, length);
            return slice;
        }
    }
}
