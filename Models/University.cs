namespace University.Models
{
    internal class University
    {
        private UniversityEmployee[] _employees;

        public Rector Rector { get; set; }
        public UniversityEmployee[] Employees
        {
            get
            {
                return _employees;
            }

            set
            {
                if (value == null)
                {
                    _employees = value;
                    return;
                }
                var list = new List<UniversityEmployee>();
                foreach (var e in value)
                {
                    if (!(e is Rector))
                    {
                        list.Add(e);
                    }
                }
                _employees = list.ToArray();
            }
        }
        public Building[] Buildings { get; set; }

        public University(UniversityEmployee[] employees, Rector rector, Building[] buildings)
        {
            Employees = employees;
            Rector = rector;
            Buildings = buildings;
        }
                
    }
}
