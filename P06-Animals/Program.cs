namespace P06_Animals
{
    public class Program
    {
        static void Main()
        {
            string animal = Console.ReadLine();
            string[] arg = Console.ReadLine().Split(" ");
            string name = arg[0];
            int age = int.Parse(arg[1]);
            string gender = arg[2];
            Animals animals = default;
            while (animal != "Beast!")
            {
                if (animal == "Cat")
                {
                    animals = new Cat(name, age, gender);
                }
                else if (animal == "Dog")
                {
                    animals = new Dog(name, age, gender);
                }
                else if(animal == "Frog")
                {
                    animals = new Frog(name, age, gender);
                }
                else if (animal == "Kittens")
                {
                    animals = new Kittens(name, age, gender);
                }
                else if (animal == "Tomcat")
                {
                    animals = new Tomcat(name, age, gender);
                }
               
            }
            Console.WriteLine(animals);
            animals.ProduceSound();
        }
    }
}