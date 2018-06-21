using System.Collections.Generic;
using StephaneBern.Data;

namespace StephaneBern.Contracts.Services
{
    public interface ReignServiceContract
    {
        Reign FindById(int id);

        List<Reign> all();

        Reign Create(Reign reign);

        Reign Update(Reign reign);
        
        void Delete(Reign reign);
    }
}