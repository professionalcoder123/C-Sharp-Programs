using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class InsufficientBalanceException : Exception
    {
        public InsufficientBalanceException(string message) : base(message)
        {
            Console.WriteLine(message);
        }
    }

    internal class BankAccount
    {
        static double totalAmount = 50000.00;
        public static void Withdraw(double amount)
        {
            if (amount > totalAmount)
            {
                throw new InsufficientBalanceException("Withdrawal amount is greater than total amount. Please enter valid amount!");
            }
            else
            {
                double withdrawnAmount = totalAmount - amount;
                Console.WriteLine("Remaining balance in your account = Rs. " + withdrawnAmount);
            }
        }
    }
}
