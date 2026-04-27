using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Problem 2: Book Library System
Design a Book class with:
ISBN (public)
title (protected)
author (private)
Implement methods to:
Set and get the author name.
Create a subclass EBook to access ISBN and title and demonstrate access modifiers.
 */

namespace Assignment.constructors_access_modifiers.access_modifiers
{
    internal class Book
    {
        public string ISBN;          // public
        protected string title;      // protected
        private string author;       // private

        public Book(string isbn, string title, string author)
        {
            ISBN = isbn;
            this.title = title;
            this.author = author;
        }

        // Getter & Setter for private member
        public string GetAuthor()
        {
            return author;
        }

        public void SetAuthor(string author)
        {
            this.author = author;
        }
    }

    class EBook : Book
    {
        public EBook(string isbn, string title, string author)
            : base(isbn, title, author)
        {
        }

        public void DisplayEBook()
        {
            Console.WriteLine("ISBN: " + ISBN);
            Console.WriteLine("Title: " + title); // protected access
        }
    }
}
