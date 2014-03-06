using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SoftwareAcademy
{
    public class OffsiteCourse : Course, IOffsiteCourse
    {

        public OffsiteCourse(string name, string town, ITeacher teacher) :
            base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
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
            string result = "Offsite" + base.ToString() + "; Town=" + this.Town;
            return result;
        }
    }
}
