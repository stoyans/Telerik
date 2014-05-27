namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class LocalCourse : Course
    {
        private string lab;

        public LocalCourse(string courseName, string teacherName, IList<string> students, string lab)
            : base(courseName, teacherName, students)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }

            set
            {
                if (value.Length < 3 || value == null || value == string.Empty)
                {
                    throw new ArgumentException("Invalid name for a lab!");
                }

                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("; Lab = ");
            result.Append(this.Lab);
            result.Append(" }");
            return base.ToString() + result.ToString();
        }
    }
}
