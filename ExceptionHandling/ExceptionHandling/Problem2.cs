using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Problem2
    {
        public static void HandleFormatException()
        {
            Console.WriteLine("Enter an integer");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Number is " + num);
        }
    }
}
