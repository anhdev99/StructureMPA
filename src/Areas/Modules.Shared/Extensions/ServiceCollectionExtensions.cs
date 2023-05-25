using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Modules.Shared.Configurations;
using Modules.Shared.Controllers;
using Modules.Shared.Data;

namespace Modules.Shared.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSharedInfrastructure(this IServiceCollection services, IConfiguration config = null)
        {
            services.AddSingleton<IAppSettingConfigManager, AppSettingConfigManager>();
            services.AddSingleton<BaseDataContext>();
            services.AddMvcCore()
                .ConfigureApplicationPartManager(manager =>
                {
                    manager.FeatureProviders.Add(new InternalControllerFeatureProvider());
                });
            
            
            
            return services;
        }
    }
}