using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class CheckEqual
    {
        static void Main(string[] args)
        {
            HashSet<int> set1 = new HashSet<int>();
            HashSet<int> set2 = new HashSet<int>();

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

            bool isEqual = true;

            // Check count first
            if (set1.Count != set2.Count)
            {
                isEqual = false;
            }
            else
            {
                // Check every element of set1 exists in set2
                foreach (int item in set1)
                {
                    if (!set2.Contains(item))
                    {
                        isEqual = false;
                        break;
                    }
                }
            }

            Console.WriteLine("\nAre sets equal? " + isEqual);
            Console.ReadLine();
        }
    }
}
