using App.Entities.Interfaces;
using App.RepositoryEFCore.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.RepositoryEFCore.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext Context;

        public UnitOfWork(AppDbContext context) => Context = context;

        public Task<int> SaveChanges() //Aqui es donde se atraparian las Excepciones que pueda generar la Bd
        {
            return Context.SaveChangesAsync(); 
        }
    }
}
