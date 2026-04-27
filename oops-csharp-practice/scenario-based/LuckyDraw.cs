using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BridgeLabz_Scenario
{
    internal class LuckyDraw
    {
        static void Main(string[] args)
        {
            Display();
        }

        static void Display()
        {
            //for multiple visitors
            while (true)
            {
                Console.WriteLine("\nWelcome to the Lucky Draw");
                Console.WriteLine("1. Draw the number");
                Console.WriteLine("2. Quit");
                Console.Write("Enter your choice: ");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input! Please enter a number.");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter the number drawn: ");
                        if (!int.TryParse(Console.ReadLine(), out int number))
                        {
                            Console.WriteLine("Invalid number!");
                            continue;
                        }

                        if (number % 3 == 0 && number % 5 == 0)
                        {
                            Console.WriteLine("You won a gift!");
                        }
                        else
                        {
                            Console.WriteLine("Until next time");
                        }
                        break;

                    //Exit
                    case 2:
                        Console.WriteLine("End of Game");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        continue;
                }
            }
        }
    }
}
