using System;

class PowerCalculation
{
    static void Main(string[] args)
    {
        // Read the base value from the user
        double val = Convert.ToDouble(Console.ReadLine());
        // Read the exponent value from the user
        double exp = Convert.ToDouble(Console.ReadLine());
        // Calculate the power using Math.Pow(base, exponent)
        double r = Math.Pow(val, exp);
        Console.WriteLine(r);
    }
}
