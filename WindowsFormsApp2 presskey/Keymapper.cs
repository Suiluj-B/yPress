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
    public class Keymapper
    {

        [DllImport("user32.dll",
        CallingConvention = CallingConvention.StdCall,
        CharSet = CharSet.Unicode,
        EntryPoint = "MapVirtualKey",
        SetLastError = true,
        ThrowOnUnmappableChar = false)]
        private static extern uint MapVirtualKey(uint uCode, uint uMapType);

        public static void RemapToHex(uint uCode)
        {
            var a = MapVirtualKey(uCode, 0);
            Console.Write(a);
            return;
        }














    }
}
