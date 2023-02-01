using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cleaner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Windows 10 Cleaner - Made by HyperHax";
            Console.WriteLine("*Important* Any files on desktop that are NOT in a folder called \"keep_10\" will be deleted!");
            Console.WriteLine();
            Console.WriteLine("Have you put all wanted files in a folder called \"keep_10\"? [Y / N]");
            
            if (Console.ReadLine().ToUpper() == "Y")
            {
                if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\keep_10"))
                {
                    Console.WriteLine("*Warning* The folder \"keep_10\" was NOT found on your desktop!");
                    Console.WriteLine("Are you sure you want to continue? [Y / N]");

                    if (Console.ReadLine().ToUpper() == "Y")
                    {
                        Desktop.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Exiting in 5 seconds...");
                        Console.WriteLine();
                        Thread.Sleep(5000);
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Desktop.Clear();
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Exiting in 5 seconds...");
                Console.WriteLine();
                Thread.Sleep(5000);
                Environment.Exit(0);
            }

            TempFiles.Clear();
            Explorer.Restart();
        }
    }
}
