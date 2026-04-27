using System;

class Athlete{
    static void Main(string[] args){
        int side1 = int.Parse(Console.ReadLine());
        int side2 = int.Parse(Console.ReadLine());
        int side3 = int.Parse(Console.ReadLine());

        int perimeter = side1 + side2 + side3;
        double distance = 5000; // meters

        double rounds = distance / perimeter;

        Console.WriteLine("The total number of rounds the athlete will run is " + rounds);
    }
}
