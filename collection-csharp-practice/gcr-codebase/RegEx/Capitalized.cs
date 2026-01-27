using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class Capitalized
    {
        static void Main(string[] args)
        {
            string text = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
            string pattern = @"\b[A-Z][a-z]*\b";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
                Console.WriteLine(match.Value);
        }
    }
}
