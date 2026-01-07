using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Ride_Hailing
{
    public abstract class Vehicle
    {
        private int _vehicleId;
        private string _driverName;
        private decimal _ratePerKm;

        private string _currentLocation;

        public int VehicleId
        {
            get { return _vehicleId; }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Vehicle ID must be positive.");
                _vehicleId = value;
            }
        }

        public string DriverName
        {
            get { return _driverName; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Driver name cannot be empty.");
                _driverName = value;
            }
        }

        public decimal RatePerKm
        {
            get { return _ratePerKm; }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Rate per km must be positive.");
                _ratePerKm = value;
            }
        }

        protected Vehicle(int vehicleId, string driverName, decimal ratePerKm)
        {
            VehicleId = vehicleId;
            DriverName = driverName;
            RatePerKm = ratePerKm;
            _currentLocation = "Unknown";
        }
        public abstract decimal CalculateFare(double distance);

        public void GetVehicleDetails()
        {
            Console.WriteLine("Vehicle ID: " + VehicleId);
            Console.WriteLine("Driver: " + DriverName);
            Console.WriteLine("Rate/Km: " + RatePerKm);
        }
        protected string GetLocation()
        {
            return _currentLocation;
        }

        protected void SetLocation(string location)
        {
            _currentLocation = location;
        }
    }
}
