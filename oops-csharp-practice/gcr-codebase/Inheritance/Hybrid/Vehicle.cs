using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Inheritance.Hybrid
{
    interface Refuelable
    {
        void Refuel();
    }

    internal class Vehicle
    {
        public int MaxSpeed;
        public string Model;

        public Vehicle(int maxSpeed, string model)
        {
            MaxSpeed = maxSpeed;
            Model = model;
        }
    }

    class PetrolVehicle : Vehicle, Refuelable
    {
        public PetrolVehicle(int maxSpeed, string model)
            : base(maxSpeed, model) { }

        public void Refuel()
        {
            Console.WriteLine("Petrol vehicle is being refueled.");
        }
    }

    class ElectricVehicle : Vehicle
    {
        public ElectricVehicle(int maxSpeed, string model)
            : base(maxSpeed, model) { }

        public void Charge()
        {
            Console.WriteLine("Electric vehicle is charging.");
        }
    }

    class VehicleTest
    {
        static void Main()
        {
            PetrolVehicle petrolCar = new PetrolVehicle(180, "Honda City");
            ElectricVehicle electricCar = new ElectricVehicle(160, "Tesla Model 3");

            petrolCar.Refuel();
            electricCar.Charge();
        }
    }
}
