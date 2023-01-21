namespace University.Models
{
    internal class Room
    {
        public string Type { get; set; }
        public int Number { get; set; }

        public Room(string type, int number)
        {
            Type = type;
            Number = number;
        }
    }
}
