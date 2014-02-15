using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalsTest
{
    class Tomcat : Cat, ISound
    {
        public Tomcat(string name, int age) 
            : base(name, age, "male")
        {

        }

        public new void MakeSound()
        {
            Console.WriteLine("Mewmmww");
        }
    }
}
