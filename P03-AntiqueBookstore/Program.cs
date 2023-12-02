using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics;
using Microsoft.VisualBasic;

namespace P03_AntiqueBookstore
{
    public class Program
    {
        static void Main()
        {
            List<Book> books = new List<Book>();
            string[] arr = Console.ReadLine().Split(", ");
            string cmd = arr[0];
            while (true)
            {
                if (cmd == "End")
                {
                    break;
                }
                string title = arr[1];
                string author = arr[2];
                int pubDate = int.Parse(arr[3]);
                double price = double.Parse(arr[4]);
                string publisher  = arr[5];
                string discount = arr[6];
                Book book = new Book(title, author, pubDate, price, publisher, discount);
                books.Add(book);
            }
            books = books.OrderBy(b => b.Author).ToList();
            books.ToString();
        }
    }
}