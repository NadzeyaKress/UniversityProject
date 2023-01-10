using System.Runtime.InteropServices;

namespace University
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var p1 = new Person("Petr", "Petrov");
            var p2 = new Person("Ivan", "Ivanov");
            var p3 = new Person("Vladislav", "Lopatin");
            var p4 = new Person("Anna", "Sidorova");
            var p5 = new Person("Marina", "Matusevich");

            var c1 = new Course("Course 1", "Math");
            var c2 = new Course("Course 2", "Language");
            var c3 = new Course("Course 3", "Physics");

            var e1 = new UniversityEmployee[] { new Teacher (p1, "1122",c2), new SupportStaff("Janitor", p2, "5566"), 
                new DegreeTeacher("PhD", "Physics", p3, "4512", c3), new Teacher( p4, "1133", c1), new Teacher( p5, "1245", c2)  };
         
            foreach (var e in e1) 
            {
                Console.WriteLine(e.GetOfficialDuties());

                if(e is Teacher)
                {
                    Console.WriteLine("Is a teacher");
                }

                Console.WriteLine();
            }
        }
    }
}