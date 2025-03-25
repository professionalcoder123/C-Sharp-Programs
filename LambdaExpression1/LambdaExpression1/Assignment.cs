using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression1
{
    public delegate void PerformAssignment(int a);
    internal class Assignment
    {
        public static void PerformOperation()
        {
            PerformAssignment a = (num) =>
            {
                num += 10;
                Console.WriteLine(num);
            };
            a(10);
        }

    }
}
