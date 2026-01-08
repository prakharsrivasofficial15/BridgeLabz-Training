using BridgelabzTraining.senario_based.TelecomCallLogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgelabzTraining.senario_based.Smart_Home_System
{
    internal class Menu
    {

        private Utility u = new Utility();

        public void AppMenu()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("WELCOME TO THE CONTROL SYSTEM");
                Console.WriteLine("1. Input Appliances");
                Console.WriteLine("2. Display All Appliances");
                Console.WriteLine("3. Control Appliances by Location");
                Console.WriteLine("4. Control Appliances by Type");
                Console.WriteLine("5. Remove Appliance by ID");
                Console.WriteLine("6. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        u.InputAppliances();
                        break;
                    case 2:
                        u.DisplayAppliances();
                        break;

                    case 3:
                        Console.Write("Enter location. ");
                        string location = Console.ReadLine();
                        u.ControlByLocation(location);
                        break;

                    case 4:
                        Console.Write("Enter appliance type AC ,Fan ,Light. ");
                        string type = Console.ReadLine();
                        u.ControlByType(type);
                        break;
                    case 5:
                        Console.Write("Enter Appliance ID to remove: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        u.RemoveAppliance(id);
                        break;

                    case 6:
                        flag = true;
                        Console.WriteLine("Exiting system...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }
            }
        }
    }
}
