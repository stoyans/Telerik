using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person
{
    class PersonTest
    {
        static void Main()
        {
            Person person = new Person("Ivan", 6);
            Console.WriteLine(person.ToString());
            Person person2 = new Person("Pesho");
            Console.WriteLine(person2.ToString());
        }
    }
}
