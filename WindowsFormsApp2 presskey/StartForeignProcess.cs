using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics;
using System.ComponentModel;
namespace WindowsFormsApp2_presskey
{
    internal class StartForeignProcess
    {

        internal class MyProcess
        {
           
            public static void OpenApplication(string myFavoritesPath)
            {

                Process.Start(myFavoritesPath);
            }


















            // Opens urls and .html documents using Internet Explorer.
            void OpenWithArguments()
            {
                // url's are not considered documents. They can only be opened
                // by passing them as arguments.
                Process.Start("IExplore.exe", "www.northwindtraders.com");

                // Start a Web page using a browser associated with .html and .asp files.
                Process.Start("IExplore.exe", "C:\\myPath\\myFile.htm");
                Process.Start("IExplore.exe", "C:\\myPath\\myFile.asp");
            }

            // Uses the ProcessStartInfo class to start new processes,
            // both in a minimized mode.
            void OpenWithStartInfo()
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("IExplore.exe");
                startInfo.WindowStyle = ProcessWindowStyle.Minimized;

                Process.Start(startInfo);

                startInfo.Arguments = "www.northwindtraders.com";

                Process.Start(startInfo);
            }

            
        }
    }
}
