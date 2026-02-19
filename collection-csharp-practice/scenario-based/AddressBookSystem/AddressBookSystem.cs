using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookSystem
{
    internal class AddressBookSystem<T, TId>
        where T : UserContacts<TId>
    {
        // Case-insensitive dictionary
        private readonly Dictionary<string, AddressBook<T, TId>> addressBooks;

        public AddressBookSystem()
        {
            addressBooks = new Dictionary<string, AddressBook<T, TId>>(
                StringComparer.OrdinalIgnoreCase);
        }

        // ================= ADD ADDRESS BOOK =================
        public void AddAddressBook(string name)
        {
            if (addressBooks.ContainsKey(name))
            {
                Console.WriteLine("Address Book with this name already exists.");
                return;
            }

            addressBooks[name] = new AddressBook<T, TId>(name);
            Console.WriteLine("Address Book created successfully.");
        }

        // ================= GET ADDRESS BOOK =================
        public AddressBook<T, TId> GetAddressBook(string name)
        {
            addressBooks.TryGetValue(name, out var book);
            return book;
        }

        // ================= SEARCH ACROSS BOOKS =================
        public void SearchPersonByCity(string city)
        {
            var results = addressBooks.Values
                .SelectMany(book => book.GetContacts())
                .Where(contact =>
                    contact.City.Equals(city, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!results.Any())
            {
                Console.WriteLine("No contacts found in this city.");
                return;
            }

            results.ForEach(c => Console.WriteLine(c));
        }

        public void SearchPersonByState(string state)
        {
            var results = addressBooks.Values
                .SelectMany(book => book.GetContacts())
                .Where(contact =>
                    contact.State.Equals(state, StringComparison.OrdinalIgnoreCase))
                .ToList();

            if (!results.Any())
            {
                Console.WriteLine("No contacts found in this state.");
                return;
            }

            results.ForEach(c => Console.WriteLine(c));
        }

        // ================= COUNT ACROSS BOOKS =================
        public void CountByCity(string city)
        {
            int count = addressBooks.Values
                .SelectMany(book => book.GetContacts())
                .Count(contact =>
                    contact.City.Equals(city, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"Number of contacts in city '{city}': {count}");
        }

        public void CountByState(string state)
        {
            int count = addressBooks.Values
                .SelectMany(book => book.GetContacts())
                .Count(contact =>
                    contact.State.Equals(state, StringComparison.OrdinalIgnoreCase));

            Console.WriteLine($"Number of contacts in state '{state}': {count}");
        }
    }
}
