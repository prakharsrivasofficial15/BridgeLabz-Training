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

        // Adds a new AddressBook if the name is not already used
        public void AddAddressBook(string name, int size)
        {
            // Check if an AddressBook with the same name already exists
            if (IsDuplicate(name))
            {
                Console.WriteLine("Address Book with this name already exists.");
                return;
            }

            // Create and store the new AddressBook
            addressBooks[count++] = new AddressBook(name, size);
            Console.WriteLine("Address Book created successfully.");
        }

        // Retrieves an AddressBook by owner name (case-insensitive)
        public AddressBook GetAddressBook(string name)
        {
            // Search through existing AddressBooks
            for (int i = 0; i < count; i++)
            {
                if (addressBooks[i].OwnerName.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return addressBooks[i];
            }

            // Return null if no matching AddressBook is found
            return null;
        }

        // Checks whether an AddressBook with the given name already exists
        private bool IsDuplicate(string name)
        {
            for (int i = 0; i < count; i++)
            {
                if (addressBooks[i].OwnerName.Equals(name, StringComparison.OrdinalIgnoreCase))
                    return true;
            }

            // No duplicate found
            return false;
        }
    }
}
