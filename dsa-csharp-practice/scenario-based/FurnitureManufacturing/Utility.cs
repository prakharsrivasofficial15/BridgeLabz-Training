using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Wooden_Rod_System
{
    internal class Utility : ILogOperations
    {
        public WoodLog[] ReadLogsFromUser()
        {
            Console.Write("Enter number of log types: ");
            int logTypeCount = Convert.ToInt32(Console.ReadLine());

            WoodLog[] availableLogs = new WoodLog[logTypeCount];

            for (int i = 0; i < logTypeCount; i++)
            {
                Console.WriteLine($"\nLog {i + 1}");

                Console.Write("Enter length: ");
                int length = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter waste: ");
                double waste = Convert.ToDouble(Console.ReadLine());

                availableLogs[i] = new WoodLog(length, price, waste);
            }

            return availableLogs;
        }

        public WoodLog[] FindOptimalLogs(WoodLog[] availableLogs, int rodLength, double maxAllowedWaste)
        {
            double maximumRevenue = 0;
            double minimumWaste = double.MaxValue;

            WoodLog[] bestSelection = new WoodLog[0];
            int totalLogs = availableLogs.Length;

            int totalCombinations = 1 << totalLogs;

            for (int mask = 1; mask < totalCombinations; mask++)
            {
                int usedLength = 0;
                double totalWaste = 0;
                double totalRevenue = 0;

                WoodLog[] currentSelection = new WoodLog[totalLogs];
                int selectionIndex = 0;

                for (int i = 0; i < totalLogs; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        usedLength += availableLogs[i].Length;
                        totalWaste += availableLogs[i].Waste;
                        totalRevenue += availableLogs[i].Price;
                        currentSelection[selectionIndex++] = availableLogs[i];
                    }
                }

                if (usedLength <= rodLength && totalWaste <= maxAllowedWaste)
                {
                    if (totalRevenue > maximumRevenue ||
                        (totalRevenue == maximumRevenue && totalWaste < minimumWaste))
                    {
                        maximumRevenue = totalRevenue;
                        minimumWaste = totalWaste;

                        bestSelection = new WoodLog[selectionIndex];
                        for (int j = 0; j < selectionIndex; j++)
                        {
                            bestSelection[j] = currentSelection[j];
                        }
                    }
                }
            }

            return bestSelection;
        }
    }
}
