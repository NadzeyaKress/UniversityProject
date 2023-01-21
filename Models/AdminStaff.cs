namespace University.Models
{
    internal abstract class AdminStaff : UniversityEmployee
    {
        public AdminStaff(Person person, string taxId) : base(person, taxId)
        {
        }        
    }
}
