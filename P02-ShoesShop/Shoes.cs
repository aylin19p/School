using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_ShoesShop
{
    public class Shoes : Product
    {
        private double number;
        private string color;

        public Shoes(string name, double price, int quantity, double number, int yearsWarranty, string brand) : base(name, price, quantity)
        {
            Number = number;
            YearsWarranty = yearsWarranty;
            Brand = brand;
        }
        public double Number
        {
            get { return number; }
            private set
            {
                if (value < 20)
                {
                    throw new ArgumentException("Invalid number!");
                }
                number = value;
            }
        }
        public int YearsWarranty { get; private set; }
        public string Color
        {
            get { return color; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid color");
                }
                color = value;
            }
        }
        public string Brand { get; private set; }
    }
}
