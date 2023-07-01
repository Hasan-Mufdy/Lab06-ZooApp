using System;
namespace Animals
{
    public abstract class Reptile : Animal
    {
        public string ScaleColor { get; set; }

        public abstract string LayEggs();
    }
}