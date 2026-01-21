using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class InvertMap
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> input = new Dictionary<string, int>();
            Dictionary<int, List<string>> inverted = new Dictionary<int, List<string>>();

            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            // Take input from user
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter key (string): ");
                string key = Console.ReadLine();

                Console.Write("Enter value (int): ");
                int value = int.Parse(Console.ReadLine());

                input[key] = value;
            }

            // Invert the dictionary
            foreach (var kv in input)
            {
                if (!inverted.ContainsKey(kv.Value))
                {
                    inverted[kv.Value] = new List<string>();
                }

                inverted[kv.Value].Add(kv.Key);
            }

            // Display inverted map
            Console.WriteLine("\nInverted Map:");
            foreach (var kv in inverted)
            {
                Console.Write(kv.Key + " -> [ ");

                for (int i = 0; i < kv.Value.Count; i++)
                {
                    Console.Write(kv.Value[i]);
                    if (i < kv.Value.Count - 1)
                        Console.Write(", ");
                }

                Console.WriteLine(" ]");
            }

            Console.ReadLine();
        }
    }
}
