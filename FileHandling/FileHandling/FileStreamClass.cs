using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class FileStreamClass
    {
        public static void PerformFileStream()
        {
            string path = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\C# Programs\" + 
                @"FileHandling\FileHandling\Aditya.txt";
            using(FileStream fs=new FileStream(path, FileMode.Open))
            {
                //Console.WriteLine("File created successfully!");
                //Console.WriteLine("File truncated successfully!");
            }
            File.Delete(path);
            Console.WriteLine("File deleted successfully!");
        }
    }
}