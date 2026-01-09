using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Implement a Queue Using Stacks
Problem: Design a queue using two stacks such that enqueue and dequeue operations are performed efficiently.
Hint: Use one stack for enqueue and another stack for dequeue. Transfer elements between stacks as needed.
*/

namespace StackQueues
{
    class QueueUsingStacks<T>
    {
        private Stack<T> stackIn = new Stack<T>();
        private Stack<T> stackOut = new Stack<T>();

        //Enqueue operation
        public void Enqueue(T item)
        {
            stackIn.Push(item);
        }

        //Dequeue operation
        public T Dequeue()
        {
            if (stackIn.Count == 0 && stackOut.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            if (stackOut.Count == 0)
            {
                while (stackIn.Count > 0)
                {
                    stackOut.Push(stackIn.Pop());
                }
            }

            return stackOut.Pop();
        }

        //Peek operation
        public T Peek()
        {
            if (stackIn.Count == 0 && stackOut.Count == 0)
                throw new InvalidOperationException("Queue is empty");

            if (stackOut.Count == 0)
            {
                while (stackIn.Count > 0)
                {
                    stackOut.Push(stackIn.Pop());
                }
            }

            return stackOut.Peek();
        }

        public bool IsEmpty()
        {
            return stackIn.Count == 0 && stackOut.Count == 0;
        }
    }
    class QueueImpl
    {
        static void Main()
        {
            QueueUsingStacks<int> queue = new QueueUsingStacks<int>();

            Console.Write("Enter number of elements to enqueue: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
            {
                int value = int.Parse(Console.ReadLine());
                queue.Enqueue(value);
            }

            Console.WriteLine("\nDequeuing elements:");
            while (!queue.IsEmpty())
            {
                Console.WriteLine(queue.Dequeue());
            }
        }
    }
}

