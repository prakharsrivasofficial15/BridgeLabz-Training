using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Vehicle_Rental
{
    class Truck : Vehicle
    {
        public Truck(string vehicleNumber) : base(vehicleNumber, 2500) { }

        public override double CalculateRent(int days)
        {
            return days * ratePerDay;
        }
    }
}
