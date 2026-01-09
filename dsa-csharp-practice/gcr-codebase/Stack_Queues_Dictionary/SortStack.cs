using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Sort a Stack Using Recursion
Problem: Given a stack, sort its elements in ascending order using recursion.
Hint: Pop elements recursively, sort the remaining stack, and insert the popped element back at the correct position.
*/

namespace StackQueues
{
    class SortStackRecursion
    {
        public static void SortStack(Stack<int> stack)
        {
            if (stack.Count == 0)
                return;

            int top = stack.Pop();

            SortStack(stack);

            InsertSorted(stack, top);
        }

        private static void InsertSorted(Stack<int> stack, int value)
        {
            if (stack.Count == 0 || stack.Peek() <= value)
            {
                stack.Push(value);
                return;
            }

            int top = stack.Pop();
            InsertSorted(stack, value);
            stack.Push(top);
        }
    }
    internal class SortStack
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();

            Console.Write("Enter number of elements in stack: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                stack.Push(int.Parse(Console.ReadLine()));
            }

            SortStackRecursion.SortStack(stack);

            Console.WriteLine("\nSorted stack (top to bottom):");
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
