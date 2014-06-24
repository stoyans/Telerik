namespace UnitTesting
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var st = new Student("dada", 33424);
            var st1 = new Student("d22ada", 31424);

            var languageSchool = new School();
            languageSchool.AddStudent(st);
            languageSchool.AddStudent(st1);



            var math = new Course();
            math.AddStudent(st);
            math.AddStudent(st1);
            math.RemoveStudent(new Student("dddd", 23232));
            languageSchool.AddCourse(math);
            languageSchool.RemoveCourse(math);
            languageSchool.AddCourse(math);
        }
    }
}