namespace University
{
    internal abstract class UniversityEmployee
    {
        public Person Person { get; set; }
        public string TaxId { get; set; }
        
        public UniversityEmployee(Person person, string taxId)
        {
            Person = person;
            TaxId = taxId;
        }

        public abstract string GetOfficialDuties();
    }
}
