﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P06_Animals
{
    public class Kittens : Animals
    {
        public Kittens(string name, int age, string gender) : base(name, age, gender)
        {
        }
        public override void ProduceSound()
        {
            Console.WriteLine("Meow");
        }
    }
}
