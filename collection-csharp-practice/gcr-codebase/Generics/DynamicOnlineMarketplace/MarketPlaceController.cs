using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.DynamicOnlineMarketplace
{
    class MarketplaceController
    {
        ProductCatalog catalog = new ProductCatalog();

        public void Run()
        {
            while (true)
            {
                Console.WriteLine("\nDynamic Online Marketplace");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Add Clothing");
                Console.WriteLine("3. Apply Discount");
                Console.WriteLine("4. Display Products");
                Console.WriteLine("5. Exit");

                Console.Write("Choose option: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Enter book name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter price: ");
                            double price = double.Parse(Console.ReadLine());

                            Console.Write("Enter genre: ");
                            string genre = Console.ReadLine();

                            var book = new Product<BookCategory>(name, price, new BookCategory(genre));
                            catalog.AddProduct(book);

                            Console.WriteLine("Book added successfully!");
                            break;
                        }

                    case 2:
                        {
                            Console.Write("Enter clothing name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter price: ");
                            double price = double.Parse(Console.ReadLine());

                            Console.Write("Enter size: ");
                            int size = int.Parse(Console.ReadLine());

                            var clothing = new Product<ClothingCategory>(name, price, new ClothingCategory(size));
                            catalog.AddProduct(clothing);

                            Console.WriteLine("Clothes added successfully!");
                            break;
                        }

                    case 3:
                        {
                            Console.Write("Enter product name: ");
                            string name = Console.ReadLine();

                            Console.Write("Enter discount %: ");
                            double discount = double.Parse(Console.ReadLine());

                            var product = catalog.FindByName(name);

                            if (product != null)
                            {
                                catalog.ApplyDiscount(product, discount);
                                Console.WriteLine("Discount applied successfully!");
                            }
                            else
                            {
                                Console.WriteLine("Product not found!");
                            }
                            break;
                        }

                    case 4:
                        catalog.DisplayProducts();
                        break;

                    case 5:
                        return;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
