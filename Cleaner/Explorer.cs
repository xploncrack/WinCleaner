using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cleaner
{
    class Explorer
    {
        public static void Restart()
        {
            try
            {
                Process[] processes = Process.GetProcessesByName("explorer");

                foreach (Process process in processes)
                {
                    process.Kill();
                }
                Process.Start("explorer.exe");
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine("*Error* " + ex);
                Console.WriteLine();
                Console.WriteLine("Exiting in 5 seconds...");
                Thread.Sleep(5000);
                Environment.Exit(0);
            }
        }
    }
}
