using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.AeroVigil
{
    internal class FlightUtil:IFlight
    {
        public bool ValidateFlightNumber(String flightNumber)
        {
            Regex regex = new Regex(@"^FL-[1-9][0-9]{3}$");

            if (!regex.IsMatch(flightNumber))
            {
                throw new InvalidFlightException("The flight no. " + flightNumber + " is invalid");
            }
            return true;
        }

        public bool ValidateFlightName(String flightName)
        {
            if (!(flightName.Equals("SpiceJet") || flightName.Equals("Vistara") || flightName.Equals("IndiGo") || flightName.Equals("Air Arabia")))
            {
                throw new InvalidFlightException("The flight name " + flightName + " is invalid");
            }
            return true;
        }

        public bool ValidatePassengerCount(int passengerCount, String flightName)
        {
            int maxCapacity = flightName 
            switch
            {
                "SpiceJet" => 396,
                "Vistara" => 615,
                "IndiGo" => 230,
                "Air Arabia" => 130,
                _ => 0
            };

            if (passengerCount <= 0 || passengerCount > maxCapacity)
            {
                throw new InvalidFlightException(
                    "The passenger count " + passengerCount + " is invalid for " + flightName
                );
            }
            return true;
        }

        public double CalculateFuelToFillTank(String flightName, double currentFuelLevel)
        {
            double tankCapacity = flightName 
            switch
            {
                "SpiceJet" => 200000,
                "Vistara" => 300000,
                "IndiGo" => 250000,
                "Air Arabia" => 150000,
                _ => 0
            };

            if (currentFuelLevel < 0 || currentFuelLevel > tankCapacity)
            {
                throw new InvalidFlightException("Invalid fuel level for " + flightName);
            }

            return tankCapacity - currentFuelLevel;
        }
    }
}
