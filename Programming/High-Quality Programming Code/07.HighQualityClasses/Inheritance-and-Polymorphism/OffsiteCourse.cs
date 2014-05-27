namespace InheritanceAndPolymorphism
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OffsiteCourse : Course
    {
        private string town;

        public OffsiteCourse(string courseName, string teacherName, IList<string> students, string town)
            : base(courseName, teacherName, students)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }

            set
            {
                if (value.Length < 3 || value == null || value == string.Empty)
                {
                    throw new ArgumentException("Invalid name for a town!");
                }

                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("; Town = ");
            result.Append(this.Town);
            result.Append(" }");
            return base.ToString() + result.ToString();
        }
    }
}
