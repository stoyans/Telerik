using System;
using System.Collections.Generic;

namespace Excercise1
{
	public class Classes : IComment
	{
        private string className;
        private string comment;
        private List<Teacher> teachers = new List<Teacher>();

        public Classes(string classname)
        {
            this.ClassName = classname;

        }

		public string ClassName
		{
            get
            {
                return this.className;
            }
            set
            {
                if (value == null || value.Length < 2)
                {
                    throw new ArgumentException("Invalid Name!");
                }
                this.className = value;
            }
		}
        private List<Teacher> Teacher
        {
            get
            {
                return new List<Teacher>(this.teachers);
            }
        }

        public void AddTeacher(Teacher teacher)
        {
            this.teachers.Add(teacher); 
        }
        public string Comment
        {
            get 
            {
                return this.comment;
            }
            set 
            { 
                this.comment = value; 
            }
        }
	}
}

