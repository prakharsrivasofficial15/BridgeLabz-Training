using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCheckout
{
    internal interface ICheckoutOperations
    {
        void AddCustomer(Customer customer);     // Enqueue
        void RemoveCustomer();                   // Dequeue
        void ProcessBilling();                   // Billing logic
        void ViewNextCustomer();                 // Peek
        void ViewStock();                        // Display items
    }
}
