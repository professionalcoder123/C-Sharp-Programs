using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class PhoneNumberValidation1
    {
        public static void CheckPhoneNumber(string phoneNumber)
        {
            string regex = @"^[0-9]{10}$";
            Regex re = new Regex(regex);
            if (re.IsMatch(phoneNumber))
            {
                Console.WriteLine("Phone number is valid");
            }
            else
            {
                Console.WriteLine("Phone number is not valid");
            }
        }
    }
}
