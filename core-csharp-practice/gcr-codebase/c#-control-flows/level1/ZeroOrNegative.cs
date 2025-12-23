using System;

class ZeroOrNegative{
    static void Main(string[] args){
	
        double total = 0.0;

        while (true){
		
			//0 or negative to stop
            Console.Write("Enter a number: ");
            double number = double.Parse(Console.ReadLine());

            if (number <= 0)
            {
                break;
            }

            total += number;
        }

        Console.WriteLine("Total sum: " + total);
    }
}
