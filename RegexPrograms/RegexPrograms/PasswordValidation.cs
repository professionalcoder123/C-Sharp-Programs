using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class PasswordValidation
    {
        public static void ValidatePassword()
        {
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            string strRegex = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[@$&*!%?])[A-Za-z\d@$&*!%?]{8,}$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(password))
            {
                Console.WriteLine("Password is matched!");
            }
            else
            {
                Console.WriteLine("Password is not matched");
            }
        }
    }
}
