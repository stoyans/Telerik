using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTesting;

namespace TestSchool
{
    [TestClass]
    public class SchoolTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSchoolDuplicateId()
        {
            School school = new School();

            school.AddStudent(new Student("Pesho", 50000));
            school.AddStudent(new Student("Gosho", 50000));
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestStudentNullName()
        {
            new Student(null, 50000);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentIdOutOfRangeLowerLimit()
        {
            new Student("Pesho", 0);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentIdOutOfRangeUpperLimit()
        {
            new Student("Pesho", 100000);
        }

        [TestMethod]
        public void TestCourseAddRemoveStudent()
        {
            Course course = new Course();
            Student student = new Student("Pesho", 50000);

            for (int i = 0; i < 30; i++)
            {
                course.AddStudent(student);
            }

            course.RemoveStudent(student);
        }
       //
       //[TestMethod]
       //[ExpectedException(typeof(ArgumentException))]
       //public void TestCourseIsFull()
       //{
       //    Course course = new Course();
       //
       //    for (int i = 0; i < Course.Capacity; i++)
       //        course.AddStudents(new Student("Pesho", 50000 + i));
       //
       //    course.AddStudents(new Student("Pesho", 50000 + Course.Capacity));
       //}
    }
}
