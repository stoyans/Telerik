namespace UnitTesting
{
    using System;
    using System.Collections.Generic;

    public class Course
    {
        private List<Student> students;

        public Course()
        {
            this.students = new List<Student>();
        }

        public int NumberOfStudents
        {
            get
            {
                return this.students.Count;
            }
        }

        public void AddStudent(Student student) 
        {
            if (this.CheckNumberOfStudents(this.students.Count))
            {
                this.students.Add(student);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Number of students in the course can't be more than 29!");
            }
        }

        public void RemoveStudent(Student student)
        {
            //Remove student that doesn't exists
            if (this.students.Count != 0)
            {
                this.students.Remove(student);
            }
            else
            {
                throw new ArgumentOutOfRangeException("In the course there are no students yet!");
            }
        }

        private bool CheckNumberOfStudents(int studentCount) 
        {
            if (studentCount > 29)
            {
                return false;
            }

            return true; 
        }
    }
}