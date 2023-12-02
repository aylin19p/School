using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Zoo
{
    public class Animal
    {
        private string name;
        private int age;

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value;
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if (value<1)
                {
                    throw new ArgumentException("Invalid age");
                }
                age = value;
            }
        }
        public void Grow()
        {
            Age++;
        }
        public override string ToString()
        {
            return $"I am {Name}, {Age} age.";
        }
    }
}
