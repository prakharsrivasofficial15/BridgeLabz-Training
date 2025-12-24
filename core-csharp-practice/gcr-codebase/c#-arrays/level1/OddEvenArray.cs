using System;

class OddEvenArray{
    static void Main(string[] args){
	
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        // Check for the natural number
        if (number <= 0){
            Console.WriteLine("enter a natural number");
            return;
        }

        int[] oddArray = new int[n / 2 + 1];
        int[] evenArray = new int[n / 2 + 1];

        int oddCount = 0;
        int evenCount = 0;

        for (int i=1; i<= n; i++){
            if (i % 2 == 0){
                evenArray[evenCount] = i;
                evenCount++;
            }
            else{
                oddArray[oddCount] = i;
                oddCount++;
            }
        }

        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oddCount; i++){
            Console.Write(oddNumbers[i] + " ");
        }

        Console.WriteLine("Even Numbers:");
        for (int i = 0; i < evenCount; i++){
            Console.Write(evenNumbers[i] + " ");
        }
    }
}
