using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class ExtractLinks
    {
        static void Main(string[] args)
        {
            string text = "Visit https://www.google.com and https://www.youtube.com for more info.";
            string pattern = @"https?://[^\s]+";

            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
                Console.WriteLine(match.Value);
        }
    }
}
