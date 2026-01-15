using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBook
    {
        private string ownerName;         //onwer of the address book
        private int size;                 //maximum number of contacts
        private UserContacts[] contacts;  //contacts array
        private int currentIndex = 0;  // keeps track of next empty slot

        //constructor initialize the address book
        public AddressBook(string ownerName, int size)
        {
            this.ownerName = ownerName;
            this.size = size;
            contacts = new UserContacts[size];
        }

        //Method to add a contact to the address book
        public void AddContact(UserContacts contact)
        {
            if (currentIndex >= size)                            //check if the address book is full
            {
                Console.WriteLine("Address Book is full");
                return;
            }

            contacts[currentIndex] = contact;                   //add contact to the current index
            currentIndex++;                                     //counter increment
            Console.WriteLine("Contact added successfully");
        }

        public void ShowContacts()
        {
            if (currentIndex == 0)
            {
                Console.WriteLine("No contacts in the address book");
                return;
            }

            Console.WriteLine($"Contacts in {ownerName}'s Address Book:");
            for (int i = 0; i < currentIndex; i++)
            {
                Console.WriteLine(contacts[i]);
            }
        }

        //Edit the details of the person by searching by the first name of the person
        public void EditContactByFirstName(string firstName)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (contacts[i].FirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Contact Found. Enter new details:");

                    Console.Write("New Address: ");
                    contacts[i].SetAddress(Console.ReadLine());

                    Console.Write("New City: ");
                    contacts[i].SetCity(Console.ReadLine());

                    Console.Write("New State: ");
                    contacts[i].SetState(Console.ReadLine());

                    Console.Write("New ZipCode: ");
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
        //delete a person using person's name
        public void DeleteContactByFirstName(string firstName)
        {
            for (int i = 0; i < currentIndex; i++)
            {
                if (contacts[i].FirstName().Equals(firstName, StringComparison.OrdinalIgnoreCase))
                {
                    // Shift elements to the left
                    for (int j = i; j < currentIndex - 1; j++)
                    {
                        contacts[j] = contacts[j + 1];
                    }

                    contacts[currentIndex - 1] = null; // clear last slot
                    currentIndex--;

                    Console.WriteLine("Contact deleted successfully.");
                    return;
                }
            }

            Console.WriteLine("Contact not found.");
        }

    }
}
