using System; 

class CanvertKiloToMiles
{
    static void Main(string[] args)
    {
        // Read the distance in kilometers from the user
        double kilo = Convert.ToDouble(Console.ReadLine());

        double miles = kilo * 0.621371;
        Console.WriteLine(miles);
    }
}
