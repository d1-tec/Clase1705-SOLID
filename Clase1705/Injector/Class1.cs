using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Persistencia;

namespace Injector
{
    public class Class1
    {
        public void InjectDependencies()
        {
            IRepository repository = new RepositoryDB();
            PersonService personService = new PersonService(repository);
        }
    }
}
