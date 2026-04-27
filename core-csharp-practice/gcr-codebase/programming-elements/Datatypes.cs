using System;

class Datatypes{
	static void main(String[] args){
		
		//implicit type conversion
		int x = 10;
		double y = x;
		Console.WriteLine(y); // 10
		
		//explicit type conversion(manual)
		double d = 10.75;
		int i = (int)d;   // explicit conversion

		Console.WriteLine(i); // 10

		//Explicit Conversion Using Methods
		string s = "123";
		int n = Convert.ToInt32(s);
		Console.WriteLine(n); // 123
		
		//TryParse (Safest)
		int n;
		bool success = int.TryParse("789", out n);
		Console.WriteLine(n); // 789

		float f = 5;

		Console.WriteLine(f);                 // 5
		Console.WriteLine(f.ToString("F1"));  // 5.0

	}

}