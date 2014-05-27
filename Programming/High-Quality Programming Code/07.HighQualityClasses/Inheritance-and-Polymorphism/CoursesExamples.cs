namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;

    public class CoursesExamples
    {
        public static void Main()
        {
            LocalCourse localCourse = new LocalCourse("Database", "Svetlin Nakov", new List<string>() { "Peter", "Maria", "Milena", "Todor" }, "Enterprise");
            Console.WriteLine(localCourse.ToString());

            OffsiteCourse offsiteCourse = new OffsiteCourse("PHP and WordPress Development", "Mario Peshev", new List<string>() { "Thomas", "Ani", "Steve" }, "Sofia");
            Console.WriteLine(offsiteCourse);

            List<Course> courses = new List<Course>();
            courses.Add(localCourse);
            courses.Add(offsiteCourse);

            foreach (var course in courses)
            {
                Console.WriteLine(course.Name);
            }
        }
    }
}
