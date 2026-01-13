using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
StringBuilder Problem 1: Reverse a String Using StringBuilder
Problem: Write a program that uses StringBuilder to reverse a given string. For example, if the input is "hello", the output should be "olleh". 
*/

namespace Linear_and_Binary_Search
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            string input = "hello";
            StringBuilder sb = new StringBuilder(input);

            int left = 0;
            int right = sb.Length - 1;

            while (left < right)
            {
                char temp = sb[left];
                sb[left] = sb[right];
                sb[right] = temp;

                left++;
                right--;
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
