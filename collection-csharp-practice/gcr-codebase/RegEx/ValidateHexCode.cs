using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class ValidateHexCode
    {
        static void Main(string[] args)
        {
            string pattern = @"^#[A-Fa-f0-9]{6}$";

            Console.Write("Enter hex color code: ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, pattern))
                Console.WriteLine("Valid Hex Color");
            else
                Console.WriteLine("Invalid Hex Color");
        }
    }
}
