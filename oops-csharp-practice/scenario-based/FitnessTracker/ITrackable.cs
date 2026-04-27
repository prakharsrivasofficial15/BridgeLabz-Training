using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.FitnessTracker
{
    internal interface ITrackable
    {
        double CalculateCalories();
        void TrackProgress();
    }
}
