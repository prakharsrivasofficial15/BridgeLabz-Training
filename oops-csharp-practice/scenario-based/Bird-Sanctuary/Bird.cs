using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Bird_Sanctuary
{
    internal class Bird
    {
        public string Id;
        public string BirdType;
        public string FoodType;
        public string DateOfArrival;
        public bool IsInjured;

        public Bird(string id, string birdType, string food, string date, bool injured)
        {
            Id =id;
            BirdType = birdType;
            FoodType = food;
            DateOfArrival = date;
            IsInjured = injured;
        }

        public void Display()
        {
            Console.WriteLine("ID: " + Id);
            Console.WriteLine("Food Type: " + FoodType);
            Console.WriteLine("Date of Arrival: " + DateOfArrival);
            Console.WriteLine("Injured: " + IsInjured);
        }
    }
}
