using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 2: Count the Occurrence of a Word in a File Using StreamReader Problem: Write a program that reads a file and counts how many times a specific word appears in the file. 
*/

namespace Linear__and_Binary_Search
{
    class WordCountInFile
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            Console.Write("Enter word to search: ");
            string targetWord = Console.ReadLine();

            int count = 0;

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] words = line.Split(' ', '\t', ',', '.', ';', '!', '?');

                        for (int i = 0; i < words.Length; i++)
                        {
                            if (words[i].Equals(targetWord, StringComparison.OrdinalIgnoreCase))
                            {
                                count++;
                            }
                        }
                    }
                }

                Console.WriteLine($"The word '{targetWord}' appears {count} times.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
    }
}
