using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Binary Search Problem 1: Find the Rotation Point in a Rotated Sorted Array Problem: You are given a rotated sorted array. Write a program that performs Binary Search to find the index of the smallest element in the array. 
*/

namespace Linear__and_Binary_Search
{
    class RotationPointSearch
    {
        static void Main(string[] args)
        {
            Console.Write("Enter numbers: ");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int index = FindRotationPoint(arr);

            Console.WriteLine($"Rotation point index: {index}");
            Console.WriteLine($"Smallest element: {arr[index]}");
        }

        static int FindRotationPoint(int[] arr)
        {
            int left = 0, right = arr.Length - 1;

            while (left < right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] > arr[right])
                    left = mid + 1;
                else
                    right = mid;
            }
            return left;
        }
    }
}
