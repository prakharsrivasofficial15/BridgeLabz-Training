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
        private AddressBook addressBook;

        public AddressBookUtilityImpl()
        {
            Console.Write("Enter Address Book Owner Name: ");
            string ownerName = Console.ReadLine();

            int size;
            Console.Write("Enter Address Book Size: ");
            // Validate that the size is a positive integer
            while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
            {
                Console.Write("Invalid input. Enter a positive number: ");
            }

            addressBook = new AddressBook(ownerName, size);
        }

        // Method to add contact
        public void AddContact()
        {
            Console.WriteLine("Enter the contact details: ");

            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Address: ");
            string address = Console.ReadLine();

            Console.WriteLine("Enter Phone Number: ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();

            Console.WriteLine("Enter city: ");
            string city = Console.ReadLine();

            Console.WriteLine("Enter state: ");
            string state = Console.ReadLine();

            Console.WriteLine("Enter COuntry: ");
            string country = Console.ReadLine();

            Console.WriteLine("Enter ZipCode: ");
            string zipCode = Console.ReadLine();

            //creates a new contact object
            UserContacts contact = new ContactImpl(firstName, lastName, address, city, state, zipCode, country, phoneNumber, email);

            //add contact to the address book
            addressBook.AddContact(contact);
        }
    }
}
