using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class ContactImpl : UserContacts<int>
    {
        public ContactImpl(
            int id,
            string firstName,
            string lastName,
            string address,
            string city,
            string state,
            string zipCode,
            string country,
            string phoneNumber,
            string email)
            : base(id, firstName, lastName, address, city, state, zipCode, country, phoneNumber, email)
        {
        }
    }
}
