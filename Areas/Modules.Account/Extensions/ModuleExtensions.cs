using Microsoft.AspNetCore.Mvc.Razor.RuntimeCompilation;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Modules.Account.Controllers;
namespace Modules.Account.Extensions
{
    public static class ModuleExtensions
    {
        public static IServiceCollection AddAccountModule(this IServiceCollection services, IConfiguration configuration = null)
        {

            var assembly = typeof(HomeController).Assembly;
            services.AddControllersWithViews()
                .AddApplicationPart(assembly)
                .AddRazorRuntimeCompilation();

            services.Configure<MvcRazorRuntimeCompilationOptions>(options =>
                { options.FileProviders.Add(new EmbeddedFileProvider(assembly)); });
            
            return services;
        }
    }
}