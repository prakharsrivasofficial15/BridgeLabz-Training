using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AeroVigil
{
    internal class UserInterface
    {
        public void Start()
        {
            Console.WriteLine("Enter flight details");

            try
            {
                string input = Console.ReadLine();
                string[] details = input.Split(':');

                string flightNumber = details[0];
                string flightName = details[1];
                int passengerCount = int.Parse(details[2]);
                double currentFuelLevel = double.Parse(details[3]);

                IFlight util = new FlightUtil();

                if(util.ValidateFlightNumber(flightNumber) && util.ValidateFlightName(flightName) && util.ValidatePassengerCount(passengerCount, flightName))
                {
                    double fuelRequired = util.CalculateFuelToFillTank(flightName, currentFuelLevel);
                    Console.WriteLine("Fuel required to fill the tank: " + fuelRequired + " liters");
                }  
            }
            catch (InvalidFlightException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
