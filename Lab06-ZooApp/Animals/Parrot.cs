using System;
namespace Animals
{
    public class Parrot : Bird
    {
        public override string Eat()
        {
            return "Parrot is eating";
        }

        public override string Sleep()
        {
            return "Parrot is sleeping";
        }

        public override string Sound()
        {
            return "Repeats words and mimics sounds";
        }

        public override string Fly()
        {
            return "Flies in the air.";
        }
    }
}