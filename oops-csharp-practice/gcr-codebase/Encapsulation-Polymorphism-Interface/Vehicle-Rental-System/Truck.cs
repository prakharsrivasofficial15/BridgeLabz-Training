using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Vehicle_Rental_System
{
    public class Truck : Vehicle, IInsurable
    {
        public Truck(string vehicleNumber, decimal rentalRate, string policyNumber)
            : base(vehicleNumber, "Truck", rentalRate)
        {
            SetInsurancePolicy(policyNumber);
        }

        public override decimal CalculateRentalCost(int days)
        {
            return (RentalRate * days) + 2000m;
        }

        public decimal CalculateInsurance()
        {
            return 1200m;
        }

        public string GetInsuranceDetails()
        {
            return "Truck Insurance: Flat ₹1200";
        }
    }
}
