using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Linear Search Problem 2: Search for a Specific Word in a List of Sentences Problem: You are given an array of sentences. Write a program that performs Linear Search to find the first sentence containing a specific word.
 */

namespace Linear__and_Binary_Search
{
    class SentenceSearch
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentences");
            int n = int.Parse(Console.ReadLine());

            string[] sentences = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter sentence {i + 1}: ");
                sentences[i] = Console.ReadLine();
            }

            Console.Write("Enter word to search: ");
            string word = Console.ReadLine();

            int index = FindSentence(sentences, word);

            if (index != -1)
                Console.WriteLine($"Word '{word}' found at index {index}");
            else
                Console.WriteLine("Word not found");
        }

        static int FindSentence(string[] sentences, string word)
        {
            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].ToLower().Contains(word.ToLower()))
                    return i;
            }
            return -1;
        }
    }
}
