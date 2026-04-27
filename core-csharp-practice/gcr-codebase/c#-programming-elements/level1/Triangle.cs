using System;

class Triangle{
	static void Main(string[] args){
			
		Console.Write("Enter the height(centimeters): ");
		double height = double.Parse(Console.ReadLine());
		
		Console.Write("Enter the breadth(centimeters): ");
		double breadth = double.Parse(Console.ReadLine());
		
		//Area in square inches=Area in cm2×0.155
		//1 inch = 2.54 cm
		
		double Area = (0.5 * breadth * height);
		
		Console.WriteLine("Area of triangle in cm square: " +Area);
		Console.WriteLine("Area of triangle in square inches: "+ (Area*0.155));
	}
}
