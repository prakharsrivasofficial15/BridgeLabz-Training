using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Library_Management
{
    public class DVD : LibraryItem, IReservable
    {
        public DVD(int itemId, string title, string author)
            : base(itemId, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 5;
        }

        public void ReserveItem(string borrowerName)
        {
            if (!CheckAvailability())
            {
                Console.WriteLine("DVD is already borrowed.");
            }
            else
            {
                BorrowItem(borrowerName);
                Console.WriteLine("DVD reserved by " + borrowerName);
            }
        }

        public bool CheckAvailability()
        {
            return IsAvailable();
        }
    }
}
