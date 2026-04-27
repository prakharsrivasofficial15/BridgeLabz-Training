using System;

class Factors{
    static void Main(string[] args){
	
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        for (int i=1; i<=num; i++){
            if (num % i == 0){
			
                // If array is full, make it bigger
                if (index == maxFactor){
                    maxFactor = maxFactor * 2;
                    int[] extraArray = new int[maxFactor];

                    // Copy old factors into new array
                    for (int j=0; j<factors.Length; j++){
                        extraArray[j] = factors[j];
                    }

                    factors = extraArray;
                }

                // Store the factor
                factors[index] = i;
                index++;
            }
        }

        Console.WriteLine("Factors of " + num + ":");
        for (int i = 0; i < index; i++){
            Console.Write(factors[i] + " ");
        }
    }
}
