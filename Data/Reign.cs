using System;

namespace Genealogia.Data
{
    public class Reign
    {
        public int Id { get; set; }

        public Person Person { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Area Area { get; set; }

        public Reign() {}

        public Reign(Person person, Area area, DateTime start, DateTime end)
        {
            this.Person = person;
            this.Area = area;
            this.StartDate = start;
            this.EndDate = end;
        }
    }
}