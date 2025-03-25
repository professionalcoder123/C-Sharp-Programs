using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegexPrograms
{
    internal class Order
    {
        [Required(ErrorMessage ="Order ID is required")]
        [RegularExpression(@"^ORD-\d+$")]
        public string OrderId { get; set;}

        [Required(ErrorMessage ="Order date is required")]
        [RegularExpression(@"^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[0-2])/\d{4}$")]
        public string OrderDate { get; set;}

        [Required(ErrorMessage ="Total amount is required")]
        [Range(1,100000,ErrorMessage ="Total amount must be greater than 0 and less than or equal to Rs. 100000")]
        public double TotalAmount { get; set;}
    }

    internal class OrderManagement
    {
        public static void ValidateOrderDetails()
        {
            Console.WriteLine("Enter the order ID");
            string orderId = Console.ReadLine();
            Console.WriteLine("Enter the order date");
            string orderDate = Console.ReadLine();
            Console.WriteLine("Enter the total amount");
            double totalAmount = double.Parse(Console.ReadLine());

            var order = new Order
            {
                OrderId = orderId,
                OrderDate = orderDate,
                TotalAmount = totalAmount
            };
            var context=new ValidationContext(order);
            var results = new List<ValidationResult>();
            bool isValid = Validator.TryValidateObject(order, context, results, true);
            if (isValid)
            {
                Console.WriteLine("Order details are valid!");
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
