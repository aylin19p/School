using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P05_Zoo
{
    public class Bear : Animal
    {
        private string location;

        public Bear(string name, int age, string location) : base(name, age)
        {
            Location = location;
        }
        public string Location
        {
            get { return location; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Invalid location");
                }
                location = value;
            }
        }
        public void Sleep()
        {
            Console.WriteLine($"It is winter and i am sleeping!");
        }
        public override string ToString()
        {
            return base.ToString()+ $"I live in {Location}";
        }
    }
}
