using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Division
    {
        public static void PerformDivision()
        {
            int a = 5;
            int b = 0;
            int c = a / b;
            Console.WriteLine("Division is " + c);
        }
    }
}