using System;
using System.Runtime.InteropServices;

namespace WindowsFormsApp2_presskey
{
    public class ThreadWork
    {
        [DllImport("user32.dll")]
        public static extern bool AttachThreadInput(int myThread, int TargetThread, bool coupler);

        [DllImport("Kernel32", EntryPoint = "GetCurrentThreadId", ExactSpelling = true)]
        public static extern Int32 GetCurrentWin32ThreadId();

        public int OwnPID { get; set; }

        public static int getOwnPID()
        {
            var myPID = GetCurrentWin32ThreadId();
            return myPID;
        }









        public bool Dabda { get; set; }
        public static bool AttachThreadInputt(int flyffThread, int ownThread, bool dada)
        {

            if (dada == false)
            {
                dada = true;
            }
            else
            {
                dada = false;
            }
            AttachThreadInput(ownThread, flyffThread, dada);
            return dada;

        }
    }
}
