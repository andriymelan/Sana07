using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public class ShoppingCart
    {
        protected Product []product = new Product[0];
        public void AddToShoppingCart(Product product)
        {
            Array.Resize(ref this.product, this.product.GetLength(0)+1);
            this.product[this.product.GetLength(0) - 1] = product;
        }
        public string ShowCart()
        {
            string str = "Your shopping cart:\n";
            for (int i = 0; i < product.GetLength(0); i++)
            {
                str = string.Concat($"{str} {product[i].Display()} \n");
            }
            return str;
        }
        public string GetPrice()
        {
            double Price = 0;
            for (int i = 0;i < product.GetLength(0); i++)
            {
                Price += product[i].Price; 
            }
            return $"Price of all items: {Price}";
        }
    }
}
