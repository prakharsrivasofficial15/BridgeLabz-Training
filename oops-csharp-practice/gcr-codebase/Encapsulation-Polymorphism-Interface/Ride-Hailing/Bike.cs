using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Ride_Hailing
{
    public class Bike : Vehicle, IGPS
    {
        public Bike(int vehicleId, string driverName)
            : base(vehicleId, driverName, 8m)
        {
        }

        public override decimal CalculateFare(double distance)
        {
            return RatePerKm * (decimal)distance * 0.9m;
        }

        public string GetCurrentLocation()
        {
            return GetLocation();
        }

        public void UpdateLocation(string newLocation)
        {
            SetLocation(newLocation);
        }
    }

}
