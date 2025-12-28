using System;

class MaxOfThree{
    static int FindMax(int a, int b, int c){
        return Math.Max(a, Math.Max(b, c));
    }

    static void Main(){
        Console.Write("Enter three numbers: ");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        Console.WriteLine("Maximum: " + FindMax(a, b, c));
    }
}
