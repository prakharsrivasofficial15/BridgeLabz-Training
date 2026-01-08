using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
8. Doubly Linked List: Undo/Redo Functionality for Text Editor
Problem Statement: Design an undo/redo functionality for a text editor using a doubly linked list. Each node represents a state of the text content (e.g., after typing a word or performing a command). Implement the following:
    Add a new text state at the end of the list every time the user types or performs an action.
    Implement the undo functionality (revert to the previous state).
    Implement the redo functionality (revert back to the next state after undo).
    Display the current state of the text.
    Limit the undo/redo history to a fixed size (e.g., last 10 states).
*/

namespace Assignment.Linked_List
{
    class TextStateNode
    {
        public string Content;
        public TextStateNode Prev;
        public TextStateNode Next;

        public TextStateNode(string content)
        {
            Content = content;
            Prev = Next = null;
        }
    }
    class TextDLL
    {
        private TextStateNode head;
        private TextStateNode tail;
        private TextStateNode current;
        private int maxSize;
        private int size;

        public TextDLL(int limit = 10)
        {
            maxSize = limit;
            size = 0;
        }

        //Add new text state
        public void AddState(string content)
        {
            TextStateNode newNode = new TextStateNode(content);

            if (current != null && current.Next != null)
            {
                current.Next.Prev = null;
                current.Next = null;
                tail = current;
                size = CountNodes();
            }

            if (head == null)
            {
                head = tail = current = newNode;
                size = 1;
                return;
            }

            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
            current = newNode;
            size++;

            // Limit history size
            if (size > maxSize)
            {
                head = head.Next;
                head.Prev = null;
                size--;
            }
        }

        //Undo operation
        public void Undo()
        {
            if (current == null || current.Prev == null)
            {
                Console.WriteLine("Nothing to undo");
                return;
            }

            current = current.Prev;
            DisplayCurrentState();
        }

        //Redo operation
        public void Redo()
        {
            if (current == null || current.Next == null)
            {
                Console.WriteLine("Nothing to redo");
                return;
            }

            current = current.Next;
            DisplayCurrentState();
        }

        //Display current text state
        public void DisplayCurrentState()
        {
            if (current == null)
            {
                Console.WriteLine("Editor is empty");
                return;
            }

            Console.WriteLine($"Current Text: {current.Content}");
        }

        //Helper: count nodes
        private int CountNodes()
        {
            int count = 0;
            TextStateNode temp = head;
            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }
    }
    class UndoRedo
    {
        static void Main()
        {
            TextDLL editor = new TextDLL(10);
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("\nText Editor Undo/Redo");
                Console.WriteLine("1. Type New Text");
                Console.WriteLine("2. Undo");
                Console.WriteLine("3. Redo");
                Console.WriteLine("4. Display Current Text");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter text: ");
                        string text = Console.ReadLine();
                        editor.AddState(text);
                        Console.WriteLine("Text added");
                        break;

                    case 2:
                        editor.Undo();
                        break;

                    case 3:
                        editor.Redo();
                        break;

                    case 4:
                        editor.DisplayCurrentState();
                        break;

                    case 5:
                        Console.WriteLine("Exit");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

    }

}
