using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficManager
{
    class VehicleQueue
    {
        public VehicleNode[] queue;
        private int front = 0;
        private int rear = -1;
        private int count = 0;

        public VehicleQueue(int size)
        {
            queue = new VehicleNode[size];
        }

        public bool isFull() => count == queue.Length;
        public bool isEmpty() => count == 0;
        public void Enqueue(VehicleNode node)
        {
            if (isFull())
            {
                Console.WriteLine("Queue is full");
                return;
            }
            rear = (rear + 1) % queue.Length;
            queue[rear] = node;
            count++;
        }
        public VehicleNode DequeueById(int id)
        {
            if (isEmpty())
                return null;

            int size = count;
            VehicleNode found = null;

            for (int i = 0; i < size; i++)
            {
                VehicleNode node = Dequeue();

                if (node.ID == id && found == null)
                {
                    found = node; 
                }
                else
                {
                    Enqueue(node); 
                }
            }

            return found;
        }

    }
}
