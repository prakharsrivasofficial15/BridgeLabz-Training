using System;

class CompareSn{
    static void Main(string[] args){
	
        //user input
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        //check for natural number
        if (n <= 0){
            Console.WriteLine("enter a natural number");
            return;
        }

        //find sum using recursion
        int recursiveSum = FindSumUsingRecursion(n);

        //find sum using formula
        int formulaSum = FindSumUsingFormula(n);

        Console.WriteLine("Sum using recursion: " + recursiveSum);
        Console.WriteLine("Sum using formula: " + formulaSum);

        //compare
        if (recursiveSum == formulaSum){
            Console.WriteLine("results are equal");
        }
        else{
            Console.WriteLine("results are not equal");
        }
    }

    // Method to find sum using recursion
    public static int FindSumUsingRecursion(int n){
        if (n == 1){
            return 1;
		}
        else{
            return n + FindSumUsingRecursion(n - 1);
		}
    }

    // Method to find sum using formula
    public static int FindSumUsingFormula(int n){
        return n * (n + 1) / 2;
    }
}
