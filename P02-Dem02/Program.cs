namespace P02_Dem02
{
    public class Program
    {
        static void Main()
        {
            Animal a = new Animal(2, "Kate", 5.4);
            Animal b = new Animal(3, "Ben");
            Flower f1 = new Flower( "daisy", "white");
            Flower f2 = new Flower("rose", "red", 10);
            Key k1 = new Key(1.50, "metal", "for door");
            Key k2 = new Key(1.70, "steel");
            Phone p1 = new Phone("Samsung", 2022);
            Phone p2 = new Phone("Huawei", 2019, 589.49);
            Refrigerator r1 = new Refrigerator("Philips", 800.90);
            Refrigerator r2 = new Refrigerator("Samsung", 'A', 1500.90);



            int grade = 1;
        }
        public static void AverageGrade(double grade)
        {
            int n = int.Parse(Console.ReadLine());
            double s = grade / n;
            Console.WriteLine(s);
        }
    }
}