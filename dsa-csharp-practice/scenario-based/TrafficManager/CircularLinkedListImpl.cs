using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficManager
{
    class CircularLinkedListImpl
    {
        private VehicleNode tail;

        public void Insert(VehicleNode node)
        {
            if (tail == null)
            {
                tail = node;
                tail.Next = tail;
            }
            else
            {
                node.Next = tail.Next;
                tail.Next = node;
                tail = node;
            }
        }

        public void DeleteById(int id)
        {
            if (tail == null)
            {
                Console.WriteLine("Roundabout Empty");
                return;
            }

            VehicleNode current = tail.Next;
            VehicleNode prev = tail;

            do
            {
                if (current.ID == id)
                {
                    if (current == tail && current == tail.Next)
                    {
                        tail = null; // only one node
                    }
                    else
                    {
                        prev.Next = current.Next;
                        if (current == tail)
                            tail = prev;
                    }

                    Console.WriteLine($"Vehicle {id} exited roundabout");
                    return;
                }

                prev = current;
                current = current.Next;

            } while (current != tail.Next);

            Console.WriteLine("Vehicle not found in roundabout");
        }

        public void Display()
        {
            if (tail == null)
            {
                Console.WriteLine("RoundAbout Empty");
                return;
            }

            VehicleNode temp = tail.Next;
            do
            {
                Console.WriteLine(temp);
                temp = temp.Next;
            } while (temp != tail.Next);
        }

        public void RotateAndExit()
        {
            if (tail == null) return;

            VehicleNode current = tail.Next;
            VehicleNode prev = tail;

            do
            {
                current.rotationCount++;

                if (current.rotationCount == current.Exit)
                {
                    Console.WriteLine("Vehicle Exiting: " + current);

                    if (current == tail && current == tail.Next)
                    {
                        tail = null;
                    }
                    else
                    {
                        prev.Next = current.Next;
                        if (current == tail)
                            tail = prev;
                    }
                    return;
                }

                prev = current;
                current = current.Next;

            } while (current != tail.Next);
        }

    }
}
