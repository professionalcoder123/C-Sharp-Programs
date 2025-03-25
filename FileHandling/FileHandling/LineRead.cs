using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class LineRead
    {
        public static void ReadLineFromFile()
        {
            string path = @"C:\Users\Aditya Turwatkar\Documents\data.txt";
            string line=File.ReadAllText(path);
            Console.WriteLine(line);
        }
    }
}
