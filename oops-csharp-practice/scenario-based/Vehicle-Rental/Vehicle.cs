using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Vehicle_Rental
{
    abstract class Vehicle : IRentable
    {
        protected string vehicleNumber;
        protected double ratePerDay;

        public Vehicle(string vehicleNumber, double ratePerDay)
        {
            this.vehicleNumber = vehicleNumber;
            this.ratePerDay = ratePerDay;
        }

        public abstract double CalculateRent(int days);
    }

}
