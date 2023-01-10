namespace University
{
    internal class SupportStaff: UniversityEmployee
    {
        public string Role { get; set; } 

        public SupportStaff (string role, Person person, string taxID): base(person, taxID)
        {
            Role = role;
        }

        public override string GetOfficialDuties()
        {
            return Person.FirstName + " " + Person.LastName + "," + Role;
        }
    }
}
