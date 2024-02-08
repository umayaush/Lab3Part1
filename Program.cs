namespace Lab3Part1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the dog's name: ");
            string dogName = Console.ReadLine();
            Console.WriteLine("\nEnter the dog's colour");
            string dogColour = Console.ReadLine();
            Console.WriteLine("\nEnter the dog's age");
            int dogAge = int.Parse(Console.ReadLine());

            Dog dog = new Dog();
            dog.Name = dogName;
            dog.Colour = dogColour;
            dog.Age = dogAge;

            Console.WriteLine($"\nDog's Name: {dog.Name}\nDog's Colour: {dog.Colour}\nDog's Age: {dog.Age}");
            dog.Eat();

            Console.WriteLine("\nEnter the cat's name: ");
            string catName = Console.ReadLine();
            Console.WriteLine("\nEnter the cat's colour");
            string catColour = Console.ReadLine();
            Console.WriteLine("\nEnter the cat's age");
            int catAge = int.Parse(Console.ReadLine());

            Cat cat = new Cat();
            cat.Name = catName;
            cat.Age = catAge;
            cat.Colour = catColour;

            Console.WriteLine($"\nCat's Name: {cat.Name}\nCat's Colour: {cat.Colour}\nCat's Age: {cat.Age}");
            cat.Eat();
        }
    }
}
