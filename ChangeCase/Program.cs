using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name of the place you like to visit");
            string place=Console.ReadLine();
            Console.WriteLine("Uppercase : "+place.ToUpper());
            Console.WriteLine("Lowercase : " + place.ToLower());
        }
    }
}
