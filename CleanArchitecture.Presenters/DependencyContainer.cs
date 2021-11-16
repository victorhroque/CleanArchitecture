using CleanArchitecture.UseCasesPorts;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArchitecture.Presenters
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddPresentersServices(this IServiceCollection services)
        {
            services.AddScoped<ICreateProductOuputPort, CreateProductPresenter>();
            services.AddScoped<IGetAllProductsOutputPort, GetAllProductsPresenter>();
            return services;
        }

    }
}
