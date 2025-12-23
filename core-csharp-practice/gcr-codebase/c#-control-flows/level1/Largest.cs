using System;

class Largest{
    static void Main(string[] args){

        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int number3 = int.Parse(Console.ReadLine());
		
		// Check for the first largest number
        bool firstLargest = number1 > number2 && number1 > number3;
		Console.WriteLine("first largest number: " + firstLargest);
		
		// Check for the second largest number
        bool secondLargest = number2 > number1 && number2 > number3;
		Console.WriteLine("second largest number: " + secondLargest);
		
		// Check for the third largest number
        bool thirdLargest = number3 > number1 && number3 > number2;
		Console.WriteLine("third largest number: " + thirdLargest);

    }
}
