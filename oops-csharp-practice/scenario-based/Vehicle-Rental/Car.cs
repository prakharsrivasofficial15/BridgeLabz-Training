using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Vehicle_Rental
{
    class Car : Vehicle
    {
        public Car(string vehicleNumber) : base(vehicleNumber, 1200) { }

        public override double CalculateRent(int days)
        {
            return days * ratePerDay;
        }
    }
}
