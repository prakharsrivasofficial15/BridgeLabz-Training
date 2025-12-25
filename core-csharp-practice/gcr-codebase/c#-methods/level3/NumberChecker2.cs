using System;

class NumberChecker2{
    static void Main(string[] args){
		
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        //count digits
        int count = CountDigits(number);
        Console.WriteLine("Number of digits: " + count);

        //store digits
        int[] digits = StoreDigits(number, count);

        Console.WriteLine("Digits of the number:");
        for(int i = 0; i < digits.Length; i++){
            Console.Write(digits[i] + " ");
        }
        Console.WriteLine();

        //sum of digits
        int sum = FindSumOfDigits(digits);
        Console.WriteLine("Sum of digits: " + sum);

        //sum of squares of digits
        double sumOfSquares = FindSumOfSquaresOfDigits(digits);
        Console.WriteLine("Sum of squares of digits: " + sumOfSquares);

        //harshad number check
        Console.WriteLine("Is Harshad Number: " + IsHarshadNumber(number, digits));

        //frequency of digits
        int[,] frequency = FindDigitFrequency(digits);

        Console.WriteLine("Digit Frequency:");
        for(int i = 0; i < frequency.GetLength(0); i++){
            if(frequency[i, 1] > 0){
                Console.WriteLine("Digit " + frequency[i, 0] +" occurs " + frequency[i, 1] + " time(s)");
            }
        }
    }

    //count digits
    public static int CountDigits(int number){
        int count = 0;
        while(number != 0){
            count++;
            number /= 10;
        }
        return count;
    }

    //store digits in array
    public static int[] StoreDigits(int number, int count){
        int[] digits = new int[count];
        int index = 0;

        while(number != 0){
            digits[index] = number % 10;
            index++;
            number /= 10;
        }
        return digits;
    }

    //sum of digits
    public static int FindSumOfDigits(int[] digits){
        int sum = 0;
        for(int i = 0; i < digits.Length; i++){
            sum += digits[i];
        }
        return sum;
    }

    //sum of squares of digits
    public static double FindSumOfSquaresOfDigits(int[] digits){
        double sum = 0;
        for(int i = 0; i < digits.Length; i++){
            sum += Math.Pow(digits[i], 2);
        }
        return sum;
    }

    //harshad number check
    public static bool IsHarshadNumber(int number, int[] digits){
        int sum = FindSumOfDigits(digits);
        return number % sum == 0;
    }

    //frequency of each digit using 2D array
    public static int[,] FindDigitFrequency(int[] digits){
        int[,] frequency = new int[10, 2];

        // Initialize digits column
        for(int i = 0; i < 10; i++){
            frequency[i, 0] = i;
            frequency[i, 1] = 0;
        }
        // Count frequency
        for(int i = 0; i < digits.Length; i++){
            frequency[digits[i], 1]++;
        }

        return frequency;
    }
}
