using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    //abstract class that represents a user's contact
    abstract class UserContacts
    {
        //private fields
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string state;
        private string zipCode;
        private string country;
        private string phoneNumber;
        private string email;

        //constructor to initialize all details
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

        public string FirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getAddress() { return address; }
        public string getCity() { return city; }
        public string getState() { return state; }
        public string getZipCode() { return zipCode; }
        public string getCountry() { return country; }
        public string getPhoneNumber() { return phoneNumber; }
        public string getEmail() { return email; }

        //overrides ToString method to return all entries in a single string
        public override string ToString()
        {
            return $"FirstName: {firstName} LastName: {lastName} Address: {address} City: {city} State: {state} ZipCode: {zipCode} Country: {country} PhoneNumber: {phoneNumber} Email: {email}";
        }

    }
}
