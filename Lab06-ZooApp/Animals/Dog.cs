using System;
namespace Animals
{
    public class Dog : Mammal
    {
        public override string Eat()
        {
            return "Dog Eats food";
        }

        public override string Sleep()
        {
            return "Dog is Sleeping";
        }

        public override string Sound()
        {
            return "Barks loudly.";
        }

        public override string Nurse()
        {
            return "Nurses its puppies.";
        }
    }
}