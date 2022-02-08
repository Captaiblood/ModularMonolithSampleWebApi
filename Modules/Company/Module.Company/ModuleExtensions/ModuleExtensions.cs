using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Company.Core.Extensions;
using Module.Company.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Company.ModuleExtensions
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddCompanyModule(this IServiceCollection services, IConfiguration configuration)
        {
            services
            .AddCompanyCore()
            .AddCompanyInfrastructure(configuration);
            return services;
        }
    }

}
