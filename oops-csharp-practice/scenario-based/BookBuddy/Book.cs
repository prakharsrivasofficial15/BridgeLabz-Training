using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookBuddy
{
    abstract class Book
    {
        private string author;
        private string title;

        public Book(string author,  string title)
        {
            this.author = author;
            this.title = title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetTitle()
        {
            return title;
        }

        public override string ToString()
        {
            return $"Title: {title} | Author: {author}";
        }
    }
}
