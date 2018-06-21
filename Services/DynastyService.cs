using System;
using System.Linq;
using System.Collections.Generic;
using StephaneBern.Data;
using StephaneBern.Contracts.Services;

namespace StephaneBern.Services
{
    public class DynastyService : DynastyServiceContract
    {
        public ApplicationDbContext Context { get; set; }

        public DynastyService(ApplicationDbContext context) 
        {
            this.Context = context;
        }

        public Dynasty FindById(int id)
        {
            return Context.Dynasties.Find(id);
        }

        public List<Dynasty> all()
        {
            return Context.Dynasties.ToList();
        }

        public Dynasty Create(Dynasty dynasty)
        {
            Context.Dynasties.Add(dynasty);
            Context.SaveChanges();
            return dynasty;
        }

        public Dynasty Update(Dynasty dynasty)
        {
            Context.Update(dynasty);
            return dynasty;
        }

        public void Delete(Dynasty dynasty)
        {
            Context.Dynasties.Remove(dynasty);
        }
    }
}