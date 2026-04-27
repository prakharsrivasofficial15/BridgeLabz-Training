using System;

class OddEven{
    static void Main(string[] args){
	
        Console.Write("Enter a natural number: ");
        int num = int.Parse(Console.ReadLine());

        if (num <= 0)
        {
            Console.WriteLine("Not a natural number");
            return;
        }

        for (int i = 1; i <= num; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine("Even: " + i);
            }
            else
            {
                Console.WriteLine("Odd: " + i);
            }
        }
    }
}
