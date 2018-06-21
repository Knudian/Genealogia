using System;
using System.Collections.Generic;

namespace StephaneBern.Data
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime? DateOfBirth { get; set; }

        public DateTime? DateOfDeath { get; set; }

        public Char gender { get; set; }

        public Place PlaceOfBirth { get; set; }

        public Place PlaceOfDeath { get; set; }

        public List<Person> Parents { get; set; } = new List<Person>();

        public List<Person> Children { get; set; } = new List<Person>();

        public List<Reign> Reigns { get; set; } = new List<Reign>();

        public Dynasty Dynasty { get; set; }

        public Person() { }
    }
}