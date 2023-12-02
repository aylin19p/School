using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_AntiqueBookstore
{
    public class Book
    {
        public Book(string title, string author, int pubDate, double price)
        {
            Title = title;
            Author = author;
            PubDate = pubDate;
            Price = price;
            Publisher = "Unknown";
            Discount = "Unavailabl";
        }
        public Book(string title, string author, int pubDate, double price, string publisher) : this(title, author, pubDate, price)
        {
            Publisher = publisher;
        }

        public Book(string title, string author, int pubDate, double price, string publisher, string discount) : this(title, author, pubDate, price)
        {
            Publisher = publisher;
            Discount = discount;
        }
        public string Title { get; set; }
        public string Author { get; set; }
        public int PubDate { get; set; }
        public double Price { get; set; }
        public string Publisher { get; set; }
        public string Discount { get; set;}
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Title : {Title}");
            sb.AppendLine($"Author: {Author}");
            sb.AppendLine($"Publication Date: {PubDate}");
            sb.AppendLine($"Price: {Price}");
            sb.AppendLine($"Publisher: {Publisher}");
            sb.AppendLine($"Discount: {Discount}");
            return sb.ToString().TrimEnd();
        }
    }
    
}
