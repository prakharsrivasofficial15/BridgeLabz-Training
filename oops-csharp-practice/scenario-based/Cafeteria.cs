using System;

namespace BridgeLabz_Scenario
{
    internal class Cafeteria
    {
        //string array for food items available in the menu
        static string[] items =
        {"Dosa", "Burger", "Hakka Noodles", "Pav Bhaji", "Momos", "Aloo Paratha", "Samosa", "Pizza", "Chole Bhatura", "Rajma Chawal", "Cold Drinks"};

        //prices array
        static int[] prices = { 80, 50, 55, 45, 40, 65, 15, 150, 90, 85, 20 };

        //total price
        static int total = 0;

        //main method
        static void Main(string[] args)
        {
            Display();
        }


        //displays method for the choice selection
        static void Display()
        {
            while (true)
            {
                Console.WriteLine("---Menu---");
                Console.WriteLine("1. Order items from menu");
                Console.WriteLine("2. Total for the order");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice: ");
                if(!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number");
                    continue;
                }


                //controller based
                switch (choice)
                {
                    case 1:
                        OrderFood();
                        break;

                    case 2:
                        TotalAmount();
                        break;

                    case 3:
                        Console.WriteLine("Exit...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        //method which controls the food ordered and total billing amount
        static void OrderFood()
        {
            while (true)
            {
                Console.WriteLine("\nAvailable Items:");
                for (int i = 0; i < items.Length; i++)
                {
                    Console.WriteLine((i + 1)+". " + items[i]+" - ₹"+prices[i]);
                }

                Console.Write("Enter item number to order: ");
                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                int index = choice - 1;

                if (index < 0 || index >= items.Length)
                {
                    Console.WriteLine("Invalid item number.");
                    continue;
                }

                Console.Write("Enter quantity: ");
                if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity.");
                    continue;
                }

                total += prices[index] * quantity;
                Console.WriteLine($"{quantity} x {items[index]} added to cart.");

                Console.Write("Do you want to order more items? (y/n): ");
                string option = Console.ReadLine().ToLower();

                if (option != "y")
                    break;
            }
        }

        static void TotalAmount()
        {
            Console.WriteLine("\nTotal Amount: ₹" + total);
        }
    }
}
