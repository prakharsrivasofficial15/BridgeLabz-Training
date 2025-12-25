using System;

class Factors{
    static void Main(string[] args){
	
        //user input
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        //static method to find factors
        int[] factors = FindFactors(number);

        // Display factors
        Console.WriteLine("Factors: ");
        for (int i = 0; i < factors.Length; i++){
            Console.Write(factors[i] + " ");
        }

        //sum of the factors
        int sum = FindSumOfFactors(factors);
		
		//product of the factors
        long product = FindProductOfFactors(factors);
		
		//sum of square of the factors
        double sumOfSquares = FindSumOfSquaresOfFactors(factors);

        Console.WriteLine("Sum of factors: " + sum);
        Console.WriteLine("Product of factors: " + product);
        Console.WriteLine("Sum of squares of factors: " + sumOfSquares);
    }

    //static method to find factors
    public static int[] FindFactors(int number){
        int count = 0;

        //count factors
        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                count++;
            }
        }

        int[] factors = new int[count];
        int index = 0;

        //store factors
        for (int i = 1; i <= number; i++){
            if (number % i == 0){
                factors[index] = i;
                index++;
            }
        }
        return factors;
    }

    //Method for sum of factors
    public static int FindSumOfFactors(int[] factors)
    {
        int sum = 0;
        for (int i = 0; i < factors.Length; i++)
        {
            sum += factors[i];
        }
        return sum;
    }

    //Method for the product of factors
    public static long FindProductOfFactors(int[] factors){
        long product = 1;
        for (int i = 0; i < factors.Length; i++){
            product *= factors[i];
        }
        return product;
    }

    // Method for the sum of squares of factors
    public static double FindSumOfSquaresOfFactors(int[] factors){
        double sumOfSquares = 0;
        for (int i = 0; i < factors.Length; i++){
            sumOfSquares += Math.Pow(factors[i], 2);
        }
        return sumOfSquares;
    }
}
