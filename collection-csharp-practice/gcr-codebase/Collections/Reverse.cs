using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Reverse
    {
        static void Main(string[] args)
        {
            //ArrayList Reverse
            ArrayList list = new ArrayList();

            Console.Write("Enter number of elements for ArrayList: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter element: ");
                list.Add(int.Parse(Console.ReadLine()));
            }

            // Reverse ArrayList using simple for loop
            for (int i = 0, j = list.Count - 1; i < j; i++, j--)
            {
                object temp = list[i];
                list[i] = list[j];
                list[j] = temp;
            }

            Console.WriteLine("\nReversed ArrayList:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
                if (i < list.Count - 1)
                {
                    Console.Write(", ");
                }
            }

            Console.WriteLine();

            //LinkedList Reverse
            LinkedList<int> ll = new LinkedList<int>();
            LinkedList<int> reversed = new LinkedList<int>();

            Console.Write("\nEnter number of elements for LinkedList: ");
            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                Console.Write("Enter element: ");
                ll.AddLast(int.Parse(Console.ReadLine()));
            }

            // Reverse LinkedList using simple loop
            LinkedListNode<int> node = ll.First;
            while (node != null)
            {
                reversed.AddFirst(node.Value);
                node = node.Next;
            }

            Console.WriteLine("\nReversed LinkedList:");
            LinkedListNode<int> tempNode = reversed.First;
            while (tempNode != null)
            {
                Console.Write(tempNode.Value);
                if (tempNode.Next != null)
                {
                    Console.Write(", ");
                }
                tempNode = tempNode.Next;
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
