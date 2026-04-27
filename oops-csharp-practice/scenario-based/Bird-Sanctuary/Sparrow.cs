using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Bird_Sanctuary
{
    class Sparrow : Bird, IFlyable
    {
        public Sparrow(string id, string food, string date, bool injured)
            : base(id, "Sparrow", food, date, injured) { }

        public void Fly()
        {
            Console.WriteLine("Sparrow is flying.");
        }
    }

}
