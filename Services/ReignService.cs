using System;
using System.Linq;
using System.Collections.Generic;
using Genealogia.Data;
using Genealogia.Contracts.Services;

namespace Genealogia.Services
{
    public class ReignService : ReignServiceContract
    {
        public ApplicationDbContext Context { get; set; }

        public ReignService(ApplicationDbContext context) 
        {
            this.Context = context;
        }

        public Reign FindById(int id)
        {
            return Context.Reigns.Find(id);
        }

        public List<Reign> all()
        {
            return Context.Reigns.ToList();
        }

        public Reign Create(Reign Reign)
        {
            Context.Reigns.Add(Reign);
            Context.SaveChanges();
            return Reign;
        }

        public Reign Update(Reign Reign)
        {
            Context.Update(Reign);
            return Reign;
        }

        public void Delete(Reign Reign)
        {
            Context.Reigns.Remove(Reign);
        }
    }
}