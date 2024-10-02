using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace P02_ShoesShop
{
    public class Shop
    {
        private List<Shoes> shoes = new();

        public Shop(int capacity)
        {
            Capacity = capacity;
        }

        public int Capacity { get; set; }
        public void AddShoes(Shoes shoesP)
        {
            if (shoes.Count < Capacity)
            {
                shoes.Add(shoesP);
            }
        }
        public bool RemoveShoes(string color)
        {
            Shoes shoesP = shoes.FirstOrDefault(s => s.Color == color);
            return shoes.Remove(shoesP);
        }
        public Shoes GetSmallestShoes()
        {
            Shoes shoesP = shoes.OrderBy(s => s.Number).FirstOrDefault();
            return shoesP;
        }
        public Shoes GetShoesWithBiggestYearsWarranty()
        {
            Shoes shoesP = shoes.OrderByDescending(s => s.YearsWarranty).FirstOrDefault();
            return shoesP;
        }
        public int GetClothCount()
        {
            return shoes.Count;
        }
        public string Report()
        {
            StringBuilder sb = new StringBuilder();            
            sb.AppendLine($"{shoes.GetType().Name} magazine contains:");
            foreach (var s in shoes)
            {
                sb.AppendLine(s.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
