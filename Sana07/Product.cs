using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sana07
{
    public abstract class Product
    {
        protected string _Name;
        protected double _Price;
        protected int _Count;
        protected String Name
        {
            get => _Name;
            set
            {
                if (value != "")
                    _Name = value;
                else
                    throw new MyExceptions("Name", "Product");
            }
        }
        public double Price
        {
            get => _Price;
            protected set {
                if (value >= 0)
                    _Price = value;
                else
                    throw new MyExceptions("Price","Product");
            }
        }
        protected int Count
        {
            get => _Count;
            set
            {
                if (value >= 0)
                    _Count = value;
                else
                    throw new MyExceptions("Count", "Product");
            }
        }
        public Product(string name, double price, int count)
        {
            Name = name;
            Price = price;
            Count = count;
        }
        public Product()
        {
            Name = "NM";
            Price = 1;
            Count = 1;
        }
        public abstract string Display();
    }
}
