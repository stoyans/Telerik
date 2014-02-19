using System;

namespace Excercise1
{
    public class Discipline : IComment
    {
        private string disciplineName;
        private int numberOfLectures;
        private int numberOfExcercises;

        public Discipline(string name, int lecnum, int exnum)
        {
            this.NameClass = name;
            this.NumberOfLectures = lecnum;
            this.NumberOfExcercises = exnum;
        }

        public string NameClass
        {
            get
            {
                return this.disciplineName;
            }
            set
            {
                if (value == null || value.Length < 2)
                {
                    throw new ArgumentException("Invalid Name for discipline!");
                }
                this.disciplineName = value;
            }
        }
        public int NumberOfLectures
        {
            get
            {
                return this.numberOfLectures;
            }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentException("Number of the lectures cannot be negative");
                }
                this.numberOfLectures = value;
            }
        }
        public int NumberOfExcercises
        {
            get
            {
                return this.numberOfExcercises;
            }
            set
            {
                if (value < 2)
                {
                    throw new ArgumentException("Number of the lectures cannot be negative");
                }
                this.numberOfExcercises = value;
            }
        }

        public string Comment
        {
            get;
            set;
        }

    }
}

