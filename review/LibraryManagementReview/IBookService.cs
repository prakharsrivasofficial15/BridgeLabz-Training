using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementReview
{
    internal interface IBookService
    {
        void AddBook();
        void SearchByTitle(string Keyword);
        void DisplayAllBooks();
    }
}
