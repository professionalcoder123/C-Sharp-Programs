using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Calculator
    {
        public void Add(int a,int b)
        {
            Console.WriteLine("Addition of two is " + (a + b));
        }

        public void Add(double a,double b,double c)
        {
            Console.WriteLine("Addition of three is " + (a + b + c));
        }
    }
}
