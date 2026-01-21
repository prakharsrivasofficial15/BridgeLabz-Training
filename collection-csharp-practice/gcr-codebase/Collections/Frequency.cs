using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Frequency
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string> { "apple", "banana", "apple", "orange" };
            Dictionary<string, int> freq = new Dictionary<string, int>();

            foreach (string item in list)
            {
                if (!freq.ContainsKey(item))
                {
                    freq[item] = 0;
                }
                freq[item]++;
            }

            Console.WriteLine("Frequency of elements:");
            foreach (var kv in freq)
            {
                Console.WriteLine($"{kv.Key} : {kv.Value}");
            }
        }

    }
}
