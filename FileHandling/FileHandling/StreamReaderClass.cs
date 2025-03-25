using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class StreamReaderClass
    {
        public static void PerformStreamReader()
        {
            string path = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\C# Programs\FileHandling\FileHandling\MyFile.txt";
            using(FileStream fs=new FileStream(path,FileMode.Open, FileAccess.Read))
            {
                using(StreamReader reader=new StreamReader(fs, Encoding.UTF8))
                {
                    string data = reader.ReadToEnd();
                    Console.WriteLine(data);
                }
            }
        }
    }
}
