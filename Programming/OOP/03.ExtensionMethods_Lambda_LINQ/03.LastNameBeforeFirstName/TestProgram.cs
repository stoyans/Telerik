﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastNameBeforeFirstName
{
    class TestProgram
    {
        static void Main()
        {
            Student student1 = new Student("Mark", "Twen", 25);
            Student student2 = new Student("Mark", "Knight", 24);
            Student student3 = new Student("Green", "Forest", 22);
            Student student4 = new Student("High", "Cloud", 21);

            List<Student> listOfStundets = new List<Student>();
            listOfStundets.Add(student1);
            listOfStundets.Add(student2);
            listOfStundets.Add(student3);
            listOfStundets.Add(student4);

            //=======================
            Console.WriteLine("=======================");
            var sorted =
            from st in listOfStundets
            where st.FirstName.CompareTo(st.SecondName) == -1
            select (st.FirstName + " " + st.SecondName);

            var alphabeticallyStudents = listOfStundets.Where(st => st.FirstName.CompareTo(st.SecondName) < 0);
            foreach (var item in alphabeticallyStudents)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.SecondName);
            }
            //======================
            Console.WriteLine("=======================");
            var sortedAge =
            from st in listOfStundets
            where st.Age.CompareTo(18) >= 0 && st.Age.CompareTo(24) <= 0
            select (st.FirstName + " " + st.SecondName);
            var sortedAgeLINQ = listOfStundets.Where(st => st.Age.CompareTo(18) >= 0 && st.Age.CompareTo(24) <= 0);

            foreach (var item in sortedAgeLINQ)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.SecondName);
            }
            //======================
            Console.WriteLine("=======================");
            var descendingOrder = listOfStundets.OrderByDescending(st => st.FirstName).ThenByDescending(st => st.SecondName);
            foreach (var item in descendingOrder)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.SecondName);
            }
            var descOrder = from st in listOfStundets
                            orderby st.FirstName descending, st.SecondName descending
                            select st;

            foreach (var item in descOrder)
            {
                Console.WriteLine("{0} {1}", item.FirstName, item.SecondName);
            }

        }
    }
}
