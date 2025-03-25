using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class FileDelete
    {
        public static void DeleteFile()
        {
            string path = @"C:\Users\Aditya Turwatkar\Documents\data.txt";
            File.Delete(path);
        }
    }
}
