﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalsTest
{
    class Frog : Animal, ISound
    {
        public Frog(string name, int age, string sex)
            : base(name, age, sex)
        {

        }

        public void MakeSound()
        {
            Console.WriteLine("Crack");
        }
    }
}
