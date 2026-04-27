using System;

class Factorial{
    static void Main(string[] args){
	
        Console.Write("Enter a positive integer: ");
        int num = int.Parse(Console.ReadLine());

        if (num < 0){
            Console.WriteLine("Please enter a positive integer.");
            return;
        }

        int factorial = 1;
        int i = 1;

        while (i <= num)
        {
            factorial *= i;
            i++;
        }

        Console.WriteLine("Factorial of number: " + factorial);
    }
}
