using App.UseCasePorts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<ICreatePersonOutputPort, CreatePersonPresenter>();
            services.AddScoped<IGetAllPersonOutputPort, GetAllPersonsPresenter>();

            return services;
        }
    }
}
