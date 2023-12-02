using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Zoo
{
    public class Cat : Animal
    {
        private string fur;

        public Cat(string name, int age, string fur) : base(name, age)
        {
            Fur = fur;
        }
        public string Fur
        {
            get { return fur; }
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Invalid fur");
                }
                fur = value;
            }
        }
        public void Hungry()
        {
            Console.WriteLine("I need milk");
        }
        public override string ToString()
        {
            return base.ToString()+$"Fur: {Fur}";
        }
    }
}
