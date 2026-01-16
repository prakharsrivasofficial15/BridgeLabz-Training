using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficManager
{
    class VehicleServiceUtilityImpl : IVehicleOperations
    {
        private CircularLinkedListImpl roundAbout = new CircularLinkedListImpl();
        private VehicleQueue wait = new VehicleQueue(10);

        public Vehicle AddVehicle()
        {
            Console.Write("Enter Vehicle ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Enter Vehicle Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Exit Point(1-4): ");
            int exit = int.Parse(Console.ReadLine());

            VehicleNode node = new VehicleNode(id, name, exit);
            wait.Enqueue(node);

            return node;
        }

        public void Enter(int id)
        {
            VehicleNode node = wait.DequeueById(id);

            if (node == null)
            {
                Console.WriteLine("Vehicle not found in waiting queue");
                return;
            }

            roundAbout.Insert(node);
            Console.WriteLine($"Vehicle {id} entered roundabout");
        }

        public void Exit(int id)
        {
            roundAbout.DeleteById(id);
        }

        public void PrintState()
        {
            roundAbout.Display();
        }
    }
}
