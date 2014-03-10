using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class Teacher : ITeacher
    {
        private string name;

        List<ICourse> courses = new List<ICourse>();

        public Teacher(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get 
            {
                return this.name;
            }
            
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name");
                }
                this.name = value;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            string result = string.Empty;
            string teacherName = string.Format("Teacher: Name={0}; ", this.Name);

            if (courses.Count > 0)
            {
                result = "Courses=[";
                for (int i = 0; i < courses.Count; i++)
                {
                    if (i == courses.Count - 1)
                    {
                        result += "]";
                    }
                    else
                    {
                        result += courses[i].ToString();
                        result += ", ";
                    }
                }
            }

            return string.Format(teacherName + result);
        }
    }
}
