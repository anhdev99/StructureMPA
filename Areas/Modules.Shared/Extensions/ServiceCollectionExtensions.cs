using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Modules.Shared.Controllers;

namespace Modules.Shared.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSharedInfrastructure(this IServiceCollection services, IConfiguration config = null)
        {
            services.AddMvcCore()
                .ConfigureApplicationPartManager(manager =>
                {
                    manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
                });
            return services;
        }
    }
}