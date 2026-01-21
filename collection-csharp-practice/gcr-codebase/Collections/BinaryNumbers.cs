using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class BinaryNumbers
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            List<string> result = new List<string>();

            Console.Write("Enter no. of binary numbers to be generated: ");
            int N = int.Parse(Console.ReadLine());

            queue.Enqueue("1");

            for (int i = 0; i < N; i++)
            {
                string current = queue.Dequeue();
                result.Add(current);

                queue.Enqueue(current + "0");
                queue.Enqueue(current + "1");
            }

            Console.WriteLine("\nBinary Numbers:");
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
