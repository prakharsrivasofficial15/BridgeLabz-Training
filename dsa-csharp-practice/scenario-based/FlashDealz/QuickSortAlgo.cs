using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashDealz
{
    class QuickSortAlgorithm
    {
        public void QuickSort(Product[] arr, int low, int high)
        {
            if (low < high)
            {
                int p = Partition(arr, low, high);
                QuickSort(arr, low, p - 1);
                QuickSort(arr, p + 1, high);
            }
        }

        private int Partition(Product[] arr, int low, int high)
        {
            int pivot = arr[high].GetDiscount();
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (arr[j].GetDiscount() > pivot) 
                {
                    i++;
                    Swap(arr, i, j);
                }
            }

            Swap(arr, i + 1, high);
            return i + 1;
        }

        private void Swap(Product[] arr, int i, int j)
        {
            Product temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

}
