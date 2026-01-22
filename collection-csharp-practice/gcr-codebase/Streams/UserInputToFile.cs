using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Streams
{
    class UserInputToFile
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            try
            {
                // StreamReader is used to read input from the keyboard
                // StreamWriter is used to write data into the file
                using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    Console.Write("Enter your name: ");
                    string name = reader.ReadLine();

                    Console.Write("Enter your age: ");
                    string age = reader.ReadLine();

                    Console.Write("Enter your favorite programming language: ");
                    string language = reader.ReadLine();

                    writer.WriteLine("Name: " + name);
                    writer.WriteLine("Age: " + age);
                    writer.WriteLine("Favorite Language: " + language);
                }

                Console.WriteLine("User information saved successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
