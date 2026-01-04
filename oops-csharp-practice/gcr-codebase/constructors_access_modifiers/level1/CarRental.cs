using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.constructors_access_modifiers.level1
{
    internal class CarRental
    {
        private string customerName;
        private string carModel;
        private int rentalDays;
        private double totalCost;

        //constructor
        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
            this.totalCost = CalculateCost();
        }

        private double CalculateCost()
        {
            double costPerDay = 1500;
            return rentalDays * costPerDay;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Car Model: " + carModel);
            Console.WriteLine("Rental Days: " + rentalDays);
            Console.WriteLine("Total Cost: " + totalCost);
        }
    }
}
