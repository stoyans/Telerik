namespace UnitTesting
{
    using System;
    using System.Collections.Generic;

    public class School
    {
        private IList<Course> courses;
        private IList<Student> studentsInSchool;

        public School()
        {
            this.courses = new List<Course>();
            this.studentsInSchool = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            if (this.CheckifStudentExists(student.UniqueNumber))
            {
                throw new ArgumentException(string.Format("Student with ID | {0} | already exists!", student.UniqueNumber));
            }
            this.studentsInSchool.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            this.studentsInSchool.Remove(student);
        }

        public void AddCourse(Course course)
        {
            if (this.CheckifCourseExists(course))
            {
                throw new ArgumentException("The course already exists!");
            }
            this.courses.Add(course);
        }

        public void RemoveCourse(Course course)
        {
            if (this.courses.Count == 0)
            {
                throw new ArgumentOutOfRangeException("No courses available in the school yet!");
            }
            this.courses.Remove(course);
        }

        private bool CheckifStudentExists(int ID)
        {
            for (int i = 0; i < this.studentsInSchool.Count; i++)
            {
                if (ID == this.studentsInSchool[i].UniqueNumber)
                {
                    return true;
                }
            }

            return false;
        }

        private bool CheckifCourseExists(Course course)
        {
            if (courses.Contains(course))
            {
                return true;
            }

            return false;
        }
    }
}