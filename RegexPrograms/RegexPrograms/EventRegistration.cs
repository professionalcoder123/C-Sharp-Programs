using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class Participant
    {
        [Required(ErrorMessage ="Participant name is required")]
        [StringLength(30,MinimumLength=3,ErrorMessage ="Participant name should contain maximum 30 characters")]
        public string ParticipantName { get; set; }

        [Required(ErrorMessage ="Age of participant is required")]
        [Range(18,60,ErrorMessage ="Age of participant should be between 18 and 60")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Contact number of participant is required")]
        [StringLength(10, MinimumLength = 1,ErrorMessage ="Contact number should contain 10 digits")]
        public string ContactNumber { get; set; }

    }

    internal class EventRegistration
    {
        public static void RegisterParticipant()
        {
            Console.WriteLine("Enter the name of the participant");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the age of the participant");
            int age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the contact number of the participant");
            string contactNo=Console.ReadLine();

            var participant = new Participant
            {
                ParticipantName = name,
                Age = age,
                ContactNumber = contactNo
            };
            var context=new ValidationContext(participant);
            var results=new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(participant, context, results, true);
            if (isValid) {
                Console.WriteLine("Participant details are valid!");
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
