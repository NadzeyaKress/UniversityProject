namespace University
{
    internal class SupportStaff: UniversityEmployee
    {
        public string Role { get; set; } 

        public SupportStaff (string role, Person person, string taxId): base(person, taxId)
        {
            Role = role;
        }

        public override string GetOfficialDuties()
        {
            return $"{Person.FirstName} {Person.LastName}, {Role}";
        }
    }
}
