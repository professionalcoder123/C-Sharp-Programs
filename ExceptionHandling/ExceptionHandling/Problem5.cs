using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Problem5
    {
        public static void HandleArgumentOutOfRangeException()
        {
            int age = 50;
            if (age < 0 || age > 120)
            {
                throw new ArgumentOutOfRangeException();
            }
            else
            {
                Console.WriteLine("Age is valid!");
            }
        }
    }
}