namespace BridgelabzTraining.senario_based.Wooden_Rod_System
{
    internal class Menu
    {
        public static void Start()
        {
            Utility utility = new Utility();

            WoodLog[] sampleLogs =
            {
                new WoodLog(2, 5, 0.2),
                new WoodLog(3, 8, 0.3),
                new WoodLog(4, 9, 0.4),
                new WoodLog(6, 17, 0.6)
            };

            while (true)
            {
                Console.WriteLine("\n--- Wooden Rod Cutting System ---");
                Console.WriteLine("1. Scenario A: Maximize Revenue");
                Console.WriteLine("2. Scenario B: Maximize Revenue with Waste Constraint");
                Console.WriteLine("3. Scenario C: Maximize Revenue and Minimize Waste");
                Console.WriteLine("4. Exit");
                Console.Write("Enter choice: ");

                int userChoice = Convert.ToInt32(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        ExecuteScenario(sampleLogs, double.MaxValue);
                        break;

                    case 2:
                    case 3:
                        Console.Write("Enter allowed waste: ");
                        double allowedWaste = Convert.ToDouble(Console.ReadLine());
                        ExecuteScenario(sampleLogs, allowedWaste);
                        break;

                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }

        private static void ExecuteScenario(WoodLog[] logs, double allowedWaste)
        {
            Utility utility = new Utility();
            int rodLength = 12;

            WoodLog[] result = utility.FindOptimalLogs(logs, rodLength, allowedWaste);
            DisplayResult(result);
        }

        private static void DisplayResult(WoodLog[] selectedLogs)
        {
            double totalRevenue = 0;
            int totalLength = 0;
            double totalWaste = 0;

            Console.WriteLine("\nSelected Logs:");
            foreach (WoodLog log in selectedLogs)
            {
                Console.WriteLine($"Length: {log.Length}, Price: {log.Price}, Waste: {log.Waste}");
                totalRevenue += log.Price;
                totalLength += log.Length;
                totalWaste += log.Waste;
            }

            Console.WriteLine($"Total Length Used: {totalLength}");
            Console.WriteLine($"Total Revenue: {totalRevenue}");
            Console.WriteLine($"Total Waste: {totalWaste}");
        }
    }
}
