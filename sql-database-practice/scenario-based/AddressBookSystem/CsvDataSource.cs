using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;

namespace AddressBookSystem
{
    internal class CsvDataSource<T> : IDataSource<T>
        where T : UserContacts<int>
    {
        public void Save(IEnumerable<T> contacts, string filePath)
        {
            using (var writer = new StreamWriter(filePath))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(contacts);
            }

            Console.WriteLine("Contacts saved to CSV successfully.");
        }

        public List<T> Load(string filePath)
        {
            if (!File.Exists(filePath))
                return new List<T>();

            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                return new List<T>(csv.GetRecords<T>());
            }
        }
    }
}
