using System;

class Fac{
    static void Main(string[] args){
	
        Console.Write("Enter a natural number: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 0)
        {
            Console.WriteLine("Please enter a natural number.");
            return;
        }

        int factorial = 1;

        for (int i = 1; i <= num; i++)
        {
            factorial *= i;
        }

        Console.WriteLine("Factorial of number: " + factorial);
    }
}
