using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario
    {
        internal class DistanceTravelled
        {
            //bus stops array
            static string[] stops = {"Stop A", "Stop B", "Stop C", "Stop D", "Stop E"};

            //distance array
            static int[] distances = { 2, 3, 4, 5, 6 };

            //total distance
            static int totalDistance = 0;

            static int currentStop = 0;

            static void Main(string[] args)
            {
                Display();
            }

            static void Display()
            {
                while (true)
                {
                    Console.WriteLine("\n--- Bus Distance Tracker ---");
                    Console.WriteLine("1. Travel to next stop");
                    Console.WriteLine("2. View total distance");
                    Console.WriteLine("3. Get off and exit");

                    Console.Write("Enter your choice: ");
                    if (!int.TryParse(Console.ReadLine(), out int choice))
                    {
                        Console.WriteLine("Invalid input. Please enter a number.");
                        continue;
                    }

                    switch (choice)
                    {
                        case 1:
                            TravelNextStop();
                            break;

                        case 2:
                            ShowDistance();
                            break;

                        case 3:
                            Console.WriteLine("You got off the bus");
                            Console.WriteLine("Total Distance Travelled: " + totalDistance + " km");
                            return;

                        default:
                            Console.WriteLine("Invalid choice!");
                            break;
                    }
                }
            }

            //move bus to next stop
            static void TravelNextStop()
            {
                if (currentStop >= stops.Length)
                {
                    Console.WriteLine("You reached the final stop.");
                    return;
                }

                Console.WriteLine("\nBus reached: " + stops[currentStop]);
                totalDistance += distances[currentStop];
                Console.WriteLine("Distance added: " + distances[currentStop]);

                currentStop++;
            }

            //show total distance
            static void ShowDistance()
            {
                Console.WriteLine("\nTotal Distance Travelled: " + totalDistance);
            }
        }
    }
