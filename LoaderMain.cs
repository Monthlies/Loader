using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loader
{
    class LoaderMain
    {
        public static void Cheatuwu()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Misc.Logoowo();
            Console.WriteLine("[1] Inject");
            string option = Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine("[*] Mapping the drivers...");
                CheatDrv.MapDriver();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Drivers mapped!");
                Console.WriteLine("[*] Press any key once in the Fortnite lobby!");
                Console.ReadKey();
                //  Misc.CheckFortnite();
                CheatDLL.CheatInject();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("[+] Cheat Injected! Press any key to close the Loader.");
                Console.ReadKey();
                Process.GetCurrentProcess().Kill();

            }
        }
    }
}

