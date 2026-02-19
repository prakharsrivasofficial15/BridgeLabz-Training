using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookSystem
{
    internal class AddressBook<T, TId> where T : UserContacts<TId>
    {
        private readonly string ownerName;
        private readonly List<T> contacts;

        // UC 8 & UC 9
        private readonly Dictionary<string, List<T>> cityMap;
        private readonly Dictionary<string, List<T>> stateMap;

        public AddressBook(string ownerName)
        {
            this.ownerName = ownerName;
            contacts = new List<T>();
            cityMap = new Dictionary<string, List<T>>(StringComparer.OrdinalIgnoreCase);
            stateMap = new Dictionary<string, List<T>>(StringComparer.OrdinalIgnoreCase);
        }

        public int CurrentCount => contacts.Count;

        // ===================== ADD =====================
        public void AddContact(T contact)
        {
            if (contacts.Contains(contact))
            {
                Console.WriteLine("Duplicate contact found. Contact not added.");
                return;
            }

            contacts.Add(contact);
            AddToCityDictionary(contact);
            AddToStateDictionary(contact);

            Console.WriteLine("Contact added successfully.");
        }

        // ===================== EDIT =====================
        public void EditContactByFirstName(string firstName)
        {
            var contact = contacts
                .FirstOrDefault(c => 
                    c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            // Remove old mapping (important if city/state changes)
            RemoveFromCityDictionary(contact);
            RemoveFromStateDictionary(contact);

            Console.Write("New Address: ");
            contact.Address = Console.ReadLine();

            Console.Write("New City: ");
            contact.City = Console.ReadLine();

            Console.Write("New State: ");
            contact.State = Console.ReadLine();

            Console.Write("New Zip Code: ");
            contact.ZipCode = Console.ReadLine();

            Console.Write("New Country: ");
            contact.Country = Console.ReadLine();

            Console.Write("New Phone Number: ");
            contact.PhoneNumber = Console.ReadLine();

            Console.Write("New Email: ");
            contact.Email = Console.ReadLine();

            // Add updated mapping
            AddToCityDictionary(contact);
            AddToStateDictionary(contact);

            Console.WriteLine("Contact updated successfully.");
        }

        // ===================== DELETE =====================
        public void DeleteContactByFirstName(string firstName)
        {
            var contact = contacts
                .FirstOrDefault(c => 
                    c.FirstName.Equals(firstName, StringComparison.OrdinalIgnoreCase));

            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            contacts.Remove(contact);
            RemoveFromCityDictionary(contact);
            RemoveFromStateDictionary(contact);

            Console.WriteLine("Contact deleted successfully.");
        }

        // ===================== DISPLAY =====================
        public void ShowContacts()
        {
            if (!contacts.Any())
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            contacts.ForEach(c => Console.WriteLine(c));
        }

        // ===================== SEARCH =====================
        public void SearchByCity(string city)
        {
            if (cityMap.TryGetValue(city, out var list))
                list.ForEach(c => Console.WriteLine(c));
            else
                Console.WriteLine("No contacts found in this city.");
        }

        public void CountByState(string state)
        {
            Console.WriteLine(
                stateMap.TryGetValue(state, out var list)
                ? $"Count: {list.Count}"
                : "No contacts found."
            );
        }

        // ===================== HELPERS =====================
        private void AddToCityDictionary(T contact)
        {
            if (!cityMap.ContainsKey(contact.City))
                cityMap[contact.City] = new List<T>();

            cityMap[contact.City].Add(contact);
        }

        private void AddToStateDictionary(T contact)
        {
            if (!stateMap.ContainsKey(contact.State))
                stateMap[contact.State] = new List<T>();

            stateMap[contact.State].Add(contact);
        }

        private void RemoveFromCityDictionary(T contact)
        {
            if (cityMap.TryGetValue(contact.City, out var list))
                list.Remove(contact);
        }

        private void RemoveFromStateDictionary(T contact)
        {
            if (stateMap.TryGetValue(contact.State, out var list))
                list.Remove(contact);
        }

        public IReadOnlyList<T> GetContacts() => contacts;

        // ===================== SORTING =====================

        public void SortByName()
        {
            contacts.Sort((c1, c2) =>
            {
                int first = string.Compare(
                    c1.FirstName, c2.FirstName,
                    StringComparison.OrdinalIgnoreCase);

                if (first != 0)
                    return first;

                return string.Compare(
                    c1.LastName, c2.LastName,
                    StringComparison.OrdinalIgnoreCase);
            });

            Console.WriteLine("Contacts sorted by name.");
        }

        public void SortByCity()
        {
            contacts.Sort((c1, c2) =>
                string.Compare(
                    c1.City, c2.City,
                    StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Contacts sorted by city.");
        }

        public void SortByState()
        {
            contacts.Sort((c1, c2) =>
                string.Compare(
                    c1.State, c2.State,
                    StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Contacts sorted by state.");
        }

        public void SortByZip()
        {
            contacts.Sort((c1, c2) =>
                string.Compare(
                    c1.ZipCode, c2.ZipCode,
                    StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Contacts sorted by zip code.");
        }

        public void SaveToFile(IDataSource<T> dataSource, string filePath)
        {
            dataSource.Save(contacts, filePath);
        }

        public void LoadFromFile(IDataSource<T> dataSource, string filePath)
        {
            var loadedContacts = dataSource.Load(filePath);

            contacts.Clear();
            cityMap.Clear();
            stateMap.Clear();

            foreach (var contact in loadedContacts)
            {
                contacts.Add(contact);
                AddToCityDictionary(contact);
                AddToStateDictionary(contact);
            }
        }
    }
}
