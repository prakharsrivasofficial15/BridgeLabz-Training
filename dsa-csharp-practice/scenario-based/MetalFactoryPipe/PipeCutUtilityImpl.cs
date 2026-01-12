using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalFactoryPipe
{
    internal class PipeCutUtility
    {
        private int maxRevenue = 0;

        public int FindMaximumRevenue(PipeCut[] cuts, int remainingLength)
        {
            CalculateRevenue(cuts, remainingLength, 0);
            return maxRevenue;
        }

        private void CalculateRevenue(PipeCut[] cuts, int remainingLength, int currentRevenue)
        {
            if (remainingLength == 0)
            {
                if (currentRevenue > maxRevenue)
                {
                    maxRevenue = currentRevenue;
                }
                return;
            }

            for (int i = 0; i < cuts.Length; i++)
            {
                if (cuts[i].Length <= remainingLength)
                {
                    CalculateRevenue(cuts, remainingLength - cuts[i].Length, currentRevenue + cuts[i].Price);
                }
            }
        }
    }

}
