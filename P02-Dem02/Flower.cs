using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Dem02
{
    public class Flower
    {
            private string type;
            private string color;

            public Flower(string type, string color)
            {
                Type = type;
                Color = color;
            }

            public Flower(string type, string color, int yearsLife):this(type, color) 
            {
                YearsLife = yearsLife;
            }

            public string Type
            {
                get { return type; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("Invalid type");
                    }
                    type = value;
                }
            }
            public string Color
            {
                get { return color; }
                set
                {
                    if (string.IsNullOrEmpty(value)) { throw new ArgumentException("Invalid color"); }
                    color = value;
                }
            }
            public int YearsLife { get; set; }
        public override string ToString()
        {
            return $"Type: {Type},Color: {Color},YearsLife {YearsLife}";
        }
    }
}
