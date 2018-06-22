using System.Collections.Generic;
using Genealogia.Data;

namespace Genealogia.Contracts.Services
{
    public interface PlaceServiceContract
    {
        Place FindById(int id);

        List<Place> all();

        Place Create(Place place);

        Place Update(Place place);
        
        void Delete(Place place);
    }
}