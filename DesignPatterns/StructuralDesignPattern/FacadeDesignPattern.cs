using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace StructuralDesignPattern
{
    public class Product
    {
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Product name should contain minimum 3 and maximum 20 characters")]
        [RegularExpression(@"^([A-Z][a-z]+)(\s[A-Z][a-z]+)*$", ErrorMessage = "Product name must be in title case.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Product price is required")]
        [Range(1, 500000000, ErrorMessage = "Price should be in the range of Rs. 1 and Rs. 500000000")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Product quantity is required")]
        [Range(0, 50, ErrorMessage = "Quantity should be 0 or 50")]
        public int Quantity { get; set; }

        public void ValidateProduct()
        {
            Console.WriteLine("Enter the name of the product:");
            Name = Console.ReadLine();

            Console.WriteLine("Enter the price of the product:");
            double price;
            while (!double.TryParse(Console.ReadLine(), out price) || price < 1 || price > 500000000)
            {
                Console.WriteLine("Invalid input. Price should be in the range of Rs. 1 and Rs. 500000000. Try again:");
            }
            Price = price;

            Console.WriteLine("Enter the quantity available of the above product:");
            int quantity;
            while (!int.TryParse(Console.ReadLine(), out quantity) || quantity < 0 || quantity > 50)
            {
                Console.WriteLine("Invalid input. Quantity should be between 0 and 50. Try again:");
            }
            Quantity = quantity;

            var context = new ValidationContext(this);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(this, context, results, true);

            if (!isValid)
            {
                Console.WriteLine("Validation errors:");
                foreach (var error in results)
                {
                    Console.WriteLine($" -> {error.ErrorMessage}");
                }
            }
            else
            {
                Console.WriteLine($"Product Name: {Name}\nProduct Price: {Price}\nProduct Quantity: {Quantity}");
            }
        }
    }

    public class Payment
    {
        private readonly Product _product;

        public Payment(Product product)
        {
            _product = product;
        }

        public void PayAmount()
        {
            Console.WriteLine("Enter the amount you have:");
            double amount;
            while (!double.TryParse(Console.ReadLine(), out amount) || amount < 1 || amount > 500000000)
            {
                Console.WriteLine("Invalid input. Amount should be in the range of Rs. 1 and Rs. 500000000. Try again:");
            }
            var context = new ValidationContext(_product) { MemberName = nameof(Product.Price) };
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateProperty(_product.Price, context, results);

            if (!isValid)
            {
                Console.WriteLine("Validation error:");
                foreach (var error in results)
                {
                    Console.WriteLine($" -> {error.ErrorMessage}");
                }
                return;
            }

            if (amount < _product.Price)
            {
                Console.WriteLine("Insufficient funds! Cannot purchase the product.");
                return;
            }

            Console.WriteLine("Amount paid successfully!");
            SendMail();
        }

        public void SendMail()
        {
            Console.WriteLine("Mail sent successfully!");
        }
    }

    public class FacadeDesignPattern
    {
        public void PerformPattern()
        {
            Product product = new Product();
            product.ValidateProduct();
            Payment payment = new Payment(product);
            payment.PayAmount();
        }
    }
}
