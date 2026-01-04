using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.constructors_access_modifiers.level1
{
    internal class Library
    {
        private string title;
        private string author;
        private double price;
        private bool isAvailable;

        // Constructor
        public Library(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
            this.isAvailable = true;
        }

        // Method to borrow book
        public void BorrowBook()
        {
            if (isAvailable)
            {
                isAvailable = false;
                Console.WriteLine("Book borrowed successfully.");
            }
            else
            {
                Console.WriteLine("Book is not available.");
            }
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Author: " + author);
            Console.WriteLine("Price: " + price);
            Console.WriteLine("Available: " + isAvailable);
        }
    }
}
