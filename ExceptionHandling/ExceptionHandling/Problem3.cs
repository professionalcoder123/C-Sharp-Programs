using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Problem3
    {
        public static void HandleIndexOutOfRangeException()
        {
            int[] arr = new int[5];
            for(int i = 0; i <= arr.Length; i++)
            {
                Console.Write("Enter element " + (i + 1)+" : ");
                arr[i]=int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Elements in array :");
            foreach(int i in arr)
            {
                Console.Write(i + " ");
            }
        }
    }
}
