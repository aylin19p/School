using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Wall
{
    private double lenght;

    public double Height { get; set; }
    public double Lenght
    {
        get { return lenght; }
        set
        {
           if (value < 0)
            {
                throw new ArgumentException("Invalid number");
            }
            lenght = value;
        }
    }
    public string Color { get; set; }
}


