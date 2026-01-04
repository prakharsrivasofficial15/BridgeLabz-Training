using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.c__Keywords
{
    internal class Vehicle
    {
        public static double RegistrationFee = 5000;

        public string OwnerName;
        public string VehicleType;
        public readonly string RegistrationNumber;

        public Vehicle(string ownerName, string vehicleType, string registrationNumber)
        {
            this.OwnerName = ownerName;
            this.VehicleType = vehicleType;
            this.RegistrationNumber = registrationNumber;
        }

        public static void UpdateRegistrationFee(double newFee)
        {
            RegistrationFee = newFee;
        }

        public static void DisplayVehicleDetails(object obj)
        {
            if (obj is Vehicle v)
            {
                Console.WriteLine($"{v.OwnerName} - {v.VehicleType} - {v.RegistrationNumber} - Fee:{RegistrationFee}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Rahul", "Car", "REG1001");
            Vehicle v2 = new Vehicle("Sneha", "Bike", "REG1002");

            Vehicle.DisplayVehicleDetails(v1);
            Vehicle.DisplayVehicleDetails(v2);

            Vehicle.UpdateRegistrationFee(6000);
            Console.WriteLine("Registration Fee Updated");

            Vehicle.DisplayVehicleDetails(v1);

            Console.ReadLine();
        }
    }
}
