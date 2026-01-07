using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Library_Management
{


    public abstract class LibraryItem
    {
        private int _itemId;
        private string _title;
        private string _author;

        private string _borrowerName;
        private bool _isBorrowed;

        public int ItemId
        {
            get { return _itemId; }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Item ID must be positive.");
                _itemId = value;
            }
        }

        public string Title
        {
            get { return _title; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Title cannot be empty.");
                _title = value;
            }
        }

        public string Author
        {
            get { return _author; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Author cannot be empty.");
                _author = value;
            }
        }

        protected LibraryItem(int itemId, string title, string author)
        {
            ItemId = itemId;
            Title = title;
            Author = author;
        }

        public abstract int GetLoanDuration();

        public void GetItemDetails()
        {
            Console.WriteLine("ID: " + ItemId);
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Author: " + Author);
        }

        protected void BorrowItem(string borrower)
        {
            _borrowerName = borrower;
            _isBorrowed = true;
        }

        protected bool IsAvailable()
        {
            return !_isBorrowed;
        }
    }
}
