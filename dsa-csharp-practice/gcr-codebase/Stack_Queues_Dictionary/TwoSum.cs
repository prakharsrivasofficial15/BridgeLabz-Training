using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Two Sum Problem
Problem: Given an array and a target sum, find two indices such that their values add up to the target.
Hint: Use a hash map to store the index of each element as you iterate. Check if target - current_element exists in the map.
*/

namespace StackQueues
{
    internal class TwoSum
    {
        public static int[] FindTwoSum(int[] nums, int target)
        {
            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (map.ContainsKey(complement))
                {
                    return new int[] { map[complement], i };
                }

                map[nums[i]] = i;
            }

            return Array.Empty<int>();
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

            Console.Write("Enter target sum: ");
            int target = int.Parse(Console.ReadLine());

            int[] result = FindTwoSum(nums, target);

            if (result.Length == 0)
                Console.WriteLine("No two sum solution found");
            else
                Console.WriteLine($"Indices: [{result[0]}, {result[1]}]");
        }
    }
}
