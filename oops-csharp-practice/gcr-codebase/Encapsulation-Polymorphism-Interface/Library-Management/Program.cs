using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Library_Management
{
    class Program
    {
        static void Main()
        {
            LibraryItem[] libraryItems = new LibraryItem[3];

            libraryItems[0] = new Book(1, "Clean Code", "Robert C. Martin");
            libraryItems[1] = new Magazine(2, "Time Magazine", "Editorial Team");
            libraryItems[2] = new DVD(3, "Inception", "Christopher Nolan");

            LibraryProcessor.ProcessLibraryItems(libraryItems);
        }
    }

}
