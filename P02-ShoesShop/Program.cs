namespace P02_ShoesShop
{
    public class Program
    {
        static void Main()
        {
            Shop shop = new Shop(3000);
            Shoes s1 = new Shoes("sneakers", 255.90,20,39,2,"Nike");
            Shoes s2 = new Shoes ("boots",599.90,3,40,5,"GUCCI");
            Shoes s3 = new Shoes("heels", 99.90, 36, 40, 1, "BOSS");
            Shoes s4 = new Shoes("sneakers", 399.90, 48, 40, 1, "adidas");
            shop.AddShoes(s1);
            shop.AddShoes(s2);
            shop.AddShoes (s3);
            shop.AddShoes(s4);
            Shoes shoesSmallest = shop.GetSmallestShoes();
            Console.WriteLine(shoesSmallest);
            Shoes shoes = shop.GetShoesWithBiggestYearsWarranty();
            Console.WriteLine(shoes);
            shop.Report();
        }
    }
}