using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class Employee
    {
        [Required(ErrorMessage ="Name is required")]
        [StringLength(50,MinimumLength=3,ErrorMessage ="Name should contain 3 to 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage ="Age is required")]
        [Range(18,70,ErrorMessage ="Age should be between 18 to 70")]
        public int Age { get; set; }

        [Required(ErrorMessage ="Email address is required")]
        [EmailAddress(ErrorMessage ="Please provide valid email address")]
        public string Email { get; set; }
    }
}
