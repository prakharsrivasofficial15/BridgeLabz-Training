using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Ride_Hailing
{
    public class Auto : Vehicle, IGPS
    {
        public Auto(int vehicleId, string driverName)
            : base(vehicleId, driverName, 10m)
        {
        }

        public override decimal CalculateFare(double distance)
        {
            return (RatePerKm * (decimal)distance) + 20m;
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
