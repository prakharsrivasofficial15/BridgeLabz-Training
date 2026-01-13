using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    interface IBookService
    {
        void AddBook(string title, string author);
        void SortBookAlphabetically();
        void SearchByAuthor(string author);
        void DisplayAllBooks();
    }
}
