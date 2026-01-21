using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class RotateElements
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            List<int> result = new List<int>();

            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            Console.Write("Enter rotation value k: ");
            int k = int.Parse(Console.ReadLine());

            k = k % list.Count;

            // Add elements from k to end
            for (int i = k; i < list.Count; i++)
            {
                result.Add(list[i]);
            }

            // Add elements from 0 to k-1
            for (int i = 0; i < k; i++)
            {
                result.Add(list[i]);
            }

            Console.WriteLine("\nRotated List:");
            for (int i = 0; i < result.Count; i++)
            {
                Console.Write(result[i]);
                if (i < result.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
