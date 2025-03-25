using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace RegexPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter employee name");
            //string name = Console.ReadLine();
            //Console.WriteLine("Enter employee age");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter employee email address");
            //string email = Console.ReadLine();

            //var employees = new Employee
            //{
            //    Name = name,
            //    Age = age,
            //    Email = email
            //};

            //var context = new ValidationContext(employees);
            //var results = new List<ValidationResult>();
            //bool isValid = Validator.TryValidateObject(employees, context, results, true);

            //if (isValid)
            //{
            //    Console.WriteLine("Employee details are valid!");
            //}
            //else
            //{
            //    Console.WriteLine("Validation errors :");
            //    foreach (var error in results)
            //    {
            //        Console.WriteLine($" -> {error.ErrorMessage}");
            //    }
            //}

            //PhoneNumberValidation1.CheckPhoneNumber("9325127059");

            //PhoneNumberValidation2.CheckPhoneNumber("+91 9325127059");

            //UserRegistration.RegisterUser();

            //ProductDetailsValidation.EnterProductDetails();

            //EventRegistration.RegisterParticipant();

            //FileUploadValidation.ValidateFileDetails();

            //OrderManagement.ValidateOrderDetails();

            //EmailValidation.ValidateEmail();

            //PhoneNumberValidation3.ValidatePhoneNumber();

            //DateValidation.ValidateDate();

            PasswordValidation.ValidatePassword();

            //DomainName.ExtractDomainNames();
        }
    }
}
