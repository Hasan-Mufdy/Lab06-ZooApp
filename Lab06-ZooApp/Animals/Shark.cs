using Animals;

namespace Animals
{
    public class Shark : Fish
    {
        public override string Eat()
        {
            return "shark is eating";
        }

        public override string Sleep()
        {
            return "shark is sleeping";
        }

        public override string Sound()
        {
            return "does not make any sound";
        }
        public override string Swim()
        {
            return "shark is swimming";
        }
    }
}
