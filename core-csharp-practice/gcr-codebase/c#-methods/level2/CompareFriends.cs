using System;

class CompareFriends{
    static void Main(string[] args){
	
        string[] names = { "Amar", "Akbar", "Anthony" };
        int[] ages = new int[3];
        int[] heights = new int[3];

        //user input
        for (int i = 0; i < 3; i++){

            Console.Write("Age: ");
            ages[i] = int.Parse(Console.ReadLine());

            Console.Write("Height: ");
            heights[i] = int.Parse(Console.ReadLine());
        }

        //find youngest and tallest
        int youngest = FindYoungest(ages);
        int tallest = FindTallest(heights);

        Console.WriteLine("Youngest friend: " + names[youngest]);

        Console.WriteLine("Tallest friend: " + names[tallest]);
    }

    //method to find youngest friend
    public static int FindYoungest(int[] ages){
        int min = 0;

        for(int i = 1; i < ages.Length; i++){
            if (ages[i] < ages[min]){
                min = i;
            }
        }
        return min;
    }

    //method to find tallest friend
    public static int FindTallest(int[] heights){
        int max = 0;

        for(int i = 1; i < heights.Length; i++){
            if (heights[i] > heights[max]){
                max = i;
            }
        }

        return max;
    }
}
