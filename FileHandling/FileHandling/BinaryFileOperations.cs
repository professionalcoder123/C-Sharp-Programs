using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    internal class BinaryFileOperations
    {
        public static void PerformOperations()
        {
            BinaryReader br;
            BinaryWriter bw;
            int i = 10;
            double d = 20.59;
            bool b = true;
            string s = "My name is Aditya";
            try
            {
                bw = new BinaryWriter(new FileStream(@"C:\Users\Aditya Turwatkar\Documents\filedata", FileMode.Create));
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + " Cannot create a file!");
                return;
            }

            try
            {
                bw.Write(i);
                bw.Write(d);
                bw.Write(b);
                bw.Write(s);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + " Cannot write into file!");
            }
            bw.Close();
            
            try
            {
                br = new BinaryReader(new FileStream(@"C:\Users\Aditya Turwatkar\Documents\filedata", FileMode.Open));
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message+" Cannot open the file!");
                return;
            }
            
            try
            {
                i = br.ReadInt32();
                d = br.ReadDouble();
                b = br.ReadBoolean();
                s = br.ReadString();
                Console.WriteLine("Integer value : " + i + "\n" +
                    "Double value : " + d + "\n" +
                    "Boolean value : " + b + "\n" +
                    "String value : " + s);
            }
            catch(IOException e)
            {
                Console.WriteLine(e.Message + " Cannot read into file!");
                return;
            }
            br.Close();
        }
    }
}