using System;

class ReversedTemp{
    static void Main(string[] args){
        double fahrenheit = double.Parse(Console.ReadLine());

        double celcius = (fahrenheit - 32) * 5 / 9;

        Console.WriteLine("The temperature in celcius: " + celcius);
    }
}
