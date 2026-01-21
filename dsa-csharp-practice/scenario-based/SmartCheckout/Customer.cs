using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartCheckout
{
    abstract class Customer
    {
        protected int customerId;
        protected string customerName;
        protected double totalBill;
        protected string[] items;

        public Customer(int customerId, string customerName, string[] items)
        {
            this.customerId = customerId;
            this.customerName = customerName;
            this.totalBill = 0;
            this.items = items;
        }

        public int CustomerId => customerId;
        public string CustomerName => customerName;
        public double TotalBill { get => totalBill; set => totalBill = value; }
        public string[] Items => items;

        public override string ToString()
        {
            return $"Name: {customerName} Id: {customerId} Bill: {totalBill}";
        }
    }
}
