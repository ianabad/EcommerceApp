using Core.Interfaces;
using Infrastructure.Data;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extensions
{
    public static class ApplicationServicesExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepo, ProductRepo>();
            services.AddScoped<IBasketRepo, BasketRepo>();
            services.AddScoped(typeof(IGenericRepo<>), (typeof(GenericRepo<>)));

            return services;
        }
    }
}
