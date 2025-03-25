using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern
{
    public interface IVehicle
    {
        string getVehicleType();
        int numberOfWheels();
    }

    public class Car : IVehicle
    {
        public string getVehicleType()
        {
            return "Car";
        }

        public int numberOfWheels()
        {
            return 4;
        }
    }

    public class Bike : IVehicle
    {
        public string getVehicleType()
        {
            return "Bike";
        }

        public int numberOfWheels()
        {
            return 2;
        }
    }

    public class FactoryDesignPattern
    {
        public static IVehicle GetObjectType(string objectType)
        {
            IVehicle vehicle = null;
            if (objectType.ToLower().Equals("bike"))
            {
                vehicle = new Bike();
            }
            else if (objectType.ToLower().Equals("car"))
            {
                vehicle = new Car();
            }
            return vehicle;
        }
    }
}
