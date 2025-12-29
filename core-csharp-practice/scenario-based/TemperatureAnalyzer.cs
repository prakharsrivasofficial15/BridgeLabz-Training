using System;

class TemperatureAnalyzer
{
    static void Main()
    {
        float[,] temperatures = new float[7, 24];
        int choice;

        InputTemperatures(temperatures);

        while (true)
        {
            Console.WriteLine("1. Find Hottest Day");
            Console.WriteLine("2. Find Coldest Day");
            Console.WriteLine("3. Average Temperature Per Day");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    FindHottestDay(temperatures);
                    break;

                case 2:
                    FindColdestDay(temperatures);
                    break;

                case 3:
                    AverageTemperaturePerDay(temperatures);
                    break;

                case 4:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
            if(choice == 4)
            {
                break;
            }

        }
    }

    //Input float 2D array
    static void InputTemperatures(float[,] temps)
    {
        for (int day = 0; day < 7; day++)
        {
            Console.WriteLine("Enter 24 temperatures for Day: " + (day + 1));
            for (int hour = 0; hour < 24; hour++)
            {
                temps[day, hour] = float.Parse(Console.ReadLine());
            }
        }
    }

    //Hottest Day
    static void FindHottestDay(float[,] temps)
    {
        int hottestDay = 0;
        float maxTemp = temps[0, 0];

        for (int day = 0; day < 7; day++)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                if (temps[day, hour] > maxTemp)
                {
                    maxTemp = temps[day, hour];
                    hottestDay = day;
                }
            }
        }

        Console.WriteLine("Hottest Day: " + (hottestDay + 1));
    }

    //Coldest Day
    static void FindColdestDay(float[,] temps)
    {
        int coldestDay = 0;
        float minTemp = temps[0, 0];

        for (int day = 0; day < 7; day++)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                if (temps[day, hour] < minTemp)
                {
                    minTemp = temps[day, hour];
                    coldestDay = day;
                }
            }
        }

        Console.WriteLine("Coldest Day: " + coldestDay + 1);
    }

    //Average Temperature Per Day
    static void AverageTemperaturePerDay(float[,] temps)
    {
        for (int day = 0; day < 7; day++)
        {
            float sum = 0;

            for (int hour = 0; hour < 24; hour++)
            {
                sum += temps[day, hour];
            }

            float average = sum / 24;
            Console.WriteLine("Day " + (day + 1) + " Average Temperature: " + average);
        }
    }
}
