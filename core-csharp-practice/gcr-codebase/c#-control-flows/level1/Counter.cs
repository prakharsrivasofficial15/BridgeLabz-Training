using System;

class Counter{
    static void Main(string[] args){
	
        Console.Write("Enter countdown start number: ");
        int counter = int.Parse(Console.ReadLine());

        while (counter >= 1){
            Console.WriteLine(counter);
            counter--;
        }
    }
}
