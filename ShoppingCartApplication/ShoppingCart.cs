using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ShoppingCart
    {
        List<Product> items=new List<Product> { };

        public void AddItems(Product item)
        {
            items.Add(item);
        }
        public void removeItems(Product item) 
        { 
            items.Remove(item);        
        }

        public void ViewItems()
        {
            int count = 0;
           
            foreach (Product item in items)
            {
                count++;
                Console.WriteLine($"{count}-{item}");
            }
        }

        public void CalculateTotal()
        {   
            int count = 0;
            foreach (Product item in items)
            {
                count += item.Price;
            }
            Console.WriteLine($"\ntotal price is : {count}\n");

           
        }
    }
}
