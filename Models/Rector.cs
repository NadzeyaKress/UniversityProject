namespace University.Models
{
    internal class Rector : AdminStaff
    {
        public Rector(Person person, string taxId) : base(person, taxId)
        {
        }

        public override string GetOfficialDuties()
        {
            return $"{Person.FirstName} {Person.LastName}, rector";
        }
    }
}
