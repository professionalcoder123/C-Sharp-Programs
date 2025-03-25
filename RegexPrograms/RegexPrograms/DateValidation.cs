using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class DateValidation
    {
        public static void ValidateDate()
        {
            Console.WriteLine("Enter the date in DD/MM/YYYY or MM-DD-YYYY format");
            string date=Console.ReadLine();
            string strRegex = @"^(([0][1-9]{2}|[12][0-9]|3[01])\/(0[1-9]|1[0-2])\/\d{4}|(0[1-9]|1[1-2])\-?([0][1-9]{2}|[12][0-9]|3[01])\-?\d{4})$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(date))
            {
                Console.WriteLine("Date is matched!");
            }
            else
            {
                Console.WriteLine("Date is not matched!");
            }
        }
    }
}
