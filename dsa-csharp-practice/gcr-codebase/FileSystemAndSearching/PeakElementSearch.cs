using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Binary Search Problem 2: Find the Peak Element in an Array
Problem: A peak element is an element that is greater than its neighbors. Write a program that performs Binary Search to find a peak element in an array. 
*/

namespace Linear__and_Binary_Search
{
    class PeakElementSearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 3, 20, 4, 1, 0 };
            int index = FindPeak(arr);
            Console.WriteLine($"Peak element index: {index}");
        }

        static int FindPeak(int[] arr)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] < arr[mid + 1])
                    left = mid + 1;
                else
                    right = mid;
            }
            return left;
        }
    }
}
