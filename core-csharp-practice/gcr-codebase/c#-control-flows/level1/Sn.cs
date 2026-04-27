using System;

class Sn{
    static void Main(string[] args){
	
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());
		
		if (n > 0){
			//calculating sum of n natural numbers
			int sum = n * (n + 1) / 2;
            Console.WriteLine("The sum of natural numbers is: "+ sum);
        }
        else{
            Console.WriteLine($"The number is not a natural number");
        }
    }
}
