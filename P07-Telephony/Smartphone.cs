using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P07_Telephony
{
    public class Smartphone : ICalling, IBrowsing
    {
        public void Browsing(string site)
        {
            if (site.Any(char.IsDigit))
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {site}!");
            }
        }

        public void Calling(string number)
        {
            if (number.Length == 10 && number.All(char.IsDigit))
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}
