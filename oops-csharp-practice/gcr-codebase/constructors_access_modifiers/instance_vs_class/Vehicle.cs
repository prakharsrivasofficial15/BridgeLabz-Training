using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.constructors_access_modifiers.instance_vs_class
{
    internal class Vehicle
    {
        //Instance variables
        private string ownerName;
        private string vehicleType;

        //Class variable
        private static double registrationFee = 5000;

        //constructor
        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        //instance method
        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Owner Name: " + ownerName);
            Console.WriteLine("Vehicle Type: " + vehicleType);
            Console.WriteLine("Registration Fee: " + registrationFee);
        }

        //class method
        public static void UpdateRegistrationFee(double newFee)
        {
            registrationFee = newFee;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Vehicle v1 = new Vehicle("Rahul", "Car");
            Vehicle v2 = new Vehicle("Anita", "Bike");

            v1.DisplayVehicleDetails();
            Console.WriteLine();

            Vehicle.UpdateRegistrationFee(6000);

            v2.DisplayVehicleDetails();
        }
    }
}
