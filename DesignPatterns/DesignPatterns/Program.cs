using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreationalDesignPattern;
using StructuralDesignPattern;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SingletonDesignPattern sdp1 = SingletonDesignPattern.GetObject();
            //SingletonDesignPattern sdp2 = SingletonDesignPattern.GetObject();
            //SingletonDesignPattern sdp3 = SingletonDesignPattern.GetObject();

            //Factory Design Pattern
            //Console.WriteLine("Enter vehicle type");
            //string userInput = Console.ReadLine();
            //IVehicle Type = FactoryDesignPattern.GetObjectType(userInput);
            //Console.WriteLine("Vehicle type : " + Type.getVehicleType());
            //Console.WriteLine("Number of wheels : " + Type.numberOfWheels());

            //Abstract Factory Design Pattern
            //VehicleCompany hondaCompany = new Honda();
            //ICar hondaCar = hondaCompany.GetCar();
            //IBike hondaBike = hondaCompany.GetBike();
            //VehicleCompany suzukiCompany = new Suzuki();
            //ICar suzukiCar = suzukiCompany.GetCar();
            //IBike suzukiBike = suzukiCompany.GetBike();
            //hondaCar.ManufactureCar();
            //hondaBike.ManufactureBike();
            //suzukiCar.ManufactureCar();
            //suzukiBike.ManufactureBike();

            //Prototype Design Pattern
            //Employee emp1 = new PermanentEmployee()
            //{
            //    Id = 101,
            //    Name = "Aditya",
            //    Department = "IT",
            //    Salary = 35000
            //};
            //Employee emp2 = emp1.GetClone();
            //emp2.Id = 102;
            //emp2.Name = "Hrishikesh";
            //emp2.Department = "Marketing";
            //emp1.ShowDetails();
            //emp2.ShowDetails();
            //Employee emp3 = new TemporaryEmployee()
            //{
            //    Id = 103,
            //    Name = "Sohel",
            //    Department = "Sales",
            //    FixedAmount = 20000.50
            //};
            //Employee emp4 = emp3.GetClone();
            //emp4.Id = 104;
            //emp4.Name = "Kedar";
            //emp4.Department = "HR";
            //emp3.ShowDetails();
            //emp4.ShowDetails();

            //Builder Design Pattern
            //ExcelReport excelReport = new ExcelReport();
            //ReportDirector excelDirector = new ReportDirector();
            //Report excel = excelDirector.MakeReport(excelReport);
            //excel.DisplayReport();
            //Console.WriteLine("--------------------------");
            //PDFReport pdfReport = new PDFReport();
            //ReportDirector pdfDirector = new ReportDirector();
            //Report pdf = pdfDirector.MakeReport(pdfReport);
            //pdf.DisplayReport();

            AdapterDesignPattern.PerformPattern();


        }
    }
}
