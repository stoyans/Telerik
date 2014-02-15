namespace Excercise1
{
    using System;
    using System.Collections.Generic;
	
	public class Teacher : IPerson, IComment
	{
		private string name;
        private string comment;
		private List<Discipline> disciplines;
			
		public Teacher (string name)
		{
            this.Name = name;
            this.disciplines = new List<Discipline>();
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
                    throw new ArgumentException("Invalid Name!");
                }
                this.name = value;
            }
		}
		
		private List<Discipline> Discipline
		{
			get
			{
				return new List<Discipline>(this.disciplines);
			}
		}
		public void AddDiscipline(Discipline discipline)
		{
            this.disciplines.Add(discipline);
		}

        public string Comment
        {
            get;
            set;
        }
		
	}
}

