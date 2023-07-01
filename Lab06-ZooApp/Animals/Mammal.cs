using System;
namespace Animals
{
    public abstract class Mammal : Animal
    {
        public string FurColor { get; set; }

        public abstract string Nurse();
    }
}