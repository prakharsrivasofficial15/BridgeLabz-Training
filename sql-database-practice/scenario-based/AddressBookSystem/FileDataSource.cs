using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AddressBookSystem
{
    internal class FileDataSource<T> : IDataSource<T>
        where T : UserContacts<int>
    {
        public void Save(IEnumerable<T> contacts, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (var contact in contacts)
                {
                    string line = string.Join("|",
                        contact.ContactId,
                        contact.FirstName,
                        contact.LastName,
                        contact.SetAddress,
                        contact.City,
                        contact.State,
                        contact.ZipCode,
                        contact.SetCountry,
                        contact.SetPhoneNumber,
                        contact.SetEmail);

                    writer.WriteLine(line);
                }
            }

            Console.WriteLine("Contacts saved to file successfully.");
        }

        public List<T> Load(string filePath)
        {
            var contacts = new List<T>();

            if (!File.Exists(filePath))
                return contacts;

            foreach (var line in File.ReadAllLines(filePath))
            {
                var parts = line.Split('|');

                var contact = (T)Activator.CreateInstance(
                    typeof(T),
                    int.Parse(parts[0]),
                    parts[1], parts[2], parts[3], parts[4],
                    parts[5], parts[6], parts[7],
                    parts[8], parts[9]);

                contacts.Add(contact);
            }

            Console.WriteLine("Contacts loaded from file successfully.");
            return contacts;
        }
    }
}
