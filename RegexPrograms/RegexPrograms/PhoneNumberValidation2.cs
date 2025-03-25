using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class PhoneNumberValidation2
    {
        public static void CheckPhoneNumber(string phoneNumber)
        {
            string regex = @"^\+[0-9]{2}\s[6-9][0-9]{9}$";
            Regex re = new Regex(regex);
            if (re.IsMatch(phoneNumber))
            {
                Console.WriteLine("Phone number is valid!");
            }
            else
            {
                Console.WriteLine("Phone number is not valid!");
            }
        }
    }
}
