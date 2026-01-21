using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class ReverseQueue
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            Stack<int> stack = new Stack<int>();

            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());

            //input from user
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                int value = int.Parse(Console.ReadLine());
                queue.Enqueue(value);
            }

            // Move from queue to stack
            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            //Move back from stack to queue (reversed)
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

            Console.WriteLine("\nReversed Queue:");
            int count = queue.Count;
            for (int i = 0; i < count; i++)
            {
                int value = queue.Dequeue();
                Console.Write(value);

                if (i < count - 1)
                    Console.Write(", ");

                queue.Enqueue(value); 
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
