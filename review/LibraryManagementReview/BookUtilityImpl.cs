using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementReview
{
    internal class BookUtilityImpl : IBookService
    {
        private Book[] books = new Book[1000];
        private int counter = 0;

        public void AddBook()
        {
            Console.WriteLine("Enter Book title:");
            string title = Console.ReadLine();

            Console.WriteLine("Enter Book Author: ");
            string author = Console.ReadLine();

            books[counter++] = new Book(title, author);
            Console.WriteLine("Book Added successfully");
        }

        public void SearchByTitle(string keyword)
        {
            Console.WriteLine("Enter the Book to be searched: ");
            string input = Console.ReadLine();
            bool found = false;
            for(int i=0; i<books.Length; i++)
            {
                if (books[i].getTitle().ToLower().Contains(keyword.ToLower()))
                {
                    Console.WriteLine(books[i]);
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("No book found");
            }
        }

        public void DisplayAllBooks()
        {
            for(int i=0; i<books.Length ; i++)
            {
                Console.WriteLine(books[i]);
            }
        }

     }
}
