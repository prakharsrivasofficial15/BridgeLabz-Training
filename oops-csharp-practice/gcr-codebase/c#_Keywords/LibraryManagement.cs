using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///*Sample Program 2: Library Management System
//Create a Book class to manage library books with the following features:
//static: 
//    A static variable LibraryName shared across all books.
//    A static method DisplayLibraryName() to print the library name.
//this: 
//    Use this to initialize Title, Author, and ISBN in the constructor.
//readonly: 
//    Use a readonly variable ISBN to ensure the unique identifier of a book cannot be changed.
//is operator: 
//    Verify if an object is an instance of the Book class before displaying its details.
//*/

namespace Assignment.c__Keywords
{
    internal class LibraryManagement
    {
        public static string LibraryName = "Golden Mind";
        public string Title;
        public string Author;
        public readonly string ISBN;

        public static void DisplayLibraryName()
        {
            Console.WriteLine($"Library Name:{LibraryName}");
        }

        public LibraryManagement(string Title, string Author, string ISBN)
        {
            this.Title = Title;
            this.Author = Author;
            this.ISBN = ISBN;
        }

        public static void DisplayBookDetails(object obj)
        {
            if (obj is LibraryManagement lib)
            {
                Console.WriteLine($"{lib.Title} - {lib.Author} - {lib.ISBN}");
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // Display library name
            LibraryManagement.DisplayLibraryName();

            // Create book objects
            LibraryManagement book1 = new LibraryManagement(
                "The Alchemist",
                "Paulo Coelho",
                "ISBN-001"
            );

            LibraryManagement book2 = new LibraryManagement(
                "Atomic Habits",
                "James Clear",
                "ISBN-002"
            );

            // Display book details using is operator
            LibraryManagement.DisplayBookDetails(book1);
            LibraryManagement.DisplayBookDetails(book2);

            Console.ReadLine();
        }
    }
}
