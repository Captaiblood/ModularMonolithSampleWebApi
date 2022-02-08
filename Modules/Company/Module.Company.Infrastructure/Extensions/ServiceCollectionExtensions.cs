using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Module.Company.Core.Abstractions;
using Module.Company.Infrastructure.Persistence;
using Shared.Infrastructure.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.Company.Infrastructure.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddCompanyInfrastructure(this IServiceCollection services, IConfiguration config)
        {
            services
            .AddDatabaseContext<CompanyDbContext>(config)
            .AddScoped<ICompanyDbContext>(provider => provider.GetService<CompanyDbContext>());
            return services;
        }
    }

}
