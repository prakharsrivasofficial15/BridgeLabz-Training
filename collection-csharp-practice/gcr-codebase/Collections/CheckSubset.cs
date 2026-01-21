using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class CheckSubset
    {
        static void Main(string[] args)
        {
            HashSet<int> small = new HashSet<int>();
            HashSet<int> large = new HashSet<int>();

            Console.Write("Enter number of elements in small set: ");
            int n1 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n1; i++)
            {
                Console.Write("Enter element: ");
                small.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Enter number of elements in large set: ");
            int n2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < n2; i++)
            {
                Console.Write("Enter element: ");
                large.Add(int.Parse(Console.ReadLine()));
            }

            bool isSubset = true;
            foreach (int item in small)
            {
                if (!large.Contains(item))
                {
                    isSubset = false;
                    break;
                }
            }
            Console.WriteLine("\nIs subset? " + isSubset);
            Console.ReadLine();
        }
    }
}
