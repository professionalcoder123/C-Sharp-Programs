using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Animals sounds with their own sound");
        }
    }

    internal class Dog : Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Dog sounds bow-bow");
        }
    }

    internal class Cat : Animal
    {
        public void MakeSound()
        {
            Console.WriteLine("Cat sounds meow-meow");
        }
    }
}
