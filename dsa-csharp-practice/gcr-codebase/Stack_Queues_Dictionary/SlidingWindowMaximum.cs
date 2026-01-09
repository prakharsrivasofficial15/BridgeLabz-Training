using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Sliding Window Maximum
Problem: Given an array and a window size k, find the maximum element in each sliding window of size k.
Hint: Use a deque (double-ended queue) to maintain indices of useful elements in each window.
*/

namespace StackQueues
{
    internal class SlidingWindowMaximum
    {
        public static int[] MaxSlidingWindow(int[] nums, int k)
        {
            if (nums.Length == 0 || k == 0)
                return Array.Empty<int>();

            int n = nums.Length;
            int[] result = new int[n - k + 1];
            LinkedList<int> deque = new LinkedList<int>();

            for (int i = 0; i < n; i++)
            {
                if (deque.Count > 0 && deque.First.Value <= i - k)
                {
                    deque.RemoveFirst();
                }

                while (deque.Count > 0 && nums[deque.Last.Value] <= nums[i])
                {
                    deque.RemoveLast();
                }

                deque.AddLast(i);

                if (i >= k - 1)
                {
                    result[i - k + 1] = nums[deque.First.Value];
                }
            }

            return result;
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

            Console.Write("Enter window size k: ");
            int k = int.Parse(Console.ReadLine());

            int[] result = MaxSlidingWindow(nums, k);

            Console.WriteLine("Sliding window maximums:");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
