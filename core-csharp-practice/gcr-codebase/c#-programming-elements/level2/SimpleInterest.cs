using System;

class SimpleInterest{
	static void Main(string[] args){
		
		double principal = double.Parse(Console.ReadLine());
		double rate = double.Parse(Console.ReadLine());
		double time = double.Parse(Console.ReadLine());
		
		double SI = (principal*rate*time)/100;
		
		Console.WriteLine("Simple Interest: " + SI);
	}
}

