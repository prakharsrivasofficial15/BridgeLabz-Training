using System;

class Divisibility{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 5 == 0){
            Console.WriteLine("The number is divisible by 5: " + number);
        }else{
            Console.WriteLine("The number is not divisible by 5");
        }
    }
}
