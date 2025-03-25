using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class CommonElements
    {
        public static void FindCommonElements()
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 2, 4, 6, 8, 10 };
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0;j< arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.Write(arr1[i] + " ");
                    }
                }
            }
        }
    }
}
