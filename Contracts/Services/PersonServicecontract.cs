using System.Collections.Generic;
using Genealogia.Data;

namespace Genealogia.Contracts.Services
{
    public interface PersonServiceContract
    {
        Person FindById(int id);

        List<Person> all();

        Person Create(Person person);

        Person Update(Person person);
        
        void Delete(Person person);
    }
}