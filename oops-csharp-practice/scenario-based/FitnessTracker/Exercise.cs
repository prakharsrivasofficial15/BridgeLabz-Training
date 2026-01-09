using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.FitnessTracker
{
    public class Exercise
    {
        public string Name { get; set; }
        public int TimeInMinutes { get; set; }

        public Exercise(string name, int time)
        {
            Name = name;
            TimeInMinutes = time;
        }
    }

}
