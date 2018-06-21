namespace Genealogia.Data
{
    public class Dynasty
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Dynasty() {}

        public Dynasty(string name)
        {
            this.Name = name;
        }
    }
}