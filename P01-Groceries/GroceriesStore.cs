using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Groceries
{
    public class GroceriesStore
    {
        public GroceriesStore(int capacity)
        {
            Capacity = capacity;
            Turnover = 0;
            Stall = new List<Product>();
        }

        public int	Capacity  { get; set; }
        public double Turnover  { get; set; }
        public List<Product> Stall { get; set; }

        public void AddProduct(Product product)
        {
            if (Stall.Any(p => p.Name == product.Name) || Stall.Count >= Capacity)
            {
                return; 
            }
            Stall.Add(product);
        }
        public bool RemoveProduct(string name)
        {
            Product p = Stall.FirstOrDefault(x => x.Name == name);

            if (p != null)
            {
                Stall.Remove(p);
                return true;
            }

            return false;
        }
        public string SellProduct(string name, double quantity)
        {
            Product product = Stall.FirstOrDefault(p => p.Name == name);

            if (product != null)
            {
                double totalPrice = product.Price * quantity;
                Turnover += totalPrice;

                return $"{product.Name} - {totalPrice:f2}$";
            }

            return "Product not found";
        }
        public string GetMostExpensive()
        {
            if (Stall.Count == 0)
            {
                return "Stall is empty";
            }

            Product product = Stall.OrderByDescending(p => p.Price).First();
            return product.ToString();
        }
        public string CashReport()
        {
            return $"Total Turnover: {Turnover:f2}$";
        }
        public string PriceList()
        {
            if (Stall.Count == 0)
            {
                return "Stall is empty";
            }

            string price = "Groceries Price List: ";
            foreach (Product product in Stall)
            {
                price += product.ToString();
            }

            return price;
        }
    }
}
