using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Vehicle_Rental_System
{
    public class Car : Vehicle, IInsurable
    {
        public Car(string vehicleNumber, decimal rentalRate, string policyNumber)
            : base(vehicleNumber, "Car", rentalRate)
        {
            SetInsurancePolicy(policyNumber);
        }

        public override decimal CalculateRentalCost(int days)
        {
            return RentalRate * days;
        }

        public decimal CalculateInsurance()
        {
            return 500m;
        }

        public string GetInsuranceDetails()
        {
            return "Car Insurance: Flat ₹500";
        }
    }
}
