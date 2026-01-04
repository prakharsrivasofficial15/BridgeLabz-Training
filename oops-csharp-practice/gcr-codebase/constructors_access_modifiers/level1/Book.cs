using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Book Class:
Create a Book class with attributes title, author, and price.
Provide both default and parameterized constructors.
*/

namespace Assignment.constructors_access_modifiers.level1
{
    internal class Book
    {
        private string title;
        private string author;
        private double price;

        //default constructor
        public Book()
        {
            title = "Unknown";
            author = "Unknown";
            price = 0.0;
        }

        //parameterized constructor
        public Book(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        //Method to display
        public void DisplayDetails()
        {
            Console.WriteLine("Book Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            //default constructor call
            Book book1 = new Book();
            Console.WriteLine("Default Constructor");
            book1.DisplayDetails();

            //parameterized constructor call
            Book book2 = new Book("Clean Code", "Robert C. Martin", 550);
            Console.WriteLine("\nParameterized Constructor");
            book2.DisplayDetails();
        }
    }
}