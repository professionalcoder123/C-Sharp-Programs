using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class MissingNumber
    {
        public static void FindMissingElement()
        {
            int[] arr = { 1, 2, 3, 4, 6 };
            int expected_no_elements = arr.Length + 1;
            int maxSum = expected_no_elements * (expected_no_elements + 1) / 2;
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Missing element is " + (maxSum - sum));
        }
    }
}
