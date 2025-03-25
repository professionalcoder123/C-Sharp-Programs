using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class Document
    {
        [Required(ErrorMessage ="File name is required")]
        [StringLength(20,MinimumLength =1,ErrorMessage ="File name should be minimum 1 and maximum 20 characters")]
        [RegularExpression(@"(.*)\.(pdf|docx)$",ErrorMessage ="The file name should contain the extension .pdf or .docx")]
        public string FileName { get; set; }

        [Range(1000,5000000,ErrorMessage ="File size should be between 1 KB and 5 MB")]
        public int FileSize { get; set; }
    }

    internal class FileUploadValidation
    {
        public static void ValidateFileDetails()
        {
            Console.WriteLine("Enter the name of the file");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the size of the file");
            int size = int.Parse(Console.ReadLine());

            var document = new Document
            {
                FileName = name,
                FileSize = size
            };
            var context = new ValidationContext(document);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(document, context, results, true);
            if (isValid)
            {
                Console.WriteLine("Document details are valid!");
            }
            else
            {
                Console.WriteLine("Validation errors :");
                foreach (var error in results)
                {
                    Console.WriteLine($" -> {error.ErrorMessage}");
                }
            }
        }
    }
}