using Microsoft.VisualBasic;

namespace WindowsFormsApp2_presskey
{
    internal class AppActivateCall
    {
        //[DllImport("Microsoft.VisualBasic.Core.dll")]
        //public static extern Int32 AppActivate(int hWnd);


        public static void TryIt(int fedHWND)
        {
            if (fedHWND != 0)
            {
                Interaction.AppActivate(fedHWND);
                return;
            }
            
            return;
        }


    }
}