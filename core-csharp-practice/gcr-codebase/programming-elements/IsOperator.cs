using System;

class IsOperator{
	static void main(String[] args){
		object n = 10;

		if (n is int)
		{
			Console.WriteLine("n is int");
		}
	}
}