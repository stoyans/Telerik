using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    public class Student
    {
        private string firstName;
        private string lastName;
        private int fn;
        private string tel;
        private string email;
        private List<int> marks;
        private int groupNumber;

        public Student(string fname, string lname, int fn, string tel, string email, List<int> marks, int group)
        {
            this.FirstName = fname;
            this.LastName = lname;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = group;

        }
        public Group Group { get; set; }

        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                this.firstName = value;
            }
        }

        public string LastName
        {
            get { return this.lastName; }
            set
            {
                this.lastName = value;
            }
        }

        public int FN
        {
            get { return this.fn; }
            set
            {
                this.fn = value;
            }
        }
        public string Tel
        {
            get { return this.tel; }
            set
            {
                this.tel = value;
            }
        }
        public string Email
        {
            get { return this.email; }
            set
            {
                this.email = value;
            }
        }
        public List<int> Marks
        {
            get { return this.marks; }
            set
            {
                this.marks = value;
            }
        }
        public int GroupNumber
        {
            get { return this.groupNumber; }
            set
            {
                this.groupNumber = value;
            }
        }

    }
}
