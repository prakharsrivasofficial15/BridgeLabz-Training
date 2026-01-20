using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AadharNumbers
{
    internal class BinarySearch
    {
        public static int Search(Aadhar[] arr, int n, long key)
        {
            int low = 0, high = n - 1;

            while (low <= high)
            {
                int mid = (low + high) / 2;
                long midVal = arr[mid].getAadharNumber();

                if (midVal == key) return mid;
                else if (midVal < key) low = mid + 1;
                else high = mid - 1;
            }
            return -1;
        }
    }
}

