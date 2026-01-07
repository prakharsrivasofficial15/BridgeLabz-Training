using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.Library_Management
{
    public class Magazine : LibraryItem
    {
        public Magazine(int itemId, string title, string author)
            : base(itemId, title, author)
        {
        }

        public override int GetLoanDuration()
        {
            return 7;
        }
    }

}
