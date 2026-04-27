using System;

class RemainderAndQuotient{
    static void Main(string[] args){
	
        //user input
        Console.Write("Enter the number: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Enter the divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        // Calling method
        int[] result = FindRemainderAndQuotient(number, divisor);

        Console.WriteLine("Quotient: " + result[0]);
        Console.WriteLine("Remainder: " + result[1]);
    }

    // Method
    public static int[] FindRemainderAndQuotient(int number, int divisor){
        int quotient = number / divisor;
        int remainder = number % divisor;

        return new int[] { quotient, remainder };
    }
}
