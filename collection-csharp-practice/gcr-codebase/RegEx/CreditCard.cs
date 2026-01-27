using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class CreditCard
    {
        static void Main(string[] args)
        {
            string visa = @"^4\d{15}$";
            string master = @"^5\d{15}$";

            Console.Write("Enter card number: ");
            string input = Console.ReadLine();

            if (Regex.IsMatch(input, visa))
                Console.WriteLine("Visa Card");
            else if (Regex.IsMatch(input, master))
                Console.WriteLine("MasterCard");
            else
                Console.WriteLine("Invalid Card");
        }
    }
}
