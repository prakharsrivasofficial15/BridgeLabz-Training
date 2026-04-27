using System;

class SimpleInterest
{
    static void Main(string[] args)
    {
        // Read the principal amount from the user
        double p = Convert.ToDouble(Console.ReadLine());
        // Read the rate of interest from the user
        double rate = Convert.ToDouble(Console.ReadLine());
        // Read the time period from the user
        double t = Convert.ToDouble(Console.ReadLine());
        // Calculate simple interest using the formula: (P × R × T) / 100
        double SI = (p * rate * t) / 100;
        Console.WriteLine(SI);
    }
}
