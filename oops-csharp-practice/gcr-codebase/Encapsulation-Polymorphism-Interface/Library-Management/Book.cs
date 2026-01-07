using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Library_Management
{
    public class Book : LibraryItem, IReservable
    {
        public Book(int itemId, string title, string author)
            : base(itemId, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 21;
        }

        public void ReserveItem(string borrowerName)
        {
            if (!CheckAvailability())
            {
                Console.WriteLine("Book is already borrowed.");
            }
            else
            {
                BorrowItem(borrowerName);
                Console.WriteLine("Book reserved by " + borrowerName);
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }

}
