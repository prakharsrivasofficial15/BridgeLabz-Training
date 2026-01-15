using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal interface IAddressBook
    {
        //add new contact to the address book 
        void AddContact();
        //edit the existing contact
        void EditContact();
        //delete the contact
        void DeleteContact();
        //show all contacts
        void ShowContacts();
        //create new address book
        void CreateAddressBook();
        //create new address book
        void SelectAddressBook();
    }
}
