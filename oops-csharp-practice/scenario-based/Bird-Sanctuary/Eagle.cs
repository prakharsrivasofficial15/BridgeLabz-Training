using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Bird_Sanctuary
{
    class Eagle: Bird, IFlyable
    {
        public Eagle(string id, string food, string date, bool injured) : base(id, "Eagle", food, date, injured) { }
        
        public void Fly()
        {
            Console.WriteLine("Eagle is flying");
        }
    }
}
