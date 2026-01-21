using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class SymmetricDifference
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();
            List<int> result = new List<int>();

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

            // Elements in set1 but not in set2
            foreach (int item in set1)
            {
                if (!set2.Contains(item))
                {
                    result.Add(item);
                }
            }

            // Elements in set2 but not in set1
            foreach (int item in set2)
            {
                if (!set1.Contains(item))
                {
                    result.Add(item);
                }
            }

            Console.WriteLine("\nSymmetric Difference:");
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]);

                if (i < result.Count - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
