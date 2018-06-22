namespace Genealogia.Data
{
    public class Rank
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Feminine { get; set; }

        public Rank() {}

        public Rank(string name, string feminine)
        {
            this.Name = name;
            this.Feminine = name;
        }
    }
}