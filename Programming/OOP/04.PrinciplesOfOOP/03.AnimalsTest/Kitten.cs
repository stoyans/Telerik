using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalsTest
{
    class Kitten : Cat, ISound
    {

        public Kitten(string name, int age)
            : base(name, age, "female")
        {

        }

        public new void MakeSound()
        {
            Console.WriteLine("Mewewww");
        }
    }
}
