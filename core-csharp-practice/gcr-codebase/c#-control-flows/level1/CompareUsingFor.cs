using System;

class CompareUsingFor{
    static void Main(string[] args){
	
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        if (n <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        // Formula:
        int formulaSum = n * (n + 1) / 2;

        // For loop:
        int loopSum = 0;
        for (int i = 1; i <= n; i++)
        {
            loopSum += i;
        }

        Console.WriteLine("Sum using formula: " + formulaSum);
        Console.WriteLine("Sum using while loop: " + loopSum);

        if (formulaSum == loopSum){
            Console.WriteLine("Both are correct");
        }
        else{
            Console.WriteLine("Incorrect");
        }
    }
}
