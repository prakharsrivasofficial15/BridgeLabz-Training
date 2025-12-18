using System;

class Area
{
    static void Main()
    {
        double radius = Convert.ToDouble(Console.ReadLine());
        double area = 3.14 * Math.Pow(radius, 2);

        Console.WriteLine(area);
    }
}
