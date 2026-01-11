using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class InsertionSortEmployees
    {
        static void Sort(int[] empIds)
        {
            for (int i = 1; i < empIds.Length; i++)
            {
                int key = empIds[i];
                int j = i - 1;

                while (j >= 0 && empIds[j] > key)
                {
                    empIds[j + 1] = empIds[j];
                    j--;
                }
                empIds[j + 1] = key;
            }
        }
        static void Main()
        {
            Console.Write("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());

            int[] empIds = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter Employee ID " + (i+1) + ": ");
                empIds[i] = int.Parse(Console.ReadLine());
            }
            //method calling
            Sort(empIds);

            Console.WriteLine("Sorted Employee IDs:");
            Console.WriteLine(string.Join(", ", empIds));
        }
    }
}
