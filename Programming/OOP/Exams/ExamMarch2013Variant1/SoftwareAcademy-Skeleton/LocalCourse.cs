using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class LocalCourse : Course, ILocalCourse
    {

        public LocalCourse(string name, string lab, ITeacher teacher = null) :
            base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get;
            set;
        }

        public override void AddTopic(string topic)
        {
            base.AddTopic(topic);
        }

        public override string ToString()
        {
            string result = "Local" + base.ToString() + "; Lab=" + this.Lab;
            return result;
        }

    }
}
