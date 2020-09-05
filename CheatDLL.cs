using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loader
{
    class CheatDLL
    {
        public static void CheatInject()
        {
            File.WriteAllBytes("\\Windows\\Fortnite.dll", Resource1.Fortnite);   // DLL change it in Resources to your own, current one outdated 
            File.WriteAllBytes("\\Windows\\Injector.exe", Resource1.modmap);   // Injector change it in Resources

            Process inject = new Process();


            inject.StartInfo.WorkingDirectory = @"C:\Windows\"; // selected to C but you can change it so its not selected to C but all drives etc. 
            inject.StartInfo.FileName = "cmd.exe";
            inject.StartInfo.Arguments = "/c" + "Injector FortniteClient-Win64-Shipping.exe dxgi.dll Fortnite.dll";
            inject.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            inject.Start();
            inject.WaitForExit();


            if (File.Exists("\\Windows\\Fortnite.dll"))
            {
                File.Delete("\\Windows\\Fortnite.dll");
            }
            if (File.Exists("\\Windows\\Injector.exe"))
            {
                File.Delete("\\Windows\\Injector.exe");
            }
        }
    }
}
