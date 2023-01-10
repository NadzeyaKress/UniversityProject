
namespace University
{
    internal class Teacher: UniversityEmployee
    {
        public Course Course { get; set; }


        public Teacher(Person person, string taxID, Course course): base(person, taxID)
        {
            Course = course;
        }

        public override string GetOfficialDuties()
        {
            return Person.FirstName + " " + Person.LastName + ", " + Course.Name;
        }
    }
}
