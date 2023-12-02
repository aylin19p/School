using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P04_ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public double Length
        {
            get { return length; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Length cannot be 0 or negative!");
                }
                length = value;
            }
        }
        public double Width
        {
            get { return width; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Width cannot be 0 or negative!");
                }
                width = value;
            }
        }
        public double Height
        {
            get { return height; }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Height cannot be 0 or negative!");
                }
                height = value;
            }
        }
        public override string ToString()
        {
            double surfaceare = 2*Length*Width + 2*Length*Height + 2*Width*Height;
            double volume = Length * Height * Width;
            double lateralSurfaceArea = 2 * Length * Height + 2 * Width * Height;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {surfaceare:f2}");
            sb.AppendLine($"Lateral Surface Area - {lateralSurfaceArea:f2}");
            sb.AppendLine($"Volume - {volume:f2}");
            return sb.ToString().TrimEnd();
        }
    }
}
