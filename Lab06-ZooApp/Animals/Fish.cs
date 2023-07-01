using System;
namespace Animals
{
    public abstract class Fish : Animal
    {
        public string Size { get; set; }

        public abstract string Swim();
    }
}