using University.Models;

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
            var p6 = new Person("Inna", "Los'");

            var rec = new Rector(p6, "5511");

            var c1 = new Course("Course 1", "Math");
            var c2 = new Course("Course 2", "Language");
            var c3 = new Course("Course 3", "Physics");

            var e1 = new UniversityEmployee[] { 
                new Teacher (p1, "1122",c2),
                new SupportStaff("Janitor", p2, "5566"), 
                new DegreeTeacher("PhD", "Physics", p3, "4512", c3),
                new Teacher( p4, "1133", c1),
                new Teacher( p5, "1245", c2)};

            var r1 = new Room[] { 
                new Room("lecture", 1), 
                new Room("lecture", 2), 
                new Room("lecture", 3), 
                new Room("laboratory", 4),
                new Room("seminary", 5) };

            var b1 = new Building[] {
                new Building ("Lenina 4", r1),
                new Building ("Lenina 5", r1)};
                     
            foreach (var e in e1) 
            {
                Console.WriteLine(e.GetOfficialDuties());

                if(e is Teacher)
                {
                    Console.WriteLine("Is a teacher");
                }

                Console.WriteLine();
            }

            var u = new Models.University (e1, rec, b1);            
        }
    }
}