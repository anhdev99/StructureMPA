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
            
            // configuration.UseStaticFiles(new StaticFileOptions()
            // {
            //     // Add the other folder, using the Content Root as the base
            //     FileProvider = new PhysicalFileProvider(
            //         Path.Combine(builder.Environment.ContentRootPath, "OtherFolder"))
            // });
            // var assembly = typeof(HomeController).Assembly;
            //
            // services.Configure<MvcRazorRuntimeCompilationOptions>(options =>
            //     { options.FileProviders.Add(new EmbeddedFileProvider(assembly)); });
            // services
            //     .AddOptions<MvcRazorRuntimeCompilationOptions>()
            //     .Configure<IEnumerable<IFileProvider>>((options, providers) => {
            //         //add all registered providers
            //         foreach(IFileProvider provider in providers) {
            //             options.FileProviders.Add(provider);
            //         }
            //     });
            // services.Configure<MvcRazorRuntimeCompilationOptions>(options => {
            //     options.FileProviders.Clear();
            //     options.FileProviders.Add(new PhysicalFileProvider("/Views"));
            // });
            // services.AddMvcCore().AddFeatureFolders().AddAreaFeatureFolders();
            return services;
        }
    }
}