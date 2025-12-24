using System;

class Frequency{
    static void Main(string[] args){
	
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int temp = number;
        int count = 0;

        while (temp != 0){   //count digits in number
            count++;
            temp /= 10;
        }

        int[] digits = new int[count];
        int index = 0;

        // Store digits in array
        while (number != 0){
            digits[index] = number % 10;
            index++;
            number /= 10;
        }

        // Frequency array for digits 0–9
        int[] frequency = new int[10];

        for (int i = 0; i < digits.Length; i++){
            frequency[digits[i]]++;
        }
		
		for (int i = 0; i < 10; i++){
			if (frequency[i] > 0)
				Console.WriteLine(i + ": " + frequency[i]);
		}

    }
}
