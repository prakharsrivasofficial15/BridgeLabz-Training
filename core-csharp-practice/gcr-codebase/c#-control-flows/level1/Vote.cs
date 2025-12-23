using System;

class Vote{
    static void Main(string[] args){
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());
		
		// Check if the age is 18 or above
        if (age >= 18){
			//eligible
            Console.WriteLine("The person can vote.");
        }
        else{
			//non-eligible
            Console.WriteLine("The person cannot vote.");
        }
    }
}
