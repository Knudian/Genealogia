namespace Genealogia.Data
{
    public class Area
    {
        public int Id { get; set; }

        public string Name { get; set;}

        public Area() {}

        public Area(string name)
        {
            this.Name = name;
        }
    }
}