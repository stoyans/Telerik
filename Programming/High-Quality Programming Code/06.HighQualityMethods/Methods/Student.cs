namespace Methods
{
    using System;

    public class Student
    {
        private string firstName;
        private string lastName;
        private DateTime birthDay;

        public Student(string firstName, string lastName, string birthDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDay = DateTime.Parse(birthDay);
        }

        public string FirstName
        {
            get 
            { 
                return this.firstName; 
            }

            set
            {
                if (value.Length < 3 || value == null)
                {
                    throw new ArgumentException("first name can't be shorter than 3 letters");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get 
            { 
                return this.lastName; 
            }

            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Last name can't be shorter than 2 letters");
                }

                this.lastName = value;
            }
        }

        public DateTime BirthDay
        {
            get 
            {
                return this.birthDay;
            }

            set
            {
                if (value.Year < 1900)
                {
                    throw new ArgumentOutOfRangeException("Input year is invalid!");
                }

                this.birthDay = value;
            }
        }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            return this.BirthDay < other.BirthDay;
        }
    }
}
