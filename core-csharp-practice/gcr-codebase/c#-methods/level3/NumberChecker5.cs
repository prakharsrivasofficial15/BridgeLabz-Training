using System;

class NumberChecker5{
    static void Main(string[] args){
		
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        //find factors
        int[] factors = FindFactors(number);

        Console.WriteLine("Factors of the number:");
        foreach(int f in factors)
            Console.Write(f + " ");
        Console.WriteLine();

        //greatest factor
        Console.WriteLine("Greatest Factor: " + FindGreatestFactor(factors));

        //sum of factors
        int sum = FindSumOfFactors(factors);
        Console.WriteLine("Sum of Factors: " + sum);

        //product of factors
        long product = FindProductOfFactors(factors);
        Console.WriteLine("Product of Factors: " + product);

        //product of cubes of factors
        double cubeProduct = FindProductOfCubesOfFactors(factors);
        Console.WriteLine("Product of Cubes of Factors: " + cubeProduct);

        //perfect number
        Console.WriteLine("Is Perfect Number: " + IsPerfectNumber(number));

        //abundant number
        Console.WriteLine("Is Abundant Number: " + IsAbundantNumber(number));

        //deficient number
        Console.WriteLine("Is Deficient Number: " + IsDeficientNumber(number));

        //strong number
        Console.WriteLine("Is Strong Number: " + IsStrongNumber(number));
    }

    //find factors
    public static int[] FindFactors(int number){
        int count = 0;

        for(int i = 1; i <= number; i++){
            if(number % i == 0){
                count++;
			}
        }

        int[] factors = new int[count];
        int index = 0;

        for(int i = 1; i <= number; i++){
            if(number % i == 0){
                factors[index] = i;
                index++;
            }
        }

        return factors;
    }

    //greatest factor
    public static int FindGreatestFactor(int[] factors){
        int max = factors[0];
        for(int i = 1; i < factors.Length; i++){
            if(factors[i] > max){
                max = factors[i];
			}
        }
        return max;
    }

    //Sum of factors
    public static int FindSumOfFactors(int[] factors){
        int sum = 0;
        foreach(int f in factors)
            sum += f;
        return sum;
    }

    //Product of factors
    public static long FindProductOfFactors(int[] factors){
        long product = 1;
        foreach(int f in factors)
            product *= f;
        return product;
    }

    //product of cubes of factors
    public static double FindProductOfCubesOfFactors(int[] factors){
        double product = 1;
        foreach (int f in factors)
            product *= Math.Pow(f, 3);
        return product;
    }

    //perfect number check
    public static bool IsPerfectNumber(int number){
        int sum = 0;
        for(int i = 1; i < number; i++){
            if (number % i == 0){
                sum += i;
			}
        }
        return sum == number;
    }

    //Abundant number check
    public static bool IsAbundantNumber(int number){
        int sum = 0;
        for(int i = 1; i < number; i++){
            if (number % i == 0){
                sum += i;
			}
        }
        return sum > number;
    }

    //Deficient number check
    public static bool IsDeficientNumber(int number){
        int sum = 0;
        for(int i = 1; i < number; i++){
            if (number % i == 0){
                sum += i;
			}
        }
        return sum < number;
    }

    //Strong number check
    public static bool IsStrongNumber(int number){
        int temp = number;
        int sum = 0;

        while(temp != 0){
            int digit = temp % 10;
            sum += Factorial(digit);
            temp /= 10;
        }
        return sum == number;
    }

    public static int Factorial(int n){
        int fact = 1;
        for(int i = 1; i <= n; i++)
            fact *= i;
        return fact;
    }
}
