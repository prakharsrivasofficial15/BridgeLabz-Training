using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class RepeatingWords
    {
        static void Main(string[] args)
        {
            string input = "This is is a repeated repeated word test.";
            string pattern = @"\b(\w+)\s+\1\b";

            foreach (Match m in Regex.Matches(input, pattern, RegexOptions.IgnoreCase))
                Console.WriteLine(m.Groups[1].Value);
        }
    }
}
