using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionOfSquares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number");
            var num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number");
            var num2=Convert.ToInt32(Console.ReadLine());
            var squaredNum1=Math.Pow(num1, 2);
            var squaredNum2=Math.Pow(num2, 2);
            var sum=squaredNum1 + squaredNum2;
            var diff=squaredNum1 - squaredNum2;
            Console.WriteLine("Sum and difference of two numbers is "+sum+" and "+diff);
        }
    }
}
