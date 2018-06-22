using System;
using System.Linq;
using System.Collections.Generic;
using Genealogia.Data;
using Genealogia.Contracts.Services;

namespace Genealogia.Services
{
    public class PersonService : PersonServiceContract
    {
        public ApplicationDbContext Context { get; set; }

        public PersonService(ApplicationDbContext context) 
        {
            this.Context = context;
        }

        public Person FindById(int id)
        {
            return Context.Persons.Find(id);
        }

        public List<Person> all()
        {
            return Context.Persons.ToList();
        }

        public Person Create(Person Person)
        {
            Context.Persons.Add(Person);
            Context.SaveChanges();
            return Person;
        }

        public Person Update(Person Person)
        {
            Context.Update(Person);
            return Person;
        }

        public void Delete(Person Person)
        {
            Context.Persons.Remove(Person);
        }
    }
}