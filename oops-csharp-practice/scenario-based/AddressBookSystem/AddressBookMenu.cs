using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal class AddressBookMenu
    {
        private IAddressBook addressBook;
        public void Start()
        {
            addressBook = new AddressBookUtilityImpl();
            while (true)
            {
                Console.WriteLine("\n1. Create Address Book");
                Console.WriteLine("2. Select Address Book");
                Console.WriteLine("3. Add Contact");
                Console.WriteLine("4. Edit Contact");
                Console.WriteLine("5. Delete Contact");
                Console.WriteLine("6. Show Contacts");
                Console.WriteLine("7. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // UC 5: create a new Address Book with a unique name
                        addressBook.CreateAddressBook();
                        break;

                    case 2:
                        // UC 5: select an existing Address Book by name
                        addressBook.SelectAddressBook();
                        break;

                    case 3:
                        // UC 1 & 4: Add a new contact and allow adding multiple contacts
                        addressBook.AddContact();
                        break;

                    case 4:
                        // UC 2:edit an existing contact using first name
                        addressBook.EditContact();
                        break;

                    case 5:
                        // UC 3: delete a contact using first name
                        addressBook.DeleteContact();
                        break;

                    case 6:
                        // UC 4: display all contacts in the selected Address Book
                        addressBook.ShowContacts();
                        break;

                    case 7:
                        // Exit
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
