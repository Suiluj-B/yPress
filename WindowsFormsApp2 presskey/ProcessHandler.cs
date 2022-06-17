using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Automation;

namespace WindowsFormsApp2_presskey
{
    public class ProcessHandler
    {
        [DllImport("User32.dll")]
        public static extern int SetForegroundWindow(int hWnd);
        

        //[DllImport("User32.dll")]
        //private static extern Int32 SetFocus(IntPtr hWnd);

        [DllImport("UIAutomationClient.dll")]
        public static extern void SetFocus();
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        private static extern IntPtr GetForegroundWindow();


        public static string getActiveWindowName()
        {
            try
            {
                var activatedHandle = GetForegroundWindow();

                Process[] processes = Process.GetProcesses();
                foreach (Process clsProcess in processes)
                {

                    if (activatedHandle == clsProcess.MainWindowHandle)
                    {
                        string processName = clsProcess.ProcessName;

                        return processName;
                    }
                }
            }
            catch { }
            return null;
        }





        public static IntPtr hWndSniffer(Process fedProcess)
        {

            if (fedProcess != null)
            {
                IntPtr returnedHWND = fedProcess.Handle;
                return returnedHWND;
            }

            return IntPtr.Zero;
        }

        public static void MakeitForegroundWindow(int fedHWND)
        {
            SetForegroundWindow(fedHWND);
            return;
        }

        //public static void FocusTheWindow(IntPtr fedHWND)
        //{
        //    SetFocus(fedHWND);
        //    return;
        //}

        public static void Focuss(Process process)
        {
            try
            {
                AutomationElement element = AutomationElement.FromHandle(process.MainWindowHandle);
                if (element != null)
                {
                    element.SetFocus();
                }
            }
            catch
            {
                return;
            }
            
        }

        

    }
}
