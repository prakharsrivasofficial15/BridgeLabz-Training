using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcelTracker
{
    class StageNode
    {
        public string Stage;
        public StageNode Next;

        public StageNode(string stage)
        {
            Stage = stage;
            Next = null;
        }
    }
    class ParcelNode
    {
        public Parcel ParcelData;
        public StageNode StageHead;
        public ParcelNode Next;

        public ParcelNode(Parcel parcel)
        {
            ParcelData = parcel;
            Next = null;
            InitStages();
        }

        private void InitStages()
        {
            StageHead = new StageNode("Packed");
            StageHead.Next = new StageNode("Shipped");
            StageHead.Next.Next = new StageNode("In Transit");
            StageHead.Next.Next.Next = new StageNode("Delivered");
        }
    }
    class ParcelLinkedList
    {
        private ParcelNode head;

        public void AddParcel(Parcel parcel)
        {
            ParcelNode node = new ParcelNode(parcel);
            node.Next = head;
            head = node;
        }

        public ParcelNode Find(int id)
        {
            ParcelNode temp = head;
            while (temp != null)
            {
                if (temp.ParcelData.GetId() == id)
                    return temp;
                temp = temp.Next;
            }
            return null;
        }

        public void DisplayStages(StageNode head)
        {
            StageNode temp = head;
            while (temp != null)
            {
                Console.Write(temp.Stage + " → ");
                temp = temp.Next;
            }
            Console.WriteLine("END");
        }

        public void DisplayAll()
        {
            ParcelNode temp = head;

            if (temp == null)
            {
                Console.WriteLine("No parcels available.");
                return;
            }

            while (temp != null)
            {
                Console.WriteLine($"Parcel ID: {temp.ParcelData.GetId()} | Sender: {temp.ParcelData.GetSender()}");
                DisplayStages(temp.StageHead);
                temp = temp.Next;
            }
        }
    }
}
