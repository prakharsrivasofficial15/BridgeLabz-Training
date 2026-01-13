using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 1: Read a File Line by Line Using StreamReader Problem: Write a program that uses StreamReader to read a text file line by line and print each line to the console. 
*/

namespace Linear__and_Binary_Search
{
    class ReadFileLineByLine
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error reading file: " + ex.Message);
            }
        }
    }
}
