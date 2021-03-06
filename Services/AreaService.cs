using System;
using System.Linq;
using System.Collections.Generic;
using Genealogia.Data;
using Genealogia.Contracts.Services;

namespace Genealogia.Services
{
    public class AreaService : AreaServiceContract
    {
        public ApplicationDbContext Context { get; set; }

        public AreaService(ApplicationDbContext context) 
        {
            this.Context = context;
        }

        public Area FindById(int id)    
        {
            return Context.Areas.Find(id);
        }

        public IEnumerable<Area> all()
        {
            return Context.Areas;
        }

        public Area Create(Area area)
        {
            Context.Areas.Add(area);
            Context.SaveChanges();
            return area;
        }

        public Area Update(Area area)
        {
            Context.Update(area);
            Context.SaveChanges();
            return area;
        }

        public void Delete(Area area)
        {
            Context.Areas.Remove(area);
            Context.SaveChanges();
        }
    }
}