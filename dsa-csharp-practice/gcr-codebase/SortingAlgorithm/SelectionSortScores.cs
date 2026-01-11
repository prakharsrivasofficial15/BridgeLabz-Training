using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    internal class SelectionSortScores
    {
        static void SelectionSort(int[] scores)
        {
            int n = scores.Length;

            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;

                //find the smallest element in the unsorted part
                for (int j = i + 1; j < n; j++)
                {
                    if (scores[j] < scores[minIndex])
                    {
                        minIndex = j;
                    }
                }
                //swap the smallest element with the first element
                int temp = scores[i];
                scores[i] = scores[minIndex];
                scores[minIndex] = temp;
            }
        }


        static void Main()
        {
            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());

            int[] scores = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter exam score of student: ");
                scores[i] = int.Parse(Console.ReadLine());
            }

            SelectionSort(scores);

            Console.WriteLine("Sorted Exam Scores:");
            Console.WriteLine(string.Join(", ", scores));
        }
    }
}
