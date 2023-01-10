namespace University
{
    internal class DegreeTeacher:Teacher
    {
        public string Degree { get; set; }
        public string DegreeInf { get; set; }

        public DegreeTeacher(string degree, string degreeInf, Person person, string taxID, Course course): base(person, taxID, course)
        {
            Degree = degree;
            DegreeInf = degreeInf;
        }

        public override string GetOfficialDuties()
        {
            return Person.FirstName + " " + Person.LastName + " " + Degree + ", " + Course.Name;
        }
    }
}
