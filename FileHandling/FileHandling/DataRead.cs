using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class DataRead
    {
        public static void ReadDataFromFile()
        {
            string path = @"C:\Users\Aditya Turwatkar\Documents\data.txt";
            string[] data;
            data = File.ReadAllLines(path);
            for(int i = 0; i < data.Length; i++)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
