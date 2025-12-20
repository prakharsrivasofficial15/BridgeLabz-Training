using System;

class TempConversion{
    static void Main(string[] args){
        double celcius = double.Parse(Console.ReadLine());

        double fahrenheit = (celcius * 9 / 5) + 32;

        Console.WriteLine("The temperature in fahrenheit: " + fahrenheit);
    }
}


