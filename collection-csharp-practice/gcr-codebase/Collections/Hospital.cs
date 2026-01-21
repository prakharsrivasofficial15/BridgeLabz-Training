using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Hospital
    {
        static void Main(string[] args)
        {
            PriorityQueue<string, int> pq = new PriorityQueue<string, int>();

            Console.Write("Enter number of patients: ");
            int n = int.Parse(Console.ReadLine());

            //patient data from user
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter patient name: ");
                string name = Console.ReadLine();

                Console.Write("Enter severity (higher number = more serious): ");
                int severity = int.Parse(Console.ReadLine());

                // Use negative to make higher severity treated first
                pq.Enqueue(name, -severity);
            }

            Console.WriteLine("\nTreatment Order:");
            while (pq.Count > 0)
            {
                Console.WriteLine(pq.Dequeue());
            }

            Console.ReadLine();
        }
    }
}
