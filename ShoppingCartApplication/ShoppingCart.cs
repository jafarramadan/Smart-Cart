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

        public bool AddItems(Product item)
        {
            int count =items.Count;
            items.Add(item);
            if (count+1==items.Count) 
            {
                return true;
            }
            else
            {
            return false; 
            }
        }
        public bool removeItems(Product item) 
        {             
            int count = items.Count;
            items.Remove(item);
            if (count -1 == items.Count)
            {
                return true;
            }
            else
            {
                return false;
            }
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

        public int CalculateTotal()
        {   
            int count = 0;
            foreach (Product item in items)
            {
                count += item.Price;
            }
            Console.WriteLine($"\ntotal price is : {count}\n");

            return count;

           
        }
    }
}
