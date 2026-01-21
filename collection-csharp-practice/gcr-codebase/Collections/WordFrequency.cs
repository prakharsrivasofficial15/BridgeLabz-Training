using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class WordFrequency
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> freq = new Dictionary<string, int>();

            Console.Write("Enter a sentence: ");
            string text = Console.ReadLine();

            text = text.ToLower();
            text = text.Replace(",", "");
            text = text.Replace("!", "");
            text = text.Replace(".", "");

            string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            // Count frequency using simple for loop
            for (int i = 0; i < words.Length; i++)
            {
                string word = words[i];

                if (!freq.ContainsKey(word))
                {
                    freq[word] = 0;
                }

                freq[word]++;
            }

            Console.WriteLine("\nWord Frequency:");
            List<string> keys = new List<string>(freq.Keys);

            // Display
            for (int i = 0; i < keys.Count; i++)
            {
                string key = keys[i];
                Console.WriteLine(key + " : " + freq[key]);
            }

            Console.ReadLine();
        }
    }
}
