using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // Utility class that interacts with the user to manage the AddressBook
    internal class AddressBookUtilityImpl : IAddressBook
    {
        private AddressBookSystem system;
        private AddressBook activeBook;

        // Constructor: initializes system only (no forced creation)
        public AddressBookUtilityImpl()
        {
            system = new AddressBookSystem(5); // max 5 address books
            activeBook = null;
        }

        // UC-1: Create Address Book
        public void CreateAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Address Book Size: ");
            int size;
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Invalid input. Enter a positive number: ");
            }

            system.AddAddressBook(name, size);
            activeBook = system.GetAddressBook(name);

            Console.WriteLine("Address Book created and selected successfully.");
        }

        // UC-2: Select Address Book
        public void SelectAddressBook()
        {
            Console.Write("Enter Address Book Name to Select: ");
            string name = Console.ReadLine();

            activeBook = system.GetAddressBook(name);

            if (activeBook == null)
                Console.WriteLine("Address Book not found.");
            else
                Console.WriteLine("Address Book selected.");
        }

        // UC-3: Add Contact
        public void AddContact()
        {
            if (activeBook == null)
            {
                Console.WriteLine("Select an Address Book first.");
                return;
            }

            Console.WriteLine("Enter the contact details:");

            Console.Write("First Name: ");
            string firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            string lastName = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("City: ");
            string city = Console.ReadLine();

            Console.Write("State: ");
            string state = Console.ReadLine();

            Console.Write("Country: ");
            string country = Console.ReadLine();

            Console.Write("Zip Code: ");
            string zipCode = Console.ReadLine();

            Console.Write("Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            UserContacts contact = new ContactImpl(
                firstName, lastName, address, city, state,
                zipCode, country, phoneNumber, email
            );

            activeBook.AddContact(contact);
        }

        // UC-4: Edit Contact
        public void EditContact()
        {
            if (activeBook == null)
            {
                Console.WriteLine("Select an Address Book first.");
                return;
            }

            Console.Write("Enter First Name of contact to edit: ");
            string name = Console.ReadLine();

            activeBook.EditContactByFirstName(name);
        }

        // UC-5: Delete Contact
        public void DeleteContact()
        {
            if (activeBook == null)
            {
                Console.WriteLine("Select an Address Book first.");
                return;
            }
            Console.Write("Enter First Name of contact to delete: ");
            string name = Console.ReadLine();

            activeBook.DeleteContactByFirstName(name);
        }

        // UC-6: Show Contacts
        public void ShowContacts()
        {
            if (activeBook == null)
            {
                Console.WriteLine("Select an Address Book first.");
                return;
            }
            activeBook.ShowContacts();
        }
        //UC-8: search person by city
        public void SearchByCity()
        {
            Console.Write("Enter city name to search: ");
            string city = Console.ReadLine();
            system.SearchPersonByCity(city);
        }
        //UC-8: search person by state
        public void SearchByState()
        {
            Console.Write("Enter state name to search: ");
            string state = Console.ReadLine();
            system.SearchPersonByState(state);
        }
    }
}

