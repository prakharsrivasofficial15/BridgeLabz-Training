using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Linear Search Problem 1: Search for the First Negative Number Problem: You are given an integer array. Write a program that performs Linear Search to find the first negative number in the array. 
*/

namespace Linear__and_Binary_Search
{
    class FirstNegativeSearch
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 8, 3, -4, 7, -2 };

            int index = FindFirstNegative(numbers);

            if (index != -1)
                Console.WriteLine($"First negative number is {numbers[index]} at index {index}");
            else
                Console.WriteLine("No negative number found");
        }

        static int FindFirstNegative(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0) 
                    return i;
            }
            return -1;
        }
    }
}
