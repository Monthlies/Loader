using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Loader
{
    class Misc
    {
        public static void Logouwu()
        {
            Console.WriteLine(" ██████╗██╗  ██╗███████╗ █████╗ ████████╗");
            Console.WriteLine("██╔════╝██║  ██║██╔════╝██╔══██╗╚══██╔══╝");   // Change this to your own 
            Console.WriteLine("██║     ███████║█████╗  ███████║   ██║   ");
            Console.WriteLine("██║     ██╔══██║██╔══╝  ██╔══██║   ██║   ");
            Console.WriteLine("╚██████╗██║  ██║███████╗██║  ██║   ██║   ");
            Console.WriteLine(" ╚═════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝  ");
            Console.WriteLine("Cheat FN, Last Update: 4th August");
            Console.WriteLine();
        }
        public static void Logoowo()
        {
            Console.WriteLine(" ██████╗██╗  ██╗███████╗ █████╗ ████████╗");
            Console.WriteLine("██╔════╝██║  ██║██╔════╝██╔══██╗╚══██╔══╝");   // Change this to your own 
            Console.WriteLine("██║     ███████║█████╗  ███████║   ██║   ");
            Console.WriteLine("██║     ██╔══██║██╔══╝  ██╔══██║   ██║   ");
            Console.WriteLine("╚██████╗██║  ██║███████╗██║  ██║   ██║   ");
            Console.WriteLine(" ╚═════╝╚═╝  ╚═╝╚══════╝╚═╝  ╚═╝   ╚═╝  ");
            Console.WriteLine();
        }
        public static void RandomTitle()    // Changes the app title to something random, you can edit the size of the name down below
        {
            {
                int size = 15;
                char[] chars = new char[62];
                string a = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
                chars = a.ToCharArray();

                RNGCryptoServiceProvider crypto = new RNGCryptoServiceProvider();

                byte[] data = new byte[size];
                crypto.GetNonZeroBytes(data);

                StringBuilder result = new StringBuilder(size);

                foreach (byte b in data)
                    result.Append(chars[b % (chars.Length - 1)]);
                Console.Title = "" + result;

            }
        }



    }
}


