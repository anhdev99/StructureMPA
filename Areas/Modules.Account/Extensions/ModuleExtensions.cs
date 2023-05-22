using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
namespace Modules.Account.Extensions
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddAccountModule(this IServiceCollection services, IConfiguration configuration)
        {
            // services.AddMvcCore().AddFeatureFolders().AddAreaFeatureFolders();
            return services;
        }
    }
}