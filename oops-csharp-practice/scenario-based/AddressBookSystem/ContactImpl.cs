using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    /* Implementation class for a user's contact. Inherits from the abstract class UserContacts*/
    class ContactImpl : UserContacts
    {
        // Constructor calls the base abstract class constructor to initialize contact fields
        public ContactImpl(string firstName, string lastName, string address, string city, string state, string zipCode, string country, string phoneNumber, string email) : base(firstName, lastName, address, city, state, zipCode, country, phoneNumber, email)
        {
        }
    }
}
