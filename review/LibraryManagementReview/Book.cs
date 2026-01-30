using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementReview
{
    class Book
    {
        private string title;
        private string author;
        private bool isAvailable;

        public Book(string title, string author)
        {
            this.title = title;
            this.author = author;
            this.isAvailable = true;
        }

        public string getTitle()
        {
            return title;
        }

        public string getAuthor(string author)
        {
            return author;
        }

        public bool getStatus()
        {
            return isAvailable;
        }

        public override string ToString()
        {
            return $"Title: {title} | Author: {author}";
        }
    }
}


