using App.Entities.POCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities.Interfaces
{
    public interface IPersonRepository
    {
        void CreatePerson(Person person);
        IEnumerable<Person> GetAll();
    }
}
