using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class DomainName
    {
        public static bool IsValidDomainName()
        {
            Console.WriteLine("Enter any URL");
            string url=Console.ReadLine();
            string strRegex= @"^[a-zA-Z0-9]+\.(com|org|gov|in|us|cc)$";
            Regex re = new Regex(strRegex);
            if (re.IsMatch(url))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void ExtractDomainNames()
        {
            string[] urls = {
                "https://www.google.com",
                "https://www.javatpoint.com",
                "https://www.w3schools.com"
            };
            foreach (string url in urls)
            {
                bool res = IsValidDomainName();
                if (res)
                {
                    if (url == urls[urls.Length-1])
                    {
                        Console.WriteLine(url);
                    }
                    else
                    {
                        Console.WriteLine(url+", ");
                    }
                }
            }
        }
    }
}
