using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Library_Management
{
    public interface IReservable
    {
        void ReserveItem(string borrowerName);
        bool CheckAvailability();
    }
}
