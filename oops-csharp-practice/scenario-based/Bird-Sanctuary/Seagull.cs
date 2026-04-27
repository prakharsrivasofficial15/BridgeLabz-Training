using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Bird_Sanctuary
{
    class Seagull : Bird, IFlyable, ISwimmable
    {
        public Seagull(string id, string food, string date, bool injured)
            : base(id, "Seagull", food, date, injured) { }

        public void Fly()
        {
            Console.WriteLine("Seagull is flying.");
        }

        public void Swim()
        {
            Console.WriteLine("Seagull is swimming.");
        }
    }
}
