using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Cleaner
{
    class Desktop
    {
        public static void Clear()
        {
            try
            {
                string dir = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                DirectoryInfo directoryInfo = new DirectoryInfo(dir);
                FileInfo[] files = directoryInfo.GetFiles();

                foreach (FileInfo file in files)
                {
                    if (!file.DirectoryName.ToLower().Contains("keep_10"))
                    {
                        file.Delete();
                    }
                }

                DirectoryInfo[] subDirectories = directoryInfo.GetDirectories();
                foreach (DirectoryInfo subDirectory in subDirectories)
                {
                    if (!subDirectory.FullName.ToLower().Contains("keep_10"))
                    {
                        subDirectory.Delete(true);
                    }
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
