using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Ride_Hailing
{
    public class RideProcessor
    {
        public static void ProcessRides(Vehicle[] vehicles, double distance)
        {
            for (int i = 0; i < vehicles.Length; i++)
            {
                Vehicle vehicle = vehicles[i];

                vehicle.GetVehicleDetails();

                decimal fare = vehicle.CalculateFare(distance);
                Console.WriteLine("Distance: " + distance + " km");
                Console.WriteLine("Calculated Fare: " + fare);

                if (vehicle is IGPS)
                {
                    IGPS gpsVehicle = (IGPS)vehicle;
                    gpsVehicle.UpdateLocation("City Center");
                    Console.WriteLine("Current Location: " + gpsVehicle.GetCurrentLocation());
                }

            }
        }
    }

}
