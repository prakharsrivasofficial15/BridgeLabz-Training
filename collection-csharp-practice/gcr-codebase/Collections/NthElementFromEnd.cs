using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class NthElementFromEnd
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>( new[] { "A", "B", "C", "D", "E" });

            int n = 2;
            var fast = list.First;
            var slow = list.First;

            for (int i = 0; i < n; i++)
                fast = fast.Next;

            while (fast != null)
            {
                fast = fast.Next;
                slow = slow.Next;
            }

            Console.WriteLine("Nth element from end:");
            Console.WriteLine(slow.Value);
        }
    }
}
