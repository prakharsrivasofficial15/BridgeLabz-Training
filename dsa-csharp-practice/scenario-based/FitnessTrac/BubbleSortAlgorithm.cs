using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrac
{
    class BubbleSortAlgorithm
    {
        public void Sort(User[] arr, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;

                for (int j = 0; j < n - i - 1; j++)
                {
                    //compare steps of two users
                    if (arr[j].GetSteps() < arr[j + 1].GetSteps()) 
                    {
                        Swap(arr, j, j + 1);
                        swapped = true;
                    }
                }

                if (!swapped) break;
            }
        }
        //method to swap two users in the array
        private void Swap(User[] arr, int i, int j)
        {
            User temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }

}
