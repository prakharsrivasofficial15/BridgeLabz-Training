using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    internal interface IAddressBook<T, TId> where T : UserContacts<TId>
    {
        //add new contact to the address book 
        void AddContact();
        //edit the existing contact
        void EditContact();
        //delete the contacts
        void DeleteContact();
        //show all contacts
        void ShowContacts();
        //create new address book
        void CreateAddressBook();
        //create new address book
        void SelectAddressBook();
        //search person by city
        void SearchByCity();
        //search person by state
        void SearchByState();
        //search Number of Contacts by City
        void CountByCity();
        //search Number of Contacts by state
        void CountByState();
        void SortContactsByName();
        void SortContactsByCity();
        void SortContactsByState();
        void SortContactsByZip();
        void SaveToFile();
        void LoadFromFile();
        void SaveToCsv();
        void LoadFromCsv();
        void SaveToJson();
        void LoadFromJson();
    }
}