using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class TemperatureOutOfControlException : Exception
    {
        public TemperatureOutOfControlException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }

    internal class TemperatureControl
    {
        public static void CheckTemperature()
        {
            double temperature = 160.55;
            if (temperature < 100)
            {
                Console.WriteLine("Boiler temperature is valid");
            }
            else
            {
                throw new TemperatureOutOfControlException("Temperature cannot be above 100 degrees celsius");
            }
        }
    }
}
