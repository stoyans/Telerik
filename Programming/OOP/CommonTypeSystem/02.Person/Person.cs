using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Person
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        private int? age;

        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Person(string name, int? age = null)
        {
            this.Name = name;
            this.Age = age;
        }

        public override string ToString()
        {
            if (this.age == null)
            {
                return string.Format("Name: {0}" + " --> " + "Age not Specified", Name);
            }
            return string.Format("{0} {1}", Name, Age);
        }


    }
}
