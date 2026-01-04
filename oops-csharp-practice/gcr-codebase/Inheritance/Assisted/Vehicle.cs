using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Inheritance.Assisted
{
    internal class Vehicle
    {
        public int MaxSpeed;
        public string FuelType;

        public Vehicle(int maxSpeed, string fuelType)
        {
            MaxSpeed = maxSpeed;
            FuelType = fuelType;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Max Speed: " + MaxSpeed);
            Console.WriteLine("Fuel Type: " + FuelType);
        }
    }

    class Car : Vehicle
    {
        public int SeatCapacity;

        public Car(int maxSpeed, string fuelType, int seatCapacity)
            : base(maxSpeed, fuelType)
        {
            SeatCapacity = seatCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Seat Capacity: " + SeatCapacity);
        }
    }

    class Truck : Vehicle
    {
        public int PayloadCapacity;

        public Truck(int maxSpeed, string fuelType, int payloadCapacity)
            : base(maxSpeed, fuelType)
        {
            PayloadCapacity = payloadCapacity;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Payload Capacity: " + PayloadCapacity);
        }
    }

    class Motorcycle : Vehicle
    {
        public bool HasSidecar;

        public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
            : base(maxSpeed, fuelType)
        {
            HasSidecar = hasSidecar;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Has Sidecar: " + HasSidecar);
        }
    }

    class VehicleTest
    {
        static void Main()
        {
            Vehicle[] vehicles = new Vehicle[3];

            vehicles[0] = new Car(180, "Petrol", 5);
            vehicles[1] = new Truck(120, "Diesel", 5000);
            vehicles[2] = new Motorcycle(150, "Petrol", false);

            for (int i = 0; i < vehicles.Length; i++)
            {
                vehicles[i].DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
