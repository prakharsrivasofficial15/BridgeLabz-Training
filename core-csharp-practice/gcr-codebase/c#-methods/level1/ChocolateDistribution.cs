using System;

class ChocolateDistribution{
    static void Main(string[] args){
	
        //user input
        Console.Write("Enter the number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());

        // Calling method
        int[] result = FindRemainderAndQuotient(numberOfChocolates, numberOfChildren);

        Console.WriteLine("Each child gets: " + result[0]);
        Console.WriteLine("Remaining chocolates: " + result[1]);
    }

    // Method
    public static int[] FindRemainderAndQuotient(int number, int divisor){
        int chocolatesPerChild = number / divisor;
        int remainingChocolates = number % divisor;

        return new int[] { chocolatesPerChild, remainingChocolates };
    }
}
