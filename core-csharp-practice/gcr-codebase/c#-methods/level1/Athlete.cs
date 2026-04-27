using System;

class Athlete{
    static void Main(string[] args){
        //user input
        Console.Write("Enter side 1 of the triangle (in meters): ");
        double side1 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2 of the triangle (in meters): ");
        double side2 = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3 of the triangle (in meters): ");
        double side3 = double.Parse(Console.ReadLine());

        //Total distance
        double totalDistance = 5000;

        double rounds = CalculateRounds(side1, side2, side3, totalDistance);

        Console.WriteLine("The athlete needs to complete " +rounds + " rounds to finish a 5 km run.");
    }

    // Method
    static double CalculateRounds(double a, double b, double c, double distance){
        //perimeter of park
        double perimeter = a + b + c;

        //number of rounds
        return distance / perimeter;
    }
}
