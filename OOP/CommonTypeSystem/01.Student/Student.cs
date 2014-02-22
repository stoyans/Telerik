using System;

namespace StudentClass
{

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

        

        public Student(string fname, University university)
        {
            this.firstName = fname;
            this.University = university;

        }

        public Student(string fname, string lastname, int ssn, string address, string phone, string email, int course, University university, Specialty specialty, Faculty faculty)
            : this(fname, university)
        {
            this.LastName = lastname;
            this.SSN = ssn;
            this.Address = address;
            this.Phone = phone;
            this.Email = email;
            this.Course = course;
            this.Specialty = specialty;
            this.Faculty = faculty;

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

        public int SSN
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

        public Specialty Specialty
        {
            get { return this.specialty; }
            set { this.specialty = value; }
        }
        public University University
        {
            get { return this.university; }
            set { this.university = value; }
        }
        public Faculty Faculty
        {
            get { return this.faculty; }
            set { this.faculty = value; }
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
            this.LastName,
            this.SSN,
            this.Address,
            this.Phone,
            this.Email,
            this.Course,
            this.university,
            this.specialty,
            this.faculty
            );

            return clone;
        }


        public int CompareTo(Student student)
        {
            if (this.LastName != student.LastName)
            {
                return (String.Compare(this.LastName, student.LastName));
            }
            if (this.FirstName != student.FirstName)
            {
                return (String.Compare(this.FirstName, student.FirstName));
            }
            if (this.SSN != student.SSN)
            {
                return (this.SSN - student.SSN);
            }
            return 0;
        }
    }
}

