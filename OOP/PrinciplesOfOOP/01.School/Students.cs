using System;
namespace Excercise1
{
    public class Students : IPerson, IComment
    {

        private int classNumber;
        private string name;

        public Students(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;

        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null || value.Length < 2)
                {
                    throw new ArgumentException("Invalid Student Name!");
                }
                this.name = value;
            }
        }
        public int UniqueNumber
        {
            get
            {
                return this.classNumber;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Student number cannot be negative");
                }
                this.classNumber = value;
            }
        }

        public string Comment
        {
            get;
            set;
        }

    }
}

