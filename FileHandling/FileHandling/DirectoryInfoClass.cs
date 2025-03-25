using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class DirectoryInfoClass
    {
        public static void PerformOperations()
        {
            //string path = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\C# Programs\FileHandling\FileHandling\My Directory";
            string path = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\C# Programs\FileHandling\FileHandling\Folder\Folder 1";
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            //dirInfo.Create();
            //dirInfo.CreateSubdirectory("My Subdirectory");
            //dirInfo.MoveTo(newPath);
            //dirInfo.Delete(true);
            Console.WriteLine(dirInfo.Name);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Parent);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Attributes);
            Console.WriteLine(dirInfo.LastAccessTime);
            Console.WriteLine(dirInfo.LastAccessTimeUtc);
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.CreationTimeUtc);
            Console.WriteLine(dirInfo.Exists);
            Console.WriteLine(dirInfo.LastWriteTime);
            Console.WriteLine(dirInfo.LastWriteTimeUtc);
        }
    }
}
