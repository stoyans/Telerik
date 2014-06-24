namespace UnitTesting
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        private string name;
        private int uniqueNumber;

        public Student(string name, int studentNumber)
        {
            this.Name = name;
            this.UniqueNumber = studentNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value == string.Empty || value == null)
                {
                    throw new ArgumentException("Student name is invalid");
                }

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get 
            {
                return this.uniqueNumber;
            }

            set 
            {
                if (value > 99999 || value < 10000)
                {
                    throw new ArgumentOutOfRangeException("Student number must be between 10 000 and 99 999");
                }
                this.uniqueNumber = value;
            }
        }
    }
}