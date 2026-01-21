using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class UnionIntersection
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

            List<int> union = new List<int>();
            List<int> intersection = new List<int>();

            Console.Write("Enter number of elements in set 1: ");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++)
            {
                Console.Write("Enter element: ");
                set1.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Enter number of elements in set 2: ");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n2; i++)
            {
                Console.Write("Enter element: ");
                set2.Add(int.Parse(Console.ReadLine()));
            }

            // Union: add all from set1
            foreach (int item in set1)
            {
                union.Add(item);
            }

            // Union: add items from set2 if not already present
            foreach (int item in set2)
            {
                if (!set1.Contains(item))
                {
                    union.Add(item);
                }
            }

            // Intersection
            foreach (int item in set1)
            {
                if (set2.Contains(item))
                {
                    intersection.Add(item);
                }
            }

            Console.WriteLine("\nUnion:");
            for (int i = 0; i < union.Count; i++)
            {
                Console.Write(union[i]);
                if (i < union.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine("\n\nIntersection:");
            for (int i = 0; i < intersection.Count; i++)
            {
                Console.Write(intersection[i]);
                if (i < intersection.Count - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
