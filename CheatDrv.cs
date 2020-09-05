using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using System.Net;
namespace Loader
{
    class CheatDrv
    {
        public static void MapDriver()    // Uses kdmapper, can be changed to kdu mapper, shown down below 
        {
            File.WriteAllBytes("\\Windows\\IME\\driver.sys", Resource1.driver); // Cheat Driver
            File.WriteAllBytes("\\Windows\\IME\\kdmapper.exe", Resource1.kdmapper);
            //File.WriteAllBytes("\\Windows\\IME\\chauffeurSIL.sys", Resource1.chauffeurSIL); // I don't remember lol
            //File.WriteAllBytes("\\Windows\\IME\\udmapper.exe", Resource1.udmapper);  // kdu mapper


            //   string driverloader = "\\Windows\\IME\\driverload.bat";

            Process driver = new Process();

            driver.StartInfo.WorkingDirectory = @"C:\Windows\IME\";
            driver.StartInfo.FileName = "cmd.exe";
            driver.StartInfo.Arguments = "/c" + "kdmapper driver.sys";
            // driver.StartInfo.Arguments = "/c" + "udmapper -prv 1 -map chauffeurSIL.sys";  --- KDU can be used instead but kdmapper is the og mapper for skids so 
            driver.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            driver.Start();
            driver.WaitForExit();

            if (File.Exists("\\Windows\\IME\\driver.sys"))
            {
               File.Delete("\\Windows\\IME\\driver.sys");
            }
            if (File.Exists("\\Windows\\IME\\kdmapper.exe"))
            {
               File.Delete("\\Windows\\IME\\kdmapper.exe");
            }


        }
    }
}


