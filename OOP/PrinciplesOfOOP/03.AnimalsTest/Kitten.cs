using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalsTest
{
    class Kitten : Animal, ISound
    {

        public Kitten(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = "female";
        }

        public void MakeSound()
        {
            Console.WriteLine("Mewewww");
        }
    }
}
