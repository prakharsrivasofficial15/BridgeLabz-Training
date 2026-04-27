using System;

class PositiveNegativeZero{
    static void Main(string[] args){
	
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (n > 0){
            Console.WriteLine("positive");
        }
        else if (n < 0){
            Console.WriteLine("negative");
        }
        else{
            Console.WriteLine("zero");
        }
    }
}
