using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class PersonService
    {
        @Inject
        private IRepository repository;

        public PersonService(IRepository repository)
        {
        }

        public void AddPerson()
        {
            this.repository.Add();
        }
    }
}
