using Microsoft.AspNetCore.Mvc.Razor;
namespace StructureMPA.Extensions
{
    public class AreaViewLocationExpander : IViewLocationExpander {
        public virtual IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations) => viewLocations.Concat(new[] {
            "Areas/Modules.Account/Views/{1}/{0}" + RazorViewEngine.ViewExtension,
            "Areas/Modules.Shared/Views/{1}/{0}" + RazorViewEngine.ViewExtension,
            "Views/Shared" + RazorViewEngine.ViewExtension
        });

        public virtual void PopulateValues(ViewLocationExpanderContext context) { }
    }
}