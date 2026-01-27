using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class ValidateIP
    {
        static void Main(string[] args)
        {
            string pattern = @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}(25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$";

            Console.Write("Enter IP Address: ");
            string input = Console.ReadLine();

            Console.WriteLine(Regex.IsMatch(input, pattern) ? "Valid IP" : "Invalid IP");
        }
    }
}
