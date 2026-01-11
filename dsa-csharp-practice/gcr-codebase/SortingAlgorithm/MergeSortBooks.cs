using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class MergeSortBooks
    {
        static void MergeSort(int[] prices, int left, int right)
        {
            if (left < right)
            {
                int mid = left + (right - left) / 2;    //middle index

                MergeSort(prices, left, mid);           //sort left half
                MergeSort(prices, mid + 1, right);      //sort right half
                Merge(prices, left, mid, right);        //merge
            }
        }

        static void Merge(int[] prices, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            //temp array
            int[] leftArr = new int[n1];
            int[] rightArr = new int[n2];

            //Copy data to leftArr
            for(int i = 0; i < n1; i++)
                leftArr[i] = prices[left + i];

            //Copy data to rightArr
            for(int j = 0; j < n2; j++)
                rightArr[j] = prices[mid + 1 + j];


            int iIndex = 0, jIndex = 0, k = left;

            //Merge the temp arrays
            while(iIndex < n1 && jIndex < n2)
            {
                if (leftArr[iIndex] <= rightArr[jIndex])
                    prices[k++] = leftArr[iIndex++];
                else
                    prices[k++] = rightArr[jIndex++];
            }

            //Copy remaining ele of leftArr
            while(iIndex < n1)
                prices[k++] = leftArr[iIndex++];

            //Copy remaining ele of rightArr
            while(jIndex < n2)
                prices[k++] = rightArr[jIndex++];
        
        }

        static void Main()
        {
            Console.Write("Enter number of books: ");
            int n = int.Parse(Console.ReadLine());

            int[] prices = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter price of book {i + 1}: ");
                prices[i] = int.Parse(Console.ReadLine());
            }

            MergeSort(prices, 0, prices.Length - 1);

            Console.WriteLine("Sorted Book Prices:");
            Console.WriteLine(string.Join(", ", prices));
        }
    }
}
