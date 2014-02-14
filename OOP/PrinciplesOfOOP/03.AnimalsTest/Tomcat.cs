using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalsTest
{
    class Tomcat : Animal, ISound
    {
        public Tomcat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
            this.Sex = "male";
        }

        public void MakeSound()
        {
            Console.WriteLine("Mewmmww");
        }
    }
}
