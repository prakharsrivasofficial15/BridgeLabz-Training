//find the subset sum

using System;
public class SubsetSum{
    public static int[] subset(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    return new int[] { arr[i], arr[j] };
                }
            }
        }
        return new int[0];
    }

    public static void Main(string[] args){
        Console.WriteLine("Enter the length of array: ");
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Console.WriteLine("Input array");
        for(int i=0; i<n; i++){
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Enter target sum: ");
        int target = int.Parse(Console.ReadLine());

        int[] newArr = subset(arr, target);

        if (newArr.Length == 0) {
            Console.WriteLine("No subsets");
        } else {
            Console.Write("Subset found: ");
            for (int i = 0; i < newArr.Length; i++) {
                Console.Write(newArr[i] +  " ");
            }
            Console.WriteLine();
        }
    }
}