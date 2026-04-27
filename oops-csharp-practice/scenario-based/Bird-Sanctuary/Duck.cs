using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Bird_Sanctuary
{
    class Duck : Bird, ISwimmable
    {
        public Duck(string id, string food, string date, bool injured)
            : base(id, "Duck", food, date, injured) { }

        public void Swim()
        {
            Console.WriteLine("Duck is swimming.");
        }
    }

}
