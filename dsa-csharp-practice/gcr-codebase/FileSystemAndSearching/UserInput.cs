using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 2: Read User Input and Write to File Using StreamReader Problem: Write a program that reads user input from the console and writes it to a file.
*/

namespace Linear__and_Binary_Search
{
    class UserInput
    {
        static void Main(string[] args)
        {
            Console.Write("Enter output file path: ");
            string filePath = Console.ReadLine();

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    Console.WriteLine("Enter text 'exit' to stop:");

                    string line;
                    while ((line = Console.ReadLine()) != "exit")
                    {
                        writer.WriteLine(line);
                    }
                }

                Console.WriteLine("Input successfully written to file.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
