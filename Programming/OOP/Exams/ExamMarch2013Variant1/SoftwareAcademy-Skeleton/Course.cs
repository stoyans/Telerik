using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public abstract class Course : ICourse
    {
        private string name;

        IList<string> topics = new List<string>();

        public Course(string name, ITeacher teacher = null)
        {
            this.Name = name;
            this.Teacher = teacher;
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

        public ITeacher Teacher
        {
            get;
            set;
        }

        public virtual void AddTopic(string topic)
        {
            topics.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.Append("Course: Name=" + this.Name);
            if (this.Teacher != null)
            {
                result.Append("; Teacher=" + this.Teacher.Name);
            }
            if (this.topics.Count > 0)
            {
                result.Append("; Topics=[");
                result.Append(string.Join(", ", this.topics));
                result.Append("]");
            }
            return result.ToString();
        }
    }
}
