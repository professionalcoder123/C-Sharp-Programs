using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Division.PerformDivision();
            //}
            //catch (DivideByZeroException e)
            //{
            //    Console.WriteLine(e);
            //}

            //try
            //{
            //    TemperatureControl.CheckTemperature();
            //}
            //catch(TemperatureOutOfControlException e)
            //{
            //    Console.WriteLine(e);
            //}

            //try
            //{
            //    Problem2.HandleFormatException();
            //}
            //catch(FormatException e)
            //{
            //    Console.WriteLine(e);
            //}

            //try
            //{
            //    Problem3.HandleIndexOutOfRangeException();
            //}
            //catch (IndexOutOfRangeException e)
            //{
            //    Console.WriteLine(e);
            //}

            //try
            //{
            //    Problem4.HandleNullReferenceException();
            //}
            //catch (NullReferenceException e)
            //{
            //    Console.WriteLine("Caught NullReferenceException: " + e.Message);
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Caught General Exception: " + e.Message);
            //}

            //try
            //{
            //    Problem5.HandleArgumentOutOfRangeException();
            //}
            //catch(ArgumentOutOfRangeException e)
            //{
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    BankAccount.Withdraw(60000);
            //}
            //catch(Exception e)
            //{
            //    Console.WriteLine(e.ToString());
            //}

            try
            {
                ValidationInEmail.CheckEmail();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
