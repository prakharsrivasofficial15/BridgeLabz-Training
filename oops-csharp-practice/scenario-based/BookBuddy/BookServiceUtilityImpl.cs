using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    class BookServiceUtilityImpl : IBookService
    {
        private string[] Books;
        private int count = 0;

        public BookServiceUtilityImpl()
        {
            Console.WriteLine("Enter the number of books to store in the Library: ");
            int size = Convert.ToInt32(Console.ReadLine());
            Books = new string[size];
        }

        public void AddBook(string title, string author)
        {
            if(count >= Books.Length)
            {
                Console.WriteLine("No new Book Could be added");
                return;
            }
            Books[count] = title + " - " + author;
            count++;
            Console.WriteLine("Book Added Successfully");
        }

        public void SortBookAlphabetically()
        {
            if(count == 0)
            {
                Console.WriteLine("No Books in the Library");
                return;
            }

            Array.Sort(Books, 0, count);
            Console.WriteLine("Books sorted Alphabetically");
        }

        public void SearchByAuthor(string author)
        {
            bool found = false;

            for(int i=0;  i<Books.Length; i++)
            {
                string[] parts = Books[i].Split('-');
                string bookAuthor = parts[1].Trim();

                if (bookAuthor.Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(Books[i]);
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Book not found for the author");
            }
        }

        public void DisplayAllBooks()
        {
            if(Books.Length < 0)
            {
                Console.WriteLine("No Books in the Library to display");
                return;
            }
            for(int i=0; i < Books.Length; i++)
            {
                Console.WriteLine(Books[i]);
            }
        }
    }
}
