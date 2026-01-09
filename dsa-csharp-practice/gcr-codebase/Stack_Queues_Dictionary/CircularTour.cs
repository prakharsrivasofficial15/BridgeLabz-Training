using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Circular Tour Problem
Problem: Given a set of petrol pumps with petrol and distance to the next pump, determine the starting point for completing a circular tour.
Hint: Use a queue to simulate the tour, keeping track of surplus petrol at each pump.
*/

namespace StackQueues
{
    internal class CircularTour
    {
        public static int FindStartingPoint(int[] petrol, int[] distance)
        {
            int n = petrol.Length;
            int start = 0;
            int surplus = 0;
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                int diff = petrol[i] - distance[i];
                surplus += diff;
                total += diff;

                if (surplus < 0)
                {
                    start = i + 1;
                    surplus = 0;
                }
            }
            if(total >= 0)
            {
                return start;
            }
            return -1;
        }
        static void Main()
        {
            Console.Write("Enter number of petrol pumps: ");
            int n = int.Parse(Console.ReadLine());

            int[] petrol = new int[n];
            int[] distance = new int[n];

            Console.WriteLine("Enter petrol at each pump:");
            for (int i = 0; i < n; i++)
            {
                petrol[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter distance to next pump:");
            for (int i = 0; i < n; i++)
            {
                distance[i] = int.Parse(Console.ReadLine());
            }

            int start = FindStartingPoint(petrol, distance);

            if (start != -1)
            {
                Console.WriteLine("Start at pump " + start);
            }
            else
            {
                Console.WriteLine("No possible tour");
            }
        }
    }
}
