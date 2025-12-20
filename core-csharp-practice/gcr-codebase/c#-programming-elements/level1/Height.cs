using System;

class Height{
	static void Main(string[] args){
		
		//1 foot = 12 inches
		//1 inch = 2.54 cm
		
		Console.Write("Enter the height(centimeters): ");
		double height = double.Parse(Console.ReadLine());
		
		double heightInInches = height/2.54;
		int feet = (int)(heightInInches / 12);
		double inches = heightInInches % 12;
		
		Console.WriteLine("height in centimeters: "+ height);
		Console.WriteLine("height in feet: "+ feet);
		Console.WriteLine("height in inches: "+ inches);
	}
}