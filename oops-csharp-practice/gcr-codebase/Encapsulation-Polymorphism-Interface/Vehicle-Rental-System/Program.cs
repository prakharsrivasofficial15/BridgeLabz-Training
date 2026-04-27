using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Vehicle_Rental_System
{
    class Program
    {
        static void Main()
        {
            Vehicle[] vehicles = new Vehicle[3];

            vehicles[0] = new Car("CAR-101", 1500, "CAR-INS-001");
            vehicles[1] = new Bike("BIKE-202", 500);
            vehicles[2] = new Truck("TRUCK-303", 3000, "TRK-INS-009");

            RentalProcessor.ProcessRentals(vehicles, 3);
        }
    }

}
