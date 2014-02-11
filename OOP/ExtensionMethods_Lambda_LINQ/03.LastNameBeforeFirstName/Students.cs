using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.LastNameBeforeFirstName
{
    class Student
    {
        private string firstName;
        private string secondName;
        private int age;

        public Student(string fname, string sname, int age)
        {
            this.FirstName = fname;
            this.SecondName = sname;
            this.Age = age;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }

        public string SecondName
        {
            get
            {
                return this.secondName;
            }
            set
            {
                this.secondName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

    }
}
