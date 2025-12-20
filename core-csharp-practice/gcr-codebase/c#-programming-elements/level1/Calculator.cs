using System;

class Calculator{
	static void Main(string[] args){
		
		Console.Write("Input for number 1: ");
		int number1 = int.Parse(Console.ReadLine());
		
		Console.Write("Input for number 2: ");
		int number2 = int.Parse(Console.ReadLine());
		
		int addition = number1 + number2;
		int subtraction = number1 - number2;
		int multiplication = number1 * number2;
		int division = number1 / number2;
		
		Console.WriteLine("The addition, subtraction, multiplication and division value of 2 numbers: " + addition + ", "+ subtraction +", "+multiplication+"and "+division);
		
	}
}

