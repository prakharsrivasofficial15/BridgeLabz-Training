using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class QuickSortProduct
    {
        static void QuickSort(int[] prices, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = Partition(prices, low, high);

                //Sort elements before pivot
                QuickSort(prices, low, pivotIndex - 1);

                //Sort elements after pivot
                QuickSort(prices, pivotIndex + 1, high);
            }
        }

        static int Partition(int[] prices, int low, int high)
        {
            //pivot element
            int pivot = prices[high];

            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (prices[j] < pivot)
                {
                    i++;

                    //swap prices[i] and prices[j]
                    int temp = prices[i];
                    prices[i] = prices[j];
                    prices[j] = temp;
                }
            }

            //place pivot in correct position
            int tempPivot = prices[i + 1];
            prices[i + 1] = prices[high];
            prices[high] = tempPivot;

            return i + 1;
        }


        static void Main()
        {
            Console.Write("Enter number of products: ");
            int n = int.Parse(Console.ReadLine());

            int[] prices = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter price of product: ");
                prices[i] = int.Parse(Console.ReadLine());
            }
            //method czlling
            QuickSort(prices, 0, prices.Length - 1);

            Console.WriteLine("Sorted Product Prices:");
            Console.WriteLine(string.Join(", ", prices));
        }
    }
}
