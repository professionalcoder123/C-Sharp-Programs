using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression1
{
    public delegate string CheckEvenOrOdd(int num);
    internal class EvenOrOdd
    {
        public static void CheckNumberEvenOrOdd()
        {
            CheckEvenOrOdd c = (num) =>
            {
                if (num % 2 == 0)
                {
                    return "Even number";
                }
                return "Odd number";
            };
            Console.WriteLine(c(10));
        }
    }
}
