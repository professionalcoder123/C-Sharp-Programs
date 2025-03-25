using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace StructuralDesignPattern
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Designation { get; set; }
        public decimal Salary { get; set; }

        public Employee(int id, string name, string gender, string designation, decimal salary)
        {
            Id = id;
            Name = name;
            Gender = gender;
            Designation = designation;
            Salary = salary;
        }
    }

    public class ThirdPartyBillingSystem
    {
        public void ProcessSalary(List<Employee> employees)
        {
            foreach(Employee employee in employees)
            {
                if (employee.Gender.Equals("Male"))
                {
                    Console.WriteLine("Rs. " + employee.Salary + " credited to Mr. " + employee.Name + "\'s"+" bank account");
                }
                else if(employee.Gender.Equals("Female"))
                {
                    Console.WriteLine("Rs. " + employee.Salary + " credited to Mrs. " + employee.Name + "\'s" + " bank account");
                }
                else
                {
                    Console.WriteLine("Cannot credit the amount due to the invalid gender of an employee!");
                }
            }
        }
    }

    public interface ITarget
    {
        void ProcessCompanySalary(string[,] employeesArray);
    }

    public class EmployeeAdapter : ITarget
    {
        ThirdPartyBillingSystem system = new ThirdPartyBillingSystem();
        public void ProcessCompanySalary(string[,] employeesArray)
        {
            string Id = null;
            string Name = null;
            string Gender = null;
            string Designation = null;
            string Salary = null;

            List<Employee> employees = new List<Employee>();
            for(int i = 0; i < employeesArray.GetLength(0); i++)
            {
                for (int j = 0; j < employeesArray.GetLength(1); j++) 
                {
                    if (j == 0)
                    {
                        Id = employeesArray[i, j];
                    }
                    else if (j == 1)
                    {
                        Name = employeesArray[i, j];
                    }
                    else if (j == 2)
                    {
                        Gender = employeesArray[i, j];
                    }
                    else if (j == 3)
                    {
                        Designation = employeesArray[i, j];
                    }
                    else
                    {
                        Salary = employeesArray[i, j];
                    }
                }
                employees.Add(new Employee(int.Parse(Id), Name, Gender, Designation, decimal.Parse(Salary)));
            }
            system.ProcessSalary(employees);
        }
    }

    public class AdapterDesignPattern
    {
        public static void PerformPattern()
        {
            string[,] employeesArray = new string[4, 5]
            {
                { "101","Aditya","Male","Developer","45000.85" },
                { "102","Rahul","Male","Tester","50000.70" },
                { "103","Sohel","Male","Network Analyst","30000.45" },
                { "104","Namita","Female","Data Scientist","48000.50" }
            };
            ITarget target = new EmployeeAdapter();
            target.ProcessCompanySalary(employeesArray);
        }
    }
}