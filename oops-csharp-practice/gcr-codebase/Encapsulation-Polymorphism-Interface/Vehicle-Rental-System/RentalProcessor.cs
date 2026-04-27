using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Vehicle_Rental_System
{
    public class RentalProcessor
    {
        public static void ProcessRentals(Vehicle[] vehicles, int days)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                Vehicle vehicle = vehicles[i];
                vehicle.DisplayVehicleDetails();

                decimal rentalCost = vehicle.CalculateRentalCost(days);
                decimal insuranceCost = 0;

                if (vehicle is IInsurable)
                {
                    IInsurable insurableVehicle = (IInsurable)vehicle;
                    insuranceCost = insurableVehicle.CalculateInsurance();
                    Console.WriteLine(insurableVehicle.GetInsuranceDetails());
                }

                Console.WriteLine("Rental Cost (" + days + " days): " + rentalCost);
                Console.WriteLine("Insurance Cost: " + insuranceCost);
                Console.WriteLine("Total Cost: " + (rentalCost + insuranceCost));
            }
        }
    }

}
