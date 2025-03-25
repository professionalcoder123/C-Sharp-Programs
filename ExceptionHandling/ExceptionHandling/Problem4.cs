using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Problem4
    {
        public static void HandleNullReferenceException()
        {
            string str = null;
            Console.WriteLine(str.Length);
        }
    }
}
