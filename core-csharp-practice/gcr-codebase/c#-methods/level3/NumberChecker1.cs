using System;

class NumberChecker1{
    static void Main(string[] args){
		
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Count digits
        int count = CountDigits(number);
        Console.WriteLine("Number of digits: " + count);

        // Store digits in array
        int[] digits = StoreDigits(number, count);

        Console.WriteLine("Digits of the number:");
        for (int i = 0; i < digits.Length; i++){
            Console.Write(digits[i] + " ");
        }
        Console.WriteLine();

        // Duck number check
        Console.WriteLine("Is Duck Number: " + IsDuckNumber(digits));

        // Armstrong number check
        Console.WriteLine("Is Armstrong Number: " + IsArmstrongNumber(digits));

        // Largest and second largest
        int[] large = FindLargestAndSecondLargest(digits);
        Console.WriteLine("Largest digit: " + large[0]);
        Console.WriteLine("Second Largest digit: " + large[1]);

        // Smallest and second smallest
        int[] small = FindSmallestAndSecondSmallest(digits);
        Console.WriteLine("Smallest digit: " + small[0]);
        Console.WriteLine("Second Smallest digit: " + small[1]);
    }

    //count digits
    public static int CountDigits(int number){
        int count = 0;
        while (number != 0){
            count++;
            number /= 10;
        }
        return count;
    }

    //store digits in array
    public static int[] StoreDigits(int number, int count){
        int[] digits = new int[count];
        int index = 0;

        while (number != 0){
            digits[index] = number % 10;
            index++;
            number /= 10;
        }
        return digits;
    }

    //Duck number check
    public static bool IsDuckNumber(int[] digits){
        for(int i = 0; i < digits.Length; i++){
            if(digits[i] != 0){
                return true;
			}
        }
        return false;
    }

    //Armstrong number check
    public static bool IsArmstrongNumber(int[] digits){
        int power = digits.Length;
        int sum = 0;

        for(int i = 0; i < digits.Length; i++){
            sum += (int)Math.Pow(digits[i], power);
        }

        int original = 0;
        for(int i = digits.Length - 1; i >= 0; i--){
            original = original * 10 + digits[i];
        }

        return sum == original;
    }

    //largest and second largest
    public static int[] FindLargestAndSecondLargest(int[] digits){
        int largest = Int32.MinValue;
        int secondLargest = Int32.MinValue;

        for(int i = 0; i < digits.Length; i++){
            if(digits[i] > largest){
                secondLargest = largest;
                largest = digits[i];
            }
            else if(digits[i] > secondLargest && digits[i] != largest){
                secondLargest = digits[i];
            }
        }

        return new int[] { largest, secondLargest };
    }

    //smallest and second smallest
    public static int[] FindSmallestAndSecondSmallest(int[] digits){
        int smallest = Int32.MaxValue;
        int secondSmallest = Int32.MaxValue;

        for(int i = 0; i < digits.Length; i++){
            if(digits[i] < smallest){
                secondSmallest = smallest;
                smallest = digits[i];
            }
            else if(digits[i] < secondSmallest && digits[i] != smallest){
                secondSmallest = digits[i];
            }
        }

        return new int[] { smallest, secondSmallest };
    }
}
