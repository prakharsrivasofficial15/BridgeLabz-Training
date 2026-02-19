using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    abstract class UserContacts<TId>
    {
        // Properties (CSV requires public get/set)
        public TId ContactId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // Collection (UC 11)
        private Dictionary<string, string> extraDetails 
            = new Dictionary<string, string>();

        protected UserContacts() 
        {
            // Required for CsvHelper deserialization
        }

        protected UserContacts(
            TId contactId,
            string firstName,
            string lastName,
            string address,
            string city,
            string state,
            string zipCode,
            string country,
            string phoneNumber,
            string email)
        {
            ContactId = contactId;
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            City = city;
            State = state;
            ZipCode = zipCode;
            Country = country;
            PhoneNumber = phoneNumber;
            Email = email;
        }

        // Collection operations
        public void AddExtraDetail(string key, string value)
        {
            extraDetails[key] = value;
        }

        public string? GetExtraDetail(string key)
        {
            return extraDetails.TryGetValue(key, out var value)
                ? value
                : null;
        }

        public override string ToString()
        {
            return $"ID: {ContactId}, Name: {FirstName} {LastName}, City: {City}, Phone: {PhoneNumber}, Email: {Email}";
        }

        // Duplicate check (UC 7)
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            var other = (UserContacts<TId>)obj;

            return FirstName.Equals(other.FirstName, StringComparison.OrdinalIgnoreCase)
                && LastName.Equals(other.LastName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName).ToLower().GetHashCode();
        }
    }
}
