using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Class_Object
{
    internal class BookDetails
    {
        private string title;
        private string author;
        private double price;

        // Constructor
        public BookDetails(string title, string author, double price)
        {
            this.title = title;
            this.author = author;
            this.price = price;
        }

        // Method to display book details
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
            BookDetails book = new BookDetails("Clean Code", "Robert C. Martin", 550);
            book.DisplayDetails();
        }
    }
}
