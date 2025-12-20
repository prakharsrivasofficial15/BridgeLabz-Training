using System;

class DoubleOperation{
    static void Main(string[] args){
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double Q1 = a + b * c;
        double Q2 = a * b + c;
        double Q3 = c + a / b;
        double Q4 = a % b + c;

        Console.WriteLine("The results of Double Operations are: " + Q1 + ", " + Q2 + ", " +Q3 + ", and " + Q4);
    }
}
