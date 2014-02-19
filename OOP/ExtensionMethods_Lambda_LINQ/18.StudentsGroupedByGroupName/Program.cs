using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.StudentsGroupedByGroupName
{
    class Program
    {
        static void Main()
        {
            var students = new[]
            {
                new {Name = "Mila", Group = "Physics"},
                new {Name = "George", Group = "Math"},
                new {Name = "Kiril", Group = "Literature"},
                new {Name = "Forest", Group = "Art"}
            };

            var selectedByGroup = students.OrderBy(st => st.Group);
            foreach (var item in selectedByGroup)
            {
                Console.WriteLine("{0} -> {1}", item.Name, item.Group);
            }

        }
    }
}
