using System;
namespace Animals
{
    public class Amphibian : Reptile
    {
        public string SkinType { get; set; }

        public override string LayEggs()
        {
            return "Lays eggs in water.";
        }

        public string Swim()
        {
            return "Swims in water.";
        }
        public override string Eat()
        {
            return "Eats insects and small fish.";
        }
        public override string Sound()
        {
            return "Eats insects and small fish.";
        }
        public override string Sleep()
        {
            return "Eats insects and small fish.";
        }
    }
}