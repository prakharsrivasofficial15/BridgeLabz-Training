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
        // UC-8: count how many people live in a given city
        public void CountContactsByCity(string city)
        {
            int countMatches = 0;

            //check every Address Book in the system
            for (int i = 0; i < count; i++)
            {
                AddressBook book = addressBooks[i];           //pick the current address book
                UserContacts[] contacts = book.GetContacts(); //get all contacts in this book
                int contactCount = book.GetContactCount();    //count contacts are there

                // Now, check each contact in this address book
                for (int j = 0; j < contactCount; j++)
                {
                    //check if the contact’s city matches the city looking for
                    if (contacts[j].City.Equals(city, StringComparison.OrdinalIgnoreCase))
                    {
                        countMatches++; //if found Increase our counter
                    }
                }
            }

            //total number of people found in that city
            Console.WriteLine($"Total contacts in city '{city}': {countMatches}");
        }


        // UC-8: Count how many people live in a given state
        public void CountContactsByState(string state)
        {
            int countMatches = 0;

            for (int i = 0; i < count; i++)
            {
                AddressBook book = addressBooks[i];
                UserContacts[] contacts = book.GetContacts();
                int contactCount = book.GetContactCount();

                for (int j = 0; j < contactCount; j++)
                {
                    if (contacts[j].State.Equals(state, StringComparison.OrdinalIgnoreCase))
                    {
                        countMatches++;
                    }
                }
            }

            //total number of people found in that state
            Console.WriteLine($"Total contacts in state '{state}': {countMatches}");
        }

        // UC-8: Search person by city
        public void SearchPersonByCity(string city)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                AddressBook book = addressBooks[i];

                for (int j = 0; j < book.CurrentCount; j++)
                {
                    UserContacts contact = book.GetContactAt(j);

                    if (contact.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(contact);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No contacts found in this city.");
            }
        }

        // UC-8: Search person by state
        public void SearchPersonByState(string state)
        {
            bool found = false;

            for (int i = 0; i < count; i++)
            {
                AddressBook book = addressBooks[i];

                for (int j = 0; j < book.CurrentCount; j++)
                {
                    UserContacts contact = book.GetContactAt(j);

                    if (contact.State.Equals(state, StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine(contact);
                        found = true;
                    }
                }
            }

            if (!found)
            {
                Console.WriteLine("No contacts found in this state.");
            }
        }

        public void CountByCity(string city)
        {
            int countResult = 0;

            for (int i = 0; i < count; i++)
            {
                AddressBook book = addressBooks[i];
                UserContacts[] contacts = book.GetContacts();
                int contactCount = book.GetContactCount();

                for (int j = 0; j < contactCount; j++)
                {
                    if (contacts[j].City.Equals(city, StringComparison.OrdinalIgnoreCase))
                    {
                        countResult++;
                    }
                }
            }

            Console.WriteLine($"Number of contacts in city '{city}': {countResult}");
        }
        public void CountByState(string state)
        {
            int countResult = 0;

            for (int i = 0; i < count; i++)
            {
                AddressBook book = addressBooks[i];
                UserContacts[] contacts = book.GetContacts();
                int contactCount = book.GetContactCount();

                for (int j = 0; j < contactCount; j++)
                {
                    if (contacts[j].State.Equals(state, StringComparison.OrdinalIgnoreCase))
                    {
                        countResult++;
                    }
                }
            }

            Console.WriteLine($"Number of contacts in state '{state}': {countResult}");
        }
    }
}

