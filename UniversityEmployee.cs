namespace University
{
    internal abstract class UniversityEmployee
    {
        public Person Person { get; set; }
        public string TaxID { get; set; }
        
        public UniversityEmployee(Person person, string taxID)
        {
            Person = person;
            TaxID = taxID;
        }

        public abstract string GetOfficialDuties();
    }
}
