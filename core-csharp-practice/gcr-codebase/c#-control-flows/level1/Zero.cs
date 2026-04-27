using System;

class Zero{
    static void Main(string[] args){
	
        double total = 0.0;
        double n;

        Console.Write("Enter a number: ");
        n = double.Parse(Console.ReadLine());

        while (n != 0)
        {
            total += n;
			
			// Ask the user to enter another number
            Console.Write("Enter a number: ");
            n = double.Parse(Console.ReadLine());
        }

        Console.WriteLine("Total sum: "+ total);
    }
}
