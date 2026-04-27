using System;

class SwapNumbers{
    static void Main(string[] args){
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int temp = num1;
        num1 = num2;
        num2 = temp;

        Console.WriteLine("The swapped numbers: " + num1 + " and " + num2);
    }
}
