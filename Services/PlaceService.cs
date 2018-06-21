using System;
using System.Linq;
using System.Collections.Generic;
using Genealogia.Data;
using Genealogia.Contracts.Services;

namespace Genealogia.Services
{
    public class PlaceService : PlaceServiceContract
    {
        public ApplicationDbContext Context { get; set; }

        public PlaceService(ApplicationDbContext context) 
        {
            this.Context = context;
        }

        public Place FindById(int id)
        {
            return Context.Places.Find(id);
        }

        public List<Place> all()
        {
            return Context.Places.ToList();
        }

        public Place Create(Place Place)
        {
            Context.Places.Add(Place);
            Context.SaveChanges();
            return Place;
        }

        public Place Update(Place Place)
        {
            Context.Update(Place);
            return Place;
        }

        public void Delete(Place Place)
        {
            Context.Places.Remove(Place);
        }
    }
}