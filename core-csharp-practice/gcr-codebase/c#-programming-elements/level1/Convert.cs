using System;

class Convert{
	static void Main(string[] args){
		
		Console.Write("Enter distance in kilometers: ");
        int km = int.Parse(Console.ReadLine());

        // 1 km = 0.625 miles (approx)
        double miles = km * 0.625;

        Console.WriteLine("The total miles: " + miles);
		
	}
}

