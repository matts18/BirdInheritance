using System;
namespace BirdInheritance
{
    class Ostrich : Bird
    {
        public Ostrich()
        {
        }

        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for (int count = 0; count < numberOfEggs; count++)
            {
                eggs[count] = new Egg(color: "speckled", size: (Randomizer.NextDouble() * (13-12) + 12));
            }
            return eggs;
        }


    }
}
