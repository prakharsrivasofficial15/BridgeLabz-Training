using System;

class IntOperation{
    static void Main(string[] args){
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        int Q1 = a + b * c;
        int Q2 = a * b + c;
        int Q3 = c + a / b;
        int Q4 = a % b + c;

        Console.WriteLine("The results of Int Operations are: " + Q1 + ", " + Q2 + ", " +Q3 + ", and " + Q4);
    }
}
