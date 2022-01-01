using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.UseCasePorts;
using App.UseCases.CreatePerson;
using App.UseCases.GetAllProducts;
using Microsoft.Extensions.DependencyInjection;

namespace App.UseCases
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddUseCasesServices(this IServiceCollection services)
        {
            services.AddTransient<ICreatePersonInputPort, CreatePersonInteractor>();
            services.AddTransient<IGetAllPersonInputPort, GetAllPersonsInteractor>();

            return services;
        }
    }
}
