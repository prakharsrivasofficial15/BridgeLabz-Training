using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Check for a Pair with Given Sum in an Array
Problem: Given an array and a target sum, find if there exists a pair of elements whose sum is equal to the target.
Hint: Store visited numbers in a hash map and check if target - current_number exists in the map.
*/

namespace StackQueues
{
    internal class PairWithGivenSum
    {
        public static bool HasPairWithSum(int[] arr, int target)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in arr)
            {
                int complement = target - num;

                if (seen.Contains(complement))
                    return true;

                seen.Add(num);
            }

            return false;
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

            Console.Write("Enter target sum: ");
            int target = int.Parse(Console.ReadLine());

            HashSet<int> seen = new HashSet<int>();
            bool found = false;

            for (int i = 0; i < n; i++)
            {
                int num = arr[i];
                int complement = target - num;

                if (seen.Contains(complement))
                {
                    Console.WriteLine($"Pair exists ({num}, {complement})");
                    found = true;
                    break;
                }

                seen.Add(num);
            }

            if (!found)
                Console.WriteLine("No pair found");
        }
    }
}
