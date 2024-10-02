using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_ShoesShop
{
    public abstract class Product
    {
        protected Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public string Name { get; private set; }
        public double Price { get; private set; }
        public int Quantity { get; private set; }
        public override string ToString()
        {
            return $"Product: {Name} with price {Price:f2}";
        }
    }
}
