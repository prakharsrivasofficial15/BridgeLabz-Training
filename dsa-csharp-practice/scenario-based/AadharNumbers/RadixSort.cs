using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AadharNumbers
{
    internal class RadixSort
    {
        public static void Sort(Aadhar[] arr, int n)
        {
            long max = arr[0].getAadharNumber();

            for (int i = 1; i < n; i++)
                if (arr[i].getAadharNumber() > max)
                    max = arr[i].getAadharNumber();

            for (long exp = 1; max / exp > 0; exp *= 10)
                CountingSort(arr, n, exp);
        }

        private static void CountingSort(Aadhar[] arr, int n, long exp)
        {
            Aadhar[] output = new Aadhar[n];
            int[] count = new int[10];

            for (int i = 0; i < n; i++)
                count[(arr[i].getAadharNumber() / exp) % 10]++;

            for (int i = 1; i < 10; i++)
                count[i] += count[i - 1];

            for (int i = n - 1; i >= 0; i--)
            {
                int idx = (int)((arr[i].getAadharNumber() / exp) % 10);
                output[count[idx] - 1] = arr[i];
                count[idx]--;
            }

            for (int i = 0; i < n; i++)
                arr[i] = output[i];
        }
    }
}
