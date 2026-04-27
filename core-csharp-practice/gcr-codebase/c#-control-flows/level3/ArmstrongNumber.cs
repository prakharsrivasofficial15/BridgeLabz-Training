using System;

class ArmstrongNumber{
    static void Main(string[] args){
	
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (originalNumber != 0){
            int remainder = originalNumber % 10;
            sum += remainder * remainder * remainder;
            originalNumber = originalNumber / 10;
        }

        if (sum == number){
            Console.WriteLine("number is an Armstrong Number");
        }
        else{
            Console.WriteLine("number is not an Armstrong Number");
        }
    }
}
