using System;
namespace BirdInheritance
{
    class Pigeon : Bird
    {
        public Pigeon()
        {
        }

        public override Egg[] LayEggs(int numberOfEggs)
        {
            Egg[] eggs = new Egg[numberOfEggs];
            for(int count =  0; count < numberOfEggs; count++)
            {
                // 25% chance
                if (Bird.Randomizer.Next(4) == 0 )
                {
                
                    eggs[count] = new BrokenEgg("white");
                }
                else
                {
                    eggs[count] = new Egg(color: "white", size: (Randomizer.NextDouble() * (3 - 1) + 1));
                }
            }
            return eggs;
        }


    }
}
