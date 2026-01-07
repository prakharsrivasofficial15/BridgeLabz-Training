using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Ride_Hailing
{
    class Program
    {
        static void Main()
        {
            Vehicle[] vehicles = new Vehicle[3];

            vehicles[0] = new Car(1, "Alice");
            vehicles[1] = new Bike(2, "Bob");
            vehicles[2] = new Auto(3, "Charlie");

            RideProcessor.ProcessRides(vehicles, 12.5);
        }
    }
}
