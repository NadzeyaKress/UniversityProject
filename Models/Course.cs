namespace University.Models
{
    internal class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Course(string courseName, string description)
        {
            Name = courseName;
            Description = description;
        }
    }
}
