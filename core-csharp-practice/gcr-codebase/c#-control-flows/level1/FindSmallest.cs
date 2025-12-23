using System;

class FindSmallest{
    static void Main(string[] args){
        Console.Write("Enter first number: ");
        int number1 = int.Parse(Console.ReadLine());

        Console.Write("Enter second number: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.Write("Enter third number: ");
        int number3 = int.Parse(Console.ReadLine());

        if (number1 < number2 && number1 < number3)
        {
            Console.WriteLine("First number is the smallest");
        }
        else
        {
            Console.WriteLine("First number is not the smallest");
        }
    }
}
