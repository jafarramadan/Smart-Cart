using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ElectronicsStore
    {
        private ProductGenerator productGenerator;

        public ElectronicsStore(ProductGenerator generator)
        {
            productGenerator = generator;
        }

        public void DisplayItems()
        {
            productGenerator.GenerateProduct("electronics");
        }
        public void UpdateItems(ShoppingCart shoppingCart)
        {
            int productIndex;
            if (!int.TryParse(Console.ReadLine(), out productIndex) || productIndex <= 0 || productIndex > productGenerator.ProductCategoryMap.Count)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

            var product = productGenerator.ProductCategoryMap.ElementAt(productIndex - 1).Value;
            shoppingCart.AddItems(product);
            Console.WriteLine($"{product.Name} has been added to your cart.");
        }
    }
}
