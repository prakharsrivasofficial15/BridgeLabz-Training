using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class RemoveDuplicates
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 3, 1, 2, 2, 3, 4 };
            HashSet<int> seen = new HashSet<int>();
            List<int> result = new List<int>();

            foreach (int x in list)
            {
                if (seen.Add(x))
                {
                    result.Add(x);
                }
            }

            Console.WriteLine("After removing duplicates:");
            Console.WriteLine(string.Join(", ", result));
        }
    }
}
