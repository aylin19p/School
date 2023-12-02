using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Dem02
{
    public class Refrigerator
    {
        private string brand;
        private char classs;

        public Refrigerator(string brand, double price)
        {
            Brand = brand;
            Price = price;
        }

        public Refrigerator(string brand, char classs, double price):this(brand, price)
        {
            Class = classs;
        }

        public string Brand
        {
            get { return brand; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid brand");
                }
                brand = value;
            }
        }
        public char Class
        {
            get { return classs; }
            set
            {
                if (classs != 'A' || classs != 'B'|| classs !='C')
                {
                    throw new ArgumentException("Invlid class");
                }
                classs = value;
            }
        }
        public double Price { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Brand {Brand}");
            sb.AppendLine($"Class {Class}");
            sb.AppendLine($"Price {Price}");
            return sb.ToString().TrimEnd();
        }
    }
}
