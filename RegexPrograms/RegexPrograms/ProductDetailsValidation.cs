using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class Product
    {
        [Required(ErrorMessage ="Product name is required")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Product name should contain 3 to 50 characters")]
        public string ProductName { get; set; }

        [Required(ErrorMessage ="Product price is required")]
        [Range(1,1000,ErrorMessage ="Product price should range between Rs. 1 to Rs. 1000")]
        public int Price { get; set; }

        [Required(ErrorMessage ="Product stock is required")]
        [Range(0,10000,ErrorMessage ="Product stock should be greater than or equal to 0")]
        public int Stock { get; set; }
    }

    internal class ProductDetailsValidation
    {
        public static void EnterProductDetails()
        {
            Console.WriteLine("Enter the name of the product");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the price of the product");
            int price = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the stock of the product");
            int stock = int.Parse(Console.ReadLine());

            var product = new Product
            {
                ProductName = name,
                Price = price,
                Stock = stock
            };
            var context = new ValidationContext(product);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(product, context, results, true);
            if (isValid)
            {
                Console.WriteLine("Product details are valid!");
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
