using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class User
    {
        [Required(ErrorMessage ="Username is required")]
        [StringLength(15,MinimumLength =5,ErrorMessage ="Username should contain 5 to 15 characters")]
        public string Username { get; set; }

        [Required(ErrorMessage ="Password is required")]
        [StringLength(20,MinimumLength =8,ErrorMessage ="Password should contain minimum 8 characters")]
        public string Password { get; set; }

        [Required(ErrorMessage ="Email address is required")]
        [EmailAddress(ErrorMessage ="Please provide valid email address")]
        public string Email { get; set; }
    }

    internal class UserRegistration
    {
        public static void RegisterUser()
        {
            Console.WriteLine("Enter the username");
            string username = Console.ReadLine();
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();
            Console.WriteLine("Enter the email");
            string email = Console.ReadLine();
            var users = new User
            {
                Username = username,
                Password = password,
                Email = email
            };
            var context = new ValidationContext(users);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(users, context, results, true);
            if (isValid)
            {
                Console.WriteLine("User information is valid");
            }
            else
            {
                Console.WriteLine("Validation errors :");
                foreach(var error in results)
                {
                    Console.WriteLine($" -> {error.ErrorMessage}");
                }
            }
        }
    }
}
