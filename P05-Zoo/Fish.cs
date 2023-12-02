using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Zoo
{
    public class Fish : Animal
    {
        private int yearLife;

        public Fish(string name, int age, int yearLife) : base(name, age)
        {
            YearLife = yearLife;
        }
        public int YearLife
        {
            get { return yearLife; }
            set
            {
                if (value<=0)
                {
                    throw new ArgumentException("Invalid number!");
                }
                yearLife = value;
            }
        }
        public void Swim()
        {
            Console.WriteLine("Swimming.... :)");
        }
        public override string ToString()
        {
            return base.ToString()+$"Life {YearLife}";
        }
    }
}
