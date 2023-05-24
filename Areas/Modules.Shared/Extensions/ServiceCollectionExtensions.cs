using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Modules.Shared.Configurations;
using Modules.Shared.Controllers;
using Modules.Shared.Settings;

namespace Modules.Shared.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSharedInfrastructure(this IServiceCollection services, IConfiguration config = null)
        {
            services.AddSingleton<IAppSettingConfigManager, AppSettingConfigManager>();
            services.AddMvcCore()
                .ConfigureApplicationPartManager(manager =>
                {
                    manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
                });
            
          
            
            return services;
        }
    }
}