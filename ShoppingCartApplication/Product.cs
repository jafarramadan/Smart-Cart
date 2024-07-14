using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public enum ProductCategory
    {
        Food,
        Clothing,
        Electronics

    }
    public class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public ProductCategory Category { get; set; }

        public Product(string name, int price, ProductCategory category)
        {
            Name = name;
            Price = price;
            Category = category;
        }
        public override string ToString()
        {
            return $"product name : {Name} \n price :  {Price} \n category :  {Category}";
        }
    }
}
