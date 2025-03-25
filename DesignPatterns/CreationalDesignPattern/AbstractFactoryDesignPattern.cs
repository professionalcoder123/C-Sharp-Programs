using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreationalDesignPattern
{
    public interface ICar
    {
        void ManufactureCar();
    }

    public interface IBike
    {
        void ManufactureBike();
    }

    public class HondaCar : ICar
    {
        public void ManufactureCar()
        {
            Console.WriteLine("Honda car is manufactured!");
        }
    }

    public class HondaBike : IBike
    {
        public void ManufactureBike()
        {
            Console.WriteLine("Honda bike is manufactured!");
        }
    }

    public class SuzukiCar : ICar
    {
        public void ManufactureCar()
        {
            Console.WriteLine("Suzuki car is manufactured!");
        }
    }

    public class SuzukiBike : IBike
    {
        public void ManufactureBike()
        {
            Console.WriteLine("Suzuki bike is manufactured!");
        }
    }

    public interface VehicleCompany
    {
        ICar GetCar();
        IBike GetBike();
    }

    public class Honda : VehicleCompany
    {
        public IBike GetBike()
        {
            return new HondaBike();
        }

        public ICar GetCar()
        {
            return new HondaCar();
        }
    }

    public class Suzuki : VehicleCompany
    {
        public IBike GetBike()
        {
            return new SuzukiBike();
        }

        public ICar GetCar()
        {
            return new SuzukiCar();
        }
    }
}
