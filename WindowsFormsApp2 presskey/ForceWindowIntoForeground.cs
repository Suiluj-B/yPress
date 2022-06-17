using System;
using System.Runtime.InteropServices;

namespace WindowsFormsApp2_presskey
{
    internal class ForceWindowIntoForeground
    {
        [DllImport("user32.dll")]
        private static extern uint GetCurrentThreadId();

        public static void ForceWindowIntoForegroundd(IntPtr window)
        {





            //uint currentThread = GetCurrentThreadId();

            //IntPtr activeWindow = Win32.GetForegroundWindow();
            //uint activeProcess;
            //uint activeThread = Win32.GetWindowThreadProcessId(activeWindow, out activeProcess);

            //uint windowProcess;
            //uint windowThread = Win32.GetWindowThreadProcessId(window, out windowProcess);

            //if (currentThread != activeThread)
            //    Win32.AttachThreadInput(currentThread, activeThread, true);
            //if (windowThread != currentThread)
            //    Win32.AttachThreadInput(windowThread, currentThread, true);

            //uint oldTimeout = 0, newTimeout = 0;
            //Win32.SystemParametersInfo(Win32.SPI_GETFOREGROUNDLOCKTIMEOUT, 0, ref oldTimeout, 0);
            //Win32.SystemParametersInfo(Win32.SPI_SETFOREGROUNDLOCKTIMEOUT, 0, ref newTimeout, 0);
            //Win32.LockSetForegroundWindow(LSFW_UNLOCK);
            //Win32.AllowSetForegroundWindow(Win32.ASFW_ANY);

            //Win32.SetForegroundWindow(window);
            //Win32.ShowWindow(window, Win32.SW_RESTORE);

            //Win32.SystemParametersInfo(Win32.SPI_SETFOREGROUNDLOCKTIMEOUT, 0, ref oldTimeout, 0);

            //if (currentThread != activeThread)
            //    Win32.AttachThreadInput(currentThread, activeThread, false);
            //if (windowThread != currentThread)
            //    Win32.AttachThreadInput(windowThread, currentThread, false);
        }
    }
}
