using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Streams
{
    class LargeFileReader
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            Console.Write("Enter word to search: ");
            string searchWord = Console.ReadLine();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Check if the line contains the search word (case-insensitive)
                        if (line.IndexOf(searchWord, StringComparison.OrdinalIgnoreCase) >= 0)
                        {
                            Console.WriteLine(line);
                        }
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("I/O Error: " + ex.Message);
            }
        }
    }
}
