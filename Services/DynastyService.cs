using System;
using System.Linq;
using System.Collections.Generic;
using Genealogia.Data;
using Genealogia.Contracts.Services;

namespace Genealogia.Services
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