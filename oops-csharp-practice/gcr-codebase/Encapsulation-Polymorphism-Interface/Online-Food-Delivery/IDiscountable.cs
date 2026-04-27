using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Online_Food_Delivery
{
    public interface IDiscountable
    {
        decimal ApplyDiscount();
        string GetDiscountDetails();
    }


}
