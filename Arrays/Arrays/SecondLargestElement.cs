using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class SecondLargestElement
    {
        public static void FindSecondLargest()
        {
            int[] arr = { 2, 3, 1, 6, 7 };
            for(int i=0;i<arr.Length; i++)
            {
                for(int j = 0; j < arr.Length-1; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            Console.WriteLine("Second largest element in an array is " + arr[arr.Length-2]);
        }
    }
}
