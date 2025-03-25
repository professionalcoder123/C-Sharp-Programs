using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Shape
    {
        public void GetArea()
        {
            Console.WriteLine("Shape area");
        }
    }

    internal class Circle : Shape
    {
        public void GetArea()
        {
            Console.WriteLine("Circle area=pi*r^2");
        }
    }

    internal class Square : Shape
    {
        public void GetArea()
        {
            Console.WriteLine("Square area=side*side");
        }
    }
}
