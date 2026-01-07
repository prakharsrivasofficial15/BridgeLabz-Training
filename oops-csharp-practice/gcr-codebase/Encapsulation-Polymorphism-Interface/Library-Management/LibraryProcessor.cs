using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Library_Management
{
    public class LibraryProcessor
    {
        public static void ProcessLibraryItems(LibraryItem[] items)
        {
            for (int i = 0; i < items.Length; i++)
            {
                LibraryItem item = items[i];

                item.GetItemDetails();
                Console.WriteLine("Loan Duration: " + item.GetLoanDuration() + " days");

                // is operator with interface
                if (item is IReservable)
                {
                    Console.WriteLine("Item is reservable.");
                    IReservable reservableItem = (IReservable)item;
                    reservableItem.ReserveItem("John Doe");
                }
                else
                {
                    Console.WriteLine("Item is not reservable.");
                }
            }
        }
    }

}
