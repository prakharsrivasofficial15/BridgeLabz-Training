using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp
{
    public class StringUtils
    {
        public string Reverse(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }

        public bool IsPalindrome(string str)
        {
            string rev = Reverse(str);
            return str.Equals(rev, StringComparison.OrdinalIgnoreCase);
        }

        public string ToUpperCase(string str)
        {
            return str.ToUpper();
        }
    }
}
