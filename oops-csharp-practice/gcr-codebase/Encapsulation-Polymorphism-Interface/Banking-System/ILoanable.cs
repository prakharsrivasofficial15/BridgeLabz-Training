using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Banking_System
{
    public interface ILoanable
    {
        void ApplyForLoan(decimal amount);
        bool CalculateLoanEligibility();
    }


}
