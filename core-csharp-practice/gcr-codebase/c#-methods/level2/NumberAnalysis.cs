using System;

class NumberAnalysis{
    static void Main(string[] args){
		
        int[] numbers = new int[5];

        Console.WriteLine("Enter 5 numbers:");
        for (int i = 0; i < numbers.Length; i++){
            numbers[i] = int.Parse(Console.ReadLine());

            //check if positive or negative
            if (IsPositive(numbers[i])){
                //check even or odd
                if (IsEven(numbers[i]))
                    Console.WriteLine(numbers[i] + " is positive and even");
                else
                    Console.WriteLine(numbers[i] + " is positive and odd");
            }
            else
            {
                Console.WriteLine(numbers[i] + " is negative");
            }
        }

        // Compare first and last elements
        int comparisonResult = Compare(numbers[0], numbers[numbers.Length - 1]);

        Console.WriteLine("Compare first and last:");
        if (comparisonResult == 1)
            Console.WriteLine("First element is greater than last element");
        else if (comparisonResult == 0)
            Console.WriteLine("First and last elements are equal");
        else
            Console.WriteLine("First element is less than last element");
    }

    // Method to check if number is positive
    public static bool IsPositive(int number){
        return number >= 0;
    }

    // Method to check if number is even
    public static bool IsEven(int number){
        return number % 2 == 0;
    }

    // Method to compare two numbers
    public static int Compare(int number1, int number2){
        if(number1 > number2){
            return 1;
		}
        else if(number1 == number2){
            return 0;
		}
        else{
            return -1;
		}
    }
}
