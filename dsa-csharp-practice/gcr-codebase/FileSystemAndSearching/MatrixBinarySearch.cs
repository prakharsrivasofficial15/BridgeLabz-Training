using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Binary Search Problem 3: Search for a Target Value in a 2D Sorted Matrix
Problem: You are given a 2D matrix where each row is sorted in ascending order. Write a program that performs Binary Search to find a target value in the matrix. 
*/

namespace Linear__and_Binary_Search
{
    class MatrixBinarySearch
    {
        static void Main(string[] args)
        {
            Console.Write("Enter rows: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Enter columns: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter matrix elements:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }
            }

            Console.Write("Enter target value: ");
            int target = int.Parse(Console.ReadLine());

            Console.WriteLine(SearchMatrix(matrix, target)? "Target found" : "Target not found");
        }

        static bool SearchMatrix(int[,] matrix, int target)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);

            int left = 0, right = rows * cols - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                int value = matrix[mid / cols, mid % cols];

                if (value == target)
                {
                    return true;
                }
                else if (value < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return false;
        }
    }
}
