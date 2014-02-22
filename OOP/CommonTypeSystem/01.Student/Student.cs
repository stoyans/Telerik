using System;

namespace StudentClass
{
    public class Student : ICloneable, IComparable<Student>
    {
        private string firstName;
        private string midName;
        private string lastName;
        private int ssn;
        private string address;
        private string phone;
        private string email;
        private int course;


        private Specialty specialty;
        private University university;
        private Faculty faculty;


        public enum Specialty
        {
            MobileNetwork,
            SoftwareDevelopment,
            RadioCommunications,
        }

        public enum University
        {
            SofiaUniversity,
            TechnicalUniversity,
            UBWEE,
            UASG
        }

        public enum Faculty
        {
            Telecommunications,
            Informatics,
            Physics,
            Electronics
        }

        public Student(string name, University university)
        {
            this.firstName = name;
            this.university = university;

        }

        public Student(string name, University university, Specialty specialty, Faculty faculty)
            : this(name, university)
        {
            this.specialty = specialty;
            this.faculty = faculty;

        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }


        public string MidName
        {
            get { return this.midName; }
            set { this.midName = value; }
        }


        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }


        public int Ssn
        {
            get { return this.ssn; }
            set { this.ssn = value; }
        }


        public string Address
        {
            get { return this.address; }
            set { this.address = value; }
        }


        public string Phone
        {
            get { return this.phone; }
            set { this.phone = value; }
        }


        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }


        public int Course
        {
            get { return this.course; }
            set { this.course = value; }
        }

        public override bool Equals(object obj)
        {

            Student student = obj as Student;

            if (student == null)
                return false;

            if (!Object.Equals(this.firstName, student.firstName))
                return false;

            if (this.university != student.university)
                return false;
            return true;

        }

        public static bool operator ==(Student st1, Student st2)
        {
            return Student.Equals(st1, st2);
        }

        public static bool operator !=(Student st1, Student st2)
        {
            return !Student.Equals(st1, st2);
        }

        public override int GetHashCode()
        {
            return firstName.GetHashCode() ^ ssn.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.firstName, this.university, this.specialty);
        }

        public object Clone()
        {
            Student clone = new Student
            (
            this.FirstName,
            this.MidName,
            this.LastName,
            this.Address,
            this.Phone,
            this.Course,
            this.Ssn,
            this.specialty,
            this.university,
            this.faculty
            );
            return clone;
        }


        public int CompareTo(Student other)
        {
            throw new NotImplementedException();
        }
    }
}

