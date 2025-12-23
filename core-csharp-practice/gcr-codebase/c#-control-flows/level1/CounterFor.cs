using System;

class CounterFor{
    static void Main(string[] args){
	
        Console.Write("Enter countdown start number: ");
        int counter = int.Parse(Console.ReadLine());

        for (int i = counter; i >= 1; i--){
            Console.WriteLine(i);
        }
		
    }
}
