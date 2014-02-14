using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalsTest
{
    class Dog : Animal, ISound
    {

        public Dog(string name, int age, string sex)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = sex;            
        }

        public void MakeSound()
        {
            Console.WriteLine("Bow");
        }
    }
}
