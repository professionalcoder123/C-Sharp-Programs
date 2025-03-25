using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS
{
    internal class Payment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment is processed normally");
        }
    }

    internal class CreditCardPayment : Payment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment is processed via credit card");
        }
    }

    internal class CashPayment : Payment
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Payment is processed via cash");
        }
    }
}
