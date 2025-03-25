using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class InvalidEmailFormatException : Exception
    {
        public InvalidEmailFormatException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }

    internal class ValidationInEmail
    {
        public static void CheckEmail()
        {
            string email = "aditya";
            if (!email.Contains("@") || !email.Contains(".com"))
            {
                throw new InvalidEmailFormatException("Email should contain '@' and '.com'. Please enter valid email!");
            }
            else
            {
                Console.WriteLine("Email is valid!");
            }
        }
    }
}
