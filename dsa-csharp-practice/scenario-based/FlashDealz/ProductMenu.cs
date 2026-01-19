using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashDealz
{
    sealed class ProductMenu
    {
        private IProductService service = new ProductServiceImpl();

        public void Start()
        {
            while (true)
            {
                Console.WriteLine("\n1. Add Product");
                Console.WriteLine("2. Sort by Discount");
                Console.WriteLine("3. Display Products");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter Your Choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                        service.AddProduct(); 
                        break;

                    case 2: 
                        service.SortByDiscount(); 
                        break;

                    case 3: 
                        service.DisplayProducts(); 
                        break;

                    case 4: 
                        return;

                    default:
                        Console.WriteLine("Inavlid Choice");
                        break;
                }
            }
        }
    }

}
