using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class Censor
    {
        static void Main(string[] args)
        {
            string input = "This is a damn bad example with some stupid words.";
            string pattern = @"\b(damn|stupid)\b";

            string result = Regex.Replace(input, pattern, "****", RegexOptions.IgnoreCase);

            Console.WriteLine(result);
        }
    }
}
