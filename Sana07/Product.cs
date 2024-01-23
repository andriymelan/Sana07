using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public abstract class Product
    {
        protected string Name { get; set; }
        public double Price { get; protected set; }
        protected int Count { get; set; }
        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public Product()
        {
            Name = "NM";
            Price = 0;
            Count = 0;
        }
        public abstract string Display();
    }
}
