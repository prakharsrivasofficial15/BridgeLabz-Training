using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario.Bird_Sanctuary
{
    internal class Program
    {
        static bool IsDuplicateId(Bird[] birds, int count, string id)
        {
            for (int i = 0; i < count; i++)
            {
                if (birds[i].Id == id)
                    return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            Bird[] birds = new Bird[10];
            int count = 0;

            while (true)
            {
                Console.WriteLine("\nBird Sanctuary Menu");
                Console.WriteLine("1. Add Bird");
                Console.WriteLine("2. Display All Birds");
                Console.WriteLine("3. Exit");

                Console.WriteLine("Enter your choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        if (count >= birds.Length)
                        {
                            Console.WriteLine("Sanctuary is full!");
                            break;
                        }
                        Console.WriteLine("Select Bird Type:");
                        Console.WriteLine("1. Eagle");
                        Console.WriteLine("2. Sparrow");
                        Console.WriteLine("3. Duck");
                        Console.WriteLine("4. Penguin");
                        Console.WriteLine("5. Seagull");

                        int type = int.Parse(Console.ReadLine());

                        Console.Write("Enter ID:");
                        string id = Console.ReadLine();

                        if (IsDuplicateId(birds, count, id))
                        {
                            Console.WriteLine("Error: Bird ID already exists.");
                            break;
                        }

                        Console.Write("Enter Food: ");
                        string food = Console.ReadLine();

                        Console.Write("Enter Date of Arrival: ");
                        string date = Console.ReadLine();

                        Console.Write("Is injured: ");
                        bool injured = bool.Parse(Console.ReadLine());

                        switch (type)
                        {
                            case 1:
                                birds[count++] = new Eagle(id, food, date, injured);
                                break;
                            case 2:
                                birds[count++] = new Sparrow(id, food, date, injured);
                                break;
                            case 3:
                                birds[count++] = new Duck(id, food, date, injured);
                                break;
                            case 4:
                                birds[count++] = new Penguin(id, food, date, injured);
                                break;
                            case 5:
                                birds[count++] = new Seagull(id, food, date, injured);
                                break;
                        }
                        break;

                    case 2:
                        for (int i = 0; i < count; i++)
                        {
                            birds[i].Display();

                            if (birds[i] is IFlyable)
                            {
                                ((IFlyable)birds[i]).Fly();
                            }

                            if (birds[i] is ISwimmable)
                            {
                                ((ISwimmable)birds[i]).Swim();
                            }

                            Console.WriteLine("------------------");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Exiting Program...");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
