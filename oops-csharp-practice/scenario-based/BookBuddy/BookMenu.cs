using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    class BookMenu
    {
        private IBookService _bookService;

        public void Start()
        {
            _bookService = new BookServiceUtilityImpl();

            while (true)
            {
                Console.WriteLine("Welcome to the Pandu Library");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Sort Books Alphabetically");
                Console.WriteLine("3. Search By Author");
                Console.WriteLine("4. Display All Books");
                Console.WriteLine("5. Exit");

                Console.Write("Enter choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter Book Title: ");
                        string title = Console.ReadLine();

                        Console.Write("Enter Author Name: ");
                        string author = Console.ReadLine();

                        _bookService.AddBook(title, author);
                        break;

                    case 2:
                        _bookService.SortBookAlphabetically();
                        break;

                    case 3:
                        Console.Write("Enter Author Name to Search: ");
                        string searchAuthor = Console.ReadLine();

                        _bookService.SearchByAuthor(searchAuthor);
                        break;

                    case 4:
                        _bookService.DisplayAllBooks();
                        break;

                    case 5:
                        Console.WriteLine("Exiting BookBuddy");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}
