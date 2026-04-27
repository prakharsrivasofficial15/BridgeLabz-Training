using System;

class Program
{
    static void Main(string[] args)
    {
        // Declare variables to store the numbers and the sum
        int num1, num2, sum;

        Console.WriteLine("Enter the first number:");
        // Read the first number from the user and convert the string input to an integer
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        // Read the second number from the user and convert the string input to an integer
        num2 = Convert.ToInt32(Console.ReadLine());

        // Calculate the sum
        sum = num1 + num2;

        // Display the result
        Console.WriteLine($"The sum of {num1} and {num2} is: {sum}");
    }
}
