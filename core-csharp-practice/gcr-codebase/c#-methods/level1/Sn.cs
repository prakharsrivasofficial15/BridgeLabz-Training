using System;

class Sn{
    static void Main(string[] args){
	
        //user input
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        // Calling method
        int sum = CalculateSum(n);

        Console.WriteLine("The sum of first " + n + " natural numbers is " + sum);
    }

    // Method 
    static int CalculateSum(int n){
        int sum = 0;
        for (int i = 1; i <= n; i++){
            sum += i;
        }
        return sum;
    }
}
