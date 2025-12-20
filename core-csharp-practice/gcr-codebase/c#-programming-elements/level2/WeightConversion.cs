using System;

class WeightConversion{
	static void Main(string[] args){
		
		// 1 pound = 2.2 kg
		
		double weight = double.Parse(Console.ReadLine());  //in pounds
		
		double weightInKg = weight*2.2;
		
		Console.WriteLine("The Weight of the person in Kg is: " + weightInKg);
	}
}

		
		