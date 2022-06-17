using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using static WindowsFormsApp2_presskey.Inputt;
using static WindowsFormsApp2_presskey.ProcessHandler;
using System.Threading;
using System.Runtime;
using System.Collections.Generic;
using System.Windows.Input;


namespace WindowsFormsApp2_presskey
{


    public partial class Form1 : Form
    {

        KeyboardListener KListener = new KeyboardListener();

        public Form1()
        {


            //KeyboardListener KListener = new KeyboardListener();

            KListener.KeyDown += new RawKeyEventHandler(HotkeyProxy);

            //TO LOOK AT KEYS
            KListener.KeyDown += new RawKeyEventHandler(KListener_KeyDown);
            InitializeComponent();
        }
        //TO LOOK AT KEYS
        private void KListener_KeyDown(object sender, RawKeyEventArgs e)
        {
            Console.WriteLine($"{e.VKCode}, {e.IsSysKey}, {e.Character}, {e.Key}");


        }

        #region HOTKEY FUNCTIONALITY

        //GET THE VKCode and convert to Keys. -> Feed to ProcessCmdKey as Hotkey
        private void HotkeyProxy(object sender, RawKeyEventArgs e)
        {

            Message a = new Message();
            var z = e.Key;
            if (RUNNING == true)
            {
                ProcessCmdKey(ref a, (Keys)e.VKCode);
            }



        }





        //private const uint MAPVK_VK_TO_VSC = 0;
        protected override bool ProcessCmdKey(ref Message message, Keys keys) //HOTKEY TO CALL FUNCTION

        {
            //MAYBE LATER TO CONVERT KEYS FOR ClickKey ??????
            //var scanCodeForF5 = MapVirtualKey((uint)KeyInterop.VirtualKeyFromKey(Key.B), MAPVK_VK_TO_VSC);
            //Console.WriteLine(scanCodeForF5);
            if (keys == HAWTKEY)
            {

                SendToSecondClient();
                //IS SENT TO PREVENT ProcessCmdKey from consuming. True to consume. False to let through.
                return false;
            }

            return false;
        }
        #endregion


        #region VARIABLES



        public static int Randomint(int min, int max)
        {
            return new Random().Next(min, max);
        }

        public static int Humaninput
        {
            get
            {
                double random51100 = new Random().Next(51, 100);
                int a = ((int)Math.Round(Randomint(20, 30) * (random51100 / 100)));
                return a;
            }

        }

        public static Keys KeyToPressDOWN { get; set; }
        public static Keys KeyToPressUP { get; set; }

        public static int FlyffThreadId { get; set; }

        public static int TargetThreadId { get; set; }

        public int FlyffPID
        {
            get
            {
                if (textBoxFlyffPID.Text != "")
                {
                    return int.Parse(textBoxFlyffPID.Text);
                }

                return 0;
            }
            set => textBoxFlyffPID.Text = value.ToString();

        }

        public int Flyff2PID
        {
            get
            {
                if (textBoxFlyff2PID.Text != "")
                {
                    return int.Parse(textBoxFlyff2PID.Text);
                }




                return 0;
            }

            set => textBoxFlyff2PID.Text = value.ToString();

        }

        public Process FlyffPROCESS
        {
            get
            {
                try
                {
                    Process currentProcess = Process.GetProcessById(FlyffPID);
                    return currentProcess;
                }
                catch
                {
                    MessageBox.Show("Error in FlyffPROCESS");

                    return null;
                }



            }
            set
            {
            }
        }

        public Process Flyff2PROCESS
        {
            get
            {
                try
                {
                    Process currentProcess = Process.GetProcessById(Flyff2PID);
                    return currentProcess;
                }
                catch
                {
                    MessageBox.Show("Error in Flyff2PROCESS");
                    return null;
                }

            }
            set
            {
            }
        }

        public IntPtr FlyffMainWindowHandle
        {
            get
            {

                try
                {
                    return FlyffPROCESS.MainWindowHandle;

                }
                catch
                {
                    MessageBox.Show("Error in FlyffMainWindowHandle");
                    return IntPtr.Zero;
                }

            }
        }

        public IntPtr Flyff2MainWindowHandle
        {
            get
            {
                try
                {
                    return Flyff2PROCESS.MainWindowHandle;
                }
                catch
                {
                    MessageBox.Show("Error in Flyff2MainWindowHandle");
                    return IntPtr.Zero;
                }
            }
        }

        public string FocusedMainWindowTitle
        {
            get
            {
                return ProcessHandler.getActiveWindowName();
            }
        }

        public IntPtr FocusedMainWindowHandle
        {
            get
            {
                try
                {
                    return Process.GetCurrentProcess()
                    .MainWindowHandle;
                }
                catch
                {
                    return IntPtr.Zero;
                }
            }
        }

        public int OwnPID
        {
            get
            {
                if (textBoxOwnId.Text != "")
                {
                    return int.Parse(textBoxOwnId.Text);
                }
                return 0;
            }
            set
            {

            }
        }

        public Process OwnPROCESS
        {
            get
            {
                if (OwnPID != 0)
                {
                    return Process.GetProcessById(OwnPID);
                }
                return null;
            }
            set
            {
            }
        }

        public static string SunkistLocation { get; set; }

        public static bool RUNNING { get; set; }

        public Keys HAWTKEY { get; set; }

        #endregion


        #region IMPORTS

        [DllImport("Kernel32", EntryPoint = "GetCurrentThreadId", ExactSpelling = true)]
        public static extern Int32 GetCurrentWin32ThreadId();

        [DllImport("Kernel32", EntryPoint = "GetCurrentThreadId", ExactSpelling = true)]
        public static extern int GetCurrentProcessId();

        [DllImport("user32.dll",
        CallingConvention = CallingConvention.StdCall,
        CharSet = CharSet.Unicode,
        EntryPoint = "MapVirtualKey",
        SetLastError = true,
        ThrowOnUnmappableChar = false)]
        private static extern ushort MapVirtualKey(uint uCode, uint uMapType);


        //NEEDED TO TRANSLATE KEY TO SCANCODE


        #endregion


        #region BUTTONS

        //##############################        BUTTONS         ##############################




        private void getOwnThread_Click(object sender, EventArgs e)
        {

            textBoxOwnId.Text = ThreadWork.getOwnPID().ToString();
            textBoxOwnId.ReadOnly = true;
        }

        private void threadlink_Click(object sender, EventArgs e)
        {
            ThreadWork.AttachThreadInputt(int.Parse(textBoxFlyffPID.Text), int.Parse(textBoxOwnId.Text), true /*bool.Parse(lblOwnPidBool.Text)*/);

        }

        private void AppActivateButton_Click(object sender, EventArgs e)
        {
            SendToSecondClient();

        }

        private void ThreadbyName_Click(object sender, EventArgs e)
        {
            GetProcessByWindowName();

        }

        public void ACTIVEBUTTON_Click(object sender, EventArgs e)
        {
            if (textBoxFlyffPID.Text != "")
            {
                if (RUNNING == true)
                {
                    RUNNING = false;
                    ACTIVEBUTTON.Text = "ACTIVATE";
                    ACTIVEBUTTON.BackColor = System.Drawing.Color.DarkGreen;
                }
                else
                {
                    RUNNING = true;
                    ACTIVEBUTTON.Text = "DEACTIVATE";
                    ACTIVEBUTTON.BackColor = System.Drawing.Color.Red;
                }
            }
            else
            {
                MessageBox.Show("Enter Process IDs first.");
            }
        }

        private void ExeLocation_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                ExeLocation.Text = openFileDialog1.SafeFileName;
                SunkistLocation = openFileDialog1.FileName;
            }

        }

        private void StartFlyff_Click(object sender, EventArgs e)
        {

            StartExe();
            Thread.Sleep(2000);


        }

        private void buttonGetPIDs_Click(object sender, EventArgs e)
        {
            string[] stringresult = new string[50];
            int[] result = new int[50];
            int count = 0;
            Process[] processes = Process.GetProcesses();

            foreach (var process in processes)
            {
                if (process.MainWindowTitle
                           .IndexOf(TitleFilterBox.Text, StringComparison.InvariantCulture) > -1)
                {
                    stringresult[count] = process.MainWindowTitle;
                    stringresult[count + 10] = process.ProcessName;
                    result[count + 20] = process.Id;
                    count++;
                    //comboBox1.Items.Add(process.MainWindowTitle + Flyff2PID);
                    //comboBox1.SelectedIndex = -1;
                    try
                    {
                        Console.WriteLine(result[20].ToString());
                        textBoxFlyffPID.Text = result[20].ToString();
                        textBoxFlyff2PID.Text = result[21].ToString();

                    }
                    catch
                    {
                        return;
                    }
                    if (count == 0)
                    {
                        textBoxFlyffPID.Text = "None found. Check Title Filter?";
                    }
                }


            }
        }


        #endregion


        #region METHODS

        //##############################        METHODS         ############################## 



        



        //private void textBoxKeyToSend_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        //{

        //    //textBoxKeyToSend.Text = e.KeyCode.ToString();
        //    //MapVirtualKeys(sender, e.VKCode);
            
        //    var scanCodeForF5 = MapVirtualKey(KeyInterop.VirtualKeyFromKey(Key.), 4);
        //}


        void SendToSecondClient()
        {

            
            Focuss(Flyff2PROCESS);
            Thread.Sleep(Humaninput+100);
            Console.WriteLine(KeyToPress);
            ClickKey((ushort)KeyToPress);
            Focuss(FlyffPROCESS);


        }


        void GetProcessByWindowName()
        {
            if (NameBox.Text == "")
            {
                return;
            }
            string[] result = new string[50];
            int count = 0;
            Process[] processes = Process.GetProcesses();
            //comboBox1.Items.Clear();
            foreach (var process in processes)
            {
                if (process.MainWindowTitle
                           .IndexOf(NameBox.Text, StringComparison.InvariantCulture) > -1)
                {
                    result[count] = process.MainWindowTitle;
                    result[count + 1] = process.ProcessName;
                    count++;
                    //comboBox1.Items.Add(process.MainWindowTitle + Flyff2PID);
                    //comboBox1.SelectedIndex = -1;
                }




            }

            //var processes = Process.GetProcessesByName(NameBox.Text);
            //foreach (var process in processes)
            //{

            //    if (textBoxFlyffPID.Text == "")
            //    {
            //        textBoxFlyffPID.Text = process.Id.ToString();
            //        return;
            //    }

            //    textBoxFlyff2PID.Text = process.Id.ToString();

            //}
        }


        private void StartExe()
        {
            try
            {
                Process.Start(SunkistLocation);
            }
            catch (Exception)
            {

                MessageBox.Show("Cannot start process because a file name has not been provided.");
                return;
                throw;
            }
        }














        #endregion



        private void keyEventBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            
            HAWTKEY = (Keys)e.KeyValue;
            keyEventBox1.Text = HAWTKEY.ToString();
            AppActivateButton.Text = $"Send to Client with {HAWTKEY}";
        }

        private void textBoxKeyToSend_KeyDown_1(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            //KeyToPress = (short)e.KeyCode;
            //textBoxKeyToSend.Text = e.KeyCode.ToString();

        }


        public short KeyToPress
        {
            get;
            set;

        }


        private void textBoxKeyToSend_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            uint uCode = (uint)e.KeyCode;
            uint scanCode = MapVirtualKey(uCode, 0);
            textBoxKeyToSend.Text = scanCode.ToString();
            KeyToPress = (short)scanCode;
            //textBoxKeyToSend.Text = e.KeyData.ToString();
        }


    






        //private void textBoxKeyToSend_KeyDown_1(object sender, System.Windows.Forms.KeyEventArgs e)
        //{
        //    //KeyToPressDOWN = (Keys)e.KeyData;
        //    //Console.WriteLine($"{e.KeyData}, {e.KeyValue}") ;
        //    //textBoxKeyToSend.Text = KeyToPressDOWN.ToString();
        //    //KListener.KeyDown += new RawKeyEventHandler(Listener);
        //    //void Listener(object senderr, RawKeyEventArgs ee)
        //    //{


        //    //    InterceptKeys.LowLevelKeyboardProc lowLevelKeyboardProc = new InterceptKeys.LowLevelKeyboardProc(KListener.);
        //    //    foreach (var item in lowLevelKeyboardProc)
        //    //    {
        //    //        lowLevelKeyboardProc.GetValue(UIntPtr);
        //    //    }
        //    //}
        //    ////Key key = KeyInterop.KeyFromVirtualKey(wParam.ToInt32());
        //    ////Keymapper.RemapToHex(key);
        //}
    }
}




