using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelTracker
{
    class ParcelServiceImpl : IParcelService
    {
        private ParcelLinkedList list = new ParcelLinkedList();

        public void CreateParcel()
        {
            Console.Write("Parcel ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Sender: ");
            string sender = Console.ReadLine();

            Parcel parcel = new CourierParcel(id, sender);
            list.AddParcel(parcel);

            Console.WriteLine("Parcel created successfully.");
        }

        public void AddCheckpoint()
        {
            Console.Write("Parcel ID: ");
            int id = int.Parse(Console.ReadLine());

            ParcelNode parcel = list.Find(id);
            if (parcel == null)
            {
                Console.WriteLine("Parcel not found (lost).");
                return;
            }

            Console.Write("After which stage? ");
            string after = Console.ReadLine();

            StageNode temp = parcel.StageHead;
            while (temp != null && temp.Stage != after)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Stage not found.");
                return;
            }

            Console.Write("New checkpoint: ");
            string stage = Console.ReadLine();

            StageNode node = new StageNode(stage);
            node.Next = temp.Next;
            temp.Next = node;

            Console.WriteLine("Checkpoint added.");
        }

        public void TrackParcel()
        {
            Console.Write("Parcel ID: ");
            int id = int.Parse(Console.ReadLine());

            ParcelNode parcel = list.Find(id);
            if (parcel == null)
            {
                Console.WriteLine("Parcel not found (lost).");
                return;
            }

            list.DisplayStages(parcel.StageHead);
        }

        public void DisplayAll()
        {
            list.DisplayAll();
        }
    }

}
