using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 1: Convert Byte Stream to Character Stream Using StreamReader Problem: Write a program that uses StreamReader to read binary data from a file and print it as characters. 
*/

namespace Linear__and_Binary_Search
{
    class ByteCharacter
    {
        static void Main(string[] args)
        {
            Console.Write("Enter file path: ");
            string filePath = Console.ReadLine();

            try
            {
                using (StreamReader reader = new StreamReader(filePath, Encoding.UTF8))
                {
                    int ch;
                    while ((ch = reader.Read()) != -1)
                    {
                        Console.Write((char)ch);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
