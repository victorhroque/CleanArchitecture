using CleanArchitecture.Presenters;
using CleanArchitecture.RepositoryEFCore;
using CleanArchitecture.UseCases;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddCleanArchitecture(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepositoriesServices(configuration);
            services.AddUseCasesServices();
            services.AddPresentersServices();
            return services;
        }
    }
}
