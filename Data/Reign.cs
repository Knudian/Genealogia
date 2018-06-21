using System;

namespace StephaneBern.Data
{
    public class Reign
    {
        public int Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public Area Area { get; set; }

        public Reign() {}

        public Reign(Area area, DateTime start, DateTime end)
        {
            this.Area = area;
            this.StartDate = start;
            this.EndDate = end;
        }
    }
}