using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;

namespace AddressBookSystem
{
    internal class DatabaseDataSource<T> : IDataSource<T>
        where T : UserContacts<int>
    {
        private readonly string connectionString;

        public DatabaseDataSource(string connectionString)
        {
            this.connectionString = connectionString;
        }

        // ================= INSERT =================
        public void Save(IEnumerable<T> contacts, string _)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            foreach (var contact in contacts)
            {
                var cmd = new SqlCommand(@"
                    IF NOT EXISTS (SELECT 1 FROM Contacts WHERE ContactId = @Id)
                    INSERT INTO Contacts 
                    (ContactId, FirstName, LastName, Address, City, State, ZipCode, Country, PhoneNumber, Email)
                    VALUES 
                    (@Id, @FirstName, @LastName, @Address, @City, @State, @Zip, @Country, @Phone, @Email)", conn);

                AddParameters(cmd, contact);
                cmd.ExecuteNonQuery();
            }

            Console.WriteLine("Contacts inserted into DB.");
        }

        // ================= LOAD =================
        public List<T> Load(string _)
        {
            var contacts = new List<T>();

            using var conn = new SqlConnection(connectionString);
            conn.Open();

            var cmd = new SqlCommand("SELECT * FROM Contacts", conn);
            var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var contact = (T)Activator.CreateInstance(
                    typeof(T),
                    reader.GetInt32(0),
                    reader.GetString(1),
                    reader.GetString(2),
                    reader.GetString(3),
                    reader.GetString(4),
                    reader.GetString(5),
                    reader.GetString(6),
                    reader.GetString(7),
                    reader.GetString(8),
                    reader.GetString(9)
                );

                contacts.Add(contact);
            }

            return contacts;
        }

        // ================= UPDATE =================
        public void Update(T contact, string _)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            var cmd = new SqlCommand(@"
                UPDATE Contacts SET
                    FirstName = @FirstName,
                    LastName = @LastName,
                    Address = @Address,
                    City = @City,
                    State = @State,
                    ZipCode = @Zip,
                    Country = @Country,
                    PhoneNumber = @Phone,
                    Email = @Email
                WHERE ContactId = @Id", conn);

            AddParameters(cmd, contact);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Contact updated in DB.");
        }

        // ================= DELETE =================
        public void Delete(int contactId, string _)
        {
            using var conn = new SqlConnection(connectionString);
            conn.Open();

            var cmd = new SqlCommand(
                "DELETE FROM Contacts WHERE ContactId = @Id", conn);

            cmd.Parameters.AddWithValue("@Id", contactId);
            cmd.ExecuteNonQuery();

            Console.WriteLine("Contact deleted from DB.");
        }

        // ================= PARAMETER HELPER =================
        private void AddParameters(SqlCommand cmd, T contact)
        {
            cmd.Parameters.AddWithValue("@Id", contact.ContactId);
            cmd.Parameters.AddWithValue("@FirstName", contact.FirstName);
            cmd.Parameters.AddWithValue("@LastName", contact.LastName);
            cmd.Parameters.AddWithValue("@Address", contact.Address);
            cmd.Parameters.AddWithValue("@City", contact.City);
            cmd.Parameters.AddWithValue("@State", contact.State);
            cmd.Parameters.AddWithValue("@Zip", contact.ZipCode);
            cmd.Parameters.AddWithValue("@Country", contact.Country);
            cmd.Parameters.AddWithValue("@Phone", contact.PhoneNumber);
            cmd.Parameters.AddWithValue("@Email", contact.Email);
        }
    }
}
