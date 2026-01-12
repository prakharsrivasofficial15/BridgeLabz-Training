using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoanBuddy
{
    public interface IApprovable
    {
        bool ApproveLoan();
        double CalculateEMI();
    }

}
