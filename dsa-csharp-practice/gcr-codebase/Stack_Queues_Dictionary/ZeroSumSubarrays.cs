using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Find All Subarrays with Zero Sum Problem: Given an array, find all subarrays whose elements sum up to zero. Hint: Use a hash map to store the cumulative sum and its frequency. If a sum repeats, a zero-sum subarray exists.
*/

namespace StackQueues
{
    internal class ZeroSumSubarrays
    {
        public static void FindZeroSumSubarrays(int[] arr)
        {
            Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
            int sum = 0;

            map[0] = new List<int> { -1 };

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

                if (map.ContainsKey(sum))
                {
                    foreach (int startIndex in map[sum])
                    {
                        Console.WriteLine($"Subarray found from index {startIndex + 1} to {i}");
                    }
                }

                if (!map.ContainsKey(sum))
                {
                    map[sum] = new List<int>();
                }

                map[sum].Add(i);
            }
        }
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nZero-sum subarrays:");
            FindZeroSumSubarrays(arr);
        }
    }
}
