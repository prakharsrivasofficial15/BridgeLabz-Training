using System;

class Area
{
    static void Main()
    {
        // Read the radius value from the user and convert it to double
        double rad = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the circle
        double ar = 3.14 * Math.Pow(rad, 2);

        Console.WriteLine(ar);
    }
}
