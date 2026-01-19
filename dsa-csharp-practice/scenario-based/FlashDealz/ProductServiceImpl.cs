using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlashDealz
{
    class ProductServiceImpl : IProductService
    {
        private Product[] products = new Product[100];
        private int count = 0;

        private QuickSortAlgorithm algo = new QuickSortAlgorithm();

        public void AddProduct()
        {
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Discount: ");
            int discount = int.Parse(Console.ReadLine());

            products[count++] = new ConcreteProduct(id, name, discount);
        }

        public void SortByDiscount()
        {
            algo.QuickSort(products, 0, count - 1);
            Console.WriteLine("Products sorted by discount (High → Low)");
        }

        public void DisplayProducts()
        {
            for (int i = 0; i < count; i++)
                Console.WriteLine(products[i]);
        }
    }

}
