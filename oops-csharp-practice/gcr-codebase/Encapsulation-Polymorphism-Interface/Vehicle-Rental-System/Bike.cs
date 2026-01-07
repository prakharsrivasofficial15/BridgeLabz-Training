using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Vehicle_Rental_System
{
    public class Bike : Vehicle
    {
        public Bike(string vehicleNumber, decimal rentalRate)
            : base(vehicleNumber, "Bike", rentalRate)
        {
        }

        public override decimal CalculateRentalCost(int days)
        {
            return RentalRate * days * 0.9m; 
        }
    }
}
