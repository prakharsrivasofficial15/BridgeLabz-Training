using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 1: Concatenate Strings Efficiently Using StringBuilder
Problem: You are given an array of strings. Write a program that uses StringBuilder to concatenate all the strings in the array efficiently. 
*/

namespace Linear__and_Binary_Search
{
    class ConcatenateStrings
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of words: ");
            int n = int.Parse(Console.ReadLine());

            string[] words = new string[n];
            int totalLength = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter word {i + 1}: ");
                words[i] = Console.ReadLine();
                totalLength += words[i].Length;
            }

            StringBuilder sb = new StringBuilder(totalLength);

            for (int i = 0; i < words.Length; i++)
            {
                sb.Append(words[i]);
            }
            Console.WriteLine(sb.ToString());
        }
    }
}
