using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Challenge Problem (for both Linear and Binary Search)
Problem:
You are given a list of integers. Write a program that uses Linear Search to find the first missing positive integer in the list and Binary Search to find the index of a given target number.
Approach:
Linear Search for the first missing positive integer:
Iterate through the list and mark each number in the list as visited (you can use negative marking or a separate array).
Traverse the array again to find the first positive integer that is not marked.
Binary Search for the target index:
After sorting the array, perform binary search to find the index of the given target number.
Return the index if found, otherwise return -1.
*/

namespace Linear__and_Binary_Search
{
    class LinearAndBinarySearchChallenge
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 4, -1, 1 };

            Console.Write("Enter target value: ");
            int target = int.Parse(Console.ReadLine());

            int missing = FirstMissingPositive(arr);
            Console.WriteLine($"First missing positive integer: {missing}");

            Array.Sort(arr);
            int index = BinarySearch(arr, target);
            Console.WriteLine($"Index of target {target}: {index}");
        }

        //1: Linear Search
        static int FirstMissingPositive(int[] nums)
        {
            int n = nums.Length;

            //mark visited numbers
            for (int i = 0; i < n; i++)
            {
                int val = Math.Abs(nums[i]);
                if (val >= 1 && val <= n)
                {
                    nums[val - 1] = -Math.Abs(nums[val - 1]);
                }
            }

            //find first positive index
            for (int i = 0; i < n; i++)
            {
                if (nums[i] > 0)
                    return i + 1;
            }

            return n + 1;
        }

        //2: Binary Search 
        static int BinarySearch(int[] arr, int target)
        {
            int left = 0, right = arr.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (arr[mid] == target)
                    return mid;
                else if (arr[mid] < target)
                    left = mid + 1;
                else
                    right = mid - 1;
            }
            return -1;
        }
    }
}
