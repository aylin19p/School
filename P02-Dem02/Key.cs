using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Dem02
{
    public class Key
    {
        private double price;
        private string material;

        public Key(double price, string material)
        {
            Price = price;
            Material = material;
        }

        public Key(double price, string material, string type): this(price, material)
        {
            Type = type;
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentException("");
                }
                price = value;
            }
        }
        public string Material
        {
            get { return material; }
            set
            {
                material = value;
            }
        }
        public string Type { get; set; }
        public override string ToString()
        {
            return $"Price: {Price}{Environment.NewLine}Material {Material}{Environment.NewLine}Type {Type}";
        }
    }
}
