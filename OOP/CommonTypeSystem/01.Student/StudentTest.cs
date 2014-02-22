using System;

namespace StudentClass
{
	class MainClass
	{
		public static void Main ()
		{
			
			Student st = new Student("Black", Student.University.UASG);
			
            var st1 = new Student("Black",Student.University.UASG, Student.Specialty.MobileNetwork,Student.Faculty.Electronics);
            Console.WriteLine(st.Equals(st1));
            Console.WriteLine(st1.ToString());

            if (st1 == st)
            {
                Console.WriteLine("Equal");
            }

            Console.WriteLine(st1.GetHashCode());
            
		}
	}
}
