using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;

namespace Cleaner
{
    class TempFiles
    {
        public static void Clear()
        {
            try
            {
                string tempPath = Path.GetTempPath();
                DirectoryInfo directoryInfo = new DirectoryInfo(tempPath);
                FileInfo[] files = directoryInfo.GetFiles();

                foreach (FileInfo file in files)
                {
                    file.Delete();
                }
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
