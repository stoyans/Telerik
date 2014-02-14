using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Human
{
    class HumanTest
    {
        static void Main()
        {
            List<Student> listOfStudents = new List<Student>()
            {
                new Student("Strange", "Last", 5),
                new Student("Bon", "Bonev", 6),
                new Student("Strong", "Will", 4),
                new Student("Big", "Smile", 5),
                new Student("Strange412", "Last", 3),
                new Student("Strange89", "Last414", 6),
                new Student("Strange7", "Laster", 6),
                new Student("Strange1", "Lastov", 4),
                new Student("Stranger", "Lasting", 5),
                new Student("Stranging", "Lasted", 5)
            };

            listOfStudents = listOfStudents.OrderBy(st => st.Grade).ToList();

            foreach (var student in listOfStudents)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName + " -> Grade: " + student.Grade);
            }

            Console.WriteLine();

            List<Worker> listOfWorkers = new List<Worker>()
            {
                new Worker("WStrange", "WLast", 350, 9),
                new Worker("WBon", "WBonev", 200 ,6),
                new Worker("WStrong", "WWill", 390 ,8),
                new Worker("WBig", "Smile", 390 ,8),
                new Worker("WStrange412", "Last", 390 ,8),
                new Worker("WStrange89", "Last414", 590 ,12),
                new Worker("WStrange7", "WLaster", 240 ,6),
                new Worker("WStrange1", "WLastov", 190 ,3),
                new Worker("WStranger", "WLasting", 490 ,8),
                new Worker("WStranging", "WLasted", 270 ,6)
            };

            listOfWorkers = listOfWorkers.OrderByDescending(worker => worker.MoneyPerHour()).ToList();

            foreach (var worker in listOfWorkers)
            {
                Console.WriteLine(worker.FirstName + " " + worker.LastName + " " + " -> {0:F2} ",worker.MoneyPerHour());
            }

            Console.WriteLine();

            List<Human> studentsAndWorkers = new List<Human>();
            studentsAndWorkers.AddRange(listOfStudents);
            studentsAndWorkers.AddRange(listOfWorkers);

            studentsAndWorkers = studentsAndWorkers.OrderBy(human => human.FirstName).ThenBy(human => human.LastName).ToList();

            foreach (var human in studentsAndWorkers)
            {
                Console.WriteLine(human.FirstName + " " + human.LastName);
            }

        }
    }
}
