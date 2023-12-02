using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_Dem02
{
    public class Animal
    {
        private string name;
        private int age;

        public Animal(int age, string name)
        {
            Age = age;
            Name = name;
        }

        public Animal(int age, string name, double weight):this( age,name)
        {
            Weight = weight;
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 2)
                {
                    throw new ArgumentException("Invalid age");
                }
                age = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length <= 2)
                {
                    throw new ArgumentException("Invalid name");
                }
                name = value;
            }
        }
        public double Weight { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {Name}");
            sb.AppendLine($"Age: {Age}");
            sb.AppendLine($"Weight {Weight}");
            return sb.ToString().TrimEnd();
        }
    }
}
