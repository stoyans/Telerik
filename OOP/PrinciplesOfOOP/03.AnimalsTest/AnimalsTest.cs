using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AnimalsTest
{
    class AnimalsTest
    {

        public static double AverageAge(Animal[] animals)
        {
            int sumAge = animals.Sum(animal => animal.Age);
            return (double)sumAge / animals.Count(); 
        }
        static void Main()
        {
            Cat[] cats = new Cat[]
            {
                new Cat("Cat1", 3, "female"),
                new Cat("Cat2", 4, "female"),
                new Cat("Cat3", 2, "male")
            };

            Dog[] dogs = new Dog[]
            {
                new Dog("Dog1", 3, "male"),
                new Dog("Dog2", 4, "female"),
                new Dog("Dog3", 8, "male")
            };

            Frog[] frogs = new Frog[]
            {
                new Frog("Frog1", 2, "male"),
                new Frog("Frog2", 1, "female"),
                new Frog("Frog3", 3, "female")
            };

            Kitten[] kittens = new Kitten[]
            {
                new Kitten("Kitten1", 1),
                new Kitten("Kitten2", 1),
                new Kitten("Kitten3", 2)
            };

            Console.WriteLine("{0:F2}",AnimalsTest.AverageAge(kittens));
        }

    }
}
