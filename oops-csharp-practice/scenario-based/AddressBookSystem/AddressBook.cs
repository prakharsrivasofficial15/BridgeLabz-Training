using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        private string ownerName;              // owner of the address book
        private int size;                      // maximum number of contacts
        private UserContacts[] contacts;       // contacts array
        private int currentIndex = 0;          // next empty slot index

        // Constructor
        public AddressBook(string ownerName, int size)
        {
            this.ownerName = ownerName;
            this.size = size;
            contacts = new UserContacts[size];
        }

        // UC-3: Add Contact
        public void AddContact(UserContacts contact)
        {
            // Check if address book is full
            if (currentIndex >= size)
            {
                Console.WriteLine("Address Book is full.");
                return;
            }

            // UC-6: Duplicate check BEFORE adding
            if (IsDuplicateContact(contact))
            {
                Console.WriteLine("Duplicate contact found. Contact not added.");
                return;
            }

            contacts[currentIndex] = contact;
            currentIndex++;

            Console.WriteLine("Contact added successfully.");
        }

        // UC-6: Show Contacts
        public void ShowContacts()
        {
            if (currentIndex == 0)
            {
                Console.WriteLine("No contacts in the address book.");
                return;
            }

            Console.WriteLine($"Contacts in {ownerName}'s Address Book:");
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine(contacts[i]);
            }
        }

        // UC-4: Edit Contact by First Name
        public void EditContactByFirstName(string firstName)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contact found. Enter new details:");

                    Console.Write("New Address: ");
                    contacts[i].SetAddress(Console.ReadLine());

                    Console.Write("New City: ");
                    contacts[i].SetCity(Console.ReadLine());

                    Console.Write("New State: ");
                    contacts[i].SetState(Console.ReadLine());

                    Console.Write("New Zip Code: ");
                    contacts[i].SetZipCode(Console.ReadLine());

                    Console.Write("New Country: ");
                    contacts[i].SetCountry(Console.ReadLine());

                    Console.Write("New Phone Number: ");
                    contacts[i].SetPhoneNumber(Console.ReadLine());

                    Console.Write("New Email: ");
                    contacts[i].SetEmail(Console.ReadLine());

                    Console.WriteLine("Contact updated successfully.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        // UC-5: Delete Contact
        public void DeleteContactByFirstName(string firstName)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (contacts[i].FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase))
                {
                    // Shift left
                    for (int j = i; j < currentIndex - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }

                    contacts[currentIndex - 1] = null;
                    currentIndex--;

                    Console.WriteLine("Contact deleted successfully.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

        //Duplicate check helper
        public bool IsDuplicateContact(UserContacts contact)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (contacts[i].Equals(contact))
                {
                    return true;
                }
            }
            return false;
        }
        //returns who owns this Address Book
        public string OwnerName
        {
            get { return ownerName; }
        }
        // This method gives us access to all the contacts stored in this Address Book. It returns the full array of contacts, even if some slots are empty
        public UserContacts[] GetContacts()
        {
            return contacts;
        }
        //method tells how many contacts are currently added to the Address Book
        public int GetContactCount()
        {
            return currentIndex;
        }

        public int CurrentCount => currentIndex;

        public UserContacts GetContactAt(int index)
        {
            if (index < 0 || index >= currentIndex)
                return null;

            return contacts[index];
        }

    }
}
