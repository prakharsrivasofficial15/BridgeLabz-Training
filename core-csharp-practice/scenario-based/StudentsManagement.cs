using System;

class StudentsManagement
{
    static void Main(string[] args)
    {
        int n = 0;

        int n = 0;

        // Input number of students
        while (true)
        {
            Console.Write("Enter number of students: ");
            try
            {
                n = int.Parse(Console.ReadLine());

                if (n > 0)
                    break;
                else
                    Console.WriteLine("Please enter a positive number.");
            }
            catch
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }
        }

        int[] scores = new int[n];

        // Input scores
        for (int i = 0; i < n; i++)
        {
            while (true)
            {
                Console.Write("Enter score for student " + (i + 1) + ": ");
                try
                {
                    scores[i] = int.Parse(Console.ReadLine());

                    if (scores[i] >= 0)
                        break;
                    else
                        Console.WriteLine("Score must be non-negative.");
                }
                catch
                {
                    Console.WriteLine("Invalid score. Please enter a number.");
                }
            }
        }


        while (true)
        {
            Console.WriteLine("1. Average score");
            Console.WriteLine("2. Highest score");
            Console.WriteLine("3. Lowest score");
            Console.WriteLine("4. Scores above average");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");

            string choiceInput = Console.ReadLine();
            int choice;

            if (!int.TryParse(choiceInput, out choice))
            {
                Console.WriteLine("Invalid choice.");
                continue;
            }

            if (choice == 1)
            {
                double avg = AverageScore(scores);
                Console.WriteLine("Average score: " + avg);
            }
            else if (choice == 2)
            {
                Console.WriteLine("Highest score: " + MaxScore(scores));
            }
            else if (choice == 3)
            {
                Console.WriteLine("Lowest score: " + MinScore(scores));
            }
            else if (choice == 4)
            {
                ShowAboveAverage(scores);
            }
            else if (choice == 5)
            {
                Console.WriteLine("Exiting...");
                break;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }

    // Calculate average
    static double AverageScore(int[] scores)
    {
        int sum = 0;
        for (int i = 0; i < scores.Length; i++)
        {
            sum += scores[i];
        }
        return (double)sum / scores.Length;
    }

    // Find highest score
    static int MaxScore(int[] scores)
    {
        int max = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] > max)
                max = scores[i];
        }
        return max;
    }

    // Find lowest score
    static int MinScore(int[] scores)
    {
        int min = scores[0];
        for (int i = 1; i < scores.Length; i++)
        {
            if (scores[i] < min)
                min = scores[i];
        }
        return min;
    }

    // Display scores above average
    static void ShowAboveAverage(int[] scores)
    {
        double avg = AverageScore(scores);
        bool found = false;

        Console.WriteLine("Scores above average:");

        for (int i = 0; i < scores.Length; i++)
        {
            if (scores[i] > avg)
            {
                Console.WriteLine(scores[i]);
                found = true;
            }
        }

        if (!found)
            Console.WriteLine("None");
    }
}
