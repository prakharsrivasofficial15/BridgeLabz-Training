using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
StringBuilder Problem 2: Remove Duplicates from a String Using StringBuilder
Problem: Write a program that uses StringBuilder to remove all duplicate characters from a given string while maintaining the original order.
*/

namespace Linear__and_Binary_Search
{
    class RemoveDuplicatesUsingStringBuilder
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            StringBuilder sb = new StringBuilder();
            HashSet<char> seen = new HashSet<char>();

            for (int i = 0; i < input.Length; i++)
            {
                if (seen.Add(input[i]))
                {
                    sb.Append(input[i]);
                }
            }
            Console.WriteLine(sb.ToString()); 
        }
    }
}
