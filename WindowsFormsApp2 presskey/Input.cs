using System;
using System.Runtime.InteropServices;
using System.Threading;
namespace WindowsFormsApp2_presskey
{
    public class Inputt
    {
        //OWN VERSION OF SENDINPUT; CHECK WHY THIS DIDNT WORK?
        //[DllImport("user32.dll")]
        //public static extern uint SendInput(uint KorM, string KeyToPress, byte sizeofpress);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint SendInput(uint nInputs, Input[] pInputs, int cbSize);

        [DllImport("user32.dll")]
        public static extern IntPtr GetMessageExtraInfo();

        [DllImport("User32.dll")]
        public static extern int SetForegroundWindow(IntPtr hWnd);

        public static int Randomint(int min, int max)
        {
            return new Random().Next(min, max);
        }
        public static int Humaninput
        {
            get
            {
                double random51100 = new Random().Next(51, 100);
                int a = ((int)Math.Round(Randomint(100, 169) * (random51100 / 100)));
                return a;
            }

        }

        #region CONSTRUCTOR





        #endregion

        //##############################              METHODS

        #region METHODS



        public static void SendKeyboardInput(KeyboardInput[] kbInputs)

        {
            Input[] inputs = new Input[kbInputs.Length];

            for (int i = 0; i < kbInputs.Length; i++)
            {
                inputs[i] = new Input
                {
                    type = (int)InputType.Keyboard,
                    u = new InputUnion
                    {
                        ki = kbInputs[i]
                    }
                };
                
            }

            SendInput((uint)inputs.Length, inputs, Marshal.SizeOf(typeof(Input)));
        }

        public static void ClickKey(ushort scanCode)
        {
            var inputs = new KeyboardInput[]
            {
                new KeyboardInput
                {
                    wScan = scanCode,
                    dwFlags = (uint)(KeyEventF.KeyDown | KeyEventF.Scancode),
                    dwExtraInfo = GetMessageExtraInfo()
                },
                new KeyboardInput
                {
                    wScan = scanCode,
                    dwFlags = (uint)(KeyEventF.KeyUp | KeyEventF.Scancode),
                    dwExtraInfo = GetMessageExtraInfo()
                }
            };
            SendKeyboardInput(inputs);
        }






        #endregion

        #region STRUCTURES

        //##############################            STRUCTURES

        [StructLayout(LayoutKind.Sequential)]
        public struct KeyboardInput
        {
            public ushort wVk; //Virtual Key code
            public ushort wScan; //Scan code of Key we want to press (hex)
            public uint dwFlags; //bits for KEY UP/DOWN-Events (KEYBDINPUT)
            public uint time; //timestamp of input. 0 = System provides Timestamp.
            public IntPtr dwExtraInfo; // lParam provided by GetMessageExtraInfo
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct MouseInput
        {
            public int dx;
            public int dy;
            public uint mouseData;
            public uint dwFlags;
            public uint time;
            public IntPtr dwExtraInfo;
        }


        [StructLayout(LayoutKind.Sequential)]
        public struct HardwareInput
        {
            public uint uMsg;
            public ushort wParamL;
            public ushort wParamH;
        }

        /* ???? Union contains input data. 
         * InputUnion is the union parameter in the INPUT struct. It contains the input data for the mouse, keyboard, or hardware.
         */

        [StructLayout(LayoutKind.Explicit)]
        public struct InputUnion
        {
            [FieldOffset(0)] public MouseInput mi;
            [FieldOffset(0)] public KeyboardInput ki;
            [FieldOffset(0)] public HardwareInput hi;
        }


        //SendInput() uses this to store information. type = type of input event [1]Mouse [2]Keyboard [3]Hardware. 
        public struct Input
        {
            public int type;
            public InputUnion u;
        }
        #endregion

        #region FLAGS

        //##############################            FLAGS

        //Used in INPUT Structure
        [Flags]
        public enum InputType
        {
            Mouse = 0,
            Keyboard = 1,
            Hardware = 2
        }


        //Used in KEYBDINPUT Structure
        [Flags]
        public enum KeyEventF
        {
            KeyDown = 0x0000,
            ExtendedKey = 0x0001,
            KeyUp = 0x0002,
            Unicode = 0x0004,
            Scancode = 0x0008
        }

        //Used in MOUSEINPUT Structure
        [Flags]
        public enum MouseEventF
        {
            Absolute = 0x8000,
            HWheel = 0x01000,
            Move = 0x0001,
            MoveNoCoalesce = 0x2000,
            LeftDown = 0x0002,
            LeftUp = 0x0004,
            RightDown = 0x0008,
            RightUp = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp = 0x0040,
            VirtualDesk = 0x4000,
            Wheel = 0x0800,
            XDown = 0x0080,
            XUp = 0x0100
        }
        #endregion

    }
}
