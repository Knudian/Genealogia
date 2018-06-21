using System.Collections.Generic;
using Genealogia.Data;

namespace Genealogia.Contracts.Services
{
    public interface AreaServiceContract
    {
        Area FindById(int id);

        List<Area> all();

        Area Create(Area area);

        Area Update(Area area);
        
        void Delete(Area area);
    }
}