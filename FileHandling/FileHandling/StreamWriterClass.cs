using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class StreamWriterClass
    {
        public static void PerformStreamWriter()
        {
            string path = @"C:\Users\Aditya Turwatkar\Desktop\Aditya\C# Programs\FileHandling\FileHandling\MyFile.txt";
            using(FileStream fs=new FileStream(path, FileMode.Append, FileAccess.Write))
            {
                using (StreamWriter writer = new StreamWriter(fs, Encoding.UTF8))
                {
                    //int a = 10;
                    //int b = 20;
                    //int sum = a + b;
                    //writer.WriteLine("Sum of two numbers is " + sum);

                    //writer.WriteLine();
                    //writer.WriteLine();

                    //int num = 7;
                    //int temp = 0;
                    //for (int i = 2; i <= num - 1; i++)
                    //{
                    //    if (num % i == 0)
                    //    {
                    //        temp++;
                    //    }
                    //}
                    //if (temp > 0)
                    //{
                    //    writer.WriteLine(num + " is not a prime number");
                    //}
                    //else
                    //{
                    //    writer.WriteLine(num + " is a prime number");
                    //}

                    //writer.WriteLine();
                    //writer.WriteLine();

                    //Console.WriteLine("Enter a string");
                    //string str = Console.ReadLine();
                    //string rev = "";
                    //for(int i=str.Length-1; i>=0; i--)
                    //{
                    //    rev += str[i];
                    //}
                    //writer.WriteLine("Reverse of a string is " + rev);
                }
            }
        }
    }
}
