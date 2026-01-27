using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegEx
{
    internal class MultipleSpaces
    {
        static void Main(string[] args)
        {
            string input = "This   is    an   example   with   multiple   spaces.";
            string result = Regex.Replace(input, @"\s+", " ");

            Console.WriteLine(result);
        }
    }
}
