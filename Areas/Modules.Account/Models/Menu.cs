using Modules.Shared.Models;
namespace Modules.Account.Models
{
    public class Menu : Audit, TEntity<string>
    {
        public string Name { get; set; }
        public string Code { get; set; }
    }
}