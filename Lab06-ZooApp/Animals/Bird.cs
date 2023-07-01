using System;
namespace Animals
{
    public abstract class Bird : Animal
    {
        public string Feather { get; set; }

        public abstract string Fly();
    }

}