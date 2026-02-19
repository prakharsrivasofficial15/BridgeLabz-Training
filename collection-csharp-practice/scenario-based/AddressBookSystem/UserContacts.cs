using System;
using System.Collections.Generic;

namespace AddressBookSystem
{
    abstract class UserContacts<TId>
    {
        // Generic ID
        protected TId contactId;

        // Private fields
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string country;
        private string phoneNumber;
        private string email;

        // Collection (UC 11)
        private Dictionary<string, string> extraDetails;

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
            this.contactId = contactId;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.country = country;
            this.phoneNumber = phoneNumber;
            this.email = email;

            extraDetails = new Dictionary<string, string>();
        }

        // public UserContacts(string? firstName, string? lastName, string? address, string? city, string? state, string? zipCode, string? country, string? phoneNumber, string? email)
        // {
        //     this.firstName = firstName;
        //     this.lastName = lastName;
        //     this.address = address;
        //     this.city = city;
        //     this.state = state;
        //     this.zipCode = zipCode;
        //     this.country = country;
        //     this.phoneNumber = phoneNumber;
        //     this.email = email;
        // }

        // Read-only properties
        public TId ContactId => contactId;
        public string FirstName => firstName;
        public string LastName => lastName;
        public string City => city;
        public string State => state;
        public string ZipCode => zipCode;

        // Edit operations
        public void SetAddress(string address) => this.address = address;
        public void SetCity(string city) => this.city = city;
        public void SetState(string state) => this.state = state;
        public void SetZipCode(string zipCode) => this.zipCode = zipCode;
        public void SetCountry(string country) => this.country = country;
        public void SetPhoneNumber(string phoneNumber) => this.phoneNumber = phoneNumber;
        public void SetEmail(string email) => this.email = email;

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
            return $"ID: {contactId}, Name: {firstName} {lastName}, City: {city}, Phone: {phoneNumber}, Email: {email}";
        }

        // UC 7: Duplicate check
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            UserContacts<TId> other = (UserContacts<TId>)obj;

            return firstName.Equals(other.firstName, StringComparison.OrdinalIgnoreCase)
                && lastName.Equals(other.lastName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return (firstName + lastName).ToLower().GetHashCode();
        }
    }
}
