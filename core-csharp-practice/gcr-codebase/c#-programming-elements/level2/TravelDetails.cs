using System;

class TravelDetails{
    static void Main(string[] args){
        string name = Console.ReadLine();
        string fromCity = Console.ReadLine();
        string viaCity = Console.ReadLine();
        string toCity = Console.ReadLine();

        double fromToVia = double.Parse(Console.ReadLine());
        double viaToFinal = double.Parse(Console.ReadLine());
        double timeTaken = double.Parse(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinal;
        double speed = totalDistance / timeTaken;

        Console.WriteLine("The results of the trip: " + totalDistance);
		Console.WriteLine("Total time taken: " + timeTaken);
		Console.WriteLine("Speed: " + speed);
    }
}
