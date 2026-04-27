using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Vehicle_Rental
{
    class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.name = name;
        }

        public void RentVehicle(IRentable vehicle, int days)
        {
            Console.WriteLine("Customer Name: " + name);
            Console.WriteLine("Total Rent: Rs. " + vehicle.CalculateRent(days));
        }
    }
}
