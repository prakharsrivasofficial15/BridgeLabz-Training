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
    }
}
