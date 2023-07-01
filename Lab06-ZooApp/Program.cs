using System;
namespace Animals
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine($"Dog: {dog.Eat()}, {dog.Sleep()}, {dog.Sound()}, {dog.Nurse()}  ");

            Amphibian amphibian = new Amphibian();
            Console.WriteLine($"Amphibian: {amphibian.Eat()}, {amphibian.Sleep()}, {amphibian.Sound()}, {amphibian.LayEggs()}, {amphibian.Swim()}  ");
            
            Parrot parrot = new Parrot();
            Console.WriteLine($"Parrot: {parrot.Eat()}, {parrot.Sleep()}, {parrot.Sound()}, {parrot.Fly()}  ");

            Snake snake = new Snake();
            Console.WriteLine($"Snake: {snake.Eat()}, {snake.Sleep()}, {snake.Sound()}, {snake.LayEggs()}  ");

            Shark shark = new Shark();
            Console.WriteLine($"Shark: {shark.Eat()}, {shark.Sleep()}, {shark.Sound()}  ");

           
        }
    }
}