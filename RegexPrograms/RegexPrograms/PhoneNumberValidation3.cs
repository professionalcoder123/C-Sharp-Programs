using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class PhoneNumberValidation3
    {
        public static void ValidatePhoneNumber()
        {
            Console.WriteLine("Enter the US phone number");
            string phoneNumber = Console.ReadLine();
            string strRegex = @"^(\(?[0-9]{3}\)?\s[0-9]{3}\-?[0-9]{4}|\+1\s\(?[0-9]{3}\)\s[0-9]{3}\-?[0-9]{4}|[0-9]{3}\-?[0-9]{3}\-?[0-9]{4})$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(phoneNumber))
            {
                Console.WriteLine("Phone number is matched!");
            }
            else
            {
                Console.WriteLine("Phone number is not matched");
            }
        }
    }
}