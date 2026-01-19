using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashDealz
{
    abstract class Product
    {
        protected int productId;
        protected string name;
        protected int discount;

        public Product(int id, string name, int discount)
        {
            this.productId = id;
            this.name = name;
            this.discount = discount;
        }

        public int GetDiscount() => discount;
        //converts object data to readable format
        public override string ToString()
        {
            return $"ID: {productId}, Name: {name}, Discount: {discount}%";
        }
    }

}
