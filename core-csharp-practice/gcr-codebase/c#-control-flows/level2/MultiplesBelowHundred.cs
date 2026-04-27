using System;

class MultiplesBelowHundred{
    static void Main(string[] args){
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
		
		if (number == 0){
            Console.WriteLine("Cannot find multiples of zero.");
            return;
        }
		
        for (int i = 100; i >= 1; i--){
            if (i % number == 0){
                Console.WriteLine(i);
            }
        }
    }
}
