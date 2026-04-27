using System;

class FootballTeamHeight{
    static void Main(string[] args){
        int teamSize = 11;
        int[] heights = new int[teamSize];

        Random random = new Random();

        //generating random heights between 150 cm and 250 cm
        for(int i = 0; i < heights.Length; i++){
            heights[i] = random.Next(150, 251);
        }

        Console.WriteLine("Heights of football players (in cm):");
        for(int i = 0; i < heights.Length; i++){
            Console.WriteLine("Player " + (i + 1) + ": " + heights[i]);
        }

        //calculating values using methods
        int sum = FindSum(heights);
        double mean = FindMeanHeight(heights);
        int shortest = FindShortestHeight(heights);
        int tallest = FindTallestHeight(heights);

        Console.WriteLine("Shortest Height: " + shortest + " cm");
        Console.WriteLine("Tallest Height: " + tallest + " cm");
        Console.WriteLine("Mean Height: " + mean + " cm");
    }

    //method to find sum of heights
    public static int FindSum(int[] heights){
        int sum = 0;
        for(int i = 0; i < heights.Length; i++){
            sum += heights[i];
        }
        return sum;
    }

    //method to find mean height
    public static double FindMeanHeight(int[] heights){
        int sum = FindSum(heights);
        return (double)sum / heights.Length;
    }

    //method to find shortest height
    public static int FindShortestHeight(int[] heights){
        int min = heights[0];
        for(int i = 1; i < heights.Length; i++){
            if (heights[i] < min){
                min = heights[i];
            }
        }
        return min;
    }

    //method to find tallest height
    public static int FindTallestHeight(int[] heights){
        int max = heights[0];
        for (int i = 1; i < heights.Length; i++){
            if (heights[i] > max){
                max = heights[i];
            }
        }
        return max;
    }
}
