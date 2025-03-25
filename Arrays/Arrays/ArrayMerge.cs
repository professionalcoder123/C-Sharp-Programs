using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class ArrayMerge
    {
        public static void MergeTwoArrays()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            int[] b = { 6, 7, 8, 9, 10 };
            int[] c = new int[a.Length + b.Length];
            for (int i = 0; i < a.Length; i++)
            {
                c[i] = a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[a.Length + i] = b[i];
            }
            foreach (int i in c)
            {
                Console.Write(i + " ");
            }
        }
    }
}
