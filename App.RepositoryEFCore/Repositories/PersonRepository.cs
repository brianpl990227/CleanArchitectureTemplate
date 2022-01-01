using App.Entities.Interfaces;
using App.Entities.POCO;
using App.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.RepositoryEFCore.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly AppDbContext Context;

        public PersonRepository(AppDbContext _context) => Context = _context;

        public void CreatePerson(Person person)
        {
            Context.Add(person);
        }

        public IEnumerable<Person> GetAll()
        {
            return Context.Person;
        }
    }
}
