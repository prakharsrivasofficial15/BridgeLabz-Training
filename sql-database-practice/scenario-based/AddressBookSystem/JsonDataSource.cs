using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace AddressBookSystem
{
    internal class JsonDataSource<T> : IDataSource<T>
    {
        private readonly JsonSerializerOptions options =
            new JsonSerializerOptions
            {
                WriteIndented = true
            };

        public void Save(IEnumerable<T> contacts, string filePath)
        {
            var json = JsonSerializer.Serialize(contacts, options);
            File.WriteAllText(filePath, json);

            Console.WriteLine("Contacts saved to JSON successfully.");
        }

        public List<T> Load(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<T>();

            var json = File.ReadAllText(filePath);

            var contacts = JsonSerializer.Deserialize<List<T>>(json, options);

            Console.WriteLine("Contacts loaded from JSON successfully.");
            return contacts ?? new List<T>();
        }
    }
}
