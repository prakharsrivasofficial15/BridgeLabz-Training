using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementReview
{
    internal class BookServiceMenu
    {
        private IBookService _bookService;

        public void start()
        {
            _bookService = new BookUtilityImpl();
            while (true)
            {
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Search Book");
                Console.WriteLine("3. Display All Books");
                Console.WriteLine("4. Exit");

                Console.Write("Enter your Choice: ");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        _bookService.AddBook();
                        break;

                    case 2:
                        Console.Write("Enter title: ");
                        _bookService.SearchByTitle(Console.ReadLine());
                        break;

                    case 3:
                        _bookService.DisplayAllBooks();
                        break;
                    
                    case 4:
                        return;

                    default:
                        Console.WriteLine("Invalid status");
                        break;
                }
            }
        }
    }
}
