using Microsoft.AspNetCore.Mvc.Razor;
namespace StructureMPA.Extensions
{
    public class AreaViewLocationExpander : IViewLocationExpander {
        private const string _moduleKey = "Controller";

        private List<string> modules = new List<string>()
        {
            "Account",
            "FileManager",
        };

        public IEnumerable<string> ExpandViewLocations(ViewLocationExpanderContext context, IEnumerable<string> viewLocations)
        {
            var findModule = modules.Where(x => x == context.AreaName).FirstOrDefault();
            if (findModule != default)
            {
                if (!string.IsNullOrWhiteSpace(findModule))
                {
                    var moduleViewLocations = new string[]
                    {
                        "/Areas/Modules." + findModule + "/Views/{1}/{0}.cshtml",
                        "/Areas/Modules." + findModule + "/Views/Shared/{0}.cshtml"
                    };

                    viewLocations = moduleViewLocations.Concat(viewLocations);
                }
            }
            return viewLocations;
        }
        public virtual void PopulateValues(ViewLocationExpanderContext context)
        {
            var controller = context.ActionContext.ActionDescriptor.DisplayName;
            var moduleName = controller.Split('.')[2];
            if(moduleName != "WebHost")
            {
                context.Values[_moduleKey] = moduleName;
            }
        }
    }
}