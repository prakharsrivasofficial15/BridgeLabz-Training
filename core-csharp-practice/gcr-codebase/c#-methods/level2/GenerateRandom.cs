using System;

class GenerateRandom{
    static void Main(string[] args){
        int size = 5;

        // Generate 5 random 4-digit numbers
        int[] numbers = Generate4DigitRandomArray(size);

        Console.WriteLine("4-digit random numbers:");
        for(int i = 0; i < numbers.Length; i++){
            Console.WriteLine(numbers[i]);
        }
        //method to find the average, min and max
        double[] result = FindAverageMinMax(numbers);

        Console.WriteLine("Average value: " + result[0]);
        Console.WriteLine("Minimum value: " + result[1]);
        Console.WriteLine("Maximum value: " + result[2]);
    }

    // Method to generate array of 4-digit random numbers
    public static int[] Generate4DigitRandomArray(int size){
        int[] arr = new int[size];
        Random random = new Random();

        for(int i = 0; i < size; i++){
            // Generates numbers between 1000 and 9999
            arr[i] = random.Next(1000, 10000);
        }
        return arr;
    }

    // Method to find average, minimum and maximum
    public static double[] FindAverageMinMax(int[] numbers){
        int min = numbers[0];
        int max = numbers[0];
        int sum = 0;

        for(int i = 0; i < numbers.Length; i++){
            sum += numbers[i];
            min = Math.Min(min, numbers[i]);
            max = Math.Max(max, numbers[i]);
        }
        double average = (double)sum / numbers.Length;

        return new double[] { average, min, max };
    }
}
