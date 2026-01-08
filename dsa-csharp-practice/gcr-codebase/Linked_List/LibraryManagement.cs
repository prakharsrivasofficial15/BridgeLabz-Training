using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Linked_List
{
    class BookNode
    {
        public int BookId;
        public string Title;
        public string Author;
        public string Genre;
        public bool IsAvailable;
        public BookNode Next;
        public BookNode Prev;

        public BookNode(int id, string title, string author, string genre, bool available)
        {
            BookId = id;
            Title = title;
            Author = author;
            Genre = genre;
            IsAvailable = available;
            Next = Prev = null;
        }
    }

    class LibraryDLL
    {
        private BookNode head;
        private BookNode tail;

        //Add at Beginning
        public void AddAtBeginning(int id, string title, string author, string genre, bool available)
        {
            BookNode newNode = new BookNode(id, title, author, genre, available);

            if (head == null)
            {
                head = tail = newNode;
                return;
            }

            newNode.Next = head;
            head.Prev = newNode;
            head = newNode;
        }

        //Add at End
        public void AddAtEnd(int id, string title, string author, string genre, bool available)
        {
            BookNode newNode = new BookNode(id, title, author, genre, available);

            if (tail == null)
            {
                head = tail = newNode;
                return;
            }

            tail.Next = newNode;
            newNode.Prev = tail;
            tail = newNode;
        }

        //Add at Specific Position
        public void AddAtPosition(int position, int id, string title, string author, string genre, bool available)
        {
            if (position == 1)
            {
                AddAtBeginning(id, title, author, genre, available);
                return;
            }

            BookNode temp = head;
            for (int i = 1; i < position - 1 && temp != null; i++)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Invalid position");
                return;
            }

            BookNode newNode = new BookNode(id, title, author, genre, available);
            newNode.Next = temp.Next;
            newNode.Prev = temp;

            if (temp.Next != null)
                temp.Next.Prev = newNode;
            else
                tail = newNode;

            temp.Next = newNode;
        }

        //Remove by Book ID
        public void RemoveById(int id)
        {
            BookNode temp = head;

            while (temp != null && temp.BookId != id)
                temp = temp.Next;

            if (temp == null)
            {
                Console.WriteLine("Book not found");
                return;
            }

            if (temp == head)
                head = temp.Next;

            if (temp == tail)
                tail = temp.Prev;

            if (temp.Prev != null)
                temp.Prev.Next = temp.Next;

            if (temp.Next != null)
                temp.Next.Prev = temp.Prev;

            Console.WriteLine("Book removed successfully");
        }

        //Search by Title or Author
        public void Search(string title, string author)
        {
            BookNode temp = head;
            bool found = false;

            while (temp != null)
            {
                if ((!string.IsNullOrEmpty(title) && temp.Title == title) ||
                    (!string.IsNullOrEmpty(author) && temp.Author == author))
                {
                    DisplayBook(temp);
                    found = true;
                }
                temp = temp.Next;
            }

            if (!found)
                Console.WriteLine("No matching book found");
        }

        //Update Availability
        public void UpdateAvailability(int id, bool status)
        {
            BookNode temp = head;

            while (temp != null)
            {
                if (temp.BookId == id)
                {
                    temp.IsAvailable = status;
                    Console.WriteLine("Availability updated");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Book not found");
        }

        //Display Forward
        public void DisplayForward()
        {
            if (head == null)
            {
                Console.WriteLine("Library is empty");
                return;
            }

            BookNode temp = head;
            while (temp != null)
            {
                DisplayBook(temp);
                temp = temp.Next;
            }
        }

        //Display Reverse
        public void DisplayReverse()
        {
            if (tail == null)
            {
                Console.WriteLine("Library is empty");
                return;
            }

            BookNode temp = tail;
            while (temp != null)
            {
                DisplayBook(temp);
                temp = temp.Prev;
            }
        }

        //Count Books
        public int CountBooks()
        {
            int count = 0;
            BookNode temp = head;

            while (temp != null)
            {
                count++;
                temp = temp.Next;
            }
            return count;
        }

        private void DisplayBook(BookNode book)
        {
            Console.WriteLine(
                $"ID: {book.BookId}, Title: {book.Title}, Author: {book.Author}, Genre: {book.Genre}, Available: {book.IsAvailable}"
            );
        }
    }

    class LibraryManagement
    {
        static void Main()
        {
            LibraryDLL library = new LibraryDLL();
            int choice = -1;

            while (choice != 0)
            {
                Console.WriteLine("\nLibrary Management System");
                Console.WriteLine("1. Add Book at End");
                Console.WriteLine("2. Remove Book by ID");
                Console.WriteLine("3. Search Book by Author");
                Console.WriteLine("4. Display Books (Forward)");
                Console.WriteLine("5. Count Books");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book ID: ");
                        int id = int.Parse(Console.ReadLine());

                        Console.Write("Enter Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Author: ");
                        string author = Console.ReadLine();

                        Console.Write("Enter Genre: ");
                        string genre = Console.ReadLine();

                        Console.Write("Is Available (true/false): ");
                        bool available = bool.Parse(Console.ReadLine());

                        library.AddAtEnd(id, title, author, genre, available);
                        Console.WriteLine("Book added successfully");
                        break;

                    case 2:
                        Console.Write("Enter Book ID to remove: ");
                        int removeId = int.Parse(Console.ReadLine());
                        library.RemoveById(removeId);
                        break;

                    case 3:
                        Console.Write("Enter Author name: ");
                        string searchAuthor = Console.ReadLine();
                        library.Search(null, searchAuthor);
                        break;

                    case 4:
                        library.DisplayForward();
                        break;

                    case 5:
                        Console.WriteLine("Total Books: " + library.CountBooks());
                        break;

                    case 0:
                        Console.WriteLine("Exiting program...");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }

    }

}

