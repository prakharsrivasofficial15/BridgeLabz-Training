using System;

class TemperatureConversion {
    static void Main(String[] args){
        double celcius = Convert.ToDouble(Console.ReadLine());//taking input
        double fahrenheit = (cel * 9/5) + 32;//conversion
        Console.WriteLine(fahrenheit);//printing the converted output
    }
}
