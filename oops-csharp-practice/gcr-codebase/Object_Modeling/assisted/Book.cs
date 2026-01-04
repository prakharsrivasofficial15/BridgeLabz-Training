using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 1: 
Library and Books (Aggregation) Description: Create a Library class that contains multiple Book objects. Model the relationship such that a library can have many books, but a book can exist independently (outside of a specific library). 
Tasks: Define a Library class with a List<Book> collection. 
Define a Book class with attributes such as Title and Author. Demonstrate the aggregation relationship by creating books and adding them to different libraries. 
Goal: 
Understand aggregation by modeling a real-world relationship where the Library aggregates Book objects. 
*/

namespace Assignment.Object_Modeling.assisted
{
    internal class Book
    {
        public string Title;
        public string Author;

        public Book(string title, string author)
        {
            Title = title;
            Author = author;
        }
    }

    class Library
    {
        public string LibraryName;
        private Book[] books;
        private int count;

        public Library(string name, int size)
        {
            LibraryName = name;
            books = new Book[size];
            count = 0;
        }

        public void AddBook(Book book)
        {
            if (count < books.Length)
            {
                books[count] = book;
                count++;
            }
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Library: " + LibraryName);
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("- " + books[i].Title + " by " + books[i].Author);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            //books exist independently
            Book book1 = new Book("The Hobbit", "J.R.R. Tolkien");
            Book book2 = new Book("1984", "George Orwell");

            Library library1 = new Library("City Library", 5);
            Library library2 = new Library("College Library", 5);

            //same book added to different libraries (Aggregation)
            library1.AddBook(book1);
            library1.AddBook(book2);

            library2.AddBook(book1);

            library1.DisplayBooks();
            Console.WriteLine();
            library2.DisplayBooks();
        }
    }
}
