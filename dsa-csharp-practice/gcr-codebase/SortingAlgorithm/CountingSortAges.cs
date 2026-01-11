using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class CountingSortAges
    {
        static void CountingSort(int[] ages)
        {
            int minAge = 10;
            int maxAge = 18;

            //size of count
            int range = maxAge - minAge + 1;

            int[] count = new int[range];

            //counting occurrences of each age
            for (int i = 0; i < ages.Length; i++)
            {
                int index = ages[i] - minAge;
                count[index]++;
            }

            //rewrite sorted values into the original array
            int k = 0;
            for (int i = 0; i < range; i++)
            {
                for (int j = 0; j < count[i]; j++)
                {
                    ages[k] = i + minAge;
                    k++;
                }
            }
        }


        static void Main()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[] ages = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter age of student (10–18): ");
                ages[i] = int.Parse(Console.ReadLine());
            }
            //method calling
            CountingSort(ages);

            Console.WriteLine("\nSorted Student Ages:");
            Console.WriteLine(string.Join(", ", ages));
        }
    }
}
