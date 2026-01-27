using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class ProgrammingLanguage
    {
        static void Main(string[] args)
        {
            string text = "I love Java, Python, and JavaScript, but I haven't tried Go yet.";
            string pattern = @"\b(Java|Python|JavaScript|Go)\b";

            foreach (Match m in Regex.Matches(text, pattern))
                Console.WriteLine(m.Value);
        }
    }
}
