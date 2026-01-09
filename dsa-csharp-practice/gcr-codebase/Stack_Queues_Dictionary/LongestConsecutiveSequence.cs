using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Longest Consecutive Sequence
Problem: Given an unsorted array, find the length of the longest consecutive elements sequence.
Hint: Use a hash map to store elements and check for consecutive elements efficiently.
*/

namespace StackQueues
{
    internal class LongestConsecutiveSequence
    {
        public static int FindLongestConsecutive(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0; 
            }

            HashSet<int> set = new HashSet<int>(nums);
            int maxLength = 0;

            foreach (int num in set)
            {
                if (!set.Contains(num - 1))
                {
                    int currentNum = num;
                    int currentLength = 1;

                    while (set.Contains(currentNum + 1))
                    {
                        currentNum++;
                        currentLength++;
                    }

                    maxLength = Math.Max(maxLength, currentLength);
                }
            }

            return maxLength;
        }
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            int[] nums = new int[n];

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int result = FindLongestConsecutive(nums);
            Console.WriteLine("Longest consecutive sequence length: " + result);
        }
    }
}
