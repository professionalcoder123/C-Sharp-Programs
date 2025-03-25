using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class EmailValidation
    {
        public static void ValidateEmail()
        {
            Console.WriteLine("Enter an email");
            string email=Console.ReadLine();
            string strRegex = @"^([a-zA-Z0-9]+|[a-zA-Z0-9]+\.[a-zA-Z0-9]+|[a-zA-Z0-9]+[_][a-zA-Z0-9]+)@?[a-z]+\.(com|org|gov|in|us|cc)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(email))
            {
                Console.WriteLine("Email is validated correctly!");
            }
            else
            {
                Console.WriteLine("Email is not validated!");
            }
        }
    }
}
