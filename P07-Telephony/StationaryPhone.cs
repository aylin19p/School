using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Telephony
{
    public class StationaryPhone : ICalling
    {
        public void Calling(string number)
        {
            if (number.Length == 7 && number.All(char.IsDigit))
            {
                Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
