using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetalFactoryPipe
{
    iinternal class Menu
    {
        public static void Start()
        {
            PipeCutUtility utility = new PipeCutUtility();

            // Scenario A
            PipeCut[] cuts =
            {
            new PipeCut(1, 1),
            new PipeCut(2, 5),
            new PipeCut(3, 8),
            new PipeCut(4, 9),
            new PipeCut(6, 17),
            new PipeCut(8, 20)
            };

            int rodLength = 8;

            int maxRevenue = utility.FindMaximumRevenue(cuts, rodLength);
            Console.WriteLine("Scenario A - Maximum Revenue: " + maxRevenue);

            // Scenario B
            PipeCut[] cutsWithCustom =
            {
            new PipeCut(1, 1),
            new PipeCut(2, 5),
            new PipeCut(3, 8),
            new PipeCut(4, 9),
            new PipeCut(5, 14), 
            new PipeCut(6, 17),
            new PipeCut(8, 20)
        };

            PipeCutUtility utility2 = new PipeCutUtility();
            int newRevenue = utility2.FindMaximumRevenue(cutsWithCustom, rodLength);

            Console.WriteLine("Scenario B - Revenue with Custom Cut: " + newRevenue);

            // Scenario C
            ShowNonOptimizedRevenue();
        }

        private static void ShowNonOptimizedRevenue()
        {
            int revenue = 8 * 1;
            Console.WriteLine("Non-Optimized Revenue: " + revenue);
        }
    }

}
