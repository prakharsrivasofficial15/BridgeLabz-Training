using System;

class DistanceConversion
{
    static void Main()
    {
        Console.Write("Enter distance in feet: ");
        double distanceInFeet = double.Parse(Console.ReadLine());

        double yards = distanceInFeet / 3;
        double miles = yards / 1760;

        Console.WriteLine("Distance in yards: " + yards);
        Console.WriteLine("Distance in miles: " + miles);
    }
}
