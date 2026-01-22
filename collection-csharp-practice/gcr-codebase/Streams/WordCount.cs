using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Streams
{
    class WordCount
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            try
            {
                // Dictionary to store words and their counts
                Dictionary<string, int> wordCount = new Dictionary<string, int>();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    // Read file line by line until end of file
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line.ToLower().Split(new char[] { ' ', '\t', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

                        foreach (string word in words)
                        {
                            // If word already exists, increase count
                            if (wordCount.ContainsKey(word))
                            {
                                wordCount[word]++;
                            }
                            else
                            {
                                // If word not found, add it with count 1
                                wordCount[word] = 1;
                            }
                        }
                    }
                }
                // Sort words by count in descending order and take top 5
                var topWords = wordCount.OrderByDescending(w => w.Value).Take(5);

                Console.WriteLine("Top 5 most frequent words:");
                foreach (var word in topWords)
                {
                    Console.WriteLine($"{word.Key} : {word.Value}");
                }
            }
            catch (IOException ex)
            {
                // Handle file reading errors
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }
}
