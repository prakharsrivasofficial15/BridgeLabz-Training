using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.DynamicOnlineMarketplace
{
    class ProductCatalog : ICatalog
    {
        private List<ProductBase> products = new List<ProductBase>();

        public void AddProduct(ProductBase product)
        {
            products.Add(product);
        }

        public void DisplayProducts()
        {
            Console.WriteLine("\nProduct Catalog");
            foreach (var product in products)
                product.Display();
        }

        // Generic method with constraint
        public void ApplyDiscount<T>(T product, double percentage) where T : ProductBase
        {
            product.Price -= product.Price * (percentage / 100);
        }

        public ProductBase FindByName(string name)
        {
            return products.FirstOrDefault(p => p.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }
    }
}
