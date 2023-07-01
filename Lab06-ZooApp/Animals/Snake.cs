using System;
namespace Animals
{
    public class Snake : Reptile
    {
        public override string Eat()
        {
            return "snake is eating";
        }

        public override string Sleep()
        {
            return "snake is sleeping";
        }

        public override string Sound()
        {
            return "snake Hisses";
        }

        public override string LayEggs()
        {
            return "Lays eggs on land.";
        }
    }
}