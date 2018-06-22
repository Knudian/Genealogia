using System;

namespace Genealogia.Data
{
    public class Reign
    {
        public int Id { get; set; }

        public Person Person { get; set; }

        public Rank Rank { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Area Area { get; set; }

        public Reign() {}

        public Reign(Person person, Rank rank, Area area, DateTime start, DateTime end)
        {
            this.Person = person;
            this.Rank = rank;
            this.Area = area;
            this.StartDate = start;
            this.EndDate = end;
        }
    }
}