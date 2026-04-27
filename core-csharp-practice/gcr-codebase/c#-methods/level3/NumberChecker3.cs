using System;

class NumberChecker3{
    static void Main(string[] args){
		
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        //count digits
        int count = CountDigits(number);
        Console.WriteLine("Number of digits: " + count);

        //store digits
        int[] digits = StoreDigits(number, count);

        Console.WriteLine("Original digits:");
        PrintArray(digits);

        //reverse digits array
        int[] reversedDigits = ReverseArray(digits);

        Console.WriteLine("Reversed digits:");
        PrintArray(reversedDigits);

        //compare arrays
        bool arraysEqual = CompareArrays(digits, reversedDigits);
        Console.WriteLine("Are original and reversed arrays equal: " + arraysEqual);

        //palindrome check
        Console.WriteLine("Is Palindrome Number: " + IsPalindrome(digits));

        //duck number check
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));
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

    //reverse digits array
    public static int[] ReverseArray(int[] array){
        int[] reversed = new int[array.Length];

        for(int i = 0; i < array.Length; i++){
            reversed[i] = array[array.Length - 1 - i];
        }
        return reversed;
    }

    //compare two arrays
    public static bool CompareArrays(int[] arr1, int[] arr2){
        if(arr1.Length != arr2.Length){
            return false;
		}
        for(int i = 0; i < arr1.Length; i++){
            if (arr1[i] != arr2[i]){
                return false;
			}
        }
        return true;
    }

    //palindrome number check
    public static bool IsPalindrome(int[] digits){
        int[] reversed = ReverseArray(digits);
        return CompareArrays(digits, reversed);
    }

    //duck number check (has at least one non-zero digit)
    public static bool IsDuckNumber(int[] digits){
        for(int i = 0; i < digits.Length; i++){
            if(digits[i] != 0){
                return true;
			}
        }
        return false;
    }

    //print array
    public static void PrintArray(int[] array){
        for(int i = 0; i < array.Length; i++){
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}
