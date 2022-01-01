using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.RepositoryEFCore.DataContext
{
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var OptionBuilder = new DbContextOptionsBuilder<AppDbContext>();

          //  OptionBuilder.UseNpgsql("Host=127.0.0.1;Port=5432;Database=template;User Id=postgres;Password=9902;");

            return new AppDbContext(OptionBuilder.Options);

        }
    }
}
