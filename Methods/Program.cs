using System;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("What your name");
            string name = Console.ReadLine();
            Console.WriteLine(name);

            Console.WriteLine("What is you favorite color");
            string color = Console.ReadLine();
            Console.WriteLine(color);

            Console.WriteLine("What is favorite animal");
            string animal = Console.ReadLine();
            Console.WriteLine(animal);

            Console.WriteLine("Whats you dogs name");
            string dogName = Console.ReadLine();
            Console.WriteLine(dogName);

            Console.WriteLine("What is you favorite band?");
            string band = Console.ReadLine();
            Console.WriteLine(band);

            Console.WriteLine($"There handsome man named {name}, his eyes were my favorite {color}.");
            Console.WriteLine($"He had a {animal} called {dogName}, he was also {color}.");
            Console.WriteLine($"The handsome man {name} and his dog {dogName} loved listening to his" +
            $"his favorite {band}");

        }








































    }
}
