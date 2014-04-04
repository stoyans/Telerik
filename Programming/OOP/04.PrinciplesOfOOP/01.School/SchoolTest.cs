using System;

namespace Excercise1
{
    class MainClass
    {
        public static void Main()
        {
            try
            {
                Students st = new Students("ivan", 22);
                Teacher pesho = new Teacher("Mark");
                Discipline p1 = new Discipline("math", 2, 3);
                pesho.AddDiscipline(p1);
                pesho.AddDiscipline(new Discipline("biology", 2, 5));

                Classes firstClass = new Classes("SomeClass");
                pesho.Comment = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
