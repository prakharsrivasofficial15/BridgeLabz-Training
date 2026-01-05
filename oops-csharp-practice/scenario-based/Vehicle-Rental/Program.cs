using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Vehicle_Rental
{
    class Program
    {
        static void Main()
        {
            Customer customer = new Customer("Rahul");

            string[] vehicleNumbers = { "BIKE101", "CAR202", "TRUCK303" };

            Console.WriteLine("=== Vehicle Rental System ===");
            Console.WriteLine("1. Rent Bike");
            Console.WriteLine("2. Rent Car");
            Console.WriteLine("3. Rent Truck");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of days: ");
            int days = Convert.ToInt32(Console.ReadLine());

            Vehicle vehicle = null;

            switch (choice)
            {
                case 1:
                    vehicle = new Bike(vehicleNumbers[0]);
                    break;

                case 2:
                    vehicle = new Car(vehicleNumbers[1]);
                    break;

                case 3:
                    vehicle = new Truck(vehicleNumbers[2]);
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    return;
            }

            customer.RentVehicle(vehicle, days);
        }
    }
}
