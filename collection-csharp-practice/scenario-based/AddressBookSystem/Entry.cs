using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class Entry
    {
        static void Main()
        {
            Console.WriteLine("Welcome to Address Book Program");
            AddressBookMenu menu = new AddressBookMenu();
            menu.Start();
        }
    }
}
