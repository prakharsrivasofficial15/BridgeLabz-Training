using System;

class DoubleMaxDigit{
    static void Main(string[] args){
	
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int maxDigit = 10;
        int[] digits = new int[maxDigit];
        int index = 0;

        // Store digits of the number in the array
        while (number != 0)
        {
            // If array is full
            if (index == maxDigit){
				//increase its size by 10
                maxDigit = maxDigit + 10;
                int[] temp = new int[maxDigit];

                // Copy old digits to new array
                for (int i = 0; i < digits.Length; i++){
                    temp[i] = digits[i];
                }

                digits = temp;
            }

            digits[index] = number % 10;
            number = number / 10;
            index++;
        }

        int largest = 0;
        int secondLargest = 0;

        // Find largest and second largest digits
        for (int i = 0; i < index; i++){
            if (digits[i] > largest){
                secondLargest = largest;
                largest = digits[i];
            }
            else if (digits[i] > secondLargest && digits[i] != largest){
                secondLargest = digits[i];
            }
        }

        Console.WriteLine("Largest digit: " + largest);
        Console.WriteLine("Second largest digit: " + secondLargest);
    }
}
