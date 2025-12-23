using System;

class Compare{
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

        // While loop calculation
        int loopSum = 0;
        int i = 1;

        while (i <= n)
        {
            loopSum += i;
            i++;
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
