namespace StephaneBern.Data
{
    public class Place
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Country { get; set; }

        public Place() {}

        public Place(string name, string country)
        {
            this.Country = country;
            this.Name = name;
        }
    }
}