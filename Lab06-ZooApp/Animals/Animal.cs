using System;
namespace Animals
{

    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract string Eat();
        public abstract string Sleep();
        public abstract string Sound();
    }
}