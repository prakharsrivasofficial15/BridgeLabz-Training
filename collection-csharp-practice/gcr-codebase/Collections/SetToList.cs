using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class SetToList
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            List<int> list = new List<int>();

            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                set.Add(int.Parse(Console.ReadLine()));
            }

            // Convert set to list
            foreach (int item in set)
            {
                list.Add(item);
            }

            // Simple bubble sort using for loops 
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = 0; j < list.Count - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp;
                    }
                }
            }

            Console.WriteLine("\nSorted List:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);

                if (i < list.Count - 1)
                    Console.Write(", ");
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
