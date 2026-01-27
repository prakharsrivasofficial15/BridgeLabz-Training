using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class ValidateLicense
    {
        static void Main(string[] args)
        {
            string pattern = @"^[A-Z]{2}\d{4}$";

            Console.Write("Enter license plate: ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, pattern))
                Console.WriteLine("Valid License Plate");
            else
                Console.WriteLine("Invalid License Plate");
        }
    }
}
