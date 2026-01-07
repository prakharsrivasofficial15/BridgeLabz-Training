using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.TelecomCallLogs
{
    // Handles user interaction and menu options
    internal class Menu
    {
        public void ShowMenu()
        {
            Utility utility = new Utility();

            while (true)
            {
                Console.WriteLine("\nCall Logs Manager");
                Console.WriteLine("1. Add Call Log");
                Console.WriteLine("2. Search by Keyword");
                Console.WriteLine("3. Filter by Time Range");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Phone Number: ");
                        long phoneNumber = Convert.ToInt64(Console.ReadLine());

                        Console.Write("Enter Message: ");
                        string message = Console.ReadLine();

                        Console.Write("Enter Time Stamp (yyyy-mm-dd hh:mm): ");
                        DateTime timeStamp = DateTime.Parse(Console.ReadLine());

                        utility.AddCallLog(phoneNumber, message, timeStamp);
                        break;

                    case 2:
                        Console.Write("Enter keyword to search: ");
                        string keyword = Console.ReadLine();
                        utility.SearchByKeyword(keyword);
                        break;

                    case 3:
                        Console.Write("Enter start time: ");
                        DateTime startTime = DateTime.Parse(Console.ReadLine());

                        Console.Write("Enter end time: ");
                        DateTime endTime = DateTime.Parse(Console.ReadLine());

                        utility.FilterByTimeRange(startTime, endTime);
                        break;

                    case 4:
                        Console.WriteLine("Exit application...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
