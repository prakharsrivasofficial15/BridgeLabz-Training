using System;

class Volume{
	static void Main(string[] args){
		
		int earthRadius = 6378;
		
		//1 km = 1.6 miles
		
		double volume = (4.0/3.0)*3.14*Math.Pow(earthRadius, 3);
		double volumeInMiles = volume * Math.Pow(0.621371, 3);
		
		Console.WriteLine("Volume of earth in cubic kilometers: " + volume);
		Console.WriteLine("Volume of earth in cubic miles: " + volumeInMiles);
	}
}
