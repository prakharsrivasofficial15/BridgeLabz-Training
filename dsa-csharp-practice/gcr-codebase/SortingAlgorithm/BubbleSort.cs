using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class BubbleSort
    {
        static void Sort(int[] marks)
        {
            int n = marks.Length;
            bool swapped;              //fllag to check if happened or not

            for (int i = 0; i < n - 1; i++)
            {
                swapped = false;           //
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (marks[j] > marks[j + 1])
                    {
                        int temp = marks[j];
                        marks[j] = marks[j + 1];
                        marks[j + 1] = temp;
                        swapped = true;         //swap done succesfully
                    }
                }

                if (!swapped)
                    break;
            }
        }

        static void Main()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[] marks = new int[n];

            for (int i = 0; i < n; i++)
            {
                marks[i] = int.Parse(Console.ReadLine());
            }
            //method call
            Sort(marks);

            Console.WriteLine("Sorted Student Marks:");
            Console.WriteLine(string.Join(", ", marks));
        }
    }
}
