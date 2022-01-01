using App.Presenters;
using App.RepositoryEFCore;
using App.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddAppDependencies(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositories(configuration);
            services.AddPresenters();
            services.AddUseCasesServices();

            return services;
        }
    }
}
