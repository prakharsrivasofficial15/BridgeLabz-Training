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
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Exit");


                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        // UC-2: Add a contact
                        addressBook.AddContact();
                        break;

                    case 2:
                        // UC-2: edit a existing contact
                        addressBook.EditContact();
                        break;

                    case 3:
                        return;

                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }
        }
    }
}
