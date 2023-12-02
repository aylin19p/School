using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Zoo
{
    public class Dog : Animal
    {
        private string breed;

        public Dog(string name, int age, string breed) : base(name, age)
        {
            Breed = breed;
        }
        public string Breed
        {
            get { return breed; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid breed");
                }
                breed = value;
            }
        }
        public void Weep()
        {
            Console.WriteLine("Weeping");
        }
        public override string ToString()
        {
            return base.ToString()+$"Breed: {Breed}";
        }
    }
}
