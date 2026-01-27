using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class ExtractCurrency
    {
        static void Main(string[] args)
        {
            string text = "The price is $45.99, and the discount is $ 10.50.";
            string pattern = @"\$ ?\d+(\.\d{2})?";

            foreach (Match m in Regex.Matches(text, pattern))
                Console.WriteLine(m.Value);
        }
    }
}
