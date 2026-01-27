using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class ValidateUsername
    {
        static void Main(string[] args)
        {
            string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

            Console.Write("Enter username: ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, pattern))
                Console.WriteLine("Valid Username");
            else
                Console.WriteLine("Invalid Username");
        }
    }
}
