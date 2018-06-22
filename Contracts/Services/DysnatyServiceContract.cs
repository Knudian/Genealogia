using System.Collections.Generic;
using Genealogia.Data;

namespace Genealogia.Contracts.Services
{
    public interface DynastyServiceContract
    {
        Dynasty FindById(int id);

        List<Dynasty> all();

        Dynasty Create(Dynasty dynasty);

        Dynasty Update(Dynasty dynasty);
        
        void Delete(Dynasty dynasty);
    }
}