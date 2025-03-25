using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class FileCopy
    {
        public static void CopyFileDataToAnother()
        {
            string path = @"C:\Users\Aditya Turwatkar\Documents\data.txt";
            string copyPath = @"C:\Users\Aditya Turwatkar\Documents\aditya.txt";
            File.Copy(path, copyPath);
        }
    }
}
