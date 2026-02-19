using System;

namespace AddressBookSystem
{
    internal class AddressBookUtilityImpl 
        : IAddressBook<ContactImpl, int>
    {
        private readonly AddressBookSystem<ContactImpl, int> system;
        private AddressBook<ContactImpl, int> activeBook;

        private int contactIdCounter = 1;

        private readonly IDataSource<ContactImpl> fileDataSource = new FileDataSource<ContactImpl>();

        public AddressBookUtilityImpl()
        {
            system = new AddressBookSystem<ContactImpl, int>();
            activeBook = null;
        }

        // ================= CREATE =================
        public void CreateAddressBook()
        {
            Console.Write("Enter Address Book Name: ");
            string name = Console.ReadLine();

            system.AddAddressBook(name);
            activeBook = system.GetAddressBook(name);

            if (activeBook != null)
                Console.WriteLine("Address Book created and selected successfully.");
        }

        // ================= SELECT =================
        public void SelectAddressBook()
        {
            Console.Write("Enter Address Book Name to Select: ");
            string name = Console.ReadLine();

            activeBook = system.GetAddressBook(name);

            Console.WriteLine(activeBook == null
                ? "Address Book not found."
                : "Address Book selected.");
        }

        // ================= ADD CONTACT =================
        public void AddContact()
        {
            if (!EnsureActiveBook()) return;

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

            var contact = new ContactImpl(
                contactIdCounter++,   // ID added
                firstName,
                lastName,
                address,
                city,
                state,
                zipCode,
                country,
                phoneNumber,
                email
            );

            activeBook.AddContact(contact);
        }

        // ================= EDIT =================
        public void EditContact()
        {
            if (!EnsureActiveBook()) return;

            Console.Write("Enter First Name of contact to edit: ");
            string name = Console.ReadLine();

            activeBook.EditContactByFirstName(name);
        }

        // ================= DELETE =================
        public void DeleteContact()
        {
            if (!EnsureActiveBook()) return;

            Console.Write("Enter First Name of contact to delete: ");
            string name = Console.ReadLine();

            activeBook.DeleteContactByFirstName(name);
        }

        // ================= SHOW =================
        public void ShowContacts()
        {
            if (!EnsureActiveBook()) return;

            activeBook.ShowContacts();
        }

        // ================= SEARCH =================
        public void SearchByCity()
        {
            Console.Write("Enter city name to search: ");
            string city = Console.ReadLine();
            system.SearchPersonByCity(city);
        }

        public void SearchByState()
        {
            Console.Write("Enter state name to search: ");
            string state = Console.ReadLine();
            system.SearchPersonByState(state);
        }

        // ================= COUNT =================
        public void CountByCity()
        {
            Console.Write("Enter city name: ");
            string city = Console.ReadLine();
            system.CountByCity(city);
        }

        public void CountByState()
        {
            Console.Write("Enter state name: ");
            string state = Console.ReadLine();
            system.CountByState(state);
        }

        // ================= SORT =================
        public void SortContactsByName()
        {
            if (!EnsureActiveBook()) return;

            activeBook.SortByName();
            activeBook.ShowContacts();
        }

        public void SortContactsByCity()
        {
            if (!EnsureActiveBook()) return;

            activeBook.SortByCity();
            activeBook.ShowContacts();
        }

        public void SortContactsByState()
        {
            if (!EnsureActiveBook()) return;

            activeBook.SortByState();
            activeBook.ShowContacts();
        }

        public void SortContactsByZip()
        {
            if (!EnsureActiveBook()) return;

            activeBook.SortByZip();
            activeBook.ShowContacts();
        }

        // ================= HELPER =================
        private bool EnsureActiveBook()
        {
            if (activeBook == null)
            {
                Console.WriteLine("Select an Address Book first.");
                return false;
            }
            return true;
        }

        public void SaveToFile()
        {
            if (!EnsureActiveBook()) return;

            Console.Write("Enter file path: ");
            string path = Console.ReadLine();

            activeBook.SaveToFile(fileDataSource, path);
        }

        public void LoadFromFile()
        {
            if (!EnsureActiveBook()) return;

            Console.Write("Enter file path: ");
            string path = Console.ReadLine();

            activeBook.LoadFromFile(fileDataSource, path);
        }
    }
}
