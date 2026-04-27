using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // Abstract class that represents a user's contact
    abstract class UserContacts
    {
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

        // Constructor
        public UserContacts(string firstName, string lastName, string address, string city, string state, string zipCode, string country, string phoneNumber, string email)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zipCode = zipCode;
            this.country = country;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        // Properties
        public string FirstName => firstName;
        public string LastName => lastName;
        public string Address => address;
        public string City => city;
        public string State => state;
        public string ZipCode => zipCode;
        public string Country => country;
        public string PhoneNumber => phoneNumber;
        public string Email => email;

        // Setters used for edit operations
        public void SetAddress(string address) => this.address = address;
        public void SetCity(string city) => this.city = city;
        public void SetState(string state) => this.state = state;
        public void SetZipCode(string zipCode) => this.zipCode = zipCode;
        public void SetCountry(string country) => this.country = country;
        public void SetPhoneNumber(string phoneNumber) => this.phoneNumber = phoneNumber;
        public void SetEmail(string email) => this.email = email;

        // Display contact details
        public override string ToString()
        {
            return $"First Name: {firstName}, Last Name: {lastName}, Address: {address}, City: {city}, State: {state}, Zip Code: {zipCode}, Country: {country}, Phone: {phoneNumber}, Email: {email}";
        }

        public override bool Equals(object obj)
        {
            if (this == obj)
                return true;

            if (obj == null || GetType() != obj.GetType())
                return false;

            UserContacts other = (UserContacts)obj;

            return this.firstName.Equals(other.firstName, StringComparison.OrdinalIgnoreCase)
                && this.lastName.Equals(other.lastName, StringComparison.OrdinalIgnoreCase);
        }

        public override int GetHashCode()
        {
            return (firstName + lastName).ToLower().GetHashCode();
        }
    }
}
