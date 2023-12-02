using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Dem02
{
    public class Phone
    {
            private string brand;
            private int year;

            public Phone(string brand, int year)
            {
                Brand = brand;
                Year = year;
            }

            public Phone(string brand, int year, double price):this(brand, year)
            {
                Price = price;
            }

            public string Brand
            {
                get { return brand; }
                set
                {
                    if (value.Length <= 0)
                    {
                        throw new ArgumentException("Invalid brand");
                    }
                    brand = value;
                }
            }
            public int Year
            {
                get { return year; }
                set
                {
                    if (value <= 2000)
                    {
                        throw new ArgumentException("Invalid year");
                    }
                    year = value;
                }
            }
            public double Price { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Price {Price}");
            sb.AppendLine($"Brand {Brand}");
            sb.AppendLine($"Year {Year}");
            return sb.ToString().TrimEnd();
        }
    }
    }

