using System;

namespace StudentClass
{
	class MainClass
	{
		public static void Main ()
		{
			
			Student st = new Student("Black", University.UASG);
			
            var st1 = new Student("John", "Smith",11234,"World","09841233","test@test.po", 4, University.SofiaUniversity, Specialty.SoftwareDevelopment,Faculty.Informatics);
            Console.WriteLine(st.Equals(st1));
            Console.WriteLine(st1.ToString());

            if (st1 == st)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("False");
            }
            
		}
	}
}
