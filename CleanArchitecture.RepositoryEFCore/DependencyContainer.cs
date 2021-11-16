using CleanArchitecture.Entities.Interfaces;
using CleanArchitecture.RepositoryEFCore.DataContext;
using CleanArchitecture.RepositoryEFCore.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.RepositoryEFCore
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddRepositoriesServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddSqlServer<CleanArchitectureContext>(configuration.GetConnectionString("CleanArchitecture"));
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
