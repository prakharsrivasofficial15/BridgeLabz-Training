using System;

class DigitCount{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int count = 0;

        while (number != 0){
            number = number / 10;
            count++;
        }

        Console.WriteLine("Number of digits: " + count);
    }
}
