using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Zoo
{
    public class Monkey : Animal
    {
        private double weigh;

        public Monkey(string name, int age, double weigh) : base(name, age)
        {
            Weigh = weigh;
        }
        public double Weigh
        {
            get { return weigh; }
            set
            {
                if (value<=3)
                {
                    throw new ArgumentException("Invalid weigh");
                }
                weigh = value;
            }
        }
        public void IsHungry()
        {
            Console.WriteLine("I need banana!");
        }
        public override string ToString()
        {
            return base.ToString()+ $"Weigh: {Weigh:f2}";
        }
    }
}
