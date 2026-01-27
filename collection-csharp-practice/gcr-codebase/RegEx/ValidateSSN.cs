using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class ValidateSSN
    {
        static void Main(string[] args)
        {
            string pattern = @"^\d{3}-\d{2}-\d{4}$";

            Console.Write("Enter SSN: ");
            string input = Console.ReadLine();

            Console.WriteLine(Regex.IsMatch(input, pattern) ? "Valid SSN" : "Invalid SSN");
        }
    }
}
