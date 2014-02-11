using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    class Program
    {
        static void Main()
        {
            List<Group> groups = new List<Group>()
            {
                new Group(1, "Physics"),
                new Group(2, "Mathematics"),
                new Group(3, "Biology")
            };

            List<Student> students = new List<Student>()
            {
                new Student("John", "Smith",123206909, "0123456", "sample@abv.bg", new List<int> {4,5,5, 6, 3}, 2),
                new Student("John", "Brown", 123206900, "0123456", "sample2@gbg.bg", new List<int> {5,5,2, 2, 3}, 3),
                new Student("Big", "Foot", 123206901, "0223456", "sample3@google.bg", new List<int> {6,5,6, 6, 3}, 2),
                new Student("Great", "Day", 123206906, "0123456", "sample4@mail.bg", new List<int> {4,4,5, 5, 5}, 1),
                new Student("Ivan", "Ivanov", 123206903, "0123456", "sample5@abv.bg", new List<int> {4,2,5, 6, 6}, 2),
                new Student("Petar", "Petrov", 123206906, "0233456", "sample6@mail.ru", new List<int> {6,5,4, 6, 3}, 4)
            };

            //task 9
            Console.WriteLine("==== Students from Group 2 in descending order ====");
            var groupTwoStudents = students.Where(st => st.GroupNumber == 2).OrderBy(st => st.FirstName);
            foreach (var item in groupTwoStudents)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.FirstName, item.LastName, item.FN, item.GroupNumber);
            }

            //task 10
            Console.WriteLine("==== Students from Group 2 in descending order with Extension method ====");
            List<Student> getStudents = students.GetStudentsByGroup(2);

            foreach (var item in getStudents)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.FirstName, item.LastName, item.FN, item.GroupNumber);
            }

            //Task 11
            Console.WriteLine("==== Students with email in ABV ====");
            var studentsWithABVMail = students.Where(st => st.Email.Substring(st.Email.IndexOf('@') + 1) == "abv.bg");
            foreach (var item in studentsWithABVMail)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.FirstName, item.LastName, item.Email, item.GroupNumber);
            }

            //Task 12
            Console.WriteLine("==== Students with Sofia phones ====");
            var studentsWithSofiaPhone = students.Where(st => st.Tel.ToString().Substring(0, 2) == "02");
            foreach (var item in studentsWithSofiaPhone)
            {
                Console.WriteLine("{0} {1} {2} {3}", item.FirstName, item.LastName, item.Tel, item.GroupNumber);
            }

            //Task 13
            Console.WriteLine("==== Students with at least one excellent mark ====");
            var studentsWithAtLeastOneSixMark = from student in students
                                                where student.Marks.Contains(6)
                                                select new { fullName = student.FirstName + " " + student.LastName, Marks = student.Marks };

            foreach (var student in studentsWithAtLeastOneSixMark)
            {
                Console.WriteLine(student.fullName + " { " + string.Join(" ", student.Marks) + " }");
            }

            //Task 14
            Console.WriteLine("==== Students with 2 F marks ====");
            List<Student> studentsWith2Marks = students.GetStudentsBy2Marks(2);
            foreach (var item in studentsWith2Marks)
            {
                Console.WriteLine("{0} {1}" + string.Join(" ", item.Marks), item.FirstName, item.LastName);
            }

            //Task 15
            Console.WriteLine("==== Marks of the students from 2006 ====");
            var marksOfStudentsEnrolled2006 = students.Where(st => st.FN.ToString().Substring(7, 2) == "06");
            foreach (var student in marksOfStudentsEnrolled2006)
            {
                Console.WriteLine(string.Join(" ", student.Marks));
            }

            //Task 16
            Console.WriteLine("==== Students from Math ====");
            var studentsMath = from student in students
                               join gr in groups on student.GroupNumber equals gr.GroupNumber
                               where gr.GroupNumber == 2
                               select student;

           foreach (var st in studentsMath)
           {
               Console.WriteLine(st.FirstName);
           }


        }
    }
}
