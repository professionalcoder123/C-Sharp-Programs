using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class FileExistence
    {
        public static void CheckPresenceOfFile()
        {
            string path = @"C:\Users\Aditya Turwatkar\Documents\data.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File exists!");
            }
            else
            {
                Console.WriteLine("File does not exist!");
            }
        }
    }
}