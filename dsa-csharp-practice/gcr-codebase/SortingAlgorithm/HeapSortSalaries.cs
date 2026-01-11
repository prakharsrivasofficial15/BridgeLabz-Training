using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class HeapSortSalaries
    {
        static void HeapSort(int[] salaries)
        {
            int n = salaries.Length;
            //buid max heap
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(salaries, n, i);
            }

            for (int i = n - 1; i > 0; i--)
            {
                int temp = salaries[0];
                salaries[0] = salaries[i];
                salaries[i] = temp;
                Heapify(salaries, i, 0);
            }
        }

        static void Heapify(int[] arr, int n, int i)
        {
            int largest = i;         //current
            int left = 2 * i + 1;    //left child
            int right = 2 * i + 2;   //right child

            //left child is larger than current
            if (left < n && arr[left] > arr[largest])
            {
                largest = left;
            }
            //right child is larger than current
            if (right < n && arr[right] > arr[largest])
            {
                largest = right;
            }
            //if largest not the root, swap largest with the root
            if (largest != i)
            {
                (arr[i], arr[largest]) = (arr[largest], arr[i]);
                Heapify(arr, n, largest);
            }
        }

        static void Main()
        {
            Console.Write("Enter number of employees: ");
            int n = int.Parse(Console.ReadLine());

            int[] salaries = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter salary demand of employee: ");
                salaries[i] = int.Parse(Console.ReadLine());
            }
            //method calling
            HeapSort(salaries);

            Console.WriteLine("Sorted Salary Demands:");
            Console.WriteLine(string.Join(", ", salaries));
        }
    }
}
