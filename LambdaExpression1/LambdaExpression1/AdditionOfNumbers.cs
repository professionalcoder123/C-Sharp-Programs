using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression1
{
    public delegate int AddTwoNumbers(int a, int b);
    internal class AdditionOfNumbers
    {
        public static int PerformAddition()
        {
            AddTwoNumbers add = (num1, num2) => num1 + num2;
            return add(10, 40);
        }
    }
}