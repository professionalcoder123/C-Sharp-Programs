using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern
{
    public abstract class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }

        public abstract Employee GetClone();

        public abstract void ShowDetails();
    }

    public class PermanentEmployee : Employee
    {
        public double Salary { get; set; }

        public override Employee GetClone()
        {
            return (PermanentEmployee)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Permanent Employee :");
            Console.WriteLine($"Id : {this.Id}\nName : {this.Name}\nDepartment : {this.Department}\nSalary : Rs. {this.Salary}\n");
            Console.WriteLine("---------------------------------------------");
        }
    }

    public class TemporaryEmployee : Employee
    {
        public double FixedAmount { get; set;}

        public override Employee GetClone()
        {
            return (TemporaryEmployee)this.MemberwiseClone();
        }

        public override void ShowDetails()
        {
            Console.WriteLine("Temporary Employee :");
            Console.WriteLine($"Id : {this.Id}\nName : {this.Name}\nDepartment : {this.Department}\nFixed Amount : Rs. {this.FixedAmount}\n");
            Console.WriteLine("--------------------------------------------");
        }
    }
}
