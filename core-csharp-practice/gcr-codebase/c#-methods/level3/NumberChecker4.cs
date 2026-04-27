using System;

class NumberChecker4{
    static void Main(string[] args){
	
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Is Prime Number: " + IsPrime(number));
        Console.WriteLine("Is Neon Number: " + IsNeon(number));
        Console.WriteLine("Is Spy Number: " + IsSpy(number));
        Console.WriteLine("Is Automorphic Number: " + IsAutomorphic(number));
        Console.WriteLine("Is Buzz Number: " + IsBuzz(number));
    }

    //Check if number is prime
    public static bool IsPrime(int number){
        if(number <= 1){
            return false;
		}
        for(int i = 2; i <= number / 2; i++){
            if(number % i == 0){
                return false;
			}
        }
        return true;
    }

    //Check if number is neon
    public static bool IsNeon(int number){
        int square = number * number;
        int sum = 0;

        while(square != 0){
            sum += square % 10;
            square /= 10;
        }
        return sum == number;
    }

    //Check if number is spy
    public static bool IsSpy(int number){
        int sum = 0;
        int product = 1;
        int temp = number;

        while(temp != 0){
            int digit = temp % 10;
            sum += digit;
            product *= digit;
            temp /= 10;
        }
        return sum == product;
    }

    //Check if number is automorphic
    public static bool IsAutomorphic(int number){
        int square = number * number;

        while(number != 0){
            if(number % 10 != square % 10){
                return false;
			}
            number /= 10;
            square /= 10;
        }
        return true;
    }

    //Check if number is buzz
    public static bool IsBuzz(int number){
        return (number % 7 == 0) || (number % 10 == 7);
    }
}
