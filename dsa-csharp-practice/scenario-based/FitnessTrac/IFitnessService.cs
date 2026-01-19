using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrac
{
    interface IFitnessService
    {
        void AddUser();
        void UpdateSteps();
        void SortRanking();
        void DisplayLeaderboard();
    }

}
