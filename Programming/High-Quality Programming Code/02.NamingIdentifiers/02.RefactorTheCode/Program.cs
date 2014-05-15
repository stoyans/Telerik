namespace _02.RefactorTheCode
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Hauptklasse
    {
        public enum Sex
        {
            Male, Female
        }

        public class Human
        {
            public Sex Sex { get; set; }

            public string Name { get; set; }

            public int Age { get; set; }
        }

        public static void AddCitizen(int age)
        {
            Human citizen = new Human();
            citizen.Age = age;

            if (age % 2 == 0)
            {
                citizen.Name = "Батката";
                citizen.Sex = Sex.Male;
            }
            else
            {
                citizen.Name = "Мацето";
                citizen.Sex = Sex.Female;
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Hauptklasse.Human human = new Hauptklasse.Human();
            Hauptklasse.AddCitizen(10);
        }
    }
}
