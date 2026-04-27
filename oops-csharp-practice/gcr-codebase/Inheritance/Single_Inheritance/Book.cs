using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Inheritance.Single_Inheritance
{
    internal class Book
    {
        public string Title;
        public int PublicationYear;

        public Book(string title, int publicationYear)
        {
            Title = title;
            PublicationYear = publicationYear;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Book Title: " + Title);
            Console.WriteLine("Publication Year: " + PublicationYear);
        }
    }

    class Author : Book
    {
        public string Name;
        public string Bio;

        public Author(string title, int publicationYear, string name, string bio)
            : base(title, publicationYear)
        {
            Name = name;
            Bio = bio;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Author Name: " + Name);
            Console.WriteLine("Author Bio: " + Bio);
        }
    }

    class LibraryTest
    {
        static void Main()
        {
            Author bookAuthor = new Author(
                "C# Programming",
                2023,
                "John Smith",
                "Software Developer and Trainer"
            );

            bookAuthor.DisplayInfo();
        }
    }
}
