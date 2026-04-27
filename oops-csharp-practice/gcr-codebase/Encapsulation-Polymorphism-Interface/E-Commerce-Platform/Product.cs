using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Encapsulation_Polymorphism_Interface.E_Commerce_Platform
{
    using System;

    public abstract class Product
    {
        private int _productId;
        private string _name;
        private decimal _price;

        public int ProductId
        {
            get { return _productId; }
            protected set
            {
                if (value <= 0)
                    throw new ArgumentException("Product ID must be positive.");
                _productId = value;
            }
        }

        public string Name
        {
            get { return _name; }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException("Product name cannot be empty.");
                _name = value;
            }
        }

        public decimal Price
        {
            get { return _price; }
            protected set
            {
                if (value < 0)
                    throw new ArgumentException("Price cannot be negative.");
                _price = value;
            }
        }

        protected Product(int productId, string name, decimal price)
        {
            ProductId = productId;
            Name = name;
            Price = price;
        }

        public abstract decimal CalculateDiscount();

        public void DisplayBasicInfo()
        {
            Console.WriteLine("ID: " + ProductId);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
        }
    }

}
