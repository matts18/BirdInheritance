﻿using System;
namespace BirdInheritance
{
    class BrokenEgg : Egg
    {
        public BrokenEgg(string color) : base(0,$"broken {color}")
        {
            Console.WriteLine("A bird laid a broken egg.");
        }
    }
}
