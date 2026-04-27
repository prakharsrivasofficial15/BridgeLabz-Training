using System;

class Solution{
    static void Main(string[] args){
	
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());

        int quotient = number1 / number2;
        int remainder = number1 % number2;

        Console.WriteLine("The Quotient and Remainder is of two numbers are: " + quotient + " and " + remainder);
    }
}
