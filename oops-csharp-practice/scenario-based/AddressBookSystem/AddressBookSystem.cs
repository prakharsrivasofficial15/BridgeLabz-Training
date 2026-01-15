using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // Manages multiple AddressBook objects
    internal class AddressBookSystem
    {
        // Array to store AddressBook objects
        private AddressBook[] addressBooks;

        // Tracks how many AddressBooks have been added
        private int count = 0;

        // Constructor initializes the AddressBook array with a fixed size
        public AddressBookSystem(int size)
        {
            addressBooks = new AddressBook[size];
        }

        // UC-1: Add Address Book
        public void AddAddressBook(string name, int size)
        {
            // Check system capacity
            if (count >= addressBooks.Length)
            {
                Console.WriteLine("Cannot add more Address Books. System is full.");
                return;
            }

            // Check duplicate AddressBook name
            if (IsDuplicate(name))
            {
                Console.WriteLine("Address Book with this name already exists.");
                return;
            }

            addressBooks[count] = new AddressBook(name, size);
            count++;

            Console.WriteLine("Address Book created successfully.");
        }

        // UC-2: Retrieve Address Book by name
        public AddressBook GetAddressBook(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (addressBooks[i].OwnerName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return addressBooks[i];
                }
            }

            return null;
        }

        // Checks whether an AddressBook with the given name already exists
        private bool IsDuplicate(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (addressBooks[i].OwnerName.Equals(name, StringComparison.OrdinalIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}

