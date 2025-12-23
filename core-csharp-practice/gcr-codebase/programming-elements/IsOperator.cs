using System;

class IsOperator{
	static void Main(String[] args){
		object n = 10;

		if (n is int)
		{
			Console.WriteLine("n is int");
		}
	}
}