using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficManager
{
    class VehicleServiceMenu
    {
        private IVehicleOperations service = new VehicleServiceUtilityImpl();

        public void Show()
        {
            service = new VehicleServiceUtilityImpl();

            while (true)
            {
                Console.WriteLine("1. Add Vehicle");
                Console.WriteLine("2. Enter Roundabout");
                Console.WriteLine("3. Exit Roundabout");
                Console.WriteLine("4. Print State");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid choice.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        service.AddVehicle();
                        break;

                    case 2:
                        Console.Write("Enter Vehicle ID: ");
                        service.Enter(int.Parse(Console.ReadLine()));
                        break;

                    case 3:
                        Console.Write("Enter Vehicle ID: ");
                        service.Exit(int.Parse(Console.ReadLine()));
                        break;

                    case 4:
                        service.PrintState();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid option.");
                        break;
                }
            }
        }
    }
}
