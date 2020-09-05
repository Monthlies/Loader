using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Loader;

namespace Loader
{
    class Program
    {
        static void Main(string[] args)
        {
            Misc.RandomTitle();

            OnProgramStart.Initialize("App Name here", "AID Here", "Program Secret here", "1.0"); // 1.0 stands for version of the app so change that incase of changes
            if (ApplicationSettings.Freemode)
            {

                MessageBox.Show("Freemode is active, bypassing login!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (!ApplicationSettings.Status)
            {
                //If application is disabled in your web-panel settings this action will occur
                MessageBox.Show("Application is disabled!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Error);
                Process.GetCurrentProcess().Kill(); 
            }
            Misc.Logouwu();   // logo
            Console.WriteLine("[1] Login");     // login with key only, can be changed, read auth.gg documentation
            string option = Console.ReadLine();
            if (option == "1")
            {
                Console.Clear();
                Console.WriteLine("Subscription Key:");
                string KEY = Console.ReadLine();
                if (API.AIO(KEY))
                {
                    MessageBox.Show("Successfully Logged In!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Information);
                    Console.Clear();
                    LoaderMain.Cheatuwu();  // Loads injection options etc.
                }
                else
                {
                    MessageBox.Show("Your key does not exist!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Error);
                    Process.GetCurrentProcess().Kill();
                }
            }
            Console.Read();
        }
    }
}
