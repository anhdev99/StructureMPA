namespace Modules.Shared.Extensions
{
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Configurations;
    using Controllers;
    using Data;
    
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