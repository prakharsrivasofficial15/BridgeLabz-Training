using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Ride_Hailing
{
    public class Car : Vehicle, IGPS
    {
        public Car(int vehicleId, string driverName)
            : base(vehicleId, driverName, 15m)
        {
        }

        public override decimal CalculateFare(double distance)
        {
            return RatePerKm * (decimal)distance;
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
