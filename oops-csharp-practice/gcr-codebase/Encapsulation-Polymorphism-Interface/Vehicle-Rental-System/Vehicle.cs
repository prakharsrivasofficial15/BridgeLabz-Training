using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Vehicle_Rental_System
{
    public abstract class Vehicle
    {
        private string _vehicleNumber;
        private string _type;
        private decimal _rentalRate;

        private string _insurancePolicyNumber;

        public string VehicleNumber
        {
            get { return _vehicleNumber; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Vehicle number cannot be empty.");
                _vehicleNumber = value;
            }
        }

        public string Type
        {
            get { return _type; }
            protected set { _type = value; }
        }

        public decimal RentalRate
        {
            get { return _rentalRate; }
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Rental rate cannot be negative.");
                _rentalRate = value;
            }
        }

        protected Vehicle(string vehicleNumber, string type, decimal rentalRate)
        {
            VehicleNumber = vehicleNumber;
            Type = type;
            RentalRate = rentalRate;
        }

        public abstract decimal CalculateRentalCost(int days);

        protected void SetInsurancePolicy(string policyNumber)
        {
            _insurancePolicyNumber = policyNumber;
        }

        protected string GetInsurancePolicy()
        {
            return _insurancePolicyNumber;
        }

        public void DisplayVehicleDetails()
        {
            Console.WriteLine("Vehicle No: " + VehicleNumber);
            Console.WriteLine("Type: " + Type);
            Console.WriteLine("Rate/Day: " + RentalRate);
        }
    }

}
