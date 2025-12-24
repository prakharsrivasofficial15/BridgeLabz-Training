using System;

class Football{
	static void Main(string[] args){
	
		double[] team = new double[11];
		double sum = 0.0;
		double avg = 0.0;
		
		for(int i=0; i<11; i++){
			team[i] = double.Parse(Console.ReadLine());
			sum += team[i];
		}
		
		avg = sum/11;
		
		Console.WriteLine("Mean height of players in football team: " + avg);
	}
}
		