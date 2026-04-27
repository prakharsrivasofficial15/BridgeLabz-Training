using System;

class MultiplicationTable{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 6; i <= 9; i++)
        {
            Console.WriteLine(num + " * " + i + " = " + (num * i));
        }
    }
}
