using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabz_Scenario
{
    internal class InvoiceGenerator
    {

        static string[] ParseInvoice(string input)
        {
            string[] tasks = input.Split(","); 
            return tasks;
        }

        static int GetTotalAmount(string[] tasks)
        {
            int total = 0;
            for (int i = 0; i < tasks.Length; i++)
            {
                string taskWithoutExtraSpace = tasks[i].Trim(); 

                string[] taskPartition = taskWithoutExtraSpace.Split(" - ");
                if (taskPartition.Length < 2)
                {
                    continue;
                }

                string[] ToGetTheAmountPart = taskPartition[1].Split(" ");

                if (int.TryParse(ToGetTheAmountPart[0], out int amount))
                {
                    total += amount;
                }


            }
            return total; 
        }
        static void Main()
        {
            //initialising the variables
            string input;
            string[] tasks = null;
            int total = 0;

            //Giving choice to the freelancer whether to create a invoice or generate total bill.
            Console.WriteLine("Invoice Generator Menu");
            while (true)
            {
                Console.WriteLine("");
                Console.WriteLine("Press 1 to create a new invoice");
                Console.WriteLine("Press 2 to Generate Total Bill");
                Console.WriteLine("Press 3 to exit this menu");

                if (!int.TryParse(Console.ReadLine(), out int choice))
                {
                    Console.WriteLine("Please enter a valid number.");
                    continue;
                }


                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter the services user wants to take with its price");
                        input = Console.ReadLine();
                        //calling methods
                        tasks = ParseInvoice(input);
                        total = GetTotalAmount(tasks);

                        continue;

                    case 2:
                        if (tasks == null)
                        {
                            Console.WriteLine("No invoice found. Please create an invoice first.");
                            continue;
                        }
                        //Generate total bill
                        Console.WriteLine("Services You have selected are: ");
                        for (int i = 0; i < tasks.Length; i++)
                        {
                            Console.WriteLine(tasks[i].Trim());
                        }
                        Console.WriteLine("Total amount in INR: " + total);
                        continue;
                        

                    case 3:
                        //exit
                        return;

                    default:
                        //if invalid choice
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}