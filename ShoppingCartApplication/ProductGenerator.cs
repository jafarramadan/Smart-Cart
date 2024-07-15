using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ProductGenerator
    {
      public  Dictionary<string, Product> ProductCategoryMap;
        public void InitializeProducts()
        {

            ProductCategoryMap = new Dictionary<string, Product>
            {
                {"pizza", new Product("pizza", 10, ProductCategory.Food)},
                {"mansaf", new Product("mansaf", 15, ProductCategory.Food)},
                {"pasta", new Product("pasta", 8, ProductCategory.Food)},

                {"t-Shirt", new Product("t-Shirt", 10, ProductCategory.Clothing)},
                {"jeans", new Product("jeans", 40, ProductCategory.Clothing)},
                {"jacket", new Product("jacket", 50, ProductCategory.Clothing)},

                {"tablet", new Product("tablet", 150, ProductCategory.Electronics)},
                {"headphones", new Product("headphones", 60, ProductCategory.Electronics)},
                {"phone", new Product("phone", 100, ProductCategory.Electronics)}
            };
            
            

        }
        public void GenerateProduct(string category)
        {
            int count = 0;
            foreach (var item in ProductCategoryMap.Values)
            {
                count++;
                if (item.Category.ToString().ToLower() == category.ToLower())
                {
                    Console.WriteLine($"{count}-{item}");
                    
                }
                
            }
            
        }

        public Product RandomItemes()
        {
            var keys = new List<string>(ProductCategoryMap.Keys);
            var random = new Random();
            int randomIndex = random.Next(keys.Count);
            string randomKey = keys[randomIndex];
            Product randomProduct = ProductCategoryMap[randomKey];
            Console.WriteLine($"Random Product:\n {randomProduct}");
            return randomProduct;   
        }

        
    }
}
