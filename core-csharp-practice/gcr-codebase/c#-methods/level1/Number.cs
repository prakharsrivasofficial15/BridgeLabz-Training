using System;

class Number{
    static void Main(string[] args){
	
        //user input
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        //method calling
        int result = CheckNumber(n);

        if (result == 1)
            Console.WriteLine("The number is positive.");
        else if (result == -1)
            Console.WriteLine("The number is negative.");
        else
            Console.WriteLine("The number is zero.");
    }

    // Method 
    static int CheckNumber(int num){
        if(num > 0){
            return 1;
		}
        else if(num < 0){
            return -1;
		}
        else{
            return 0;
		}
    }
}
