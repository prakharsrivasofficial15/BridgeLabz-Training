using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Bird_Sanctuary
{
    class Penguin : Bird, ISwimmable
    {
        public Penguin(string id, string food, string date, bool injured)
            : base(id, "Penguin", food, date, injured) { }

        public void Swim()
        {
            Console.WriteLine("Penguin is swimming.");
        }
    }

}
