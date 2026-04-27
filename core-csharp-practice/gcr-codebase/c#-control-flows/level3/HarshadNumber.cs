using System;

class HarshadNumber{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (number != 0){
            sum += number % 10;
            number = number / 10;
        }

        if (originalNumber % sum == 0){
            Console.WriteLine("Harshad Number");
        }
        else{
            Console.WriteLine("Not a Harshad Number");
        }
    }
}
